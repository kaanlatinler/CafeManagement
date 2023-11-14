using CafeManagement.Database;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement.Model
{
    public partial class AddStaff : AddSample
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        public int id = 0;

        private void AddStaff_Load(object sender, EventArgs e)
        {

        }

        public override void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public override void SaveBtn_Click(object sender, EventArgs e)
        {
            string query = "";

            if (id == 0)
            {
                query = "insert into staff Values(@Name, @Phone, @Rank)";
            }
            else
            {
                query = "Update staff Set staffName = @Name, staffPhone = @Phone, staffRank = @Rank where staffID = @id ";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", NameTxt.Text);
            ht.Add("@Phone", PhoneTxt.Text);
            ht.Add("@Rank", RankCB.Text);

            if (DBengine.SQL(query, ht) > 0)
            {
                MessageBox.Show("Saved Successfully");
                id = 0;
                NameTxt.Text = "";
                PhoneTxt.Text = "";
                RankCB.SelectedIndex = -1;
                NameTxt.Focus();
            }
        }
    }
}
