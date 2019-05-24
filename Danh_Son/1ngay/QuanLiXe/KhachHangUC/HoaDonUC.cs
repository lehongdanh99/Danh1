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

namespace QuanLiXe
{
    public partial class HoaDonUC : UserControl
    {
        public HoaDonUC()
        {
            InitializeComponent();
        }
        HoaDonClass hoadon = new HoaDonClass();
        private void HoaDonUC_Load(object sender, EventArgs e)
        {
            //loadLoaiXe();
        }
        public void loadHoaDon()
        {
            DataGridViewImageColumn picbienso = new DataGridViewImageColumn();
            DataGridViewImageColumn picsomay = new DataGridViewImageColumn();
            DataGridViewImageColumn picanhxe = new DataGridViewImageColumn();
            dgvHoaDon.RowTemplate.Height = 50;
            dgvHoaDon.DataSource = hoadon.getHoaDon();
            picbienso = (DataGridViewImageColumn)dgvHoaDon.Columns[1];
            picbienso.ImageLayout = DataGridViewImageCellLayout.Zoom;
            picsomay = (DataGridViewImageColumn)dgvHoaDon.Columns[2];
            picsomay.ImageLayout = DataGridViewImageCellLayout.Zoom;
            picanhxe = (DataGridViewImageColumn)dgvHoaDon.Columns[3];
            picanhxe.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvHoaDon.AllowUserToAddRows = false;
            int countRow = dgvHoaDon.RowCount;
            int countCol = dgvHoaDon.ColumnCount;
            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                if (row.Cells["tinhtrang"].Value.ToString() == "Chờ duyệt")
                {
                    row.Cells["tinhtrang"].Style.BackColor = Color.Khaki;
                }
                else
                {
                    row.Cells["tinhtrang"].Style.BackColor = Color.MediumSeaGreen;
                }
            }
            DataTable dt = hoadon.getTongTien();
            lbTongTien.Text = "Tổng tiền = " + dt.Rows[0][0].ToString() + " VND";
            //txttien.Hide();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = hoadon.getHoaDon();
            int index = dgvHoaDon.CurrentCell.RowIndex;
            txtCavet.Text = dgvHoaDon.Rows[index].Cells[0].Value.ToString();
            txtMauSac.Text = dgvHoaDon.Rows[index].Cells[4].Value.ToString();
            txtHangXe.Text = dgvHoaDon.Rows[index].Cells[5].Value.ToString();
            txtSoKm.Text = dgvHoaDon.Rows[index].Cells[6].Value.ToString();
            cbTheLoai.Text = dgvHoaDon.CurrentRow.Cells[7].Value.ToString().Trim();
            nummericThoiHan.Value = Convert.ToInt32(dgvHoaDon.Rows[index].Cells[11].Value.ToString());
            datetimepickerNgayBD.Text = dgvHoaDon.CurrentRow.Cells[9].Value.ToString();
            dateTimePickerNgayKT.Text = dgvHoaDon.CurrentRow.Cells[10].Value.ToString();
            txttien.Text = dgvHoaDon.CurrentRow.Cells[12].Value.ToString();
            byte[] picBS, picA, picSM;
            picBS = (byte[])dt.Rows[index]["BienSo"];
            MemoryStream bienso = new MemoryStream(picBS);
            picBienSo.Image = Image.FromStream(bienso);
            picSM = (byte[])dt.Rows[index]["SoMay"];
            MemoryStream somay = new MemoryStream(picSM);
            picSoMay.Image = Image.FromStream(somay);
            picA = (byte[])dt.Rows[index]["AnhXe"];
            MemoryStream anhxe = new MemoryStream(picA);
            picAnhXe.Image = Image.FromStream(anhxe);
            if (dgvHoaDon.Rows[index].Cells[13].Value.ToString() == "Chờ duyệt")
            {
                btnSua.Enabled = true;
                btXoa.Enabled = true;
            }
            else
            {
                btnSua.Enabled = false;
                btXoa.Enabled = false;
            }
        }
        DangKiThueXeClass dkthue = new DangKiThueXeClass();
        public void loadLoaiXe()
        {
            DangKiThueXeClass dkthue = new DangKiThueXeClass();
            cbTheLoai.DataSource = dkthue.getLoaixe();
            cbTheLoai.DisplayMember = "LoaiXe";
            cbTheLoai.ValueMember = "id";
            cbTheLoai.SelectedItem = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string cavet = txtCavet.Text;
            MemoryStream bienso = new MemoryStream();
            picBienSo.Image.Save(bienso, picBienSo.Image.RawFormat);
            MemoryStream somay = new MemoryStream();
            picSoMay.Image.Save(somay, picSoMay.Image.RawFormat);
            MemoryStream anhxe = new MemoryStream();
            picAnhXe.Image.Save(anhxe, picAnhXe.Image.RawFormat);
            string mausac = txtMauSac.Text;
            string hangxe = txtHangXe.Text;
            string sokm = txtSoKm.Text;
            string loaixe = cbTheLoai.Text;
            string makh = Global.username;
            DateTime ngaybd = datetimepickerNgayBD.Value;
            DateTime ngaykt = dateTimePickerNgayKT.Value;
            string thoihan = nummericThoiHan.Value.ToString();
            string tien = txttien.Text;
            hoadon.updateThongTinXe(cavet, bienso, somay, anhxe, mausac, hangxe, sokm, loaixe);
            hoadon.updateDichVuDK(cavet, ngaybd, ngaykt, thoihan, tien, "Chờ duyệt");
            this.dgvHoaDon.DataSource = hoadon.getHoaDon();
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

        private void nummericThoiHan_ValueChanged(object sender, EventArgs e)
        {
            loadNgayKetThuc();
            loadThanhToan();
        }

        void loadNgayKetThuc()
        {
            DateTime dateKT = datetimepickerNgayBD.Value.AddMonths(Convert.ToInt32(nummericThoiHan.Value));
            dateTimePickerNgayKT.Value = dateKT;
        }

        void loadThanhToan()
        {
            if (cbTheLoai.Text == "Xe 4 chỗ")
            {
                txttien.Text = Convert.ToString(1200000 * nummericThoiHan.Value);
            }
            else if (cbTheLoai.Text == "Xe 7 chỗ")
            {
                txttien.Text = Convert.ToString(1500000 * nummericThoiHan.Value);
            }
            else if (cbTheLoai.Text == "Xe du lịch")
            {
                txttien.Text = Convert.ToString(2100000 * nummericThoiHan.Value);
            }
            else txttien.Text = "";
        }

        private void cbTheLoai_TextChanged(object sender, EventArgs e)
        {
            loadThanhToan();
        }

        private void datetimepickerNgayBD_ValueChanged(object sender, EventArgs e)
        {
            loadNgayKetThuc();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index= dgvHoaDon.CurrentCell.RowIndex;
                string sID = dgvHoaDon.Rows[index].Cells[0].Value.ToString().Trim();
                hoadon.deleteDichVuDK(sID);
                hoadon.deleteThongTinXe(sID);
                this.dgvHoaDon.DataSource = hoadon.getHoaDon();
            }
        }
    }
}