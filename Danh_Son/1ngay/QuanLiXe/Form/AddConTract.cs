using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiXe
{
    public partial class AddConTract : Form
    {
        Contract con = new Contract();
        public AddConTract()
        {
            InitializeComponent();
        }
        void clearform()
        {
            txtConID.Text = "";
            txtMaKH.Text = "";
            txtDescription.Text = "";
            txtPaid.Text = "";
            txtThoiHan.Text = "";
        }
        private void btnAddCon_Click(object sender, EventArgs e)
        {
            //Khai báo để vào insert
            #region khai báo
            string mahd = txtConID.Text;
            string makh = txtMaKH.Text;
            string thoihan = txtThoiHan.Text;
            string theloai;
            theloai = cbTheLoai.Text;

            DateTime ngaybatdau = dtpDateStart.Value;
            DateTime ngayketthuc;
            string paid = txtPaid.Text;
            string des = txtDescription.Text;
            string type;
            string userid = "";

            #endregion
            //Hàm xử lí combobox

            // Thêm hợp đồng
            #region them hop dong
            if (radiobtnThue.Checked == true)
            {
                type = radiobtnThue.Text.ToString();
                if (con.insertCon(mahd, makh, thoihan, ngaybatdau, paid, des, type, userid))
                {

                    for (int i = 0; i < ListBoxBienSo.Items.Count; i++)
                    {
                        con.insertGui(mahd, ListBoxBienSo.Items[i].ToString(), theloai);
                    }
                    MessageBox.Show("Đã thêm hợp đồng");
                    clearform();
                }
                else MessageBox.Show("Something Wrong!");

            }
            else
            {
                type = radiobtnGui.Text.ToString();
                if (con.insertCon(mahd, makh, thoihan, ngaybatdau, paid, des, type, userid))
                {

                    for (int i = 0; i < ListBoxBienSo.Items.Count; i++)
                    {
                        con.insertGui(mahd, ListBoxBienSo.Items[i].ToString(), theloai);
                    }
                    MessageBox.Show("Đã thêm hợp đồng");
                    clearform();
                }
                else MessageBox.Show("Something Wrong!");
            }
            #endregion

        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            //Khai báo biến để Update
            #region khai báo
            string mahd = txtConID.Text;
            string thoihan = txtThoiHan.Text;
            string paid = txtPaid.Text;
            string des = txtDescription.Text;
            DateTime ngaybatdau = dtpDateStart.Value;
            DateTime ngayketthuc = DateTime.Now;
            string makh = txtMaKH.Text;
            string theloai;
            string type;
            if (radiobtnGui.Checked)
            {
                type = radiobtnGui.Text;
            }
            else { type = radiobtnThue.Text; }
            string userid = null;

            #endregion
            try
            {
                if (con.updateCon(mahd, makh, thoihan, ngaybatdau, DateTime.Now, paid, des, type, userid))
                {
                    MessageBox.Show("Đã thanh toán xong Hợp Đồng! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ");
            }
        }

        private void AddConTract_Load(object sender, EventArgs e)
        {
            txtMaKH.Text = Global.IDKH;
            cbTheLoai.DataSource = con.getLoaiXe();
            cbTheLoai.DisplayMember = "LoaiXe";
            cbTheLoai.ValueMember = "id";
            cbTheLoai.SelectedItem = null;
        }

        private void btnListBox_Click(object sender, EventArgs e)
        {
            string bienso = txtBienSo.Text;
            ListBoxBienSo.Items.Add(bienso);
        }

        private void radiobtnGui_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
