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
            string manv = txtMaNV.Text;
            string ho = txtHo.Text;
            string ten = txtTen.Text;
            string sdt = txtSdt.Text;
            string gender = "male";
            if (radioFemale.Checked)
            {
                gender = "female";
            }
            DateTime bdate = dateTimePicker1.Value;
            string address = txtAddress.Text;
            string cmnd = txtCmnd.Text;
            string type = "Giam Sat";
            if (radioTho.Checked)
            {
                type = "Tho";
            }
            else if (radioVP.Checked)
            {
                type = "Van phong";
            }
            NhanVien nv = new NhanVien();
            MemoryStream pic = new MemoryStream();
            ptbAva.Image.Save(pic, ptbAva.Image.RawFormat);
            if (verif())
            {
                nv.insertNhanVien(manv, ho, ten, gender, bdate, sdt, address, cmnd, pic, type);
                MessageBox.Show("Thêm nhân viên thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
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
    }
}