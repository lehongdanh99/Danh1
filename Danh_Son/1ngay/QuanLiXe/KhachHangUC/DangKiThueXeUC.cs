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
    public partial class DangKiThueXeUC : UserControl
    {
        public DangKiThueXeUC()
        {
            InitializeComponent();
        }

        private void DangKiThueXeUC_Load(object sender, EventArgs e)
        {
            loadLoaiXe();
            loadNgayKetThuc();
        }
        DangKiThueXeClass dkthue = new DangKiThueXeClass();
        void loadLoaiXe()
        {
            cbTheLoai.DataSource = dkthue.getLoaixe();
            cbTheLoai.DisplayMember = "LoaiXe";
            cbTheLoai.ValueMember = "id";
            cbTheLoai.SelectedItem = null;
        }

        void loadNgayKetThuc()
        {
            DateTime dateKT = datetimepickerNgayBD.Value.AddMonths(Convert.ToInt32(nummericThoiHan.Value));
            dateTimePickerNgayKT.Value = dateKT;
        }

        private void nummericThoiHan_ValueChanged(object sender, EventArgs e)
        {
            loadNgayKetThuc();
            loadThanhToan();
        }

        private void picBienSo_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                picBienSo.Image = Image.FromFile(open.FileName);
        }

        private void picSoMay_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                picSoMay.Image = Image.FromFile(open.FileName);
        }

        private void picAnhXe_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                picAnhXe.Image = Image.FromFile(open.FileName);
        }

        private void btnAddCon_Click(object sender, EventArgs e)
        {
            string cavet = txtCavet.Text;
            try
            {
                MemoryStream bienso = new MemoryStream();
                picBienSo.Image.Save(bienso, picBienSo.Image.RawFormat);
                MemoryStream somay = new MemoryStream();
                picSoMay.Image.Save(somay, picSoMay.Image.RawFormat);
                MemoryStream anhxe = new MemoryStream();
                picAnhXe.Image.Save(anhxe, picAnhXe.Image.RawFormat);
            
            string mausac = txtMauSac.Text;
            string hangxe = txtHangXe.Text;
            string sokm = txtSoKm.Text;
            string dichvu = "Cho thuê";
            string tinhtrang = "Chờ duyệt";
            string loaixe = cbTheLoai.Text;
            string makh = txtMaKH.Text;
            DateTime ngaybd = datetimepickerNgayBD.Value;
            DateTime ngaykt = dateTimePickerNgayKT.Value;
            string thoihan = nummericThoiHan.Value.ToString();
            string tien = txtThanhToan.Text;
            if (dkthue.insertThongTinXe(cavet, bienso, somay, anhxe, mausac, hangxe, sokm, dichvu, loaixe, makh) && dkthue.insertDichVuDK(cavet, ngaybd, ngaykt, thoihan, tien, tinhtrang) &&verif())
            {
                MessageBox.Show("Đăng kí thành công\nMời bạn in hóa đơn đến showroom làm hợp đồng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Điền hết thông tin đi kìa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception E)
            {
                MessageBox.Show("Vui Lòng Thêm đầy đủ hình ảnh!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void cbTheLoai_ValueMemberChanged(object sender, EventArgs e)
        {
            //loadThanhToan();
        }
        void loadThanhToan()
        {
            if (cbTheLoai.Text == "Xe 4 chỗ")
            {
                txtThanhToan.Text = Convert.ToString(1200000 * nummericThoiHan.Value);
            }
            else if (cbTheLoai.Text == "Xe 7 chỗ")
            {
                txtThanhToan.Text = Convert.ToString(1500000 * nummericThoiHan.Value);
            }
            else if (cbTheLoai.Text == "Xe du lịch")
            {
                txtThanhToan.Text = Convert.ToString(2100000 * nummericThoiHan.Value);
            }
            else txtThanhToan.Text = "";
        }

        private void cbTheLoai_TextChanged(object sender, EventArgs e)
        {
            loadThanhToan();
        }

        private void datetimepickerNgayBD_ValueChanged(object sender, EventArgs e)
        {
            loadNgayKetThuc();
        }

        //Hàm ktra thông tin đầy đủ
        bool verif()
        {
            if (txtCavet.Text.Trim() == "" ||
                txtHangXe.Text.Trim() == "" ||
                txtMauSac.Text.Trim() == "" ||
                txtSoKm.Text.Trim() == "" 
                )
                return false;
            return true;
        }
    }
}