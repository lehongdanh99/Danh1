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
    public partial class KhachHangChinhUC : UserControl
    {
        public KhachHangChinhUC()
        {
            InitializeComponent();
        }

        private void btnKThongTin_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = kh.getThongTinKH(Global.username);

            kThongTinKH2.txtFname.Text = dt.Rows[0]["fName"].ToString();
            kThongTinKH2.txtLname.Text = dt.Rows[0]["lName"].ToString();
            kThongTinKH2.txtPhone.Text = dt.Rows[0]["phone"].ToString();
            kThongTinKH2.txtAddress.Text = dt.Rows[0]["address"].ToString();
            kThongTinKH2.txtID.Text = dt.Rows[0]["cmnd"].ToString();
            if (dt.Rows[0]["gender"].ToString() == "Nam")
            {
                kThongTinKH2.radioButtonMale.Checked = true;
            }
            else kThongTinKH2.radioButtonFemale.Checked = true;

            byte[] pic;
            pic = (byte[])dt.Rows[0]["ava"];
            MemoryStream picture = new MemoryStream(pic);
            kThongTinKH2.picAva.Image = Image.FromStream(picture);
            kThongTinKH2.Visible = true;
        }
        private void btGioiThieuKH_Click(object sender, EventArgs e)
        {
            gioiThieuUC1.BringToFront();
        }
        Cus kh = new Cus();
        private void kThongTinKH1_Load(object sender, EventArgs e)
        {
            
        }
        bool verif()
        {
            if (kThongTinKH2.txtID.Text == null
                || kThongTinKH2.txtFname.Text == null
                || kThongTinKH2.txtPhone.Text == null)
                return false;
            return true;
        }

        private void KhachHangChinhUC_Load(object sender, EventArgs e)
        {
            kThongTinKH2.Visible = false;
        }
    }
}
