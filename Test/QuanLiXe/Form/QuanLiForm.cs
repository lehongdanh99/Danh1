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
using System.IO;

namespace QuanLiXe
{
    public partial class QuanLiForm : Form
    {
        public QuanLiForm()
        {
            InitializeComponent();
        }

        private void btGioiThieu_Click(object sender, EventArgs e)
        {
            panelClick.Height = btGioiThieu.Height;
            panelClick.Top = btGioiThieu.Top;
            gioiThieuUC.BringToFront();
        }
        LoginUC login = new LoginUC();
        KhachHang kh = new KhachHang();
        public void QuanLiForm_Load(object sender, EventArgs e)
        {
            loginUC1.BringToFront();
            panelUnknow.BringToFront();
            btnLogin.BringToFront();
            btnRegister.BringToFront();
            panelTho.Location = new Point(-3, 0);
            panelUnknow.Location = new Point(-3, 0);
            panelKhachHang.Location = new Point(-3, 0);
            panelNhanVien.Location = new Point(-3, 0);
            panelForm.Location = new Point(-3, 0);
            menuStrip.Visible = false;
            panelTho.Location = new Point(-3, 0);
            gioiThieuUC.BringToFront();
            gioiThieuUC.Location = new Point(350, 0);
            giaoDienQuanLiXeUC.Location = new Point(350, 0);
            quanLiTatCaXe.Location = new Point(350, 0);
            menuStrip.Location = new Point(350, 0);
            pictureBoxBack.Location = new Point(370, 12);
            pictureBoxBack.BackColor = quanLiTatCaXe.BackColor;
            TongDoanhThuUC.Location = new Point(350, 0);
            menuStripLogout.Visible = false;
        }
        //Hàm nút trong Panel Admin
        #region PANEL ADMIN
        private void btThongTinKhachHang_Click(object sender, EventArgs e)
        {
            panelClick.BringToFront();
            panelClick.Height = btThongTinKhachHang.Height;
            panelClick.Top = btThongTinKhachHang.Top;
        }

        private void btQuanLiXe_Click(object sender, EventArgs e)
        {
            panelClick.BringToFront();
            panelClick.Height = btQuanLiXe.Height;
            panelClick.Top = btQuanLiXe.Top;
            giaoDienQuanLiXeUC.BringToFront();
            menuStrip.Visible = true;
            menuStrip.BringToFront();
        }

        private void btQuanLiNhanVien_Click(object sender, EventArgs e)
        {
            panelClick.BringToFront();
            panelClick.Height = btQuanLiNhanVien.Height;
            panelClick.Top = btQuanLiNhanVien.Top;
            nhanVienUC1.BringToFront();
        }

        private void quanLiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quanLiTatCaXe.BringToFront();
            pictureBoxBack.BringToFront();
            this.quanLiTatCaXe.refreshData();
            this.quanLiTatCaXe.refreshDataLayXe();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            giaoDienQuanLiXeUC.BringToFront();
            menuStrip.BringToFront();
        }

