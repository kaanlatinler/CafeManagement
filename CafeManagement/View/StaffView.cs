using CafeManagement.Database;
using CafeManagement.Model;
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

namespace CafeManagement.View
{
    public partial class StaffView : SampleView
    {
        public StaffView()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            string query = "Select * from staff where staffName like '%" + SearchTxt.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvID);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvPhone);
            lb.Items.Add(dgvRank);

            DBengine.LoadData(query, guna2DataGridView1, lb);
        }

        public override void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        public override void AddBtn_Click(object sender, EventArgs e)
        {
            DBengine.BlurBG(new AddStaff());

            GetData();
        }

        private void StaffView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                AddStaff form = new AddStaff();
                form.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvID"].Value);
                form.NameTxt.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvName"].Value);
                form.PhoneTxt.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvPhone"].Value);
                form.RankCB.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvRank"].Value);
                DBengine.BlurBG(form);
                GetData();
            }
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;

                if (guna2MessageDialog1.Show("Silmek istediğinize emin misiniz?") == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvID"].Value);
                    string query = "Delete from staff where staffID = '" + id + "' ";
                    Hashtable ht = new Hashtable();
                    DBengine.SQL(query, ht);

                    guna2MessageDialog1.Show("Silme İşlemi Başarılı");
                    GetData();
                }
            }
        }
    }
}
