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
    public partial class HopDongGui : UserControl
    {
        public HopDongGui()
        {
            InitializeComponent();
        }

        private void HopDongGui_Load(object sender, EventArgs e)
        {
            dgvCon.DataSource = con.getAllContract();
            dgvCon.RowTemplate.Height = 50;
        }
        Contract con = new Contract();
        private void btnAddCon_Click(object sender, EventArgs e)
        {
            AddCustomer add = new AddCustomer();
            add.ShowDialog();
        }

        private void dgvCon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCon_DoubleClick(object sender, EventArgs e)
        {
            dgvCon.DataSource = con.getAllContract();
            dgvCon.RowTemplate.Height = 50;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvCon.DataSource = con.getContractbyID(txtSearch.Text);
            dgvCon.RowTemplate.Height = 50;
        }
    }
}