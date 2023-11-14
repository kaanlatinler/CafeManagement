using System;
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
    public partial class ProductControl : UserControl
    {
        public event EventHandler onSelect = null;

        public ProductControl()
        {
            InitializeComponent();
        }

        public int id { get; set; }

        public string pPrice { get; set; }

        public string pCategory { get; set; }

        public string pName
        {
            get { return NameLbl.Text;  }
            set { NameLbl.Text = value; }
        }

        public Image pImage
        {
            get { return ImageTxt.Image; }
            set { ImageTxt.Image = value; }
        }

        private void ImageTxt_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
    }
}
