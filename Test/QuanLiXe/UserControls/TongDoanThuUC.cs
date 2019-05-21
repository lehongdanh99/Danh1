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
    public partial class TongDoanThuUC : UserControl
    {
        DoanhThu dthu = new DoanhThu();
        public TongDoanThuUC()
        {
            InitializeComponent();
        }
        //Load tong doanh thu
        private void TongDoanThuUC_Load(object sender, EventArgs e)
        {
            dateTimePickerToday.Hide();
            refreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime today = Convert.ToDateTime(dateTimePickerToday.Text);
            DataTable dt = dthu.getDoanhThu(Convert.ToDateTime(dateTimePickerToday.Text));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string loaixe = dt.Rows[i][0].ToString();
                int soluong = Convert.ToInt32(dt.Rows[i][2]);
                int tongtien = Convert.ToInt32(dt.Rows[i][3]);
                if (dthu.search(today, loaixe) == false)
                {
                    dthu.insertDoanhThu(loaixe, today, soluong, tongtien);
                }
                else
                {
                    DataTable find = dthu.getDataNgayCu(today, loaixe);
                    soluong += Convert.ToInt32(find.Rows[i][2]);
                    tongtien += Convert.ToInt32(find.Rows[i][3]);
                    dthu.updateDoanhThu(loaixe, today, soluong, tongtien);
                }
            }
            MessageBox.Show("Đã lưu", "Đang lưu...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshData();
        }
        void refreshData()
        {
            DateTime date = Convert.ToDateTime(dateTimePicker.Text);
            dgvThongKe.DataSource = dthu.getThongKe(date);
            dgvThongKe.RowTemplate.Height = 50;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            refreshData();
        }
    }
}