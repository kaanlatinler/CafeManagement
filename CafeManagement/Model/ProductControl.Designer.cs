namespace CafeManagement.Model
{
    partial class ProductControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.ImageTxt = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NameLbl = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageTxt)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.guna2Separator1);
            this.guna2ShadowPanel1.Controls.Add(this.panel1);
            this.guna2ShadowPanel1.Controls.Add(this.ImageTxt);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(3, 3);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(173, 173);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // ImageTxt
            // 
            this.ImageTxt.Image = global::CafeManagement.Properties.Resources.salver2;
            this.ImageTxt.ImageRotate = 0F;
            this.ImageTxt.Location = new System.Drawing.Point(50, 20);
            this.ImageTxt.Name = "ImageTxt";
            this.ImageTxt.Size = new System.Drawing.Size(76, 73);
            this.ImageTxt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageTxt.TabIndex = 0;
            this.ImageTxt.TabStop = false;
            this.ImageTxt.UseTransparentBackground = true;
            this.ImageTxt.Click += new System.EventHandler(this.ImageTxt_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NameLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 46);
            this.panel1.TabIndex = 1;
            // 
            // NameLbl
            // 
            this.NameLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NameLbl.Location = new System.Drawing.Point(12, 11);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(150, 25);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Product Name";
            this.NameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(-3, 125);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(179, 10);
            this.guna2Separator1.TabIndex = 2;
            // 
            // ProductControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(179, 179);
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageTxt)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox ImageTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NameLbl;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}
