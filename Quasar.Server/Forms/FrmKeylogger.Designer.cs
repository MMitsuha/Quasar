namespace Quasar.Server.Forms
{
    partial class FrmKeylogger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKeylogger));
            this.lstLogs = new System.Windows.Forms.ListView();
            this.hLogs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.stripLblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnGetLogs = new System.Windows.Forms.Button();
            this.wLogViewer = new System.Windows.Forms.WebBrowser();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstLogs
            // 
            this.lstLogs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstLogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hLogs});
            this.lstLogs.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lstLogs.FullRowSelect = true;
            this.lstLogs.GridLines = true;
            this.lstLogs.HideSelection = false;
            this.lstLogs.Location = new System.Drawing.Point(0, 62);
            this.lstLogs.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstLogs.Name = "lstLogs";
            this.lstLogs.Size = new System.Drawing.Size(302, 858);
            this.lstLogs.TabIndex = 0;
            this.lstLogs.UseCompatibleStateImageBehavior = false;
            this.lstLogs.View = System.Windows.Forms.View.Details;
            this.lstLogs.ItemActivate += new System.EventHandler(this.lstLogs_ItemActivate);
            // 
            // hLogs
            // 
            this.hLogs.Text = "记录";
            this.hLogs.Width = 149;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripLblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 923);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStrip.Size = new System.Drawing.Size(1724, 41);
            this.statusStrip.TabIndex = 6;
            this.statusStrip.Text = "statusStrip1";
            // 
            // stripLblStatus
            // 
            this.stripLblStatus.Name = "stripLblStatus";
            this.stripLblStatus.Size = new System.Drawing.Size(182, 31);
            this.stripLblStatus.Text = "状态：准备就绪";
            // 
            // btnGetLogs
            // 
            this.btnGetLogs.Location = new System.Drawing.Point(4, 6);
            this.btnGetLogs.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGetLogs.Name = "btnGetLogs";
            this.btnGetLogs.Size = new System.Drawing.Size(298, 46);
            this.btnGetLogs.TabIndex = 7;
            this.btnGetLogs.Text = "获取记录";
            this.btnGetLogs.UseVisualStyleBackColor = true;
            this.btnGetLogs.Click += new System.EventHandler(this.btnGetLogs_Click);
            // 
            // wLogViewer
            // 
            this.wLogViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wLogViewer.Location = new System.Drawing.Point(308, 100);
            this.wLogViewer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.wLogViewer.MinimumSize = new System.Drawing.Size(40, 40);
            this.wLogViewer.Name = "wLogViewer";
            this.wLogViewer.ScriptErrorsSuppressed = true;
            this.wLogViewer.Size = new System.Drawing.Size(1416, 818);
            this.wLogViewer.TabIndex = 8;
            // 
            // FrmKeylogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1724, 964);
            this.Controls.Add(this.wLogViewer);
            this.Controls.Add(this.btnGetLogs);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.lstLogs);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimumSize = new System.Drawing.Size(1234, 859);
            this.Name = "FrmKeylogger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "键盘记录器 []";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmKeylogger_FormClosing);
            this.Load += new System.EventHandler(this.FrmKeylogger_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader hLogs;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.WebBrowser wLogViewer;
        private System.Windows.Forms.ListView lstLogs;
        private System.Windows.Forms.Button btnGetLogs;
        private System.Windows.Forms.ToolStripStatusLabel stripLblStatus;
    }
}