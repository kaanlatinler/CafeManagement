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
            if(DBengine.IsAdmin(UsernameTxt.Text, PasswordTxt.Text))
            {
                this.Hide();
                MainForm form = new MainForm();
                form.Show();
            }
            else
            {
                if (DBengine.IsValid(UsernameTxt.Text, PasswordTxt.Text))
                {
                    this.Hide();
                    MainFormStaff form = new MainFormStaff();
                    form.Show();
                }
                else
                {
                    guna2MessageDialog1.Show("Kullanıcı Adı Veya Şifre Hatalı");
                    return;
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            UsernameTxt.Text = "admin";
            PasswordTxt.Text = "kaanhdd374";
        }
    }
}
