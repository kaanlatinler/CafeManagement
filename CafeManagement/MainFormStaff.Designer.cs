﻿namespace CafeManagement
{
    partial class MainFormStaff
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
            this.LeftPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.KitchenBtn = new Guna.UI2.WinForms.Guna2Button();
            this.POSBtn = new Guna.UI2.WinForms.Guna2Button();
            this.HomeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.TopPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.staffIDLblTxt = new System.Windows.Forms.Label();
            this.staffIDLbl = new System.Windows.Forms.Label();
            this.UsernameTxtLbl = new System.Windows.Forms.Label();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.RankTxtLbl = new System.Windows.Forms.Label();
            this.RankLbl = new System.Windows.Forms.Label();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.CenterPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.KitchenBtn);
            this.LeftPanel.Controls.Add(this.POSBtn);
            this.LeftPanel.Controls.Add(this.HomeBtn);
            this.LeftPanel.Controls.Add(this.label1);
            this.LeftPanel.Controls.Add(this.guna2PictureBox1);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(288, 899);
            this.LeftPanel.TabIndex = 0;
            // 
            // KitchenBtn
            // 
            this.KitchenBtn.AutoRoundedCorners = true;
            this.KitchenBtn.BackColor = System.Drawing.Color.Transparent;
            this.KitchenBtn.BorderRadius = 24;
            this.KitchenBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.KitchenBtn.CheckedState.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.KitchenBtn.CheckedState.Image = global::CafeManagement.Properties.Resources.salver;
            this.KitchenBtn.CustomizableEdges.BottomRight = false;
            this.KitchenBtn.CustomizableEdges.TopRight = false;
            this.KitchenBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.KitchenBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.KitchenBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.KitchenBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.KitchenBtn.FillColor = System.Drawing.Color.SlateBlue;
            this.KitchenBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KitchenBtn.ForeColor = System.Drawing.Color.White;
            this.KitchenBtn.HoverState.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.KitchenBtn.HoverState.Image = global::CafeManagement.Properties.Resources.salver;
            this.KitchenBtn.Image = global::CafeManagement.Properties.Resources.salver1;
            this.KitchenBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.KitchenBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.KitchenBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.KitchenBtn.Location = new System.Drawing.Point(104, 384);
            this.KitchenBtn.Name = "KitchenBtn";
            this.KitchenBtn.Size = new System.Drawing.Size(184, 51);
            this.KitchenBtn.TabIndex = 8;
            this.KitchenBtn.Text = "Kitchen";
            this.KitchenBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.KitchenBtn.TextOffset = new System.Drawing.Point(20, 0);
            this.KitchenBtn.Click += new System.EventHandler(this.KitchenBtn_Click);
            // 
            // POSBtn
            // 
            this.POSBtn.AutoRoundedCorners = true;
            this.POSBtn.BackColor = System.Drawing.Color.Transparent;
            this.POSBtn.BorderRadius = 24;
            this.POSBtn.CheckedState.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.POSBtn.CheckedState.Image = global::CafeManagement.Properties.Resources.aaa;
            this.POSBtn.CustomizableEdges.BottomRight = false;
            this.POSBtn.CustomizableEdges.TopRight = false;
            this.POSBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.POSBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.POSBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.POSBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.POSBtn.FillColor = System.Drawing.Color.SlateBlue;
            this.POSBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.POSBtn.ForeColor = System.Drawing.Color.White;
            this.POSBtn.HoverState.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.POSBtn.HoverState.Image = global::CafeManagement.Properties.Resources.aaa;
            this.POSBtn.Image = global::CafeManagement.Properties.Resources.payment_terminal;
            this.POSBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.POSBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.POSBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.POSBtn.Location = new System.Drawing.Point(104, 317);
            this.POSBtn.Name = "POSBtn";
            this.POSBtn.Size = new System.Drawing.Size(184, 51);
            this.POSBtn.TabIndex = 7;
            this.POSBtn.Text = "POS";
            this.POSBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.POSBtn.TextOffset = new System.Drawing.Point(20, 0);
            this.POSBtn.Click += new System.EventHandler(this.POSBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.AutoRoundedCorners = true;
            this.HomeBtn.BackColor = System.Drawing.Color.Transparent;
            this.HomeBtn.BorderRadius = 24;
            this.HomeBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.HomeBtn.CheckedState.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.HomeBtn.CheckedState.Image = global::CafeManagement.Properties.Resources.asdasd;
            this.HomeBtn.CustomizableEdges.BottomRight = false;
            this.HomeBtn.CustomizableEdges.TopRight = false;
            this.HomeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HomeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HomeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HomeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HomeBtn.FillColor = System.Drawing.Color.SlateBlue;
            this.HomeBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.HoverState.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.HomeBtn.HoverState.Image = global::CafeManagement.Properties.Resources.asdasd;
            this.HomeBtn.Image = global::CafeManagement.Properties.Resources.home_icon_silhouette;
            this.HomeBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HomeBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.HomeBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.HomeBtn.Location = new System.Drawing.Point(104, 251);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(184, 51);
            this.HomeBtn.TabIndex = 2;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HomeBtn.TextOffset = new System.Drawing.Point(20, 0);
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cafe Management";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::CafeManagement.Properties.Resources.restaurant;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(67, 57);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(150, 125);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.staffIDLblTxt);
            this.TopPanel.Controls.Add(this.staffIDLbl);
            this.TopPanel.Controls.Add(this.UsernameTxtLbl);
            this.TopPanel.Controls.Add(this.UsernameLbl);
            this.TopPanel.Controls.Add(this.RankTxtLbl);
            this.TopPanel.Controls.Add(this.RankLbl);
            this.TopPanel.Controls.Add(this.guna2ControlBox3);
            this.TopPanel.Controls.Add(this.guna2ControlBox2);
            this.TopPanel.Controls.Add(this.guna2ControlBox1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.TopPanel.Location = new System.Drawing.Point(288, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1197, 57);
            this.TopPanel.TabIndex = 1;
            // 
            // staffIDLblTxt
            // 
            this.staffIDLblTxt.AutoSize = true;
            this.staffIDLblTxt.BackColor = System.Drawing.Color.Transparent;
            this.staffIDLblTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.staffIDLblTxt.ForeColor = System.Drawing.Color.White;
            this.staffIDLblTxt.Location = new System.Drawing.Point(589, 18);
            this.staffIDLblTxt.Name = "staffIDLblTxt";
            this.staffIDLblTxt.Size = new System.Drawing.Size(23, 21);
            this.staffIDLblTxt.TabIndex = 8;
            this.staffIDLblTxt.Text = "id";
            // 
            // staffIDLbl
            // 
            this.staffIDLbl.AutoSize = true;
            this.staffIDLbl.BackColor = System.Drawing.Color.Transparent;
            this.staffIDLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.staffIDLbl.ForeColor = System.Drawing.Color.White;
            this.staffIDLbl.Location = new System.Drawing.Point(508, 18);
            this.staffIDLbl.Name = "staffIDLbl";
            this.staffIDLbl.Size = new System.Drawing.Size(75, 21);
            this.staffIDLbl.TabIndex = 7;
            this.staffIDLbl.Text = "Staff ID :";
            // 
            // UsernameTxtLbl
            // 
            this.UsernameTxtLbl.AutoSize = true;
            this.UsernameTxtLbl.BackColor = System.Drawing.Color.Transparent;
            this.UsernameTxtLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UsernameTxtLbl.ForeColor = System.Drawing.Color.White;
            this.UsernameTxtLbl.Location = new System.Drawing.Point(367, 20);
            this.UsernameTxtLbl.Name = "UsernameTxtLbl";
            this.UsernameTxtLbl.Size = new System.Drawing.Size(79, 21);
            this.UsernameTxtLbl.TabIndex = 6;
            this.UsernameTxtLbl.Text = "username";
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UsernameLbl.ForeColor = System.Drawing.Color.White;
            this.UsernameLbl.Location = new System.Drawing.Point(266, 20);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(95, 21);
            this.UsernameLbl.TabIndex = 5;
            this.UsernameLbl.Text = "Username :";
            // 
            // RankTxtLbl
            // 
            this.RankTxtLbl.AutoSize = true;
            this.RankTxtLbl.BackColor = System.Drawing.Color.Transparent;
            this.RankTxtLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RankTxtLbl.ForeColor = System.Drawing.Color.White;
            this.RankTxtLbl.Location = new System.Drawing.Point(68, 20);
            this.RankTxtLbl.Name = "RankTxtLbl";
            this.RankTxtLbl.Size = new System.Drawing.Size(41, 21);
            this.RankTxtLbl.TabIndex = 4;
            this.RankTxtLbl.Text = "rank";
            // 
            // RankLbl
            // 
            this.RankLbl.AutoSize = true;
            this.RankLbl.BackColor = System.Drawing.Color.Transparent;
            this.RankLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RankLbl.ForeColor = System.Drawing.Color.White;
            this.RankLbl.Location = new System.Drawing.Point(6, 20);
            this.RankLbl.Name = "RankLbl";
            this.RankLbl.Size = new System.Drawing.Size(56, 21);
            this.RankLbl.TabIndex = 3;
            this.RankLbl.Text = "Rank :";
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1038, 12);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.PressedColor = System.Drawing.SystemColors.HotTrack;
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 2;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1089, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.PressedColor = System.Drawing.SystemColors.HotTrack;
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.CustomClick = true;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1140, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // CenterPanel
            // 
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(288, 57);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(1197, 842);
            this.CenterPanel.TabIndex = 1;
            // 
            // MainFormStaff
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1485, 899);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.LeftPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainFormStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel LeftPanel;
        private Guna.UI2.WinForms.Guna2Panel TopPanel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2Button HomeBtn;
        public Guna.UI2.WinForms.Guna2Button KitchenBtn;
        public Guna.UI2.WinForms.Guna2Button POSBtn;
        public System.Windows.Forms.Label UsernameTxtLbl;
        public System.Windows.Forms.Label UsernameLbl;
        public System.Windows.Forms.Label RankTxtLbl;
        public System.Windows.Forms.Label RankLbl;
        public Guna.UI2.WinForms.Guna2Panel CenterPanel;
        public System.Windows.Forms.Label staffIDLblTxt;
        public System.Windows.Forms.Label staffIDLbl;
    }
}