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
    public partial class AddSample : Form
    {
        public AddSample()
        {
            InitializeComponent();
        }

        public virtual void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void SaveBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
