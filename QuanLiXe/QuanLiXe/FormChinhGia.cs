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
    public partial class FormChinhGia : Form
    {
        public FormChinhGia()
        {
            InitializeComponent();
        }
        KhachHang kh = new KhachHang();
        MY_DB mydb = new MY_DB();
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            DataTable dt = kh.getPhiGuiXe();
            int count = dt.Rows.Count;
            string loaixee;
            for (int i = 0; i < count; i++)
            {
                if (i == 0) loaixee = txtXedap.Text;
                else if (i == 1) loaixee = txtXemay.Text;
                else loaixee = txtOto.Text;
                dt.Rows[i][1] = loaixee;
                dt.Rows[i][2] = Convert.ToInt32(loaixee) * 8;
                dt.Rows[i][3] = Convert.ToInt32(dt.Rows[i][2]) * 3;
                dt.Rows[i][4] = Convert.ToInt32(dt.Rows[i][3]) * 2;
                SqlCommand cmd = new SqlCommand("update GIAGUIXE set theogio=@gio, theongay=@ngay, theotuan=@tuan, theothang=@thang where loaixe=@xe ", mydb.getConnection);
                cmd.Parameters.Add("@gio", SqlDbType.VarChar).Value = dt.Rows[i][1].ToString();
                cmd.Parameters.Add("@ngay", SqlDbType.VarChar).Value = dt.Rows[i][2].ToString();
                cmd.Parameters.Add("@tuan", SqlDbType.VarChar).Value = dt.Rows[i][3].ToString();
                cmd.Parameters.Add("@thang", SqlDbType.VarChar).Value = dt.Rows[i][4].ToString();
                cmd.Parameters.Add("@xe", SqlDbType.VarChar).Value = dt.Rows[i][0].ToString();
                mydb.openConnection();
                if (cmd.ExecuteNonQuery() == 1) mydb.closeConnection();
                else mydb.closeConnection();
                this.Close();
            }
        }

        private void FormChinhGia_Load(object sender, EventArgs e)
        {
            DataTable dt = kh.getPhiGuiXe();
            txtXedap.Text = dt.Rows[0][1].ToString();
            txtXemay.Text = dt.Rows[1][1].ToString();
            txtOto.Text = dt.Rows[2][1].ToString();
            mydb.closeConnection();
        }
    }
}