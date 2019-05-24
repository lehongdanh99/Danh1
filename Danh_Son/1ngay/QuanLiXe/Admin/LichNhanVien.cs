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
    public partial class LichNhanVien : UserControl
    {
        public LichNhanVien()
        {
            InitializeComponent();
        }

        private void btnLichTuan_Click(object sender, EventArgs e)
        {
            dgvNhanVien.BringToFront();
            Ca();
        }

        private void listBoxDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pnDay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            listBoxDay.Items.Clear();
            ptbSang2.Enabled = true;
            ptbChieu2.Enabled = true;
            ptbToi2.Enabled = true;
            ptbSang3.Enabled = true;
            ptbChieu3.Enabled = true;
            ptbToi3.Enabled = true;
            ptbSang4.Enabled = true;
            ptbChieu4.Enabled = true;
            ptbToi4.Enabled = true;
            ptbSang5.Enabled = true;
            ptbChieu5.Enabled = true;
            ptbToi5.Enabled = true;
            ptbSang6.Enabled = true;
            ptbChieu6.Enabled = true;
            ptbToi6.Enabled = true;
            ptbSang7.Enabled = true;
            ptbChieu7.Enabled = true;
            ptbToi7.Enabled = true;
        }

        private void btnThemLich_Click(object sender, EventArgs e)
        {
            string manv = txtMaNV.Text;
            int ngaylam;
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Chọn nhân viên trong ' lịch nhân viên' để set lịch!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (listBoxDay.Text != null && txtMaNV.Text != "")
            {
                foreach (string s in listBoxDay.Items)
                {
                    nv.insertLich(manv, s);
                }
                ngaylam = Convert.ToInt32(listBoxDay.Items.Count.ToString());

                ngaylam = Convert.ToInt32(listBoxDay.Items.Count.ToString());
                string type = nv.LoaiNV(manv);
                if (type.Trim() == "Giam Sat")
                {
                    ngaylam = ngaylam * 100000;

                    if (nv.insertLuong(manv, Convert.ToString(ngaylam))) ;
                }
                else if (type.Trim() == "Van phong")
                {
                    ngaylam = ngaylam * 110000;
                    if (nv.insertLuong(manv, Convert.ToString(ngaylam))) ;
                }
                MessageBox.Show("Đã set lịch cho nhân viên " + txtMaNV.Text, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Hãy ngày cho nhân viên", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        NhanVien nv = new NhanVien();
        public void Ca()
        {
            DataTable dt = nv.chiaCa();
           
            dgvNhanVien.RowTemplate.Height = 90;
            dgvNhanVien.DataSource = dt;
            int t = Convert.ToInt32(dt.Rows.Count);
            int i = 0;
            int j;
            while (i < t)
            {
                j = 1;
                while (j < 7)

                {
                    //Nghỉ là xanh
                    if (dgvNhanVien[j, i].Value.ToString() != "")
                    {
                        dgvNhanVien[j, i].Style.BackColor = Color.Green;
                    }
                    // Làm là đỏ
                    else
                    {
                        dgvNhanVien[j, i].Style.BackColor = Color.Red;
                    }
                    j++;
                }
                i++;
            }
            
            dgvNhanVien.Show();
        }

        private void ptbSang2_Click(object sender, EventArgs e)
        {
            listBoxDay.Items.Add("Sang 2");
            ptbSang2.Enabled = false;
            ptbChieu2.Enabled = false;
            ptbToi2.Enabled = false;
        }

        private void ptbChieu2_Click(object sender, EventArgs e)
        {
            listBoxDay.Items.Add("Chieu 2");
            ptbSang2.Enabled = false;
            ptbChieu2.Enabled = false;
            ptbToi2.Enabled = false;
        }

        private void ptbToi2_Click(object sender, EventArgs e)
        {
            listBoxDay.Items.Add("Toi 3");
            ptbSang2.Enabled = false;
            ptbChieu2.Enabled = false;
            ptbToi2.Enabled = false;
        }
        private void ptbSang3_Click(object sender, EventArgs e)
        {
            listBoxDay.Items.Add("Sang 3");
            ptbSang3.Enabled = false;
            ptbChieu3.Enabled = false;
            ptbToi3.Enabled = false;
        }

        private void ptbChieu3_Click(object sender, EventArgs e)
        {
            listBoxDay.Items.Add("Chieu 3");
            ptbSang3.Enabled = false;
            ptbChieu3.Enabled = false;
            ptbToi3.Enabled = false;
        }

        private void ptbToi3_Click(object sender, EventArgs e)
        {
            listBoxDay.Items.Add("Toi 3");
            ptbSang3.Enabled = false;
            ptbChieu3.Enabled = false;
            ptbToi3.Enabled = false;
        }

        private void ptbSang4_Click(object sender, EventArgs e)
        {
            listBoxDay.Items.Add("Sang 4");
            ptbSang4.Enabled = false;
            ptbChieu4.Enabled = false;
            ptbToi4.Enabled = false;
        }

        private void ptbChieu4_Click(object sender, EventArgs e)
        {
            listBoxDay.Items.Add("Chieu 4");
            ptbSang4.Enabled = false;
            ptbChieu4.Enabled = false;
            ptbToi4.Enabled = false;
        }

        private void ptbToi4_Click(object sender, EventArgs e)
        {
            listBoxDay.Items.Add("Toi 4");
            ptbSang4.Enabled = false;
            ptbChieu4.Enabled = false;
            ptbToi4.Enabled = false;
        }

        private void ptbSang5_Click(object sender, EventArgs e)
        {
            listBoxDay.Items.Add("Sang 5");
            ptbSang5.Enabled = false;
            ptbChieu5.Enabled = false;
            ptbToi5.Enabled = false;
        }

        private void ptbChieu5_Click(object sender, EventArgs e)
        {
            listBoxDay.Items.Add("Chieu 5");
            ptbSang5.Enabled = false;
            ptbChieu5.Enabled = false;
            ptbToi5.Enabled = false;
        }

        private void ptbToi5_Click(object sender, EventArgs e)
        {
            listBoxDay.Items.Add("Toi 5");
            ptbSang5.Enabled = false;
            ptbChieu5.Enabled = false;
            ptbToi5.Enabled = false;
        }

        private void ptbSang6_Click(object sender, EventArgs e)
        {
            listBoxDay.Items.Add("Sang 6");
            ptbSang6.Enabled = false;
            ptbChieu6.Enabled = false;
            ptbToi6.Enabled = false;
        }

        private void ptbChieu6_Click(object sender, EventArgs e)
        {
            listBoxDay.Items.Add("Chieu 6");
            ptbSang6.Enabled = false;
            ptbChieu6.Enabled = false;
            ptbToi6.Enabled = false;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ptbToi6_Click(object sender, EventArgs e)
        {
            listBoxDay.Items.Add("Toi 6");
            ptbSang6.Enabled = false;
            ptbChieu6.Enabled = false;
            ptbToi6.Enabled = false;
        }

        private void ptbSang7_Click(object sender, EventArgs e)
        {
            listBoxDay.Items.Add("Sang 7");
            ptbSang7.Enabled = false;
            ptbChieu7.Enabled = false;
            ptbToi7.Enabled = false;
        }

        private void ptbCheu7_Click(object sender, EventArgs e)
        {
            listBoxDay.Items.Add("Chieu 7");
            ptbSang7.Enabled = false;
            ptbChieu7.Enabled = false;
            ptbToi7.Enabled = false;
        }

        private void ptbToi7_Click(object sender, EventArgs e)
        {
            listBoxDay.Items.Add("Toi 7");
            ptbSang7.Enabled = false;
            ptbChieu7.Enabled = false;
            ptbToi7.Enabled = false;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtMaNV.Enabled = false;
            dgvNhanVien.SendToBack();
            pnDay.BringToFront();
        }
    }
}
