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
    public partial class NVThongTinNV : UserControl
    {
        public NVThongTinNV()
        {
            InitializeComponent();
        }
        NhanVien nv = new NhanVien();
        DangKyLogin dk = new DangKyLogin();
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            ChangePass cm = new ChangePass();
            cm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text;
            string ho = txtHo.Text;
            string address = txtAddress.Text;
            string cmnd = txtCmnd.Text;
            if (IsNumber(txtCmnd.Text) && (txtCmnd.Text).Length < 13)
            {
                cmnd = txtCmnd.Text;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng số CMND!");
                return;
            }
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
            if (IsNumber(txtSdt.Text) && (txtSdt.Text).Length < 10)
            {
                sdt = txtSdt.Text;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng số điện thoại!");
                return;
            }
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
        public void loadform()
        {
            DataTable dt = new DataTable();
            dt = nv.getNVprofile(Global.username);
            txtMaNV.Text = dt.Rows[0][0].ToString().Trim();
            txtHo.Text = dt.Rows[0][1].ToString().Trim();
            txtTen.Text = dt.Rows[0][2].ToString().Trim();
            txtSdt.Text = dt.Rows[0][5].ToString().Trim();
            txtAddress.Text= dt.Rows[0][6].ToString().Trim();
            txtCmnd.Text = dt.Rows[0][7].ToString().Trim();
            string gender = dt.Rows[0][3].ToString().Trim();
            if (gender == "female")
                radioFemale.Checked = true;
            else radioMale.Checked = true;
            byte[] pic;
            pic = (byte[])dt.Rows[0][8];
            MemoryStream picture = new MemoryStream(pic);
            ptbAva.Image = Image.FromStream(picture);
            if (dt.Rows[0][9].ToString().Trim() == "Giam Sat")
            {
               radioGS.Checked = true;
            }
            else if (dt.Rows[0][9].ToString().Trim() == "Van Phong")
            {
                radioVP.Checked = true;
            }
            else
            {
                radioTho.Checked = true;
            }

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
