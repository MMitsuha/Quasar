﻿namespace Quasar.Server.Forms
{
    partial class FrmShowMessagebox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShowMessagebox));
            this.groupMsgSettings = new System.Windows.Forms.GroupBox();
            this.cmbMsgIcon = new System.Windows.Forms.ComboBox();
            this.lblMsgIcon = new System.Windows.Forms.Label();
            this.cmbMsgButtons = new System.Windows.Forms.ComboBox();
            this.lblMsgButtons = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.lblCaption = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupMsgSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupMsgSettings
            // 
            this.groupMsgSettings.Controls.Add(this.cmbMsgIcon);
            this.groupMsgSettings.Controls.Add(this.lblMsgIcon);
            this.groupMsgSettings.Controls.Add(this.cmbMsgButtons);
            this.groupMsgSettings.Controls.Add(this.lblMsgButtons);
            this.groupMsgSettings.Controls.Add(this.txtText);
            this.groupMsgSettings.Controls.Add(this.txtCaption);
            this.groupMsgSettings.Controls.Add(this.lblText);
            this.groupMsgSettings.Controls.Add(this.lblCaption);
            this.groupMsgSettings.Location = new System.Drawing.Point(24, 24);
            this.groupMsgSettings.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupMsgSettings.Name = "groupMsgSettings";
            this.groupMsgSettings.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupMsgSettings.Size = new System.Drawing.Size(650, 292);
            this.groupMsgSettings.TabIndex = 0;
            this.groupMsgSettings.TabStop = false;
            this.groupMsgSettings.Text = "对话框设置";
            // 
            // cmbMsgIcon
            // 
            this.cmbMsgIcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMsgIcon.FormattingEnabled = true;
            this.cmbMsgIcon.Location = new System.Drawing.Point(294, 214);
            this.cmbMsgIcon.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbMsgIcon.Name = "cmbMsgIcon";
            this.cmbMsgIcon.Size = new System.Drawing.Size(320, 38);
            this.cmbMsgIcon.TabIndex = 8;
            // 
            // lblMsgIcon
            // 
            this.lblMsgIcon.AutoSize = true;
            this.lblMsgIcon.Location = new System.Drawing.Point(84, 220);
            this.lblMsgIcon.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMsgIcon.Name = "lblMsgIcon";
            this.lblMsgIcon.Size = new System.Drawing.Size(151, 30);
            this.lblMsgIcon.TabIndex = 7;
            this.lblMsgIcon.Text = "对话框图标：";
            // 
            // cmbMsgButtons
            // 
            this.cmbMsgButtons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMsgButtons.FormattingEnabled = true;
            this.cmbMsgButtons.Location = new System.Drawing.Point(294, 160);
            this.cmbMsgButtons.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbMsgButtons.Name = "cmbMsgButtons";
            this.cmbMsgButtons.Size = new System.Drawing.Size(320, 38);
            this.cmbMsgButtons.TabIndex = 6;
            // 
            // lblMsgButtons
            // 
            this.lblMsgButtons.AutoSize = true;
            this.lblMsgButtons.Location = new System.Drawing.Point(46, 166);
            this.lblMsgButtons.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMsgButtons.Name = "lblMsgButtons";
            this.lblMsgButtons.Size = new System.Drawing.Size(151, 30);
            this.lblMsgButtons.TabIndex = 5;
            this.lblMsgButtons.Text = "对话框按钮：";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(120, 98);
            this.txtText.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtText.MaxLength = 256;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(494, 37);
            this.txtText.TabIndex = 4;
            this.txtText.Text = "You are running Quasar.";
            // 
            // txtCaption
            // 
            this.txtCaption.Location = new System.Drawing.Point(120, 42);
            this.txtCaption.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCaption.MaxLength = 256;
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(494, 37);
            this.txtCaption.TabIndex = 2;
            this.txtCaption.Text = "Information";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(48, 104);
            this.lblText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(82, 30);
            this.lblText.TabIndex = 3;
            this.lblText.Text = "内容：";
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Location = new System.Drawing.Point(12, 48);
            this.lblCaption.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(82, 30);
            this.lblCaption.TabIndex = 1;
            this.lblCaption.Text = "标题：";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(362, 328);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(150, 46);
            this.btnPreview.TabIndex = 1;
            this.btnPreview.Text = "预览";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(524, 328);
            this.btnSend.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(150, 46);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // FrmShowMessagebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(698, 398);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.groupMsgSettings);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmShowMessagebox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "显示对话框 []";
            this.Load += new System.EventHandler(this.FrmShowMessagebox_Load);
            this.groupMsgSettings.ResumeLayout(false);
            this.groupMsgSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupMsgSettings;
        private System.Windows.Forms.ComboBox cmbMsgIcon;
        private System.Windows.Forms.Label lblMsgIcon;
        private System.Windows.Forms.ComboBox cmbMsgButtons;
        private System.Windows.Forms.Label lblMsgButtons;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.TextBox txtCaption;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnSend;
    }
}