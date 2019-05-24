using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuanLiXe
{
    public partial class EditNhanVienUC : UserControl
    {
        public EditNhanVienUC()
        {
            InitializeComponent();
        }
        NhanVien nv = new NhanVien();
        DangKyLogin dk = new DangKyLogin();
        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            string ten = txtTen.Text;
            string ho = txtHo.Text;
            string address = txtAddress.Text;
            string cmnd = txtCmnd.Text;
            if (IsNumber(txtCmnd.Text) && (txtCmnd.Text).Length < 13)
            {

                cmnd = txtCmnd.Text;
            }
            else { MessageBox.Show("Vui lòng nhập đúng số CMND"); return; }
            DateTime birhtday = dtpBirthday.Value;
            MemoryStream pt = new MemoryStream();
            ptbAva.Image.Save(pt, ptbAva.Image.RawFormat);
            string manv = txtMaNV.Text;
            string gender = "male";
            if (radioFemale.Checked)
            {
                gender = "Female";
            }
            string type = "Van Phong";
            string type1 = "nv";
            if (radioGS.Checked)
            {
                type = "Giam Sat";
                type1 = "tho";
            }
          
            string sdt = txtSdt.Text;
            if (IsNumber(txtSdt.Text) && (txtSdt.Text).Length < 11)
            {
                sdt = txtSdt.Text;
            }
            if (verif())
            {
                if (nv.UpdateNhanVien(manv, ho, ten, gender, birhtday, sdt, address, cmnd, pt, type) && dk.updateType(manv,type1))
                    MessageBox.Show("Đã thay đổi thông tin nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thay đổi thông tin nhân viên không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        bool verif()
        {
            if ((txtAddress.Text.Trim() == "")
                || (txtCmnd.Text.Trim() == "")
                || (txtHo.Text.Trim() == "")
                || (txtTen.Text.Trim() == "")
                || (txtMaNV.Text.Trim() == "")
               || (txtSdt.Text.Trim() == "" || (ptbAva.Image == null)))
                return false;
            return true;
        }

        private void ptbAva_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                ptbAva.Image = Image.FromFile(open.FileName);
        }

        private void dtpBirthday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCmnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
    }
}