        private void baiXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaiXeForm baiXe = new BaiXeForm();
            baiXe.ShowDialog();
        }

        private void btThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            panelClick.BringToFront();
            panelClick.Height = btThongKeDoanhThu.Height;
            panelClick.Top = btThongKeDoanhThu.Top;
            TongDoanhThuUC.BringToFront();
        }

        private void btHopDongKhachHang_Click(object sender, EventArgs e)
        {
            panelClick.BringToFront();
            panelClick.Height = btHopDongKhachHang.Height;
            panelClick.Top = btHopDongKhachHang.Top;
            hopDongGui.BringToFront();
        }

        private void btHopDongCongTy_Click(object sender, EventArgs e)
        {
            panelClick.BringToFront();
            panelClick.Height = btThongKeDoanhThu.Height;
            panelClick.Top = btHopDongCongTy.Top;
        }

        #endregion
        

        private void loginUC1_Load(object sender, EventArgs e)
        {
         
        }
        //HÀM LOGIN
        #region LOGIN

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Global.GetUsername(loginUC1.txtUsername.Text);
            DataTable dt = new DataTable();
            DataTable name = new DataTable();
            name = kh.getThongTinKH(Global.username);
            if (name.Rows.Count > 0)
            {
                menuName.Text = "Welcome( " + name.Rows[0]["fName"].ToString() + ")";
            }else { menuName.Text = "Quản Trị Viên"; }
            dt = LoginChecked(Global.username, loginUC1.txtPassword.Text, ChkBox());
            int count = dt.Rows.Count;
            if (count > 0)
            {
                MessageBox.Show("Đăng Nhập Thành Công!");
                LoginIdentify();
                gioiThieuUC.BringToFront();
                menuStripLogout.Visible = true;
                
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Hàm enable disable Panel khi đăng nhập
        void LoginIdentify()
        {
            if (ChkBox() == "ad")
            {
                panelForm.BringToFront();
                panelForm.Visible = true;
                panelTho.Visible = false;
                panelNhanVien.Visible = false;
                panelKhachHang.Visible = false;
            }
            else if (ChkBox() == "nv")
            {
                panelNhanVien.BringToFront();
                panelNhanVien.Visible = true;
                panelTho.Visible = false;
                panelKhachHang.Visible = false;
                panelForm.Visible = false;
            }
            else if (ChkBox() == "kh")
            {
                panelKhachHang.BringToFront();
                panelKhachHang.Visible = true;
                panelTho.Visible = false;
                panelForm.Visible = false;
                panelNhanVien.Visible = false;
            }
            else
            {
                panelTho.BringToFront();
                panelKhachHang.Visible = false;
                panelTho.Visible = true;
                panelForm.Visible = false;
                panelNhanVien.Visible = false;
            }
        }
        public DataTable LoginChecked(string username, string password, string type)
        {
            string tp = ChkBox();
            MY_DB db = new MY_DB();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from LOGIN where(username=@user and password =@pwd and type = @type)", db.getConnection);
            cmd.Parameters.Add("@user", SqlDbType.NChar).Value = Global.username;
            cmd.Parameters.Add("@pwd", SqlDbType.NChar).Value = loginUC1.txtPassword.Text;
            cmd.Parameters.Add("@type", SqlDbType.NChar).Value = tp.ToString();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        string type;
        public string ChkBox()
        {

            if (loginUC1.radioAdmin.Checked == true)
            {
                type = "ad";
            }
            else if (loginUC1.radioMember.Checked == true)
            {
                type = "kh";
            }
            else if (loginUC1.radioNhanVien.Checked == true)
            {
                type = "nv";
            }
            else type = "tho";
            return type;
        }
        #endregion
        // Panel của khách hàng
        #region Panel KhachHang
        private void btGioiThieuKH_Click(object sender, EventArgs e)
        {
            panelClickKH.Height = btGioiThieuKH.Height;
            panelClickKH.Top = btGioiThieuKH.Top;
            panelClickKH.BringToFront();
            gioiThieuUC.BringToFront();
            this.gioiThieuUC.pictureBoxOption.Enabled = false;
            this.gioiThieuUC.pictureBoxRefresh.Enabled = false;
        }

        private void btnKThongTin_Click(object sender, EventArgs e)
        {
            panelClickKH.Height = btnKThongTin.Height;
            panelClickKH.Top = btnKThongTin.Top;
            panelClickKH.BringToFront();
        }

        private void btnKDichVuThue_Click(object sender, EventArgs e)
        {
            panelClickKH.Height = btnKDichVuThue.Height;
            panelClickKH.Top = btnKDichVuThue.Top;
            panelClickKH.BringToFront();
        }

        private void btnKThueXe_Click(object sender, EventArgs e)
        {
            panelClickKH.Height = btnKThueXe.Height;
            panelClickKH.Top = btnKThueXe.Top;
            panelClickKH.BringToFront();
        }

        private void btnKHoaDon_Click(object sender, EventArgs e)
        {
            panelClickKH.Height = btnKHoaDon.Height;
            panelClickKH.Top = btnKHoaDon.Top;
            panelClickKH.BringToFront();
        }
        #endregion
        // Panel Nhân Viên
        #region Panel NhanVien
        private void btGioiThieuNV_Click(object sender, EventArgs e)
        {
            panelClickNV.Height = btGioiThieuNV.Height;
            panelClickNV.Top = btGioiThieuNV.Top;
            panelClickNV.BringToFront();
            gioiThieuUC.BringToFront();
            this.gioiThieuUC.pictureBoxOption.Enabled = false;
            this.gioiThieuUC.pictureBoxRefresh.Enabled = false;
        }

        private void btThongTinNV_Click(object sender, EventArgs e)
        {
            panelClickNV.Height = btThongTinNV.Height;
            panelClickNV.Top = btThongTinNV.Top;
            panelClickNV.BringToFront();
        }

        private void btHopDongThueXe_Click(object sender, EventArgs e)
        {
            panelClickNV.Height = btHopDongThueXe.Height;
            panelClickNV.Top = btHopDongThueXe.Top;
            panelClickNV.BringToFront();
        }

        private void btHopDongGuiXe_Click(object sender, EventArgs e)
        {
            panelClickNV.Height = btHopDongGuiXe.Height;
            panelClickNV.Top = btHopDongGuiXe.Top;
            panelClickNV.BringToFront();
        }

        private void btCaLamViec_Click(object sender, EventArgs e)
        {
            panelClickNV.Height = btCaLamViec.Height;
            panelClickNV.Top = btCaLamViec.Top;
            panelClickNV.BringToFront();
        }

        private void btThongKeNV_Click(object sender, EventArgs e)
        {
            panelClickNV.Height = btThongKeNV.Height;
            panelClickNV.Top = btThongKeNV.Top;
            panelClickNV.BringToFront();
        }
        #endregion
        // giao diện mới vào
        #region Mới vào sẽ xuất hiện
        private void btGioiThieuUnknow_Click(object sender, EventArgs e)
        {
            panelClickUnknow.Height = btGioiThieuUnknow.Height;
            panelClickUnknow.Top = btGioiThieuUnknow.Top;
            panelClickUnknow.BringToFront();
            gioiThieuUC.BringToFront();
            this.gioiThieuUC.pictureBoxOption.Enabled = false;
            this.gioiThieuUC.pictureBoxRefresh.Enabled = false;
        }

        private void btDangNhapUnknow_Click(object sender, EventArgs e)
        {
            panelClickUnknow.Height = btGioiThieuUnknow.Height;
            panelClickUnknow.Top = btGioiThieuUnknow.Top;
            panelClickUnknow.BringToFront();
            loginUC1.BringToFront();
            btnLogin.BringToFront();
            btnRegister.BringToFront();
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            panelUnknow.BringToFront();
            loginUC1.BringToFront();
            btnLogin.BringToFront();
            btnRegister.BringToFront();
            menuStripLogout.Visible = false;
        }
        #endregion

        AddCustomer dk = new AddCustomer();
        private void btnRegister_Click(object sender, EventArgs e)
        {
            dk.ShowDialog();
        }

        #region Panel Tho
        private void btGioiThieuTho_Click(object sender, EventArgs e)
        {
            this.panelClickTho.BringToFront();
            this.gioiThieuUC.pictureBoxOption.Enabled = false;
            this.gioiThieuUC.pictureBoxRefresh.Enabled = false;
            panelClickTho.Height = btGioiThieuTho.Height;
            panelClickTho.Top = btGioiThieuTho.Top;
            gioiThieuUC.BringToFront();
        }

        private void btThongTinTho_Click(object sender, EventArgs e)
        {
            panelClickTho.BringToFront();
            panelClickTho.Height = btThongTinTho.Height;
            panelClickTho.Top = btThongTinTho.Top;
            //btThongTinTho.BringToFront();
        }

        private void btQuanLiBaiXeTho_Click(object sender, EventArgs e)
        {
            panelClickTho.BringToFront();
            panelClickTho.Height = btQuanLiBaiXeTho.Height;
            panelClickTho.Top = btQuanLiBaiXeTho.Top;
            giaoDienQuanLiXeUC.BringToFront();
            menuStrip.Visible = true;
            menuStrip.BringToFront();
        }

        private void btThongKeDoanhThuTho_Click(object sender, EventArgs e)
        {
            panelClickTho.BringToFront();
            panelClickTho.Height = btThongKeDoanhThuTho.Height;
            panelClickTho.Top = btThongKeDoanhThuTho.Top;
            TongDoanhThuUC.BringToFront();
        }
        #endregion
    }
}