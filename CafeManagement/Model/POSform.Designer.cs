namespace CafeManagement.Model
{
    partial class POSform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ExitBtn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.WaiterLbl = new System.Windows.Forms.Label();
            this.TableLbl = new System.Windows.Forms.Label();
            this.DinInBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.KOTBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.BillBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.NewBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.CheckBtn = new Guna.UI2.WinForms.Guna2Button();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CategoryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ProductPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvproID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.SearchTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.ProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.ExitBtn);
            this.guna2Panel1.Controls.Add(this.WaiterLbl);
            this.guna2Panel1.Controls.Add(this.TableLbl);
            this.guna2Panel1.Controls.Add(this.DinInBtn);
            this.guna2Panel1.Controls.Add(this.KOTBtn);
            this.guna2Panel1.Controls.Add(this.BillBtn);
            this.guna2Panel1.Controls.Add(this.NewBtn);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.SlateBlue;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1584, 100);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.Image = global::CafeManagement.Properties.Resources.cancel;
            this.ExitBtn.ImageRotate = 0F;
            this.ExitBtn.Location = new System.Drawing.Point(1512, 22);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(60, 60);
            this.ExitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitBtn.TabIndex = 11;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.UseTransparentBackground = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // WaiterLbl
            // 
            this.WaiterLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WaiterLbl.AutoSize = true;
            this.WaiterLbl.BackColor = System.Drawing.Color.Transparent;
            this.WaiterLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WaiterLbl.ForeColor = System.Drawing.Color.White;
            this.WaiterLbl.Location = new System.Drawing.Point(881, 56);
            this.WaiterLbl.Name = "WaiterLbl";
            this.WaiterLbl.Size = new System.Drawing.Size(86, 32);
            this.WaiterLbl.TabIndex = 10;
            this.WaiterLbl.Text = "Waiter";
            this.WaiterLbl.Visible = false;
            // 
            // TableLbl
            // 
            this.TableLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TableLbl.AutoSize = true;
            this.TableLbl.BackColor = System.Drawing.Color.Transparent;
            this.TableLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TableLbl.ForeColor = System.Drawing.Color.White;
            this.TableLbl.Location = new System.Drawing.Point(881, 12);
            this.TableLbl.Name = "TableLbl";
            this.TableLbl.Size = new System.Drawing.Size(71, 32);
            this.TableLbl.TabIndex = 9;
            this.TableLbl.Text = "Table";
            this.TableLbl.Visible = false;
            // 
            // DinInBtn
            // 
            this.DinInBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DinInBtn.AutoRoundedCorners = true;
            this.DinInBtn.BackColor = System.Drawing.Color.Transparent;
            this.DinInBtn.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.DinInBtn.BorderRadius = 39;
            this.DinInBtn.BorderThickness = 2;
            this.DinInBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.DinInBtn.CheckedState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.DinInBtn.CheckedState.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.DinInBtn.CustomBorderColor = System.Drawing.Color.Black;
            this.DinInBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DinInBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DinInBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DinInBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DinInBtn.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.DinInBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DinInBtn.ForeColor = System.Drawing.Color.White;
            this.DinInBtn.Image = global::CafeManagement.Properties.Resources.dinner;
            this.DinInBtn.Location = new System.Drawing.Point(795, 12);
            this.DinInBtn.Name = "DinInBtn";
            this.DinInBtn.Size = new System.Drawing.Size(80, 80);
            this.DinInBtn.TabIndex = 8;
            this.DinInBtn.Text = "Din In";
            this.DinInBtn.Click += new System.EventHandler(this.DinInBtn_Click);
            // 
            // KOTBtn
            // 
            this.KOTBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.KOTBtn.AutoRoundedCorners = true;
            this.KOTBtn.BackColor = System.Drawing.Color.Transparent;
            this.KOTBtn.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.KOTBtn.BorderRadius = 39;
            this.KOTBtn.BorderThickness = 2;
            this.KOTBtn.CheckedState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.KOTBtn.CheckedState.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.KOTBtn.CustomBorderColor = System.Drawing.Color.Black;
            this.KOTBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.KOTBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.KOTBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.KOTBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.KOTBtn.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.KOTBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.KOTBtn.ForeColor = System.Drawing.Color.White;
            this.KOTBtn.Image = global::CafeManagement.Properties.Resources.hatChief;
            this.KOTBtn.Location = new System.Drawing.Point(711, 12);
            this.KOTBtn.Name = "KOTBtn";
            this.KOTBtn.Size = new System.Drawing.Size(80, 80);
            this.KOTBtn.TabIndex = 5;
            this.KOTBtn.Text = "KOT";
            this.KOTBtn.Click += new System.EventHandler(this.KOTBtn_Click);
            // 
            // BillBtn
            // 
            this.BillBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BillBtn.AutoRoundedCorners = true;
            this.BillBtn.BackColor = System.Drawing.Color.Transparent;
            this.BillBtn.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.BillBtn.BorderRadius = 39;
            this.BillBtn.BorderThickness = 2;
            this.BillBtn.CheckedState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.BillBtn.CheckedState.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.BillBtn.CustomBorderColor = System.Drawing.Color.Black;
            this.BillBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BillBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BillBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BillBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BillBtn.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.BillBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BillBtn.ForeColor = System.Drawing.Color.White;
            this.BillBtn.Image = global::CafeManagement.Properties.Resources.receipt;
            this.BillBtn.Location = new System.Drawing.Point(625, 12);
            this.BillBtn.Name = "BillBtn";
            this.BillBtn.Size = new System.Drawing.Size(80, 80);
            this.BillBtn.TabIndex = 4;
            this.BillBtn.Text = "Bill List";
            this.BillBtn.Click += new System.EventHandler(this.BillBtn_Click);
            // 
            // NewBtn
            // 
            this.NewBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NewBtn.AutoRoundedCorners = true;
            this.NewBtn.BackColor = System.Drawing.Color.Transparent;
            this.NewBtn.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.NewBtn.BorderRadius = 39;
            this.NewBtn.BorderThickness = 2;
            this.NewBtn.CheckedState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.NewBtn.CheckedState.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.NewBtn.CustomBorderColor = System.Drawing.Color.Black;
            this.NewBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NewBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NewBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NewBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NewBtn.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.NewBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NewBtn.ForeColor = System.Drawing.Color.White;
            this.NewBtn.Image = global::CafeManagement.Properties.Resources._new;
            this.NewBtn.Location = new System.Drawing.Point(539, 12);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(80, 80);
            this.NewBtn.TabIndex = 2;
            this.NewBtn.Text = "New";
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "POS";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::CafeManagement.Properties.Resources.restaurant;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(23, 22);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(60, 60);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.CheckBtn);
            this.guna2Panel2.Controls.Add(this.TotalLbl);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.FillColor = System.Drawing.Color.SlateBlue;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 631);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1584, 100);
            this.guna2Panel2.TabIndex = 1;
            // 
            // CheckBtn
            // 
            this.CheckBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CheckBtn.AutoRoundedCorners = true;
            this.CheckBtn.BackColor = System.Drawing.Color.Transparent;
            this.CheckBtn.BorderRadius = 21;
            this.CheckBtn.CustomizableEdges.BottomLeft = false;
            this.CheckBtn.CustomizableEdges.TopRight = false;
            this.CheckBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CheckBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CheckBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CheckBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CheckBtn.FillColor = System.Drawing.Color.PaleVioletRed;
            this.CheckBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CheckBtn.ForeColor = System.Drawing.Color.White;
            this.CheckBtn.Location = new System.Drawing.Point(1122, 31);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(155, 45);
            this.CheckBtn.TabIndex = 13;
            this.CheckBtn.Text = "Check Out";
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // TotalLbl
            // 
            this.TotalLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.BackColor = System.Drawing.Color.Transparent;
            this.TotalLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TotalLbl.ForeColor = System.Drawing.Color.White;
            this.TotalLbl.Location = new System.Drawing.Point(1448, 31);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(63, 32);
            this.TotalLbl.TabIndex = 12;
            this.TotalLbl.Text = "0.00";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1330, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "TOTAL";
            // 
            // CategoryPanel
            // 
            this.CategoryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CategoryPanel.Location = new System.Drawing.Point(23, 158);
            this.CategoryPanel.Name = "CategoryPanel";
            this.CategoryPanel.Size = new System.Drawing.Size(188, 467);
            this.CategoryPanel.TabIndex = 2;
            // 
            // ProductPanel
            // 
            this.ProductPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductPanel.AutoScroll = true;
            this.ProductPanel.Controls.Add(this.flowLayoutPanel1);
            this.ProductPanel.Location = new System.Drawing.Point(217, 158);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(772, 467);
            this.ProductPanel.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(684, 0);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 40;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSno,
            this.dgvID,
            this.dgvproID,
            this.dgvName,
            this.dgvQty,
            this.dgvPrice,
            this.dgvAmount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.guna2DataGridView1.Location = new System.Drawing.Point(995, 158);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.Size = new System.Drawing.Size(581, 467);
            this.guna2DataGridView1.TabIndex = 7;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 40;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.guna2DataGridView1_CellFormatting);
            // 
            // dgvSno
            // 
            this.dgvSno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvSno.FillWeight = 70F;
            this.dgvSno.Frozen = true;
            this.dgvSno.HeaderText = "No";
            this.dgvSno.MinimumWidth = 70;
            this.dgvSno.Name = "dgvSno";
            this.dgvSno.ReadOnly = true;
            this.dgvSno.Width = 70;
            // 
            // dgvID
            // 
            this.dgvID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvID.HeaderText = "id";
            this.dgvID.MinimumWidth = 100;
            this.dgvID.Name = "dgvID";
            this.dgvID.ReadOnly = true;
            this.dgvID.Visible = false;
            // 
            // dgvproID
            // 
            this.dgvproID.HeaderText = "ProductID";
            this.dgvproID.Name = "dgvproID";
            this.dgvproID.ReadOnly = true;
            this.dgvproID.Visible = false;
            // 
            // dgvName
            // 
            this.dgvName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvName.FillWeight = 120F;
            this.dgvName.HeaderText = "Name";
            this.dgvName.MinimumWidth = 120;
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            this.dgvName.Width = 120;
            // 
            // dgvQty
            // 
            this.dgvQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvQty.FillWeight = 120F;
            this.dgvQty.HeaderText = "Qty";
            this.dgvQty.MinimumWidth = 120;
            this.dgvQty.Name = "dgvQty";
            this.dgvQty.ReadOnly = true;
            this.dgvQty.Width = 120;
            // 
            // dgvPrice
            // 
            this.dgvPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvPrice.FillWeight = 120F;
            this.dgvPrice.HeaderText = "Price";
            this.dgvPrice.MinimumWidth = 120;
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.ReadOnly = true;
            this.dgvPrice.Width = 120;
            // 
            // dgvAmount
            // 
            this.dgvAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvAmount.FillWeight = 150F;
            this.dgvAmount.HeaderText = "Amount";
            this.dgvAmount.MinimumWidth = 150;
            this.dgvAmount.Name = "dgvAmount";
            this.dgvAmount.ReadOnly = true;
            this.dgvAmount.Width = 150;
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.SystemColors.Control;
            this.panel.Location = new System.Drawing.Point(217, 158);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(772, 467);
            this.panel.TabIndex = 9;
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = "Cafe Management";
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.guna2MessageDialog1.Parent = this;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.guna2MessageDialog1.Text = null;
            // 
            // SearchTxt
            // 
            this.SearchTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTxt.DefaultText = "";
            this.SearchTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTxt.IconLeft = global::CafeManagement.Properties.Resources.search;
            this.SearchTxt.Location = new System.Drawing.Point(217, 116);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.PasswordChar = '\0';
            this.SearchTxt.PlaceholderForeColor = System.Drawing.Color.DarkSlateBlue;
            this.SearchTxt.PlaceholderText = "Search Here";
            this.SearchTxt.SelectedText = "";
            this.SearchTxt.Size = new System.Drawing.Size(265, 36);
            this.SearchTxt.TabIndex = 8;
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            // 
            // POSform
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1584, 731);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.CategoryPanel);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.ProductPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "POSform";
            this.Text = "POSform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.POSform_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ProductPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TileButton NewBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TileButton DinInBtn;
        private Guna.UI2.WinForms.Guna2TileButton KOTBtn;
        private Guna.UI2.WinForms.Guna2TileButton BillBtn;
        private System.Windows.Forms.Label WaiterLbl;
        private System.Windows.Forms.Label TableLbl;
        private Guna.UI2.WinForms.Guna2PictureBox ExitBtn;
        private System.Windows.Forms.FlowLayoutPanel CategoryPanel;
        private System.Windows.Forms.FlowLayoutPanel ProductPanel;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        public Guna.UI2.WinForms.Guna2TextBox SearchTxt;
        private System.Windows.Forms.Label TotalLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel panel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvproID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAmount;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        public Guna.UI2.WinForms.Guna2Button CheckBtn;
    }
}