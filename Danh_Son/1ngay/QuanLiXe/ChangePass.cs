using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace QuanLiXe
{
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }
        DangKyLogin dk = new DangKyLogin();
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                DataTable dt = new DataTable();
                dt = dk.getPass(Global.username);
                string oldpass = "";
                oldpass = dt.Rows[0][0].ToString().Trim();
                string newpass = txtChangePass.Text;
                if (txtPass.Text == oldpass && txtChangePass.Text == txtCheckPass.Text)
                {
                    if (dk.updateLogin(Global.username, newpass))
                        MessageBox.Show("Mật khẩu đã thay đổi cho lần đăng nhập sau", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else {
                        MessageBox.Show("Vui Lòng Nhập Đúng Mật Khẩu", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    }
                else
                {
                    MessageBox.Show("Vui Lòng Nhập Đúng Mật Khẩu", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin! ");
                
            }

        }
        bool verif()
        {
            if (txtChangePass.Text.Trim() == ""
                || txtPass.Text.Trim() == ""
                || txtCheckPass.Text.Trim() == "")
                return false;
            return true;
                }


        private void ChangePass_Load(object sender, EventArgs e)
        {
           
        }
    }
}
