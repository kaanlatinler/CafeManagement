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
    public partial class BillList : Form
    {
        public BillList()
        {
            InitializeComponent();
        }

        public int MainID = 0;

        private void BillList_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {
            string query = @"Select mainID, tableName, waiterName, orderType, status, total from TableMain
                             where status <> 'Pending' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvID);
            lb.Items.Add(dgvTable);
            lb.Items.Add(dgvWaiter);
            lb.Items.Add(dgvType);
            lb.Items.Add(dgvStatus);
            lb.Items.Add(dgvTotal);

            DBengine.LoadData(query, guna2DataGridView1, lb);
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

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                
                MainID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvID"].Value);
                this.Close();
            }
        }
    }
}
