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
    public partial class KHThongTinKhachHang : UserControl
    {
        public KHThongTinKhachHang()
        {
            InitializeComponent();
        }
        Cus kh = new Cus();
        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            string fname = txtFname.Text;
            string lname = txtLname.Text;
            string phone="";
            string cmnd="";
            if (IsNumber(txtPhone.Text) && (txtPhone.Text).Length < 10)
            {
                phone = txtPhone.Text;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng số điện thoại!");
                return;
            }
            string address = txtAddress.Text;
            DateTime birthday = dtpBdate.Value;
            MemoryStream pic = new MemoryStream();
            picAva.Image.Save(pic, picAva.Image.RawFormat);
            if (IsNumber(txtID.Text) && (txtID.Text).Length <13)
            {
                cmnd = txtID.Text;
            } else
            {
                MessageBox.Show("Vui lòng nhập đúng số CMND!");
                return;
            }
            string gender = "Nam";
            if (radioButtonFemale.Checked == true)
            {
                gender = "Nữ";
            }
           
                if (kh.UpdateThongTinKhach(Global.username, fname, lname, gender, birthday, phone, address, cmnd, pic) && verif())
                { MessageBox.Show("Đã Sửa Thông Tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                else MessageBox.Show("Nhập Đầy Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    catch (Exception Ex)
        //    {
        //        MessageBox.Show("Vui Lòng Thêm Hình Ảnh");
        //    }
        }

        //Hàm kiểm tra thông tin đầy đủ
        bool verif()
        {
            if (txtID.Text.Trim() == ""
                || txtFname.Text.Trim() == ""
                || txtLname.Text.Trim() == ""
                || txtPhone.Text.Trim() == "")
                return false;
            return true;
        }
        //Hàm kiểm tra số
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void picAva_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                picAva.Image = Image.FromFile(open.FileName);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            ChangePass ps = new ChangePass();
            ps.ShowDialog();
        }
    }
}
