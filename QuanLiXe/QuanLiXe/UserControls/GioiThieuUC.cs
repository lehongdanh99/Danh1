using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiXe.UserControls
{
    public partial class GioiThieuUC : UserControl
    {
        public GioiThieuUC()
        {
            InitializeComponent();
        }

        KhachHang kh = new KhachHang();
        private void GioiThieuUC_Load(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(120, -78);
            lbxedapHour.Location = new Point(921, 486);
            lbxemayHour.Location = new Point(1110, 486);
            lbotoHour.Location = new Point(1295, 486);
            lbxedapDay.Location = new Point(921, 560);
            lbxemayDay.Location = new Point(1110, 560);
            lbotoDay.Location = new Point(1295, 560);
            lbxedapWeek.Location = new Point(921, 634);
            lbxemayWeek.Location = new Point(1110, 634);
            lbotoWeek.Location = new Point(1295, 634);
            lbXedapMonth.Location = new Point(921, 708);
            lbxemayMonth.Location = new Point(1110, 708);
            lbotoMonth.Location = new Point(1295, 708);
            showData();
        }
        void showData()
        {
            DataTable dt = kh.getPhiGuiXe();
            lbxedapHour.Text = dt.Rows[0][1].ToString();
            lbxemayHour.Text = dt.Rows[1][1].ToString();
            lbotoHour.Text = dt.Rows[2][1].ToString();
            lbxedapDay.Text = dt.Rows[0][2].ToString();
            lbxemayDay.Text = dt.Rows[1][2].ToString();
            lbotoDay.Text = dt.Rows[2][2].ToString();
            lbxedapWeek.Text = dt.Rows[0][3].ToString();
            lbxemayWeek.Text = dt.Rows[1][3].ToString();
            lbotoWeek.Text = dt.Rows[2][3].ToString();
            lbXedapMonth.Text = dt.Rows[0][4].ToString();
            lbxemayMonth.Text = dt.Rows[1][4].ToString();
            lbotoMonth.Text = dt.Rows[2][4].ToString();
        }
        private void pictureBoxOption_Click(object sender, EventArgs e)
        {
            FormChinhGia f = new FormChinhGia();
            f.ShowDialog();
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            showData();
        }
    }
}