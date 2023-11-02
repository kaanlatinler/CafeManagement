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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(DBengine.IsValid(UsernameTxt.Text, PasswordTxt.Text)==false)
            {
                guna2MessageDialog1.Show("Invalid Username Or Password");
                return;
            }
            else
            {
                this.Hide();
                MainForm form = new MainForm();
                form.Show();
            }
        }
    }
}
