using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeManagement;
using CafeManagement.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CafeManagement.Model
{
    public partial class POSform : Form
    {
        public POSform()
        {
            InitializeComponent();
        }

        public int mainID = 0;
        public string orderType;

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void POSform_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.BorderStyle = BorderStyle.FixedSingle;
            AddCategory();

            ProductPanel.Controls.Clear();
            getProducts();
            await Task.Delay(TimeSpan.FromSeconds(1));
            panel.Hide();
        }

        private void AddCategory()
        {
            string query = "Select * from category";
            SqlCommand cmd = new SqlCommand(query, DBengine.conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            CategoryPanel.Controls.Clear();

            if(dt.Rows.Count >0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Guna.UI2.WinForms.Guna2Button btn = new Guna.UI2.WinForms.Guna2Button();
                    btn.FillColor = Color.FromArgb(72, 61, 139);
                    btn.Size = new Size(134, 45);
                    btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                    btn.Text = row["catName"].ToString();

                    btn.Click += new EventHandler(btn_Click);

                    CategoryPanel.Controls.Add(btn);
                }
            }
        }

        private async void btn_Click(object sender, EventArgs e)
        {
            panel.Show();
            Guna.UI2.WinForms.Guna2Button btn = (Guna.UI2.WinForms.Guna2Button)sender;

            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ProductControl)item;
                pro.Visible = false;
            }

            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ProductControl)item;
                if (pro.pCategory.ToLower().Contains(btn.Text.Trim().ToLower()))
                {
                    pro.Visible = true;
                }
            }

            await Task.Delay(TimeSpan.FromMilliseconds(50));
            panel.Hide();
        }

        private void AddItem(string id, string proID, string name, string cat, string price, Image Image)
        {
            var itemBox = new ProductControl()
            {
                pName = name,
                pPrice = price,
                pCategory = cat,
                pImage = Image,
                id = Convert.ToInt32(id)
            };

            ProductPanel.Controls.Add(itemBox);

            itemBox.onSelect += (ss, ee) =>
            {
                var Box = (ProductControl)ss;

                foreach (DataGridViewRow item in guna2DataGridView1.Rows)
                {
                    if (Convert.ToInt32(item.Cells["dgvproID"].Value) == Box.id)
                    {
                        item.Cells["dgvQty"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) + 1;
                        item.Cells["dgvAmount"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) *
                                                        double.Parse(item.Cells["dgvPrice"].Value.ToString());

                        GetTotal();
                        return;
                    }
                }
                guna2DataGridView1.Rows.Add(new object[] {0, 0, Box.id, Box.pName, 1, Box.pPrice, Box.pPrice});
                GetTotal();
            };
        }

        private void getProducts()
        {
            string query = "select * from  Products inner join category on catID = categoryID";
            SqlCommand cmd = new SqlCommand(query, DBengine.conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                Byte[] imageArray = (byte[])item["productImg"];

                AddItem(item["productID"].ToString(), "0", item["productName"].ToString(), item["catName"].ToString(), item["productPrice"].ToString(), Image.FromStream(new MemoryStream(imageArray)));
            }
        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ProductControl)item;
                pro.Visible = pro.pName.ToLower().Contains(SearchTxt.Text.Trim().ToLower());
            }
        }

        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void GetTotal()
        {
            double ttl = 0;
            TotalLbl.Text = "";

            foreach (DataGridViewRow item in guna2DataGridView1.Rows)
            {
                ttl += double.Parse(item.Cells["dgvAmount"].Value.ToString());
            }
            TotalLbl.Text = ttl.ToString("N2");
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            TableLbl.Text = "";
            WaiterLbl.Text = "";

            TableLbl.Visible = false;
            WaiterLbl.Visible = false;
            guna2DataGridView1.Rows.Clear();
            mainID = 0;
            TotalLbl.Text = "0.00";
        }

        private void DeliveryBtn_Click(object sender, EventArgs e)
        {
            TableLbl.Text = "";
            WaiterLbl.Text = "";

            TableLbl.Visible = false;
            WaiterLbl.Visible = false;
            orderType = "Delivery";
        }

        private void TakeABtn_Click(object sender, EventArgs e)
        {
            TableLbl.Text = "";
            WaiterLbl.Text = "";

            TableLbl.Visible = false;
            WaiterLbl.Visible = false;
            orderType = "Take Away";
        }

        private void DinInBtn_Click(object sender, EventArgs e)
        {
            orderType = "Din In";

            SelectTable form = new SelectTable();
            DBengine.BlurBG(form);
            if (form.tableName !="")
            {
                TableLbl.Text = form.tableName;
                TableLbl.Visible=true;
            }
            else
            {
                TableLbl.Text = "";
                TableLbl.Visible = false;
            }

            SelectWaiter form2 = new SelectWaiter();
            DBengine.BlurBG(form2);
            if (form2.staffName != "")
            {
                WaiterLbl.Text = form2.staffName;
                WaiterLbl.Visible = true;
            }
            else
            {
                WaiterLbl.Text = "";
                WaiterLbl.Visible = false;
            }


        }

        private async void KOTBtn_Click(object sender, EventArgs e)
        {
            string query = "";
            string query2 = "";

            int detailID = 0;

            if(mainID==0)
            {
                query = @"INSERT INTO TableMain values(@orderDate, @orderTime, @tableName, @waiterName, @status, @orderType, @total, @received, @change);
                        select SCOPE_IDENTITY()";
            }
            else
            {
                query = @"UPDATE TableMain SET status= @status, total=@total, received= @received, change=@change where mainID = @ID";
            }

            SqlCommand cmd = new SqlCommand(query, DBengine.conn);
            cmd.Parameters.AddWithValue("@ID", mainID);
            cmd.Parameters.AddWithValue("@orderDate", Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@orderTime", DateTime.Now.ToLongTimeString());
            cmd.Parameters.AddWithValue("@tableName", TableLbl.Text);
            cmd.Parameters.AddWithValue("@waiterName", WaiterLbl.Text);
            cmd.Parameters.AddWithValue("@status", "Pending");
            cmd.Parameters.AddWithValue("@orderType", orderType);
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(TotalLbl.Text));
            cmd.Parameters.AddWithValue("@received", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));

            if(DBengine.conn.State == ConnectionState.Closed)
            {
                DBengine.conn.Open();
            }

            if(mainID==0)
            {
                mainID = Convert.ToInt32(await cmd.ExecuteScalarAsync());
            }
            else
            {
                cmd.ExecuteNonQuery();
            }

            if (DBengine.conn.State == ConnectionState.Open)
            {
                DBengine.conn.Close();
            }

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dgvID"].Value);

                if (detailID == 0)
                {
                    query2 = @"INSERT INTO TableDetails Values(@mainID, @proID, @qty, @price, @amount)";
                }
                else
                {
                    query2 = @"UPDATE TableDetails SET mainID=@mainID, proID=@proID, qty=@qty, price=@price, amount=@amount where detailID=@ID";
                }

                SqlCommand cmd2 = new SqlCommand(query2, DBengine.conn);
                cmd2.Parameters.AddWithValue("@ID", detailID);
                cmd2.Parameters.AddWithValue("@mainID", mainID);
                cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["dgvproID"].Value));
                cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvQty"].Value));
                cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value));

                if (DBengine.conn.State == ConnectionState.Closed)
                {
                    DBengine.conn.Open();
                }

                cmd2.ExecuteNonQuery();

                if (DBengine.conn.State == ConnectionState.Open)
                {
                    DBengine.conn.Close();
                }
            }
            guna2MessageDialog1.Show("Sipariş Alındı");
            mainID = 0;
            detailID = 0;
            guna2DataGridView1.Rows.Clear();

            TableLbl.Text = "";
            WaiterLbl.Text = "";

            TableLbl.Visible = false;
            WaiterLbl.Visible = false;
            TotalLbl.Text = "0.00";
        }

        public int id = 0;

        private void BillBtn_Click(object sender, EventArgs e)
        {
            BillList form = new BillList();
            DBengine.BlurBG(form);

            if(form.MainID > 0)
            {
                id = form.MainID;
                loadEntry();
            }
        }

        private void loadEntry()
        {
            string query = @"select * from TableMain m
                                            inner join TableDetails d on m.mainID = d.mainID
                                            inner join Products p on p.productID = d.proID
                                            where m.mainID = " + id + " ";

            SqlCommand cmd = new SqlCommand(query, DBengine.conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows[0]["orderType"].ToString() == "Din In")
            {
                DinInBtn.Checked = true;
                WaiterLbl.Visible = true;
                TableLbl.Visible = true;

                TableLbl.Text = dt.Rows[0]["tableName"].ToString();
                WaiterLbl.Text = dt.Rows[0]["waiterName"].ToString();
            }

                guna2DataGridView1.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                TableLbl.Text = item["tableName"].ToString();
                WaiterLbl.Text = item["waiterName"].ToString();

                string detailID = item["detailID"].ToString();
                string proName = item["productName"].ToString();
                string proID = item["proID"].ToString();
                string qty = item["qty"].ToString();
                string price = item["price"].ToString();
                string amount = item["amount"].ToString();

                object[] obj = {0, detailID, proID, proName, qty, price, amount };
                guna2DataGridView1.Rows.Add(obj);
            }
            GetTotal();
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            Check form = new Check();
            form.MainID = id;
            form.amount =Convert.ToDouble(TotalLbl.Text);
            DBengine.BlurBG(form);

            mainID = 0;
            guna2DataGridView1.Rows.Clear();

            TableLbl.Text = "";
            WaiterLbl.Text = "";

            TableLbl.Visible = false;
            WaiterLbl.Visible = false;
            TotalLbl.Text = "0.00";
        }
    }
}
