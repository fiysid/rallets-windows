﻿namespace Shadowsocks.View
{
    partial class ConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.ModeSelectButton = new System.Windows.Forms.Button();
            this.EnableButton = new System.Windows.Forms.Button();
            this.ServersListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_close = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.btn_min = new System.Windows.Forms.Button();
            this.TopLabel = new System.Windows.Forms.Label();
            this.picture_icon = new System.Windows.Forms.PictureBox();
            this.TrafficLabel = new System.Windows.Forms.Label();
            this.StateLabel = new System.Windows.Forms.Label();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_icon)).BeginInit();
            this.BottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Location = new System.Drawing.Point(32, 234);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.ModeSelectButton, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.EnableButton, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 225);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(243, 104);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // ModeSelectButton
            // 
            this.ModeSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ModeSelectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.ModeSelectButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ModeSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModeSelectButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ModeSelectButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(224)))));
            this.ModeSelectButton.Location = new System.Drawing.Point(0, 60);
            this.ModeSelectButton.Margin = new System.Windows.Forms.Padding(0, 8, 4, 4);
            this.ModeSelectButton.Name = "ModeSelectButton";
            this.ModeSelectButton.Size = new System.Drawing.Size(239, 40);
            this.ModeSelectButton.TabIndex = 8;
            this.ModeSelectButton.Text = "智能模式";
            this.ModeSelectButton.UseVisualStyleBackColor = false;
            this.ModeSelectButton.Click += new System.EventHandler(this.ModeSelectButton_Click);
            // 
            // EnableButton
            // 
            this.EnableButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnableButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.EnableButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.EnableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnableButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EnableButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(224)))));
            this.EnableButton.Location = new System.Drawing.Point(0, 8);
            this.EnableButton.Margin = new System.Windows.Forms.Padding(0, 8, 4, 4);
            this.EnableButton.Name = "EnableButton";
            this.EnableButton.Size = new System.Drawing.Size(239, 40);
            this.EnableButton.TabIndex = 9;
            this.EnableButton.Text = "开启系统代理";
            this.EnableButton.UseVisualStyleBackColor = false;
            this.EnableButton.Click += new System.EventHandler(this.EnableButton_Click);
            // 
            // ServersListBox
            // 
            this.ServersListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ServersListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.ServersListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServersListBox.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ServersListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(224)))));
            this.ServersListBox.FormattingEnabled = true;
            this.ServersListBox.IntegralHeight = false;
            this.ServersListBox.ItemHeight = 32;
            this.ServersListBox.Location = new System.Drawing.Point(1, 0);
            this.ServersListBox.Margin = new System.Windows.Forms.Padding(0);
            this.ServersListBox.Name = "ServersListBox";
            this.ServersListBox.Size = new System.Drawing.Size(241, 220);
            this.ServersListBox.TabIndex = 7;
            this.ServersListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ServersListBox_DrawItem);
            this.ServersListBox.SelectedIndexChanged += new System.EventHandler(this.ServersListBox_SelectedIndexChanged);
            this.ServersListBox.DoubleClick += new System.EventHandler(this.ServersListBox_DoubleClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ServersListBox, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 44);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(243, 334);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_close.Image = global::Shadowsocks.Properties.Resources.btn_close_18_blue;
            this.btn_close.Location = new System.Drawing.Point(245, 2);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 28);
            this.btn_close.TabIndex = 9;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TopPanel.AutoSize = true;
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            this.TopPanel.Controls.Add(this.btn_min);
            this.TopPanel.Controls.Add(this.TopLabel);
            this.TopPanel.Controls.Add(this.picture_icon);
            this.TopPanel.Controls.Add(this.btn_close);
            this.TopPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(224)))));
            this.TopPanel.Location = new System.Drawing.Point(-8, -1);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(279, 41);
            this.TopPanel.TabIndex = 10;
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            this.btn_min.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Image = global::Shadowsocks.Properties.Resources.btn_min_18_blue;
            this.btn_min.Location = new System.Drawing.Point(214, 2);
            this.btn_min.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(30, 28);
            this.btn_min.TabIndex = 12;
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // TopLabel
            // 
            this.TopLabel.AutoSize = true;
            this.TopLabel.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.TopLabel.Location = new System.Drawing.Point(44, 7);
            this.TopLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(107, 26);
            this.TopLabel.TabIndex = 11;
            this.TopLabel.Text = "星际加速";
            // 
            // picture_icon
            // 
            this.picture_icon.Image = global::Shadowsocks.Properties.Resources.logo_20;
            this.picture_icon.Location = new System.Drawing.Point(14, 5);
            this.picture_icon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picture_icon.Name = "picture_icon";
            this.picture_icon.Size = new System.Drawing.Size(29, 31);
            this.picture_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picture_icon.TabIndex = 10;
            this.picture_icon.TabStop = false;
            // 
            // TrafficLabel
            // 
            this.TrafficLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrafficLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrafficLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(224)))));
            this.TrafficLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TrafficLabel.Location = new System.Drawing.Point(36, 24);
            this.TrafficLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TrafficLabel.Name = "TrafficLabel";
            this.TrafficLabel.Size = new System.Drawing.Size(186, 18);
            this.TrafficLabel.TabIndex = 11;
            this.TrafficLabel.Text = "剩余流量";
            this.TrafficLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StateLabel
            // 
            this.StateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StateLabel.BackColor = System.Drawing.Color.Transparent;
            this.StateLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(224)))));
            this.StateLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StateLabel.Location = new System.Drawing.Point(62, 2);
            this.StateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(135, 18);
            this.StateLabel.TabIndex = 8;
            this.StateLabel.Text = "关闭/全局模式";
            this.StateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.StateLabel);
            this.BottomPanel.Controls.Add(this.TrafficLabel);
            this.BottomPanel.Location = new System.Drawing.Point(6, 376);
            this.BottomPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(248, 45);
            this.BottomPanel.TabIndex = 12;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(266, 428);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.Padding = new System.Windows.Forms.Padding(15, 15, 15, 11);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rallets";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfigForm_FormClosed);
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.Shown += new System.EventHandler(this.ConfigForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConfigForm_KeyDown);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_icon)).EndInit();
            this.BottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button EnableButton;
        private System.Windows.Forms.Button ModeSelectButton;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.ListBox ServersListBox;
        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.PictureBox picture_icon;
        private System.Windows.Forms.Label TrafficLabel;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Button btn_min;
    }
}

