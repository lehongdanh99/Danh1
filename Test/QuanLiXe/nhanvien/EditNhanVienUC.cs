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
        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            string ten = txtTen.Text;
            string ho = txtHo.Text;
            string address = txtAddress.Text;
            string cmnd = txtCmnd.Text;
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
            if (radioGS.Checked)
            {
                type = "Giam Sat";
            }
            else if (radioTho.Checked)
            {
                type = "Tho";

            }
            string sdt = txtSdt.Text;
            if (verif())
            {
                if (nv.UpdateNhanVien(manv, ho, ten, gender, birhtday, sdt, address, cmnd, pt, type))
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
    }
}