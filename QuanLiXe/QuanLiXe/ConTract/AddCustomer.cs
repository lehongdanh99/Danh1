using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuanLiXe
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }
        Cus cus = new Cus();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime bdate = dtpBdate.Value;
            string makh = txtCusID.Text;
            string fname = txtFname.Text;
            string lname = txtLname.Text;
            string phone = txtPhone.Text;
            string cmnd = txtID.Text;
            string address = txtAddress.Text;
            MemoryStream pic = new MemoryStream();
            picAva.Image.Save(pic, picAva.Image.RawFormat);
            if(cus.insertCus(makh, fname, lname, bdate, phone, address, cmnd, pic))
            {
                MessageBox.Show("Oke!");
            }

        }

        private void picAva_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                picAva.Image = Image.FromFile(open.FileName);
        }
    }
}
