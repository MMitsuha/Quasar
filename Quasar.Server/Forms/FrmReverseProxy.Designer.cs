﻿using Quasar.Server.Controls;

namespace Quasar.Server.Forms
{
    partial class FrmReverseProxy
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
            this.components = new System.ComponentModel.Container();
            Quasar.Server.Utilities.ListViewColumnSorter listViewColumnSorter1 = new Quasar.Server.Utilities.ListViewColumnSorter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReverseProxy));
            this.btnStart = new System.Windows.Forms.Button();
            this.lblLocalServerPort = new System.Windows.Forms.Label();
            this.nudServerPort = new System.Windows.Forms.NumericUpDown();
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstConnections = new Quasar.Server.Controls.AeroListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.killConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblProxyInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLoadBalance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudServerPort)).BeginInit();
            this.tabCtrl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(486, 24);
            this.btnStart.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(228, 46);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始侦听";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblLocalServerPort
            // 
            this.lblLocalServerPort.AutoSize = true;
            this.lblLocalServerPort.Location = new System.Drawing.Point(44, 34);
            this.lblLocalServerPort.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLocalServerPort.Name = "lblLocalServerPort";
            this.lblLocalServerPort.Size = new System.Drawing.Size(174, 30);
            this.lblLocalServerPort.TabIndex = 1;
            this.lblLocalServerPort.Text = "本地服务器端口";
            // 
            // nudServerPort
            // 
            this.nudServerPort.Location = new System.Drawing.Point(234, 30);
            this.nudServerPort.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nudServerPort.Maximum = new decimal(new int[] {
            65534,
            0,
            0,
            0});
            this.nudServerPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudServerPort.Name = "nudServerPort";
            this.nudServerPort.Size = new System.Drawing.Size(240, 37);
            this.nudServerPort.TabIndex = 2;
            this.nudServerPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudServerPort.Value = new decimal(new int[] {
            3128,
            0,
            0,
            0});
            this.nudServerPort.ValueChanged += new System.EventHandler(this.nudServerPort_ValueChanged);
            // 
            // tabCtrl
            // 
            this.tabCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCtrl.Controls.Add(this.tabPage1);
            this.tabCtrl.Location = new System.Drawing.Point(52, 230);
            this.tabCtrl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(1472, 548);
            this.tabCtrl.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstConnections);
            this.tabPage1.Location = new System.Drawing.Point(8, 44);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Size = new System.Drawing.Size(1456, 496);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "打开的连接";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstConnections
            // 
            this.lstConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstConnections.ContextMenuStrip = this.contextMenuStrip;
            this.lstConnections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstConnections.FullRowSelect = true;
            this.lstConnections.GridLines = true;
            this.lstConnections.HideSelection = false;
            this.lstConnections.Location = new System.Drawing.Point(6, 6);
            listViewColumnSorter1.NeedNumberCompare = false;
            listViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None;
            listViewColumnSorter1.SortColumn = 0;
            this.lstConnections.LvwColumnSorter = listViewColumnSorter1;
            this.lstConnections.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstConnections.Name = "lstConnections";
            this.lstConnections.Size = new System.Drawing.Size(1444, 484);
            this.lstConnections.TabIndex = 0;
            this.lstConnections.UseCompatibleStateImageBehavior = false;
            this.lstConnections.View = System.Windows.Forms.View.Details;
            this.lstConnections.VirtualMode = true;
            this.lstConnections.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.LvConnections_RetrieveVirtualItem);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Client IP";
            this.columnHeader6.Width = 106;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Client Country";
            this.columnHeader7.Width = 106;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Target Server";
            this.columnHeader1.Width = 135;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Target Port";
            this.columnHeader2.Width = 68;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Total Received";
            this.columnHeader3.Width = 105;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total Sent";
            this.columnHeader4.Width = 95;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Proxy Type";
            this.columnHeader5.Width = 90;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.killConnectionToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(261, 42);
            // 
            // killConnectionToolStripMenuItem
            // 
            this.killConnectionToolStripMenuItem.Name = "killConnectionToolStripMenuItem";
            this.killConnectionToolStripMenuItem.Size = new System.Drawing.Size(260, 38);
            this.killConnectionToolStripMenuItem.Text = "Kill Connection";
            this.killConnectionToolStripMenuItem.Click += new System.EventHandler(this.killConnectionToolStripMenuItem_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(726, 24);
            this.btnStop.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(228, 46);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "停止侦听";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblProxyInfo
            // 
            this.lblProxyInfo.AutoSize = true;
            this.lblProxyInfo.Location = new System.Drawing.Point(46, 102);
            this.lblProxyInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProxyInfo.Name = "lblProxyInfo";
            this.lblProxyInfo.Size = new System.Drawing.Size(564, 30);
            this.lblProxyInfo.TabIndex = 5;
            this.lblProxyInfo.Text = "连接到此SOCKS5代理：127.0.0.1:3128（无用户/密码）";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "所有DNS查询都将在远程客户端上执行，以减少DNS泄漏";
            // 
            // lblLoadBalance
            // 
            this.lblLoadBalance.AutoSize = true;
            this.lblLoadBalance.Location = new System.Drawing.Point(46, 168);
            this.lblLoadBalance.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLoadBalance.Name = "lblLoadBalance";
            this.lblLoadBalance.Size = new System.Drawing.Size(165, 30);
            this.lblLoadBalance.TabIndex = 7;
            this.lblLoadBalance.Text = "[负载平衡信息]";
            // 
            // FrmReverseProxy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1554, 804);
            this.Controls.Add(this.lblLoadBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProxyInfo);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.tabCtrl);
            this.Controls.Add(this.nudServerPort);
            this.Controls.Add(this.lblLocalServerPort);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmReverseProxy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reverse Proxy []";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmReverseProxy_FormClosing);
            this.Load += new System.EventHandler(this.FrmReverseProxy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudServerPort)).EndInit();
            this.tabCtrl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblLocalServerPort;
        private System.Windows.Forms.NumericUpDown nudServerPort;
        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tabPage1;
        private AeroListView lstConnections;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblProxyInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem killConnectionToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLoadBalance;
    }
}