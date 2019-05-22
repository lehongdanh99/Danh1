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
    public partial class KThongTinKH : UserControl
    {
        public KThongTinKH()
        {
            InitializeComponent();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }
        Cus kh = new Cus();
        private void KThongTinKH_Load(object sender, EventArgs e)
        {
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string fname = txtFname.Text;
            string lname = txtLname.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            DateTime birthday = dtpBdate.Value;
            MemoryStream pic = new MemoryStream();
            picAva.Image.Save(pic, picAva.Image.RawFormat);
            string cmnd = txtID.Text;
            string gender = "Nam";
            if (radioButtonFemale.Checked == true)
            {
                gender = "Nữ";
            }
            try
            {
                if (kh.UpdateThongTinKhach(Global.username, fname, lname, gender, birthday, phone, address, cmnd, pic) && verif())
                { MessageBox.Show("Đã Sửa Thông Tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                else MessageBox.Show("Nhập Đầy Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception Ex)
            {
                MessageBox.Show("Vui Lòng Thêm Hình Ảnh");
            }

        }
        bool verif()
        {
            if (txtID.Text == null
                || txtFname.Text == null
                || txtPhone.Text == null)
                return false;
                    return true;
        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void picAva_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          


        }
    }
}
