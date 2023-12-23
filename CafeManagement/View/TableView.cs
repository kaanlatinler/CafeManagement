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
    public partial class TableView : SampleView
    {
        public TableView()
        {
            InitializeComponent();
        }

        private void TableView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            string query = "Select * from tables where tableName like '%" + SearchTxt.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvID);
            lb.Items.Add(dgvName);

            DBengine.LoadData(query, guna2DataGridView1, lb);
        }

        public override void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        public override void AddBtn_Click(object sender, EventArgs e)
        {
            DBengine.BlurBG(new AddTable());
            GetData();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                AddTable form = new AddTable();
                form.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvID"].Value);
                form.NameTxt.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvName"].Value);
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
                    string query = "Delete from tables where tableID = '" + id + "' ";
                    Hashtable ht = new Hashtable();
                    DBengine.SQL(query, ht);

                    guna2MessageDialog1.Show("Silme İşlemi Başarılı");
                    GetData();
                }
            }
        }
    }
}
