using CafeManagement.Database;
using CafeManagement.Model;
using CafeManagement.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class MainFormStaff : Form
    {
        public MainFormStaff()
        {
            InitializeComponent();
        }

        static MainFormStaff Obj;

        public static MainFormStaff Instance
        {
            get { if (Obj == null) { Obj = new MainFormStaff(); } return Obj; }
        }

        public  void AddControls(Form f)
        {
            CenterPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            CenterPanel.Controls.Add(f);
            f.Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RankTxtLbl.Text = DBengine.Rank;
            UsernameTxtLbl.Text = DBengine.User;
            staffIDLblTxt.Text = DBengine.ID;
            HomeBtn.Checked = true;
            AddControls(new HomeForm());
            Obj = this;
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            AddControls(new HomeForm());
        }

        private void CategoryBtn_Click(object sender, EventArgs e)
        {
            AddControls(new CategoryView());
        }

        private void TableBtn_Click(object sender, EventArgs e)
        {
            AddControls(new TableView());
        }

        private void StaffBtn_Click(object sender, EventArgs e)
        {
            AddControls(new StaffView());
        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            AddControls(new ProductView());
        }

        private void POSBtn_Click(object sender, EventArgs e)
        {
            POSform form = new POSform();
            form.Show();
        }

        private void KitchenBtn_Click(object sender, EventArgs e)
        {
            AddControls(new KitchenView());
        }
    }
}
