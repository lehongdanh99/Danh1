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
    public partial class ChiaCaUC : UserControl
    {
        public ChiaCaUC()
        {
            InitializeComponent();
        }
        NhanVien nv = new NhanVien();

        private void btnBack_Click(object sender, EventArgs e)
        {
            ptbCasang.Visible = true;
            ptbCachieu.Visible = true;
            ptbToi.Visible = true;
            pnAll.Visible = false;
            dgvNV.Visible = false;
            ptbCachieu.Enabled = true;
            ptbCasang.Enabled = true;
            ptbToi.Enabled = true;
            pnPicture.Visible = true;
        }

        private void btnList_Click(object sender, EventArgs e)
        {

            DataTable dt = nv.chiaCa();
            dgvNV.DataSource = dt;
            dgvNV.RowTemplate.Height = 90;
            int t = Convert.ToInt32(dgvNV.Rows.Count);
            Ca();
            dgvNV.Show();
            dgvNV.BringToFront();
        }
        public void Ca()
        {
            int t = Convert.ToInt32(dgvNV.Rows.Count);
            int i = 0;
            while (i < t)
            {
                if (dgvNV.Rows[i].Cells[4].Value.ToString() == "busy                ")
                {
                    dgvNV.Rows[i].Cells[4].Style.BackColor = Color.Red;
                    dgvNV.Rows[i].Cells[4].Value = " ";
                }
                else if (dgvNV.Rows[i].Cells[4].Value.ToString() == "free                ")
                {
                    dgvNV.Rows[i].Cells[4].Style.BackColor = Color.Green;
                    dgvNV.Rows[i].Cells[4].Value = " ";
                }
                i++;
            }
        }
        private void btnAddCa_Click(object sender, EventArgs e)
        {
            string manv;
            manv = txtmaNV.Text;
            if (nv.checkNV(manv))
            {
                {
                    {
                        string ca;
                        if (radioSang.Checked)
                        {
                            ca = "Sang";
                        }
                        else if (radioChieu.Checked)
                        {
                            ca = "Chieu";
                        }
                        else
                        {
                            ca = "Toi";
                        }
                        string khu;
                        khu = comboKhu.Text;
                        DateTime day = DateTime.Today;

                        string tinhtrang;
                        if (radioBusy.Checked)
                        {
                            tinhtrang = "busy";
                        }
                        else
                        {
                            tinhtrang = "free";
                        }
                        string luong;
                        if (radioSang.Checked == true)
                        {
                            luong = "100000";
                        }
                        else if (radioChieu.Checked == true)
                        {
                            luong = "120000";
                        }
                        else
                        {
                            luong = "150000";
                        }
                        if (nv.insertCa(manv, ca, luong, khu, tinhtrang, day))
                        {
                            MessageBox.Show("Thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else if (nv.checkNV(manv) == false)
            {
                MessageBox.Show("Sai mã nhân viên " + manv, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pnPicture.Visible = false;
            pnAll.Visible = true;
            pnAll.BringToFront();
            txtmaNV.Text = dgvNV.CurrentRow.Cells[0].Value.ToString();
            comboKhu.Text = dgvNV.CurrentRow.Cells[3].Value.ToString();
            if (dgvNV.CurrentRow.Cells[1].Value.ToString() == "Sang                ")
            {
                radioSang.Checked = true;
            }
            else if (dgvNV.CurrentRow.Cells[1].Value.ToString() == "Toi                 ")
            {
                radioToi.Checked = true;
            }
            else
            {
                radioChieu.Checked = true;
            }
            if (dgvNV.CurrentRow.Cells[4].Style.BackColor == Color.Green)
            {
                radioFree.Checked = true;

            }
            else
            {
                radioBusy.Checked = true;
            }
        }

        private void ptbCasang_Click(object sender, EventArgs e)
        {
            DataTable dt = nv.getCa("Sang                ");
            dgvNV.DataSource = dt;
            Ca();
            dgvNV.Show();
            dgvNV.BringToFront();
            ptbCachieu.Enabled = false;
            ptbToi.Enabled = false;
        }

        private void ptbCachieu_Click(object sender, EventArgs e)
        {
            DataTable dt = nv.getCa("Chieu                ");
            dgvNV.DataSource = dt;
            Ca();
            dgvNV.Show();
            dgvNV.BringToFront();
            ptbCasang.Enabled = false;
            ptbToi.Enabled = false;
        }

        private void ptbToi_Click(object sender, EventArgs e)
        {
            DataTable dt = nv.getCa("Toi                ");
            dgvNV.DataSource = dt;
            Ca();
            dgvNV.Show();
            dgvNV.BringToFront();
            ptbCasang.Enabled = false;
            ptbCachieu.Enabled = false;
        }

        private void ChiaCaUC_Load(object sender, EventArgs e)
        {
            pnAll.Visible = false;
        }
    }
}
