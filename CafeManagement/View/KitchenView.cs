using CafeManagement.Database;
using CafeManagement.Model;
using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CafeManagement.View
{
    public partial class KitchenView : Form
    {
        public KitchenView()
        {
            InitializeComponent();
        }

        private void KitchenView_Load(object sender, EventArgs e)
        {
            GetOrders();
        }

        private void GetOrders()
        {
            flowLayoutPanel1.Controls.Clear();
            string query = @"select * from TableMain where status = 'Pending'";
            SqlCommand cmd = new SqlCommand(query, DBengine.conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            FlowLayoutPanel panel;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                panel = new FlowLayoutPanel();
                panel.AutoSize = true;
                panel.Width = 230;
                panel.Height = 350;
                panel.FlowDirection = FlowDirection.TopDown;
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Margin = new Padding(10, 10, 10, 10);

                FlowLayoutPanel panel2 = new FlowLayoutPanel();
                panel2.BackColor = Color.FromArgb(123, 104, 238);
                panel2.AutoSize = true;
                panel2.Width = 230;
                panel2.Height = 125;
                panel2.FlowDirection = FlowDirection.TopDown;
                panel2.BorderStyle = BorderStyle.FixedSingle;
                panel2.Margin = new Padding(0, 0, 0, 0);

                Label Lbl = new Label();
                Lbl.ForeColor = Color.White;
                Lbl.Margin = new Padding(10, 10, 3, 0);
                Lbl.AutoSize = true;

                Label Lbl2 = new Label();
                Lbl2.ForeColor = Color.White;
                Lbl2.Margin = new Padding(10, 5, 3, 0);
                Lbl2.AutoSize = true;

                Label Lbl3 = new Label();
                Lbl3.ForeColor = Color.White;
                Lbl3.Margin = new Padding(10, 5, 3, 0);
                Lbl3.AutoSize = true;

                Label Lbl4 = new Label();
                Lbl4.ForeColor = Color.White;
                Lbl4.Margin = new Padding(10, 5, 3, 10);
                Lbl4.AutoSize = true;



                Lbl.Text = "Table : " + dt.Rows[i]["tableName"].ToString();
                Lbl2.Text = "Waiter Name : " + dt.Rows[i]["waiterName"].ToString();
                Lbl3.Text = "Order Time : " + dt.Rows[i]["orderTime"].ToString();
                Lbl4.Text = "Order Type : " + dt.Rows[i]["orderType"].ToString();

                panel2.Controls.Add(Lbl);
                panel2.Controls.Add(Lbl2);
                panel2.Controls.Add(Lbl3);
                panel2.Controls.Add(Lbl4);

                panel.Controls.Add(panel2);

                int mid = 0;
                mid = Convert.ToInt32(dt.Rows[i]["mainID"].ToString());

                string query2 = @"select * from TableMain m
                                            inner join TableDetails d on m.mainID = d.mainID
                                            inner join Products p on p.productID = d.proID
                                            where m.mainID = " + mid + " ";

                SqlCommand cmd2 = new SqlCommand(query2, DBengine.conn);
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(dt2);

                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    Label Lbl5 = new Label();
                    Lbl5.ForeColor = Color.Black;
                    Lbl5.Margin = new Padding(10, 5, 3, 0);
                    Lbl5.AutoSize = true;

                    int no = j + 1;
                    Lbl5.Text =  no + " | " + dt2.Rows[j]["productName"].ToString() + " | " + dt2.Rows[j]["qty"].ToString() + " Adet";

                    panel.Controls.Add(Lbl5);
                }

                Guna.UI2.WinForms.Guna2Button btn = new Guna.UI2.WinForms.Guna2Button();
                btn.AutoRoundedCorners = true;
                btn.Size = new Size(100, 35);
                btn.FillColor = Color.FromArgb(72, 61, 139);
                btn.Margin = new Padding(40, 5, 3, 10);
                btn.Text = "Bitir";
                btn.Tag = dt.Rows[i]["mainID"].ToString();

                btn.Click += new EventHandler(Btn_click);
                panel.Controls.Add(btn);

                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        private void Btn_click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Guna.UI2.WinForms.Guna2Button).Tag.ToString());

            Guna2MessageDialog msg = new Guna2MessageDialog();
            msg.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            msg.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;

            if (msg.Show("Siparişi Bitirmek istediğinize emin misiniz?") == DialogResult.Yes)
            {
                string query = @"Update TableMain set status = 'Complete' where mainID = @ID";
                Hashtable ht = new Hashtable();
                ht.Add("@ID", id);

                if (DBengine.SQL(query, ht) > 0)
                {
                    msg.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    msg.Show("Kayıt İşlemi Başarılı");
                }
                GetOrders();
            }
        }
    }
}
