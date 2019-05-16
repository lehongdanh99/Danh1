namespace QuanLiXe
{
    partial class QuanLiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLiForm));
            this.panelForm = new System.Windows.Forms.Panel();
            this.btHopDongKhachHang = new System.Windows.Forms.Button();
            this.btHopDongCongTy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btThongKeDoanhThu = new System.Windows.Forms.Button();
            this.btQuanLiXe = new System.Windows.Forms.Button();
            this.btQuanLiNhanVien = new System.Windows.Forms.Button();
            this.btThongTinKhachHang = new System.Windows.Forms.Button();
            this.panelClick = new System.Windows.Forms.Panel();
            this.btGioiThieu = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuTuyChon = new System.Windows.Forms.ToolStripMenuItem();
            this.baiXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.NhanVienUC = new QuanLiXe.NhanVien1();
            this.HopDongGui = new QuanLiXe.UserControls.HopDongGui();
            this.gioiThieuUC = new QuanLiXe.UserControls.GioiThieuUC();
            this.tongDoanThuUC = new QuanLiXe.UserControls.TongDoanThuUC();
            this.quanLiTatCaXe = new QuanLiXe.UserControls.QuanLiTatCaXe();
            this.giaoDienQuanLiXeUC = new QuanLiXe.UserControls.GiaoDienQuanLiXeUC();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panelForm
            // 
            this.panelForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelForm.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelForm.Controls.Add(this.btHopDongKhachHang);
            this.panelForm.Controls.Add(this.btHopDongCongTy);
            this.panelForm.Controls.Add(this.pictureBox1);
            this.panelForm.Controls.Add(this.btThongKeDoanhThu);
            this.panelForm.Controls.Add(this.btQuanLiXe);
            this.panelForm.Controls.Add(this.btQuanLiNhanVien);
            this.panelForm.Controls.Add(this.btThongTinKhachHang);
            this.panelForm.Controls.Add(this.panelClick);
            this.panelForm.Controls.Add(this.btGioiThieu);
            this.panelForm.Location = new System.Drawing.Point(-3, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(355, 797);
            this.panelForm.TabIndex = 0;
            // 
            // btHopDongKhachHang
            // 
            this.btHopDongKhachHang.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btHopDongKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHopDongKhachHang.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btHopDongKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHopDongKhachHang.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHopDongKhachHang.ForeColor = System.Drawing.Color.Transparent;
            this.btHopDongKhachHang.Location = new System.Drawing.Point(3, 520);
            this.btHopDongKhachHang.Name = "btHopDongKhachHang";
            this.btHopDongKhachHang.Size = new System.Drawing.Size(349, 80);
            this.btHopDongKhachHang.TabIndex = 8;
            this.btHopDongKhachHang.Text = "Hợp đồng khách hàng";
            this.btHopDongKhachHang.UseVisualStyleBackColor = true;
            this.btHopDongKhachHang.Click += new System.EventHandler(this.btHopDongKhachHang_Click);
            // 
            // btHopDongCongTy
            // 
            this.btHopDongCongTy.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btHopDongCongTy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHopDongCongTy.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btHopDongCongTy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHopDongCongTy.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHopDongCongTy.ForeColor = System.Drawing.Color.Transparent;
            this.btHopDongCongTy.Location = new System.Drawing.Point(3, 606);
            this.btHopDongCongTy.Name = "btHopDongCongTy";
            this.btHopDongCongTy.Size = new System.Drawing.Size(349, 80);
            this.btHopDongCongTy.TabIndex = 7;
            this.btHopDongCongTy.Text = "Hợp đồng công ty";
            this.btHopDongCongTy.UseVisualStyleBackColor = true;
            this.btHopDongCongTy.Click += new System.EventHandler(this.btHopDongCongTy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btThongKeDoanhThu
            // 
            this.btThongKeDoanhThu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btThongKeDoanhThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThongKeDoanhThu.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btThongKeDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThongKeDoanhThu.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThongKeDoanhThu.ForeColor = System.Drawing.Color.Transparent;
            this.btThongKeDoanhThu.Location = new System.Drawing.Point(3, 692);
            this.btThongKeDoanhThu.Name = "btThongKeDoanhThu";
            this.btThongKeDoanhThu.Size = new System.Drawing.Size(349, 80);
            this.btThongKeDoanhThu.TabIndex = 6;
            this.btThongKeDoanhThu.Text = "Thống kê doanh thu";
            this.btThongKeDoanhThu.UseVisualStyleBackColor = true;
            this.btThongKeDoanhThu.Click += new System.EventHandler(this.btThongKeDoanhThu_Click);
            // 
            // btQuanLiXe
            // 
            this.btQuanLiXe.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btQuanLiXe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btQuanLiXe.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btQuanLiXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuanLiXe.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuanLiXe.ForeColor = System.Drawing.Color.Transparent;
            this.btQuanLiXe.Location = new System.Drawing.Point(3, 434);
            this.btQuanLiXe.Name = "btQuanLiXe";
            this.btQuanLiXe.Size = new System.Drawing.Size(349, 80);
            this.btQuanLiXe.TabIndex = 5;
            this.btQuanLiXe.Text = "Quản lí bãi xe";
            this.btQuanLiXe.UseVisualStyleBackColor = true;
            this.btQuanLiXe.Click += new System.EventHandler(this.btQuanLiXe_Click);
            // 
            // btQuanLiNhanVien
            // 
            this.btQuanLiNhanVien.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btQuanLiNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btQuanLiNhanVien.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btQuanLiNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuanLiNhanVien.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuanLiNhanVien.ForeColor = System.Drawing.Color.Transparent;
            this.btQuanLiNhanVien.Location = new System.Drawing.Point(3, 348);
            this.btQuanLiNhanVien.Name = "btQuanLiNhanVien";
            this.btQuanLiNhanVien.Size = new System.Drawing.Size(349, 80);
            this.btQuanLiNhanVien.TabIndex = 4;
            this.btQuanLiNhanVien.Text = "Quản lí nhân viên";
            this.btQuanLiNhanVien.UseVisualStyleBackColor = true;
            this.btQuanLiNhanVien.Click += new System.EventHandler(this.btQuanLiNhanVien_Click);
            // 
            // btThongTinKhachHang
            // 
            this.btThongTinKhachHang.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btThongTinKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThongTinKhachHang.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btThongTinKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThongTinKhachHang.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThongTinKhachHang.ForeColor = System.Drawing.Color.Transparent;
            this.btThongTinKhachHang.Location = new System.Drawing.Point(3, 262);
            this.btThongTinKhachHang.Name = "btThongTinKhachHang";
            this.btThongTinKhachHang.Size = new System.Drawing.Size(349, 80);
            this.btThongTinKhachHang.TabIndex = 2;
            this.btThongTinKhachHang.Text = "Thông tin khách hàng";
            this.btThongTinKhachHang.UseVisualStyleBackColor = true;
            this.btThongTinKhachHang.Click += new System.EventHandler(this.btThongTinKhachHang_Click);
            // 
            // panelClick
            // 
            this.panelClick.BackColor = System.Drawing.Color.AliceBlue;
            this.panelClick.Location = new System.Drawing.Point(3, 176);
            this.panelClick.Name = "panelClick";
            this.panelClick.Size = new System.Drawing.Size(23, 80);
            this.panelClick.TabIndex = 1;
            // 
            // btGioiThieu
            // 
            this.btGioiThieu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btGioiThieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGioiThieu.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btGioiThieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGioiThieu.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGioiThieu.ForeColor = System.Drawing.Color.Transparent;
            this.btGioiThieu.Location = new System.Drawing.Point(3, 176);
            this.btGioiThieu.Name = "btGioiThieu";
            this.btGioiThieu.Size = new System.Drawing.Size(349, 80);
            this.btGioiThieu.TabIndex = 0;
            this.btGioiThieu.Text = "Giới thiệu";
            this.btGioiThieu.UseVisualStyleBackColor = true;
            this.btGioiThieu.Click += new System.EventHandler(this.btGioiThieu_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTuyChon});
            this.menuStrip.Location = new System.Drawing.Point(350, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(138, 39);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuTuyChon
            // 
            this.menuTuyChon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baiXeToolStripMenuItem,
            this.quanLiToolStripMenuItem});
            this.menuTuyChon.Name = "menuTuyChon";
            this.menuTuyChon.Size = new System.Drawing.Size(130, 35);
            this.menuTuyChon.Text = "Tùy chọn";
            // 
            // baiXeToolStripMenuItem
            // 
            this.baiXeToolStripMenuItem.Name = "baiXeToolStripMenuItem";
            this.baiXeToolStripMenuItem.Size = new System.Drawing.Size(169, 36);
            this.baiXeToolStripMenuItem.Text = "Bãi xe";
            this.baiXeToolStripMenuItem.Click += new System.EventHandler(this.baiXeToolStripMenuItem_Click);
            // 
            // quanLiToolStripMenuItem
            // 
            this.quanLiToolStripMenuItem.Name = "quanLiToolStripMenuItem";
            this.quanLiToolStripMenuItem.Size = new System.Drawing.Size(169, 36);
            this.quanLiToolStripMenuItem.Text = "Quản lí";
            this.quanLiToolStripMenuItem.Click += new System.EventHandler(this.quanLiToolStripMenuItem_Click);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBack.BackgroundImage")));
            this.pictureBoxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBack.Location = new System.Drawing.Point(370, 12);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(87, 63);
            this.pictureBoxBack.TabIndex = 57;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // NhanVienUC
            // 
            this.NhanVienUC.Location = new System.Drawing.Point(350, 5);
            this.NhanVienUC.Name = "NhanVienUC";
            this.NhanVienUC.Size = new System.Drawing.Size(1080, 789);
            this.NhanVienUC.TabIndex = 62;
            // 
            // HopDongGui
            // 
            this.HopDongGui.Location = new System.Drawing.Point(350, 0);
            this.HopDongGui.Margin = new System.Windows.Forms.Padding(2);
            this.HopDongGui.Name = "HopDongGui";
            this.HopDongGui.Size = new System.Drawing.Size(1080, 800);
            this.HopDongGui.TabIndex = 61;
            this.HopDongGui.Load += new System.EventHandler(this.HopDongGui_Load);
            // 
            // gioiThieuUC
            // 
            this.gioiThieuUC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gioiThieuUC.BackColor = System.Drawing.Color.LightBlue;
            this.gioiThieuUC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gioiThieuUC.BackgroundImage")));
            this.gioiThieuUC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gioiThieuUC.Location = new System.Drawing.Point(350, 0);
            this.gioiThieuUC.Name = "gioiThieuUC";
            this.gioiThieuUC.Size = new System.Drawing.Size(1080, 800);
            this.gioiThieuUC.TabIndex = 59;
            // 
            // tongDoanThuUC
            // 
            this.tongDoanThuUC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tongDoanThuUC.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tongDoanThuUC.Location = new System.Drawing.Point(350, 0);
            this.tongDoanThuUC.Name = "tongDoanThuUC";
            this.tongDoanThuUC.Size = new System.Drawing.Size(1080, 800);
            this.tongDoanThuUC.TabIndex = 58;
            // 
            // quanLiTatCaXe
            // 
            this.quanLiTatCaXe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quanLiTatCaXe.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.quanLiTatCaXe.Location = new System.Drawing.Point(350, 0);
            this.quanLiTatCaXe.Name = "quanLiTatCaXe";
            this.quanLiTatCaXe.Size = new System.Drawing.Size(1080, 800);
            this.quanLiTatCaXe.TabIndex = 60;
            // 
            // giaoDienQuanLiXeUC
            // 
            this.giaoDienQuanLiXeUC.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.giaoDienQuanLiXeUC.Cursor = System.Windows.Forms.Cursors.Default;
            this.giaoDienQuanLiXeUC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.giaoDienQuanLiXeUC.Location = new System.Drawing.Point(350, 0);
            this.giaoDienQuanLiXeUC.Margin = new System.Windows.Forms.Padding(4);
            this.giaoDienQuanLiXeUC.Name = "giaoDienQuanLiXeUC";
            this.giaoDienQuanLiXeUC.Size = new System.Drawing.Size(1620, 1169);
            this.giaoDienQuanLiXeUC.TabIndex = 2;
            // 
            // QuanLiForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1426, 798);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.tongDoanThuUC);
            this.Controls.Add(this.quanLiTatCaXe);
            this.Controls.Add(this.giaoDienQuanLiXeUC);
            this.Controls.Add(this.NhanVienUC);
            this.Controls.Add(this.HopDongGui);
            this.Controls.Add(this.gioiThieuUC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "QuanLiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lí";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuanLiForm_Load);
            this.panelForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Button btGioiThieu;
        private System.Windows.Forms.Panel panelClick;
        private System.Windows.Forms.Button btThongTinKhachHang;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btQuanLiNhanVien;
        private System.Windows.Forms.Button btQuanLiXe;
        private UserControls.GiaoDienQuanLiXeUC giaoDienQuanLiXeUC;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuTuyChon;
        private System.Windows.Forms.ToolStripMenuItem baiXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLiToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.Button btThongKeDoanhThu;
        private UserControls.TongDoanThuUC tongDoanThuUC;
        private UserControls.GioiThieuUC gioiThieuUC;
        private UserControls.QuanLiTatCaXe quanLiTatCaXe;
        private System.Windows.Forms.Button btHopDongKhachHang;
        private System.Windows.Forms.Button btHopDongCongTy;
        private UserControls.HopDongGui HopDongGui;
        private NhanVien1 NhanVienUC;
    }
}