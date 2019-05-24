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
            string gender = "Male";
            Global.getID(makh);
            if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }
            string address = txtAddress.Text;
            try
            {
                MemoryStream pic = new MemoryStream();
                picAva.Image.Save(pic, picAva.Image.RawFormat);
                if (cus.insertCus(makh, fname, lname, gender, bdate, phone, address, cmnd, pic))
                {
                    MessageBox.Show("Đã thêm khách hàng!", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    AddConTract ac = new AddConTract();
                    ac.ShowDialog();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("thêm hình ảnh");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picAva_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                picAva.Image = Image.FromFile(open.FileName);
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
        public void ClearForm()
        {
            txtCusID.Text = "";
            txtFname.Text = "";
            txtLname.Text = "";
            txtAddress.Text = "";
            txtID.Text = "";
            txtPhone.Text = "";
            picAva.ResetText();
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            DateTime bdate = dtpBdate.Value;
            string makh = txtCusID.Text;
            string fname = txtFname.Text;
            string lname = txtLname.Text;
            string phone = txtPhone.Text;
            string cmnd = txtID.Text;
            string gender = "Male";
            Global.getID(makh);
            if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }
            string address = txtAddress.Text;
            MemoryStream pic = new MemoryStream();
            picAva.Image.Save(pic, picAva.Image.RawFormat);
            try
            {
                if (cus.insertCus(makh, fname, lname, gender, bdate, phone, address, cmnd, pic))
                {
                    MessageBox.Show("Đã thêm khách hàng!", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    AddConTract ac = new AddConTract();
                    ac.ShowDialog();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("thêm hình ảnh");
            }
        }

        private void picAva_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                picAva.Image = Image.FromFile(open.FileName);
        }
    }
}