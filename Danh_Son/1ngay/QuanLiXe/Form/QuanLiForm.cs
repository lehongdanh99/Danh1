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
            gioiThieuUC.Visible = true;
            panelClick.Height = btGioiThieu.Height;
            panelClick.Top = btGioiThieu.Top;
            gioiThieuUC.BringToFront();
        }
        LoginUC login = new LoginUC();
        DangKyLogin get = new DangKyLogin();
        public void QuanLiForm_Load(object sender, EventArgs e)
        {
            nvThongTinNV1.Location = new Point(350, 0);
            loginUC1.BringToFront();
            panelUnknow.BringToFront();
            btnLogin.BringToFront();
            btnRegister.BringToFront();
            hoaDonUC1.Location = new Point(350, 0);
            panelTho.Location = new Point(-3, 0);
            panelUnknow.Location = new Point(-3, 0);
            panelUnknow.Size = new Size(355, 753);
            panelKhachHang.Location = new Point(-3, 0);
            panelKhachHang.Size = new Size(355, 753);
            panelNhanVien.Location = new Point(-3, 0);
            panelNhanVien.Size = new Size(355, 753);
            panelForm.Location = new Point(-3, 0);
            panelForm.Size = new Size(355, 753);
            menuStrip.Visible = false;
            panelTho.Location = new Point(-3, 0);
            panelTho.Size = new Size(355, 753);
            gioiThieuUC.BringToFront();
            gioiThieuUC.Location = new Point(350, 0);
            giaoDienQuanLiXeUC.Location = new Point(350, 0);
            quanLiTatCaXe.Location = new Point(350, 0);
            menuStrip.Location = new Point(350, 0);
            pictureBoxBack.Location = new Point(370, 12);
            pictureBoxBack.BackColor = quanLiTatCaXe.BackColor;
            TongDoanhThuUC.Location = new Point(350, 0);
            dangKiThueXeUC1.Location = new Point(350, 0);
            thueXeUC1.Location = new Point(350, 0);
            hoaDonThueXeUC1.Location = new Point(350, 0);
            khThongTinKhachHang1.Location = new Point(350, 0);
        }
        //Hàm nút trong Panel Admin
        #region PANEL ADMIN
        private void btThongTinKhachHang_Click(object sender, EventArgs e)
        {
            panelClick.BringToFront();
            panelClick.Height = btThongTinKhachHang.Height;
            panelClick.Top = btThongTinKhachHang.Top;
            gioiThieuUC.Visible = false;
        }

        private void btQuanLiXe_Click(object sender, EventArgs e)
        {
            panelClick.BringToFront();
            panelClick.Height = btQuanLiXe.Height;
            panelClick.Top = btQuanLiXe.Top;
            giaoDienQuanLiXeUC.BringToFront();
            menuStrip.Visible = true;
            menuStrip.BringToFront();
            gioiThieuUC.Visible = false;
        }

        private void btQuanLiNhanVien_Click(object sender, EventArgs e)
        {
            panelClick.BringToFront();
            panelClick.Height = btQuanLiNhanVien.Height;
            panelClick.Top = btQuanLiNhanVien.Top;
            nhanVienUC1.BringToFront();
            gioiThieuUC.Visible = false;
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
            gioiThieuUC.Visible = false;
        }

        private void btHopDongKhachHang_Click(object sender, EventArgs e)
        {
            panelClick.BringToFront();
            panelClick.Height = btHopDongKhachHang.Height;
            panelClick.Top = btHopDongKhachHang.Top;
            hopDongGui.BringToFront();
            gioiThieuUC.Visible = false;
        }

        private void btHopDongCongTy_Click(object sender, EventArgs e)
        {
            panelClick.BringToFront();
            panelClick.Height = btThongKeDoanhThu.Height;
            panelClick.Top = btHopDongCongTy.Top;
            gioiThieuUC.Visible = false;
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
            dt = LoginChecked(Global.username, loginUC1.txtPassword.Text, ChkBox());
            int count = dt.Rows.Count;
            if (count > 0)
            {
                LoginIdentify();
                gioiThieuUC.BringToFront();
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
                menuName.Text = "Quản trị viên";
            }
            else if (ChkBox() == "nv")
            {
                panelNhanVien.BringToFront();
                panelNhanVien.Visible = true;
                panelTho.Visible = false;
                panelKhachHang.Visible = false;
                panelForm.Visible = false;
                DataTable dt = new DataTable();
                dt = get.getNameNV(Global.username);
                string fname = dt.Rows[0][0].ToString().Trim();
                string lname = dt.Rows[0][1].ToString().Trim();
                menuName.Text = "Welcome (" + fname+" " +lname + ")";
                
            }
            else if (ChkBox() == "kh")
            {
                panelKhachHang.BringToFront();
                panelKhachHang.Visible = true;
                panelTho.Visible = false;
                panelForm.Visible = false;
                panelNhanVien.Visible = false;
                DataTable dt = new DataTable();
                dt = get.getNameKhach(Global.username);
                string fname = dt.Rows[0][0].ToString().Trim();
                string lname = dt.Rows[0][1].ToString().Trim();
                menuName.Text = "Welcome (" + fname + " " + lname + ")";
            }
            else
            {
                panelTho.BringToFront();
                panelKhachHang.Visible = false;
                panelTho.Visible = true;
                panelForm.Visible = false;
                panelNhanVien.Visible = false;
                DataTable dt = new DataTable();
                dt = get.getNameNV(Global.username);
                string fname = dt.Rows[0][0].ToString().Trim();
                string lname = dt.Rows[0][1].ToString().Trim();
                menuName.Text = "Welcome (" + fname + " " + lname + ")";
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
            else if (loginUC1.radioNhanVien.Checked)
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
            gioiThieuUC.Visible = true;
            panelClickKH.Height = btGioiThieuKH.Height;
            panelClickKH.Top = btGioiThieuKH.Top;
            panelClickKH.BringToFront();
            gioiThieuUC.BringToFront();
            this.gioiThieuUC.pictureBoxOption.Enabled = false;
            this.gioiThieuUC.pictureBoxRefresh.Enabled = false;
        }
        Cus kh = new Cus();
        private void btnKThongTin_Click(object sender, EventArgs e)
        {
            panelClickKH.Height = btnKThongTin.Height;
            panelClickKH.Top = btnKThongTin.Top;
            panelClickKH.BringToFront();
            khThongTinKhachHang1.BringToFront();
            DataTable dt = new DataTable();
            dt = kh.getThongTinKH(Global.username);
            #region Load Thông Tin khách hàng
            khThongTinKhachHang1.txtFname.Text = dt.Rows[0]["fName"].ToString();
            khThongTinKhachHang1.txtLname.Text = dt.Rows[0]["lName"].ToString();
            khThongTinKhachHang1.txtPhone.Text = dt.Rows[0]["phone"].ToString();
            khThongTinKhachHang1.txtAddress.Text = dt.Rows[0]["address"].ToString();
            khThongTinKhachHang1.txtID.Text = dt.Rows[0]["cmnd"].ToString();
            khThongTinKhachHang1.dtpBdate.Text = dt.Rows[0]["birthday"].ToString();
            if (dt.Rows[0]["gender"].ToString() == "Nam")
            {
                khThongTinKhachHang1.radioButtonMale.Checked = true;
            }
            else khThongTinKhachHang1.radioButtonFemale.Checked = true;

            byte[] pic;
            pic = (byte[])dt.Rows[0]["ava"];
            MemoryStream picture = new MemoryStream(pic);
            khThongTinKhachHang1.picAva.Image = Image.FromStream(picture);
            khThongTinKhachHang1.Visible = true;
            #endregion
        }

        private void btnKDichVuThue_Click(object sender, EventArgs e)
        {
            panelClickKH.Height = btnKDichVuThue.Height;
            panelClickKH.Top = btnKDichVuThue.Top;
            panelClickKH.BringToFront();
            dangKiThueXeUC1.BringToFront();
            dangKiThueXeUC1.txtMaKH.Text = Global.username;
        }

        private void btnKThueXe_Click(object sender, EventArgs e)
        {
            panelClickKH.Height = btnKThueXe.Height;
            panelClickKH.Top = btnKThueXe.Top;
            panelClickKH.BringToFront();
            thueXeUC1.BringToFront();
            thueXeUC1.loadThueXe();
            thueXeUC1.loadLoaiXe();
            //this.thueXeUC1.cbTheLoai.Text = thueXeUC1.dgvThueXe.CurrentRow.Cells[7].Value.ToString().Trim();
        }

        private void btnKHoaDon_Click(object sender, EventArgs e)
        {
            DangKiThueXeClass dkthue = new DangKiThueXeClass();
            panelClickKH.Height = btnKHoaDon.Height;
            panelClickKH.Top = btnKHoaDon.Top;
            panelClickKH.BringToFront();
            hoaDonUC1.BringToFront();
            hoaDonUC1.loadLoaiXe();
            hoaDonUC1.loadHoaDon();
            this.hoaDonUC1.cbTheLoai.Text = hoaDonUC1.dgvHoaDon.CurrentRow.Cells[7].Value.ToString().Trim();
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
            nvThongTinNV1.BringToFront();
            nvThongTinNV1.loadform();
            
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
            panelClickUnknow.Height = btDangNhapUnknow.Height;
            panelClickUnknow.Top = btDangNhapUnknow.Top;
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
            nvThongTinNV1.BringToFront();
            nvThongTinNV1.loadform();
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

        private void btHoaDonThueXe_Click(object sender, EventArgs e)
        {
            panelClickKH.Height = btHoaDonThueXe.Height;
            panelClickKH.Top = btHoaDonThueXe.Top;
            panelClickKH.BringToFront();
            hoaDonThueXeUC1.BringToFront();
            hoaDonThueXeUC1.loadHoaDonThueXe();
            //hoaDonThueXeUC1.dateTimePickerNgayKT.Text = hoaDonThueXeUC1.dgvHoaDon.CurrentRow.Cells[9].Value.ToString();
        }
    }
}