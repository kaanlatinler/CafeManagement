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
using System.IO;
using System.Data.SqlClient;

namespace CafeManagement.Model
{
    public partial class AddProduct : AddSample
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        public int id =0;
        public int cID = 0;

        private void AddProduct_Load(object sender, EventArgs e)
        {
            string query = "Select catID 'id', catName 'name' from category ";

            DBengine.CBfill(query, CategoryCB);

            if(cID > 0) 
            { 
                CategoryCB.SelectedValue = cID;
            }

            if(id> 0)
            {
                UpdateData();
            }
        }

        public override void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string filePath;
        byte[] imageArray;

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                ImageTxt.Image = new Bitmap(filePath);
            }
        }

        public override void SaveBtn_Click(object sender, EventArgs e)
        {
            string query = "";

            if (id == 0)
            {
                query = "insert into Products Values(@Name, @Price, @Category, @Img)";
            }
            else
            {
                query = "Update Products Set productName = @Name, productPrice = @Price, categoryID = @Category, productImg = @Img where productID = @id ";
            }

            Image temo = new Bitmap(ImageTxt.Image);
            MemoryStream ms = new MemoryStream();
            temo.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            imageArray = ms.ToArray();

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", NameTxt.Text);
            ht.Add("@Price", PriceTxt.Text);
            ht.Add("@Category", Convert.ToInt32(CategoryCB.SelectedValue));
            ht.Add("@Img", imageArray);

            if (DBengine.SQL(query, ht) > 0)
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Show("Kayıt İşlemi Başarılı");
                id = 0;
                cID= 0;
                NameTxt.Text = "";
                PriceTxt.Text = "";
                CategoryCB.SelectedIndex = 0;
                CategoryCB.SelectedIndex = -1;
                ImageTxt.Image = CafeManagement.Properties.Resources.add_product;
                NameTxt.Focus();
            }
        }

        private void UpdateData()
        {
            string query = @"Select * from products where productID = " + id + "";
            SqlCommand cmd = new SqlCommand(query, DBengine.conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                NameTxt.Text = dt.Rows[0]["productName"].ToString();
                PriceTxt.Text = dt.Rows[0]["productPrice"].ToString();

                Byte[] imageArray = (byte[])(dt.Rows[0]["productImg"]);
                ImageTxt.Image = Image.FromStream(new MemoryStream(imageArray));
            }
        }
    }
}
