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
    public partial class AddNhanVienUC : UserControl
    {
        public AddNhanVienUC()
        {
            InitializeComponent();
        }

        private void ptbAva_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                ptbAva.Image = Image.FromFile(open.FileName);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DangKyLogin dk = new DangKyLogin();
                string manv = txtMaNV.Text;
                string ho = txtHo.Text;
                string ten = txtTen.Text;
                string sdt = "";
                if(IsNumber(txtSdt.Text) && (txtSdt.Text).Length <11)
                {
                    sdt = txtSdt.Text;
                }
                else {
                    MessageBox.Show("Vui lòng nhập đúng số điện thoại");
                    return; }
                string gender = "male";
                if (radioFemale.Checked)
                {
                    gender = "female";
                }
                DateTime bdate = dateTimePicker1.Value;
                string address = txtAddress.Text;
                string cmnd = "";
                if (IsNumber(txtCmnd.Text) && (txtCmnd.Text).Length < 13)
                {
                    
                    cmnd = txtCmnd.Text;
                }else { MessageBox.Show("Vui lòng nhập đúng số CMND"); return; }
                string type = "Giam Sat";
                string type1 = "Tho";
                if (radioVP.Checked)
                {
                    type = "Van phong";
                    type1 = "nv";
                }

                NhanVien nv = new NhanVien();
                MemoryStream pic = new MemoryStream();
                ptbAva.Image.Save(pic, ptbAva.Image.RawFormat);
                if (verif())
                {
                    nv.insertNhanVien(manv, ho, ten, gender, bdate, sdt, address, cmnd, pic, type);
                    dk.insertLogin(manv, manv, type1);
                    nv.insertLichNV(manv);
                    MessageBox.Show("Thêm nhân viên thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Chưa nhập đủ thông tin nhân viên", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã số nhân viên đã tồn tại", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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