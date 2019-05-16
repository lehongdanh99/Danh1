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
            refreshData();
            labelDauSaiViTri.Visible = false;
            labelQuaGioGui.Visible = false;
            btXoa.Visible = false;
            dgvQuanLiAllXe.BringToFront();
            dgvQuanLiAllXe.ReadOnly = true;
            dgvLuuTruXeDaLay.ReadOnly = true;
            
            dgvLuuTruXeDaLay.DataSource = layxe.getLayXe();
            
        }

        private void pictureBoxXeMay_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "Xe máy";
            btSearch_Click(sender, e);
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
            btSearch_Click(sender, e);
        }

        private void pictureBoxXeDap_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "Xe đạp";
            btSearch_Click(sender, e);
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
        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void btSua_Click_1(object sender, EventArgs e)
        {
            //int id;
            //string fname = TextBoxFname.Text;
            //string lname = TextBoxLname.Text;
            //DateTime bdate = DateTimePicker1.Value;
            //string phone = TextBoxPhone.Text;
            //string adrs = TextBoxAddress.Text;
            //string gender = "Male";
            //if (RadioButtonFemale.Checked)
            //{
            //    gender = "Female";
            //}
            //MemoryStream pic = new MemoryStream();
            //int born_year = DateTimePicker1.Value.Year;
            //int this_year = DateTime.Now.Year;
            //if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            //{
            //    MessageBox.Show("The student age must be between 10 and 100 year", "Birth date error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            //else if (verif())
            //{
            //    try
            //    {
            //        id = Convert.ToInt32(TextBoxID.Text);
            //        PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
            //        if (student.updateStudent(id, fname, lname, bdate, gender, phone, adrs, pic))
            //        {
            //            MessageBox.Show("Student information updated", "Edit student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //        else
            //        {
            //            MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Edit student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Empty fields", "Edit student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
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
                //pictureBoxRefresh_Click(sender, e);
            }
        }

        private void btGiaoDienChinh_Click(object sender, EventArgs e)
        {
            dgvQuanLiAllXe.BringToFront();
            btXoa.Visible = false;
        }

        private void btXeDaLay_Click(object sender, EventArgs e)
        {
            dgvLuuTruXeDaLay.BringToFront();
            btXoa.Visible = true;
        }

        private void dgvQuanLiAllXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}