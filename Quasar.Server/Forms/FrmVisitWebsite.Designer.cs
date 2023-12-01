namespace Quasar.Server.Forms
{
    partial class FrmVisitWebsite
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisitWebsite));
            this.chkVisitHidden = new System.Windows.Forms.CheckBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnVisitWebsite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkVisitHidden
            // 
            this.chkVisitHidden.AutoSize = true;
            this.chkVisitHidden.Checked = true;
            this.chkVisitHidden.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVisitHidden.Location = new System.Drawing.Point(96, 76);
            this.chkVisitHidden.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkVisitHidden.Name = "chkVisitHidden";
            this.chkVisitHidden.Size = new System.Drawing.Size(229, 34);
            this.chkVisitHidden.TabIndex = 2;
            this.chkVisitHidden.Text = "隐藏访问（推荐）";
            this.chkVisitHidden.UseVisualStyleBackColor = true;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(24, 18);
            this.lblURL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(56, 30);
            this.lblURL.TabIndex = 0;
            this.lblURL.Text = "URL:";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(96, 12);
            this.txtURL.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(668, 37);
            this.txtURL.TabIndex = 1;
            // 
            // btnVisitWebsite
            // 
            this.btnVisitWebsite.Location = new System.Drawing.Point(492, 68);
            this.btnVisitWebsite.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnVisitWebsite.Name = "btnVisitWebsite";
            this.btnVisitWebsite.Size = new System.Drawing.Size(276, 46);
            this.btnVisitWebsite.TabIndex = 3;
            this.btnVisitWebsite.Text = "访问网站";
            this.btnVisitWebsite.UseVisualStyleBackColor = true;
            this.btnVisitWebsite.Click += new System.EventHandler(this.btnVisitWebsite_Click);
            // 
            // FrmVisitWebsite
            // 
            this.AcceptButton = this.btnVisitWebsite;
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(792, 144);
            this.Controls.Add(this.chkVisitHidden);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.btnVisitWebsite);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVisitWebsite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "访问网站 []";
            this.Load += new System.EventHandler(this.FrmVisitWebsite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkVisitHidden;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnVisitWebsite;
    }
}