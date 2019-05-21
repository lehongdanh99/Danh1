using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLiXe
{
    public partial class BaiXeForm : Form
    {
        public BaiXeForm()
        {
            InitializeComponent();
        }
        MY_DB db = new MY_DB();
        KhachHang kh = new KhachHang();
        public void BaiXeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_DESKTOP_BAIXE.BAIXE' table. You can move, or remove it, as needed.
            this.bAIXETableAdapter.Fill(this._DESKTOP_BAIXE.BAIXE);
            connectionBaiXe();
        }
        void connectionBaiXe()
        {
            dgvBaiXe.DataSource = kh.getCus();
            int countRow = dgvBaiXe.RowCount;
            int countCol = dgvBaiXe.ColumnCount;
            foreach (DataGridViewRow row in dgvBaiXe.Rows)
            {
                for (int j = 1; j < countCol; j++)
                    if (Convert.ToInt32(row.Cells[j].Value) > 0)
                    {
                        row.Cells[j].Value = "";
                        row.Cells[j].Style.BackColor = Color.Tomato;
                    }
                    else
                    {
                        row.Cells[j].Value = "";
                        row.Cells[j].Style.BackColor = Color.SteelBlue;
                    }
            }
        }
        private void btBackThoat_Click(object sender, EventArgs e)
        {
            db.closeConnection();
            this.Close();
        }
    }
}