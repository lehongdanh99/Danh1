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
    public partial class ThueXeUC : UserControl
    {
        public ThueXeUC()
        {
            InitializeComponent();
        }

        private void dgvThueXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        ThueXeClass thue = new ThueXeClass();
        public void loadThueXe()
        {
            DataGridViewImageColumn picbienso = new DataGridViewImageColumn();
            DataGridViewImageColumn picsomay = new DataGridViewImageColumn();
            DataGridViewImageColumn picanhxe = new DataGridViewImageColumn();
            dgvThueXe.RowTemplate.Height = 50;
            dgvThueXe.DataSource = thue.getThueXe();
            picbienso = (DataGridViewImageColumn)dgvThueXe.Columns[1];
            picbienso.ImageLayout = DataGridViewImageCellLayout.Zoom;
            picsomay = (DataGridViewImageColumn)dgvThueXe.Columns[2];
            picsomay.ImageLayout = DataGridViewImageCellLayout.Zoom;
            picanhxe = (DataGridViewImageColumn)dgvThueXe.Columns[3];
            picanhxe.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvThueXe.AllowUserToAddRows = false;
            int countRow = dgvThueXe.RowCount;
            int countCol = dgvThueXe.ColumnCount;
            foreach (DataGridViewRow row in dgvThueXe.Rows)
            {
                if (row.Cells["tinhtrang"].Value.ToString() == "Đã duyệt")
                {
                    thue.updateTinhTrangThueXe(row.Cells["cavet"].Value.ToString(), " ");
                }
            }
            dgvThueXe.DataSource = thue.getThueXe();
            foreach (DataGridViewRow row in dgvThueXe.Rows)
            {
                if (row.Cells["tinhtrang"].Value.ToString() == " " || row.Cells["tinhtrang"].Value.ToString() == "")
                {
                    row.Cells["tinhtrang"].Style.BackColor = Color.MediumSeaGreen;
                }
                else if (row.Cells["tinhtrang"].Value.ToString() == "Đã thuê")
                {
                    row.Cells["tinhtrang"].Style.BackColor = Color.Tomato;
                }
                else
                {
                    row.Cells["tinhtrang"].Style.BackColor = Color.Goldenrod;
                }
            }
            loadNgayKetThuc();
            //txttien.Hide();
        }

        private void ThueXeUC_Load(object sender, EventArgs e)
        {

        }

        private void dgvThueXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = thue.getThueXe();
            int index = dgvThueXe.CurrentCell.RowIndex;
            txtCavet.Text = dgvThueXe.Rows[index].Cells[0].Value.ToString();
            txtMauSac.Text = dgvThueXe.Rows[index].Cells[4].Value.ToString();
            txtHangXe.Text = dgvThueXe.Rows[index].Cells[5].Value.ToString();
            txtSoKm.Text = dgvThueXe.Rows[index].Cells[6].Value.ToString();
            cbTheLoai.Text = dgvThueXe.CurrentRow.Cells[7].Value.ToString().Trim();
            nummericThoiHan.Value = Convert.ToInt32(dgvThueXe.Rows[index].Cells[8].Value.ToString());
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
            if (dgvThueXe.Rows[index].Cells[9].Value.ToString() == "Đã thuê")
            {
                btThueXe.Enabled = false;
            }
            else
            {
                btThueXe.Enabled = true;
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

        private void numericThoiGianThue_ValueChanged(object sender, EventArgs e)
        {
            loadNgayKetThuc();
            loadThanhToan();
        }

        void loadNgayKetThuc()
        {
            DateTime dateKT = datetimepickerNgayBD.Value.AddDays(Convert.ToInt32(numericThoiGianThue.Value));
            dateTimePickerNgayKT.Value = dateKT;
        }

        void loadThanhToan()
        {
            if (cbTheLoai.Text == "Xe 4 chỗ")
            {
                txttien.Text = Convert.ToString(500000 * numericThoiGianThue.Value + 800000);
            }
            else if (cbTheLoai.Text == "Xe 7 chỗ")
            {
                txttien.Text = Convert.ToString(800000 * numericThoiGianThue.Value + 900000);
            }
            else if (cbTheLoai.Text == "Xe du lịch")
            {
                txttien.Text = Convert.ToString(1000000 * numericThoiGianThue.Value + 1000000);
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

        private void btThueXe_Click(object sender, EventArgs e)
        {
            string cavet = txtCavet.Text.Trim();
            DateTime ngaybd = datetimepickerNgayBD.Value;
            DateTime ngaykt = dateTimePickerNgayKT.Value;
            string thoihan = numericThoiGianThue.Value.ToString();
            string tien = txttien.Text;
            string tinhtrang = "Chờ duyệt";
            if (thue.insertThueXe(cavet, ngaybd, ngaykt, thoihan, tien, tinhtrang, Global.username))
            {
                MessageBox.Show("Đơn của bạn đang chờ duyệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Bạn thiếu thông tin kìa");
        }
    }
}