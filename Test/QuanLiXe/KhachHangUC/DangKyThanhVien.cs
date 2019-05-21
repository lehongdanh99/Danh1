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
        DangKyLogin dk = new DangKyLogin();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime bdate = dtpBdate.Value;
            string makh = txtUsername.Text;
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
        //Clear Form khi Đăng Kí Xong
        public void ClearForm()
        {
            txtUsername.Text = "";
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
            string makh = txtUsername.Text;
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
            if (!dk.usernameExist(makh))
            {
                try
                {
                    if (verif())
                    {
                        if (cus.insertCus(makh, fname, lname, gender, bdate, phone, address, cmnd, pic) && dk.insertLogin(makh, txtPassword.Text, "kh"))
                        {
                            MessageBox.Show("Đã thêm khách hàng!", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();
                        }
                    }
                    else { MessageBox.Show("Vui Lòng Nhập Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                catch (Exception E)
                {
                    MessageBox.Show("thêm hình ảnh");
                }
            }
            else { MessageBox.Show("Tài Khoản Này Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }


        }

        private void picAva_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                picAva.Image = Image.FromFile(open.FileName);
        }

        //Hàm kiểm tra thông tin có nhập đầy đủ không
        bool verif()
        {
            if (txtID.Text.Trim() == null ||
                txtUsername.Text.Trim() == null ||
                txtPassword.Text.Trim() == null ||
                txtFname.Text.Trim() == null ||
                txtPhone.Text.Trim() == null
                )
                return false;
            return true;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}