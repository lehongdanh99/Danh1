using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiXe
{
    public partial class HoaDonThueXeUC : UserControl
    {
        public HoaDonThueXeUC()
        {
            InitializeComponent();
        }
        ThueXeClass thue = new ThueXeClass();
        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvHoaDon.CurrentCell.RowIndex;
            numericThoiGianThue.Value = Convert.ToInt32(dgvHoaDon.Rows[index].Cells[10].Value.ToString());
            datetimepickerNgayBD.Text = dgvHoaDon.CurrentRow.Cells[8].Value.ToString();
            dateTimePickerNgayKT.Text = dgvHoaDon.CurrentRow.Cells[9].Value.ToString();
            txttien.Text = dgvHoaDon.CurrentRow.Cells[11].Value.ToString();
            txtCavet.Text= dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
            if (dgvHoaDon.Rows[index].Cells[12].Value.ToString() == "Chờ duyệt")
            {
                btXoa.Enabled = true;
                btLuu.Enabled = true;
            }
            else
            {
                btXoa.Enabled = false;
                btLuu.Enabled = false;
            }
        }

        private void HoaDonThueXeUC_Load(object sender, EventArgs e)
        {

        }
        public void loadHoaDonThueXe()
        {
            DataGridViewImageColumn picbienso = new DataGridViewImageColumn();
            DataGridViewImageColumn picsomay = new DataGridViewImageColumn();
            DataGridViewImageColumn picanhxe = new DataGridViewImageColumn();
            dgvHoaDon.RowTemplate.Height = 50;
            dgvHoaDon.DataSource = thue.getHoaDonThueXe();
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
            DataTable dt = thue.getTongTien();
            lbTongTien.Text = "Tổng tiền = " + dt.Rows[0][0].ToString() + " VND";
            //txtCavet.Hide();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index = dgvHoaDon.CurrentCell.RowIndex;
                string sID = dgvHoaDon.Rows[index].Cells[0].Value.ToString().Trim();
                thue.updateTinhTrangThongTinXe(txtCavet.Text, " ");
                thue.deleteHoaDon(sID);
                this.dgvHoaDon.DataSource = thue.getHoaDonThueXe();
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            string thoihan = numericThoiGianThue.Value.ToString();
            DateTime ngaybd = datetimepickerNgayBD.Value;
            DateTime ngaykt = dateTimePickerNgayKT.Value;
            string tien = txttien.Text;
            string tinhtrang = "Chờ duyệt";
            thue.updateHoaDonThueXe(txtCavet.Text, ngaybd, ngaykt, thoihan, tien, tinhtrang);
            dgvHoaDon.DataSource = thue.getHoaDonThueXe();
        }
    }
}