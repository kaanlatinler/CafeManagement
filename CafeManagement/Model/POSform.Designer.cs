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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POSform));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TableLbl = new System.Windows.Forms.Label();
            this.WaiterLbl = new System.Windows.Forms.Label();
            this.CategoryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ProductPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitBtn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.DinInBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.TakeABtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.DeliveryBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.KOTBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.BillBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.HoldBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.NewBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.productControl1 = new CafeManagement.Model.ProductControl();
            this.productControl2 = new CafeManagement.Model.ProductControl();
            this.productControl3 = new CafeManagement.Model.ProductControl();
            this.productControl4 = new CafeManagement.Model.ProductControl();
            this.guna2Panel1.SuspendLayout();
            this.ProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.ExitBtn);
            this.guna2Panel1.Controls.Add(this.WaiterLbl);
            this.guna2Panel1.Controls.Add(this.TableLbl);
            this.guna2Panel1.Controls.Add(this.DinInBtn);
            this.guna2Panel1.Controls.Add(this.TakeABtn);
            this.guna2Panel1.Controls.Add(this.DeliveryBtn);
            this.guna2Panel1.Controls.Add(this.KOTBtn);
            this.guna2Panel1.Controls.Add(this.BillBtn);
            this.guna2Panel1.Controls.Add(this.HoldBtn);
            this.guna2Panel1.Controls.Add(this.NewBtn);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.SlateBlue;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1485, 100);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.FillColor = System.Drawing.Color.SlateBlue;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 799);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1485, 100);
            this.guna2Panel2.TabIndex = 1;
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
            // TableLbl
            // 
            this.TableLbl.AutoSize = true;
            this.TableLbl.BackColor = System.Drawing.Color.Transparent;
            this.TableLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TableLbl.ForeColor = System.Drawing.Color.White;
            this.TableLbl.Location = new System.Drawing.Point(993, 12);
            this.TableLbl.Name = "TableLbl";
            this.TableLbl.Size = new System.Drawing.Size(71, 32);
            this.TableLbl.TabIndex = 9;
            this.TableLbl.Text = "Table";
            this.TableLbl.Visible = false;
            // 
            // WaiterLbl
            // 
            this.WaiterLbl.AutoSize = true;
            this.WaiterLbl.BackColor = System.Drawing.Color.Transparent;
            this.WaiterLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WaiterLbl.ForeColor = System.Drawing.Color.White;
            this.WaiterLbl.Location = new System.Drawing.Point(993, 60);
            this.WaiterLbl.Name = "WaiterLbl";
            this.WaiterLbl.Size = new System.Drawing.Size(86, 32);
            this.WaiterLbl.TabIndex = 10;
            this.WaiterLbl.Text = "Waiter";
            this.WaiterLbl.Visible = false;
            // 
            // CategoryPanel
            // 
            this.CategoryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CategoryPanel.Location = new System.Drawing.Point(23, 232);
            this.CategoryPanel.Name = "CategoryPanel";
            this.CategoryPanel.Size = new System.Drawing.Size(188, 561);
            this.CategoryPanel.TabIndex = 2;
            // 
            // ProductPanel
            // 
            this.ProductPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductPanel.Controls.Add(this.productControl1);
            this.ProductPanel.Controls.Add(this.productControl2);
            this.ProductPanel.Controls.Add(this.productControl3);
            this.ProductPanel.Controls.Add(this.productControl4);
            this.ProductPanel.Location = new System.Drawing.Point(217, 232);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(684, 561);
            this.ProductPanel.TabIndex = 3;
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
            this.guna2DataGridView1.Location = new System.Drawing.Point(907, 232);
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
            this.guna2DataGridView1.Size = new System.Drawing.Size(570, 561);
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
            // dgvName
            // 
            this.dgvName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvName.FillWeight = 120F;
            this.dgvName.Frozen = true;
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
            this.dgvQty.Frozen = true;
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
            this.dgvPrice.Frozen = true;
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
            this.dgvAmount.Frozen = true;
            this.dgvAmount.HeaderText = "Amount";
            this.dgvAmount.MinimumWidth = 150;
            this.dgvAmount.Name = "dgvAmount";
            this.dgvAmount.ReadOnly = true;
            this.dgvAmount.Width = 150;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.Image = global::CafeManagement.Properties.Resources.cancel;
            this.ExitBtn.ImageRotate = 0F;
            this.ExitBtn.Location = new System.Drawing.Point(1413, 22);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(60, 60);
            this.ExitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitBtn.TabIndex = 11;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.UseTransparentBackground = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // DinInBtn
            // 
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
            this.DinInBtn.Location = new System.Drawing.Point(907, 12);
            this.DinInBtn.Name = "DinInBtn";
            this.DinInBtn.Size = new System.Drawing.Size(80, 80);
            this.DinInBtn.TabIndex = 8;
            this.DinInBtn.Text = "Din In";
            // 
            // TakeABtn
            // 
            this.TakeABtn.AutoRoundedCorners = true;
            this.TakeABtn.BackColor = System.Drawing.Color.Transparent;
            this.TakeABtn.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.TakeABtn.BorderRadius = 39;
            this.TakeABtn.BorderThickness = 2;
            this.TakeABtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.TakeABtn.CheckedState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.TakeABtn.CheckedState.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.TakeABtn.CustomBorderColor = System.Drawing.Color.Black;
            this.TakeABtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.TakeABtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.TakeABtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TakeABtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.TakeABtn.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.TakeABtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TakeABtn.ForeColor = System.Drawing.Color.White;
            this.TakeABtn.Image = global::CafeManagement.Properties.Resources.take_away;
            this.TakeABtn.Location = new System.Drawing.Point(821, 12);
            this.TakeABtn.Name = "TakeABtn";
            this.TakeABtn.Size = new System.Drawing.Size(80, 80);
            this.TakeABtn.TabIndex = 7;
            this.TakeABtn.Text = "Take Away";
            // 
            // DeliveryBtn
            // 
            this.DeliveryBtn.AutoRoundedCorners = true;
            this.DeliveryBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeliveryBtn.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.DeliveryBtn.BorderRadius = 39;
            this.DeliveryBtn.BorderThickness = 2;
            this.DeliveryBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.DeliveryBtn.CheckedState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.DeliveryBtn.CheckedState.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.DeliveryBtn.CustomBorderColor = System.Drawing.Color.Black;
            this.DeliveryBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeliveryBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeliveryBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeliveryBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeliveryBtn.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.DeliveryBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeliveryBtn.ForeColor = System.Drawing.Color.White;
            this.DeliveryBtn.Image = global::CafeManagement.Properties.Resources.fast_delivery;
            this.DeliveryBtn.Location = new System.Drawing.Point(735, 12);
            this.DeliveryBtn.Name = "DeliveryBtn";
            this.DeliveryBtn.Size = new System.Drawing.Size(80, 80);
            this.DeliveryBtn.TabIndex = 6;
            this.DeliveryBtn.Text = "Delivery";
            // 
            // KOTBtn
            // 
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
            this.KOTBtn.Location = new System.Drawing.Point(649, 12);
            this.KOTBtn.Name = "KOTBtn";
            this.KOTBtn.Size = new System.Drawing.Size(80, 80);
            this.KOTBtn.TabIndex = 5;
            this.KOTBtn.Text = "KOT";
            // 
            // BillBtn
            // 
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
            this.BillBtn.Location = new System.Drawing.Point(563, 12);
            this.BillBtn.Name = "BillBtn";
            this.BillBtn.Size = new System.Drawing.Size(80, 80);
            this.BillBtn.TabIndex = 4;
            this.BillBtn.Text = "Bill List";
            // 
            // HoldBtn
            // 
            this.HoldBtn.AutoRoundedCorners = true;
            this.HoldBtn.BackColor = System.Drawing.Color.Transparent;
            this.HoldBtn.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.HoldBtn.BorderRadius = 39;
            this.HoldBtn.BorderThickness = 2;
            this.HoldBtn.CheckedState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.HoldBtn.CheckedState.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.HoldBtn.CustomBorderColor = System.Drawing.Color.Black;
            this.HoldBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HoldBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HoldBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HoldBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HoldBtn.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.HoldBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HoldBtn.ForeColor = System.Drawing.Color.White;
            this.HoldBtn.Image = global::CafeManagement.Properties.Resources.hand;
            this.HoldBtn.Location = new System.Drawing.Point(477, 12);
            this.HoldBtn.Name = "HoldBtn";
            this.HoldBtn.Size = new System.Drawing.Size(80, 80);
            this.HoldBtn.TabIndex = 3;
            this.HoldBtn.Text = "Hold";
            // 
            // NewBtn
            // 
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
            this.NewBtn.Location = new System.Drawing.Point(391, 12);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(80, 80);
            this.NewBtn.TabIndex = 2;
            this.NewBtn.Text = "New";
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
            // productControl1
            // 
            this.productControl1.id = 0;
            this.productControl1.Location = new System.Drawing.Point(3, 3);
            this.productControl1.Name = "productControl1";
            this.productControl1.pCategory = null;
            this.productControl1.pImage = ((System.Drawing.Image)(resources.GetObject("productControl1.pImage")));
            this.productControl1.pName = "Product Name";
            this.productControl1.pPrice = null;
            this.productControl1.Size = new System.Drawing.Size(179, 179);
            this.productControl1.TabIndex = 0;
            // 
            // productControl2
            // 
            this.productControl2.id = 0;
            this.productControl2.Location = new System.Drawing.Point(188, 3);
            this.productControl2.Name = "productControl2";
            this.productControl2.pCategory = null;
            this.productControl2.pImage = ((System.Drawing.Image)(resources.GetObject("productControl2.pImage")));
            this.productControl2.pName = "Product Name";
            this.productControl2.pPrice = null;
            this.productControl2.Size = new System.Drawing.Size(179, 179);
            this.productControl2.TabIndex = 1;
            // 
            // productControl3
            // 
            this.productControl3.id = 0;
            this.productControl3.Location = new System.Drawing.Point(373, 3);
            this.productControl3.Name = "productControl3";
            this.productControl3.pCategory = null;
            this.productControl3.pImage = ((System.Drawing.Image)(resources.GetObject("productControl3.pImage")));
            this.productControl3.pName = "Product Name";
            this.productControl3.pPrice = null;
            this.productControl3.Size = new System.Drawing.Size(179, 179);
            this.productControl3.TabIndex = 2;
            // 
            // productControl4
            // 
            this.productControl4.id = 0;
            this.productControl4.Location = new System.Drawing.Point(3, 188);
            this.productControl4.Name = "productControl4";
            this.productControl4.pCategory = null;
            this.productControl4.pImage = ((System.Drawing.Image)(resources.GetObject("productControl4.pImage")));
            this.productControl4.pName = "Product Name";
            this.productControl4.pPrice = null;
            this.productControl4.Size = new System.Drawing.Size(179, 179);
            this.productControl4.TabIndex = 3;
            // 
            // POSform
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1485, 899);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.ProductPanel);
            this.Controls.Add(this.CategoryPanel);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "POSform";
            this.Text = "POSform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.POSform_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ProductPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TileButton NewBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TileButton HoldBtn;
        private Guna.UI2.WinForms.Guna2TileButton DinInBtn;
        private Guna.UI2.WinForms.Guna2TileButton TakeABtn;
        private Guna.UI2.WinForms.Guna2TileButton DeliveryBtn;
        private Guna.UI2.WinForms.Guna2TileButton KOTBtn;
        private Guna.UI2.WinForms.Guna2TileButton BillBtn;
        private System.Windows.Forms.Label WaiterLbl;
        private System.Windows.Forms.Label TableLbl;
        private Guna.UI2.WinForms.Guna2PictureBox ExitBtn;
        private System.Windows.Forms.FlowLayoutPanel CategoryPanel;
        private System.Windows.Forms.FlowLayoutPanel ProductPanel;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAmount;
        private ProductControl productControl1;
        private ProductControl productControl2;
        private ProductControl productControl3;
        private ProductControl productControl4;
    }
}