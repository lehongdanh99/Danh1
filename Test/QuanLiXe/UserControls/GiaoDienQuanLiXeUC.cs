using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace QuanLiXe.UserControls
{
    public partial class GiaoDienQuanLiXeUC : UserControl
    {
        MY_DB mydb = new MY_DB();
        KhachHang kh = new KhachHang();
        LayXeClass layxe = new LayXeClass();
        public GiaoDienQuanLiXeUC()
        {
            InitializeComponent();
        }
        private void btOto_Click(object sender, EventArgs e)
        {
            pictureBoxVienOto.Visible = true;
            pictureBoxVienXeDap.Visible = false;
            pictureBoxVienXeMay.Visible = false;
            Oto.Checked = true;
            XeMay.Checked = false;
            XeDap.Checked = false;
            txtGioGui.Text = DateTime.Now.ToString("HH:mm:ss");
            if (txtOtoTrong.Text != "0")
            {
                MY_DB db = new MY_DB();
                KhachHang student = new KhachHang();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from BAIXE", db.getConnection);
                da.SelectCommand = cmd;
                da.Fill(dt);
                bool kt = false;
                int i = 0, j = 1;

                while (j < 4 && kt == false)
                {
                    while (i < dt.Rows.Count && kt == false)
                    {
                        if (dt.Rows[i][j].ToString() == "0")
                        {
                            switch (j)
                            {
                                case 1:
                                    btKhuVuc.Text = "A." + (i + 1);
                                    kt = true;
                                    break;
                                case 2:
                                    btKhuVuc.Text = "B." + (i + 1);
                                    kt = true;
                                    break;
                                case 3:
                                    btKhuVuc.Text = "C." + (i + 1);
                                    kt = true;
                                    break;

                            }
                        }
                        i++;
                    }
                    j++;
                }
            }
            else MessageBox.Show("Đã hết chỗ trống");
            //kh.updateBaiXe()
        }
        private void btXeMay_Click(object sender, EventArgs e)
        {
            pictureBoxVienOto.Visible = false;
            pictureBoxVienXeDap.Visible = false;
            pictureBoxVienXeMay.Visible = true;
            Oto.Checked = false;
            XeMay.Checked = true;
            XeDap.Checked = false;
            txtGioGui.Text = DateTime.Now.ToString("HH:mm:ss");
            if (btXeMayTrong.Text != "0")
            {
                MY_DB db = new MY_DB();
                KhachHang student = new KhachHang();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from BAIXE", db.getConnection);
                da.SelectCommand = cmd;
                da.Fill(dt);
                bool kt = false;
                int i = 0, j = 4;

                while (j < 8 && kt == false)
                {
                    while (i < dt.Rows.Count && kt == false)
                    {
                        if (dt.Rows[i][j].ToString() == "0")
                        {
                            switch (j)
                            {
                                case 4:
                                    btKhuVuc.Text = "D." + (i + 1);
                                    kt = true;
                                    break;
                                case 5:
                                    btKhuVuc.Text = "E." + (i + 1);
                                    kt = true;
                                    break;
                                case 6:
                                    btKhuVuc.Text = "F." + (i + 1);
                                    kt = true;
                                    break;
                                case 7:
                                    btKhuVuc.Text = "G." + (i + 1);
                                    kt = true;
                                    break;
                            }
                        }
                        i++;
                    }
                    j++;
                }
            }
            else MessageBox.Show("Đã hết chỗ trống");
        }
        private void btXeDap_Click(object sender, EventArgs e)
        {
            pictureBoxVienOto.Visible = false;
            pictureBoxVienXeDap.Visible = true;
            pictureBoxVienXeMay.Visible = false;
            Oto.Checked = false;
            XeMay.Checked = false;
            XeDap.Checked = true;
            txtGioGui.Text = DateTime.Now.ToString("HH:mm:ss");
            if (btXeDapTrong.Text != "0")
            {
                MY_DB db = new MY_DB();
                KhachHang student = new KhachHang();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from BAIXE", db.getConnection);
                da.SelectCommand = cmd;
                da.Fill(dt);
                bool kt = false;
                int i = 0, j = 8;

                while (j < 10 && kt == false)
                {
                    while (i < dt.Rows.Count && kt == false)
                    {
                        if (dt.Rows[i][j].ToString() == "0")
                        {
                            switch (j)
                            {
                                case 8:
                                    btKhuVuc.Text = "H." + (i + 1);
                                    kt = true;
                                    break;
                                case 9:
                                    btKhuVuc.Text = "K." + (i + 1);
                                    kt = true;
                                    break;
                            }
                        }
                        i++;
                    }
                    j++;
                }
            }
            else MessageBox.Show("Đã hết chỗ trống");
        }
        private void KTChoTrong()
        {
            MY_DB db = new MY_DB();
            KhachHang student = new KhachHang();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from BAIXE", db.getConnection);
            da.SelectCommand = cmd;
            da.Fill(dt);
            int countOto = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    if (dt.Rows[i][j].ToString() == "1")
                        countOto++;
                }
            }
            int countXeMay = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 4; j < 8; j++)
                {
                    if (dt.Rows[i][j].ToString() == "1")
                        countXeMay++;
                }
            }
            int countXeDap = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 8; j < 10; j++)
                {
                    if (dt.Rows[i][j].ToString() == "1")
                        countXeDap++;
                }
            }
            txtOtoTrong.Text = (60 - countOto).ToString();
            btXeDapTrong.Text = (60 - countXeDap).ToString();
            btXeMayTrong.Text = (60 - countXeMay).ToString();
        }
        //Nút lưu xe (Lưu vào database rồi đổ lên Form Quản Lí Tất Cả Xe)
        private void btMoiXeVao_Click(object sender, EventArgs e)
        {
            string vitri = btKhuVuc.Text.Replace(".", "").Trim();
            string loaixe;
            if (Oto.Checked == true) loaixe = btOto.Text;
            else if (XeMay.Checked == true) loaixe = btXeMay.Text;
            else loaixe = btXeDap.Text;

            string yeucau;
            if (radHour.Checked == true) yeucau = "Hour";
            else if (radDay.Checked == true) yeucau = "Day";
            else if (radWeek.Checked == true) yeucau = "Week";
            else yeucau = "Month";
            MemoryStream nguoigui = new MemoryStream();
            MemoryStream bienso = new MemoryStream();
            DateTime ngaygui = DTPNgayGui.Value;
            TimeSpan giogui = Convert.ToDateTime(txtGioGui.Text).TimeOfDay;
            pictureBoxBienSoXe.Image.Save(bienso, pictureBoxBienSoXe.Image.RawFormat);
            pictureBoxNguoiGui.Image.Save(nguoigui, pictureBoxNguoiGui.Image.RawFormat);
            if (kh.insertCus(vitri, loaixe, bienso, nguoigui, ngaygui, giogui, yeucau))
            {
                MessageBox.Show("Xe Đã Nhận Vào Bãi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (loaixe == "Ô tô") txtOtoTrong.Text = (Convert.ToInt32(txtOtoTrong.Text) - 1).ToString();
                else if (loaixe == "Xe máy") btXeMayTrong.Text = (Convert.ToInt32(btXeMayTrong.Text) - 1).ToString();
                else btXeDapTrong.Text = (Convert.ToInt32(btXeDapTrong.Text) - 1).ToString();
            }
            else MessageBox.Show("Error", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            string s = btKhuVuc.Text.ToString();
            string[] sp = s.Split('.');
            switch (sp[0])
            {
                case "A":
                    kh.updateBaiXe("1", sp[1]);
                    break;
                case "B":
                    kh.updateBaiXe2("1", sp[1]);
                    break;
                case "C":
                    kh.updateBaiXe3("1", sp[1]);
                    break;
                case "D":
                    kh.updateBaiXe4("1", sp[1]);
                    break;
                case "E":
                    kh.updateBaiXe5("1", sp[1]);
                    break;
                case "F":
                    kh.updateBaiXe6("1", sp[1]);
                    break;
                case "G":
                    kh.updateBaiXe7("1", sp[1]);
                    break;
                case "H":
                    kh.updateBaiXe8("1", sp[1]);
                    break;
                case "K":
                    kh.updateBaiXe9("1", sp[1]);
                    break;
            }
            pictureBoxBienSoXe.Image = pictureBoxBienSoXe.BackgroundImage;
            pictureBoxNguoiGui.Image = pictureBoxNguoiGui.BackgroundImage;
            btKhuVuc.Text = "";
            BaiXeForm baiXe = new BaiXeForm();
            baiXe.BaiXeForm_Load(sender, e);
            txtGioGui.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void pictureBoxNguoiGui_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                pictureBoxNguoiGui.Image = Image.FromFile(open.FileName);
        }
        private void pictureBoxBienSoXe_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                pictureBoxBienSoXe.Image = Image.FromFile(open.FileName);
        }
        private void GiaoDienQuanLiXeUC_Load(object sender, EventArgs e)
        {
            txtGioGui.Text = DateTime.Now.ToString("HH:mm:ss");
            panelThanhToan.Location = new Point(1215, 728);
            panelThanhToan.Visible = false;
            dtpNgayLay.Hide();
            txtGioLay.Hide();
            btMoiXeVao.Location = new Point(1249, 739);
            radHour.Checked = true;
            pictureBoxVienOto.Location = new Point(51, -10);
            pictureBoxVienOto.SendToBack();
            pictureBoxVienXeMay.Location = new Point(51, -10);
            pictureBoxVienXeMay.SendToBack();
            pictureBoxVienXeDap.Location = new Point(27, -10);
            pictureBoxVienXeDap.SendToBack();
            KTChoTrong();
        }
        private void btLayXe_Click(object sender, EventArgs e)
        {
            btMoiXeVao.Visible = false;
            panelThanhToan.Visible = true;
            char s = btKhuVuc.Text.Trim()[0];
            char sp = btKhuVuc.Text.Trim()[1];
            switch (s.ToString())
            {
                case "A":
                    kh.updateBaiXe("0", sp.ToString());
                    break;
                case "B":
                    kh.updateBaiXe2("0", sp.ToString());
                    break;
                case "C":
                    kh.updateBaiXe3("0", sp.ToString());
                    break;
                case "D":
                    kh.updateBaiXe4("0", sp.ToString());
                    break;
                case "E":
                    kh.updateBaiXe5("0", sp.ToString());
                    break;
                case "F":
                    kh.updateBaiXe6("0", sp.ToString());
                    break;
                case "G":
                    kh.updateBaiXe7("0", sp.ToString());
                    break;
                case "H":
                    kh.updateBaiXe8("0", sp.ToString());
                    break;
                case "K":
                    kh.updateBaiXe9("0", sp.ToString());
                    break;
            }
            kh.deleteCus(btKhuVuc.Text.Trim());
            BaiXeForm baiXe = new BaiXeForm();
            baiXe.BaiXeForm_Load(sender, e);
            MessageBox.Show("Mời xe ra");
            KTChoTrong();
            btMoiXeVao.Visible = true;
            panelThanhToan.Visible = false;
        }
        DateTime ngaylay;
        TimeSpan giolay;
        DateTime timeguithuc, timelaythuc;
        TimeSpan tongtime;
        private void btSearch_Click(object sender, EventArgs e)
        {
            btMoiXeVao.Visible = false;
            panelThanhToan.Visible = true;
            string vitri = txtSearch.Text.Trim().ToUpper();
            DataTable dt = layxe.SearchXe(vitri);
            if (dt.Rows.Count > 0)
            {
                #region Đã tìm thấy
                btKhuVuc.Text = dt.Rows[0][0].ToString();
                string xe = dt.Rows[0][1].ToString().Trim();
                if (xe == "Ô tô")
                {
                    pictureBoxVienXeDap.SendToBack();
                    pictureBoxVienXeMay.SendToBack();
                }
                else if (xe == "Xe máy")
                {
                    pictureBoxVienXeDap.SendToBack();
                    pictureBoxVienOto.SendToBack();
                }
                else
                {
                    pictureBoxVienOto.SendToBack();
                    pictureBoxVienXeMay.SendToBack();
                }
                byte[] pic = (byte[])dt.Rows[0][3];
                MemoryStream picture = new MemoryStream(pic);
                pictureBoxNguoiGui.Image = Image.FromStream(picture);
                byte[] picbienso = (byte[])dt.Rows[0][2];
                MemoryStream pictureBienso = new MemoryStream(picbienso);
                pictureBoxBienSoXe.Image = Image.FromStream(pictureBienso);
                DTPNgayGui.Text = dt.Rows[0][4].ToString().Trim();
                txtGioGui.Text = dt.Rows[0][5].ToString().Trim();
                string guitheo = dt.Rows[0][9].ToString().Trim();
                if (guitheo == "Hour") radHour.Checked = true;
                else if (guitheo == "Day") radDay.Checked = true;
                else if (guitheo == "Week") radWeek.Checked = true;
                else radMonth.Checked = true;

                ngaylay = dtpNgayLay.Value;
                giolay = Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss")).TimeOfDay;
                txtGioLay.Text = giolay.ToString();
                timeguithuc = Convert.ToDateTime(Convert.ToDateTime(DTPNgayGui.Text) + Convert.ToDateTime(txtGioGui.Text).TimeOfDay);
                timelaythuc = Convert.ToDateTime(Convert.ToDateTime(dtpNgayLay.Text) + Convert.ToDateTime(txtGioLay.Text).TimeOfDay);
                tongtime = timelaythuc.Subtract(timeguithuc);
                txtNgay.Text = tongtime.Days.ToString();
                txtGio.Text = tongtime.Hours.ToString();
                txtPhut.Text = tongtime.Minutes.ToString();
                int tongtien = layxe.phiGuiXe(btKhuVuc.Text.Trim(), xe, guitheo, Convert.ToInt32(txtNgay.Text), Convert.ToInt32(txtGio.Text), Convert.ToInt32(txtPhut.Text));
                string tong = tongtime.Days + " Ngày " + tongtime.Hours + " Giờ " + tongtime.Minutes + " Phút";
                layxe.insertXe(btKhuVuc.Text, xe, picture, pictureBienso, Convert.ToDateTime(DTPNgayGui.Text), Convert.ToDateTime(txtGioGui.Text).TimeOfDay,
                    ngaylay, Convert.ToDateTime(txtGioLay.Text).TimeOfDay, tong, guitheo, tongtien, 1);
                lbThanhTien.Text = "= " + tongtien + " VND";
                #endregion
            }
            else MessageBox.Show("Không tìm thấy");
            mydb.closeConnection();
        }

        private void btRefreshGuiXe_Click(object sender, EventArgs e)
        {
            panelThanhToan.Visible = false;
            btMoiXeVao.Visible = true;
            pictureBoxNguoiGui.Image = pictureBoxNguoiGui.BackgroundImage;
            pictureBoxBienSoXe.Image = pictureBoxBienSoXe.BackgroundImage;
            radHour.Checked = true;
            txtSearch.Text = "";
            btKhuVuc.Text = "";
            pictureBoxVienXeDap.SendToBack();
            pictureBoxVienXeMay.SendToBack();
            txtGioGui.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btRefreshLayXe_Click(object sender, EventArgs e)
        {
            panelThanhToan.Visible = true;
            btMoiXeVao.Visible = false;
            pictureBoxNguoiGui.Image = pictureBoxNguoiGui.BackgroundImage;
            pictureBoxBienSoXe.Image = pictureBoxBienSoXe.BackgroundImage;
            radHour.Checked = true;
            txtSearch.Text = "";
            btKhuVuc.Text = "";
            txtNgay.Text = "";
            txtGio.Text = "";
            txtPhut.Text = "";
            lbThanhTien.Text = "= (VND)";
            pictureBoxVienXeDap.SendToBack();
            pictureBoxVienXeMay.SendToBack();
            txtGioGui.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}