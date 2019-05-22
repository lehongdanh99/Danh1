using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace QuanLiXe
{
    public partial class NhanVienUC : UserControl
    {
        public NhanVienUC()
        {
            InitializeComponent();
        }
        NhanVien nv = new NhanVien();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from NHANVIEN where Concat(maNV, fname, lname) like N'%" + txtSearch.Text + "%'");
            dgvNhanVien.ReadOnly = true;
            //xử lí hình ảnh, code có tham khảo msdn
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dgvNhanVien.RowTemplate.Height = 90; //chỉnh pic đẹp
            dgvNhanVien.DataSource = nv.search(cmd);
            picCol = (DataGridViewImageColumn)dgvNhanVien.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvNhanVien.AllowUserToAddRows = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addNhanVienUC1.Show();
            dgvNhanVien.Visible = false;
            editNhanVienUC1.Visible = false;
            thongKeNVUC11.Visible = false;
            btnSearch.Visible = false;
            txtSearch.Visible = false;
            chiaCaUC1.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            chiaCaUC1.Visible = false;
            btnSearch.Visible = false;
            txtSearch.Visible = false;
            addNhanVienUC1.Visible = false;
            editNhanVienUC1.Visible = false;
            dgvNhanVien.Visible = false;
            #region
            //string manv = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            //manv = manv.Trim();
            //Global.MANV(manv);
            //string fname = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            //fname = fname.Trim();
            //Global.FNAME(fname);
            //string lname = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
            //lname = lname.Trim();
            //Global.LNAME(lname);
            //string gender = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
            //gender = gender.Trim();
            //Global.gender(gender);

            //Edit ed = new Edit();
            //byte[] pic;
            //pic = (byte[])dgvNhanVien.CurrentRow.Cells[8].Value;
            //MemoryStream picture = new MemoryStream(pic);
            //Global.pic = Image.FromStream(picture);
            //string phone = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
            //phone = phone.Trim();
            //Global.PHONE(phone);
            //string address = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();
            //address = address.Trim();
            //Global.ADDRESS(address);
            //string cmnd = dgvNhanVien.CurrentRow.Cells[7].Value.ToString();
            //cmnd = cmnd.Trim();
            //Global.CMND(cmnd);
            //string type = dgvNhanVien.CurrentRow.Cells[9].Value.ToString();
            //type = type.Trim();
            //Global.TYPE(type);
            #endregion
            //DateTime BDAY= (DateTime)dgvNhanVien.CurrentRow.Cells[4].Value;
            //Global.Birthday(BDAY);
            //byte[] pic;
            //pic = (byte[])dgvNhanVien.CurrentRow.Cells[7].Value;
            //ed.ShowDialog();
            editNhanVienUC1.Visible = true;
            editNhanVienUC1.txtMaNV.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            editNhanVienUC1.txtMaNV.Text = editNhanVienUC1.txtMaNV.Text.Trim();
            editNhanVienUC1.txtHo.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
            editNhanVienUC1.txtTen.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            dgvNhanVien.CurrentRow.Cells[3].Value = dgvNhanVien.CurrentRow.Cells[3].Value.ToString().Trim();
            if (dgvNhanVien.CurrentRow.Cells[3].Value.ToString() == "Female")
            {
                editNhanVienUC1.radioFemale.Checked = true;
            }
            else
            {
                editNhanVienUC1.radioMale.Checked = true;

            }
            editNhanVienUC1.dtpBirthday.Value = (DateTime)dgvNhanVien.CurrentRow.Cells[4].Value;
            editNhanVienUC1.txtSdt.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
            editNhanVienUC1.txtAddress.Text = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();
            editNhanVienUC1.txtCmnd.Text = dgvNhanVien.CurrentRow.Cells[7].Value.ToString();
            dgvNhanVien.CurrentRow.Cells[9].Value = dgvNhanVien.CurrentRow.Cells[9].Value.ToString().Trim();
            if (dgvNhanVien.CurrentRow.Cells[9].Value.ToString() == "Giam Sat")
            {
                editNhanVienUC1.radioGS.Checked = true;
            }
            else if (dgvNhanVien.CurrentRow.Cells[9].Value.ToString() == "Van Phong")
            {
                editNhanVienUC1.radioVP.Checked = true;
            }
            else
            {
                editNhanVienUC1.radioTho.Checked = true;
            }
            byte[] pic;
            pic = (byte[])dgvNhanVien.CurrentRow.Cells[8].Value;
            MemoryStream picture = new MemoryStream(pic);
            editNhanVienUC1.ptbAva.Image = Image.FromStream(picture);
            editNhanVienUC1.Show();
        }

        private void btnThongKeNV_Click(object sender, EventArgs e)
        {
            thongKeNVUC11.Visible = true;
            dgvNhanVien.Visible = false;
            editNhanVienUC1.Visible = false;
            addNhanVienUC1.Visible = false;
            btnSearch.Visible = false;
            txtSearch.Visible = false;
            chiaCaUC1.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string manv = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            manv = manv.Trim();

            DialogResult dlr = MessageBox.Show("Bạn muốn xóa nhân viên có mã " + manv, "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (dlr == DialogResult.Yes)
            {
                dgvNhanVien.DataSource = nv.DeleteNhanVien(manv);
                dgvNhanVien.Show();
                MessageBox.Show("Nhân viên có mã " + manv + " đã bị xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reload();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            chiaCaUC1.Visible = false;
            reload();
        }
        public void reload()
        {
            btnSearch.Visible = true;
            txtSearch.Visible = true;
            dgvNhanVien.DataSource = nv.getAllNV();
            dgvNhanVien.Show();
            thongKeNVUC11.Visible = false;
            dgvNhanVien.RowTemplate.Height = 90;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dgvNhanVien.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvNhanVien.Visible = true;
            addNhanVienUC1.Visible = false;
            editNhanVienUC1.Visible = false;
        }
        private void NhanVienUC_Load(object sender, EventArgs e)
        {
            dgvNhanVien.Visible = false;           
            editNhanVienUC1.Visible = false;
            addNhanVienUC1.Visible = false;
            thongKeNVUC11.Visible = false;
            chiaCaUC1.Visible = false;
            AddNhanVienUC ad = new AddNhanVienUC();
            ad.Show();
            //dgvNhanVien.DataSource = nv.getAllNV();
            //dgvNhanVien.Show();
            //dgvNhanVien.RowTemplate.Height = 90;
            //DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            //picCol = (DataGridViewImageColumn)dgvNhanVien.Columns[8];
            //picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void btnChiaca(object sender, EventArgs e)
        {
           
        }
        private void hide()
        {
            editNhanVienUC1.Visible = false;
            addNhanVienUC1.Visible = false;
            thongKeNVUC11.Visible = false;

        }
        private void btnCa_Click(object sender, EventArgs e)
        {
            dgvNhanVien.Visible = false;
            chiaCaUC1.Location = new Point(100, 70);
            chiaCaUC1.Show();
            chiaCaUC1.BringToFront();
            
            hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}