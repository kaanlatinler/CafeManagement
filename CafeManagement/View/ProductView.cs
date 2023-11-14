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
    public partial class ProductView : SampleView
    {
        public ProductView()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            string query = "Select productID, productName, productPrice, categoryID, c.catName from Products p inner join category c on c.catID = p.categoryID where productName like '%" + SearchTxt.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvID);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvPrice);
            lb.Items.Add(dgvCategoryID);
            lb.Items.Add(dgvCategory);

            DBengine.LoadData(query, guna2DataGridView1, lb);
        }

        public override void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        public override void AddBtn_Click(object sender, EventArgs e)
        {
            DBengine.BlurBG(new AddProduct());

            GetData();
        }

        private void ProductView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                AddProduct form = new AddProduct();
                form.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvID"].Value);
                form.NameTxt.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvName"].Value);
                form.PriceTxt.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvPrice"].Value);
                form.CategoryCB.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvCategory"].Value);
                DBengine.BlurBG(form);
                GetData();
            }
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;

                if (guna2MessageDialog1.Show("Are You Sure You Want To Delete?") == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvID"].Value);
                    string query = "Delete from Products where productID = '" + id + "' ";
                    Hashtable ht = new Hashtable();
                    DBengine.SQL(query, ht);

                    MessageBox.Show("Deleted Successfully");
                    GetData();
                }
            }
        }
    }
}
