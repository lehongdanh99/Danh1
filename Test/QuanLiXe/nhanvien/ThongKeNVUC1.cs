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
    public partial class ThongKeNVUC1 : UserControl
    {
        public ThongKeNVUC1()
        {
            InitializeComponent();
        }

        private void ptbBack_Click(object sender, EventArgs e)
        {
            dgvTho.Visible = false;
            panelNhanVien.Visible = true;
            btGiamSat.Visible = true;
        }
        NhanVien nv = new NhanVien();

        private void btTho_Click(object sender, EventArgs e)
        {
            panelNhanVien.Visible = false;
            dgvTho.RowTemplate.Height = 90;
            dgvTho.DataSource = nv.getAllTho();
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dgvTho.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvTho.Visible=true;
            btGiamSat.Visible = false;
        }

        private void btVanPhong_Click(object sender, EventArgs e)
        {
            panelNhanVien.Visible = false;
            dgvTho.DataSource = nv.getAllVanPhong();
            dgvTho.RowTemplate.Height = 90;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dgvTho.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvTho.Visible = true;
        }

        private void btGiamSat_Click(object sender, EventArgs e)
        {
            panelNhanVien.Visible = false;
            dgvTho.DataSource = nv.getAllGS();
            dgvTho.RowTemplate.Height = 90;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dgvTho.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvTho.Visible = true;
        }

        private void ThongKeNVUC1_Load(object sender, EventArgs e)
        {
            dgvTho.Visible = false;
            btTho.Location = new Point(165, 189);
            btVanPhong.Location = new Point(442, 430);
            btGiamSat.Location = new Point(666, 682);
            dgvTho.RowTemplate.Height = 90;
        }
    }
}