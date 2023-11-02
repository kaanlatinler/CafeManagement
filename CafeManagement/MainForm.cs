using CafeManagement.Database;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
            HomeBtn.Checked = true;
            AddControls(new HomeForm());
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            AddControls(new HomeForm());
        }
    }
}
