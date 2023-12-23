using CafeManagement.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace CafeManagement.Model
{
    public partial class SelectTable : Form
    {
        public SelectTable()
        {
            InitializeComponent();
        }

        public string tableName;

        private void SelectTable_Load(object sender, EventArgs e)
        {
            string query = "Select * from tables";
            SqlCommand cmd = new SqlCommand(query, DBengine.conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows) 
            {
                Guna.UI2.WinForms.Guna2Button btn = new Guna.UI2.WinForms.Guna2Button();
                btn.Text = row["tableName"].ToString();
                btn.Width = 150;
                btn.Height = 50;
                btn.FillColor = Color.FromArgb(72, 61, 139);

                btn.Click += new EventHandler(btn_Click);
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private  void btn_Click(object sender, EventArgs e)
        {
            tableName = (sender as Guna.UI2.WinForms.Guna2Button).Text.ToString();
            this.Close();
        }
    }
}
