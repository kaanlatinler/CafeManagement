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
    public partial class Check : Form
    {
        public Check()
        {
            InitializeComponent();
        }

        public double amount;
        public int MainID = 0;

        private void paymentTxt_TextChanged(object sender, EventArgs e)
        {
            double amount = 0;
            double receipt = 0;
            double change = 0;

            double.TryParse(amountTxt.Text, out amount);
            double.TryParse(paymentTxt.Text, out receipt);

            change = Math.Abs(amount - receipt);
            changeTxt.Text = change.ToString();
        }

        public void SaveBtn_Click(object sender, EventArgs e)
        {
            string query = @" UPDATE TableMain set total = @total, received = @rec, change = @change,
                              status = 'Paid' where mainID = @id";

            Hashtable ht = new Hashtable();
            ht.Add("@id", MainID);
            ht.Add("@total", amountTxt.Text);
            ht.Add("@rec", paymentTxt.Text);
            ht.Add("@change", changeTxt.Text);

            if(DBengine.SQL(query, ht) > 0)
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Show("Kayıt İşlemi Başarılı");
                this.Close();
            }
        }

        private void Check_Load(object sender, EventArgs e)
        {
            amountTxt.Text=amount.ToString();
        }
    }
}
