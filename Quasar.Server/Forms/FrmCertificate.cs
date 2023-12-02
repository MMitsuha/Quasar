using Quasar.Server.Helper;
using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Quasar.Server.Models;

namespace Quasar.Server.Forms
{
    public partial class FrmCertificate : Form
    {
        private X509Certificate2 _certificate;

        public FrmCertificate()
        {
            InitializeComponent();
        }

        private void SetCertificate(X509Certificate2 certificate)
        {
            _certificate = certificate;
            txtDetails.Text = _certificate.ToString(false);
            btnSave.Enabled = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SetCertificate(CertificateHelper.CreateCertificateAuthority("Quasar Enhanced Server CA", 4096));
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.CheckFileExists = true;
                ofd.Filter = "证书文件 *.p12|*.p12";
                ofd.Multiselect = false;
                ofd.InitialDirectory = Application.StartupPath;
                if (ofd.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        SetCertificate(new X509Certificate2(ofd.FileName, "", X509KeyStorageFlags.Exportable));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, $"导入证书时出错：\n{ex.Message}", "保存错误",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_certificate == null)
                    throw new ArgumentNullException();

                if (!_certificate.HasPrivateKey)
                    throw new ArgumentException();

                File.WriteAllBytes(Settings.CertificatePath, _certificate.Export(X509ContentType.Pkcs12));

                MessageBox.Show(this,
                    "请立即备份证书。证书丢失会导致失去所有客户端！",
                    "证书备份", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string argument = "/select, \"" + Settings.CertificatePath + "\"";
                Process.Start("explorer.exe", argument);

                this.DialogResult = DialogResult.OK;
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show(this, "请先创建或导入证书。", "保存错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show(this,
                    "导入的证书没有关联的私钥。请导入其他证书。",
                    "保存错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(this,
                    "保存证书时出错，请确保您对Quasar目录具有写访问权限。",
                    "保存错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}