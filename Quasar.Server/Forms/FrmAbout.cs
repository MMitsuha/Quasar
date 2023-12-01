using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Quasar.Server.Forms
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();

            lblVersion.Text = $"v{Application.ProductVersion}";
            rtxtContent.Text = Properties.Resources.License;
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {
        }
    }
}