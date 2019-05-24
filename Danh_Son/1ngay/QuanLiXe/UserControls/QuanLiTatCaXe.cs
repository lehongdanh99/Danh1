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
    public partial class QuanLiTatCaXe : UserControl
    {
        MY_DB mydb = new MY_DB();
        KhachHang kh = new KhachHang();
        LayXeClass layxe = new LayXeClass();
        public QuanLiTatCaXe()
        {
            InitializeComponent();
        }

        private void QuanLiTatCaXe_Load(object sender, EventArgs e)
        {
            dgvQuanLiAllXe.DataSource = kh.getQLXRV();
            btSua.Visible = false;
            this.refreshData();
            txtSearch.BringToFront();
            btSearch.BringToFront();
            labelDauSaiViTri.Visible = false;
            labelQuaGioGui.Visible = false;
            btXoa.Visible = false;
            dgvQuanLiAllXe.BringToFront();
            dgvQuanLiAllXe.ReadOnly = true;
            dgvLuuTruXeDaLay.ReadOnly = true;
            refreshDataLayXe();
            
        }

        private void pictureBoxXeMay_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "Xe máy";
            txtSearchLayXe.Text = "Xe máy";
            btSearch_Click(sender, e);
            btSearchLayXe_Click(sender, e);
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from QUANLIXERAVAO where Concat(vitri, loaixe) like N'%" + txtSearch.Text + "%'");
            dgvQuanLiAllXe.ReadOnly = true;
            //xử lí hình ảnh, code có tham khảo msdn
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridViewImageColumn picCol1 = new DataGridViewImageColumn();
            dgvQuanLiAllXe.RowTemplate.Height = 90; //chỉnh pic đẹp
            dgvQuanLiAllXe.DataSource = kh.search(cmd);
            picCol = (DataGridViewImageColumn)dgvQuanLiAllXe.Columns[2];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            picCol1 = (DataGridViewImageColumn)dgvQuanLiAllXe.Columns[3];
            picCol1.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvQuanLiAllXe.AllowUserToAddRows = false;
        }

        private void pictureBoxOto_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "Ô tô";
            txtSearchLayXe.Text = "Ô tô";
            btSearch_Click(sender, e);
            btSearchLayXe_Click(sender, e);
        }

        private void pictureBoxXeDap_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "Xe đạp";
            txtSearchLayXe.Text = "Xe đạp";
            btSearch_Click(sender, e);
            btSearchLayXe_Click(sender, e);
        }

        public void refreshData()
        {
            txtSearch.Text = "";
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridViewImageColumn picCol1 = new DataGridViewImageColumn();
            dgvQuanLiAllXe.RowTemplate.Height = 90;
            dgvQuanLiAllXe.DataSource = kh.getQLXRV();
            picCol = (DataGridViewImageColumn)dgvQuanLiAllXe.Columns[2];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            picCol1 = (DataGridViewImageColumn)dgvQuanLiAllXe.Columns[3];
            picCol1.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvQuanLiAllXe.AllowUserToAddRows = false;
        }
        public void refreshDataLayXe()
        {
            txtSearchLayXe.Text = "";
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridViewImageColumn picCol1 = new DataGridViewImageColumn();
            dgvLuuTruXeDaLay.RowTemplate.Height = 90;
            dgvLuuTruXeDaLay.DataSource = layxe.getLayXe();
            picCol = (DataGridViewImageColumn)dgvLuuTruXeDaLay.Columns[2];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            picCol1 = (DataGridViewImageColumn)dgvLuuTruXeDaLay.Columns[3];
            picCol1.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvLuuTruXeDaLay.AllowUserToAddRows = false;
        }
        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            refreshData();
            refreshDataLayXe();
        }

        private void btSua_Click_1(object sender, EventArgs e)
        {
            EditGuiXe edit = new EditGuiXe();
            edit.ShowDialog();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < dgvLuuTruXeDaLay.Rows.Count; i++)
                {
                    string sID = dgvLuuTruXeDaLay.Rows[i].Cells[1].Value.ToString().Trim();
                    layxe.deleteCus(sID);
                }
                this.refreshDataLayXe();
            }
        }

        private void btGiaoDienChinh_Click(object sender, EventArgs e)
        {
            dgvQuanLiAllXe.BringToFront();
            btXoa.Visible = false;
            txtSearch.BringToFront();
            btSearch.BringToFront();
            txtSearch.Text = "";
        }

        private void btXeDaLay_Click(object sender, EventArgs e)
        {
            dgvLuuTruXeDaLay.BringToFront();
            btXoa.Visible = true;
            btSua.Visible = false;
            txtSearchLayXe.BringToFront();
            btSearchLayXe.BringToFront();
            txtSearchLayXe.Text = "";
        }

        private void btSearchLayXe_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from QLLAYXE where Concat(vitri, loaixe) like N'%" + txtSearchLayXe.Text + "%'");
            dgvLuuTruXeDaLay.ReadOnly = true;
            //xử lí hình ảnh, code có tham khảo msdn
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridViewImageColumn picCol1 = new DataGridViewImageColumn();
            dgvLuuTruXeDaLay.RowTemplate.Height = 90; //chỉnh pic đẹp
            dgvLuuTruXeDaLay.DataSource = kh.search(cmd);
            picCol = (DataGridViewImageColumn)dgvLuuTruXeDaLay.Columns[2];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            picCol1 = (DataGridViewImageColumn)dgvLuuTruXeDaLay.Columns[3];
            picCol1.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvLuuTruXeDaLay.AllowUserToAddRows = false;
        }
    }
}