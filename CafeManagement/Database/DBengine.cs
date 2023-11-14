using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement.Database
{
    class DBengine
    {
        public static readonly string connString = @"Data Source=DESKTOP-L24PRRJ\SQLEXPRESS;Initial Catalog=CafeManagamentDB;Persist Security Info=True;User ID=sa;Password=kaanhdd374";
        public static SqlConnection conn= new SqlConnection(connString);

        public static bool IsValid(string user, string pass)
        {
            bool isValid = false;

            string query = @"Select * from users where username = '" + user + "' and uPass = '" + pass + "' ";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if(dt.Rows.Count > 0)
            { 
                isValid = true;
                User = dt.Rows[0]["uName"].ToString();
                Rank = dt.Rows[0]["uRank"].ToString();
            }

            return isValid;
        }

        public static string user, rank;

        public static string User
        { 
            get { return user; }
            private set { user = value; }
        }
        public static string Rank
        {
            get { return rank; }
            private set { rank = value; }
        }

        public static int SQL(string query, Hashtable ht)
        {
            int res = 0;

            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.Text;

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }

                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                res = cmd.ExecuteNonQuery();

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                conn.Close();
            }

            return res;
        }

        public static void LoadData(string query, DataGridView gv, ListBox lb)
        {
            gv.CellFormatting += new DataGridViewCellFormattingEventHandler(gv_CellFormatting);

            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colNum1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colNum1].DataPropertyName = dt.Columns[i].ToString();
                }

                gv.DataSource = dt;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                conn.Close();
            }
        }

        private static void gv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Guna.UI2.WinForms.Guna2DataGridView gv = (Guna.UI2.WinForms.Guna2DataGridView)sender;

            int count = 0;

            foreach (DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        public static void BlurBG(Form Model)
        {
            Form BG = new Form();

            using (Model)
            {
                BG.StartPosition = FormStartPosition.Manual;
                BG.FormBorderStyle = FormBorderStyle.None;
                BG.Opacity = 0.5d;
                BG.BackColor = Color.Black;
                BG.Size = MainForm.Instance.Size;
                BG.Location = MainForm.Instance.Location;
                BG.ShowInTaskbar = false;
                BG.Show();
                Model.Owner = BG;
                Model.ShowDialog(BG);
                BG.Dispose();
            }
        }

        public static void CBfill(string query, ComboBox cb)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cb.DisplayMember = "name";
            cb.ValueMember = "id";
            cb.DataSource = dt;
            cb.SelectedIndex = -1;
        }
    }
}
