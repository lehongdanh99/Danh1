namespace QuanLiXe.UserControls
{
    partial class HopDongGui
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddCon = new System.Windows.Forms.Button();
            this.dgvCon = new System.Windows.Forms.DataGridView();
            this._DESKTOP_RRRHOP4HD = new QuanLiXe._DESKTOP_RRRHOP4HD();
            this.hOPDONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOPDONGTableAdapter = new QuanLiXe._DESKTOP_RRRHOP4HDTableAdapters.HOPDONGTableAdapter();
            this.maHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoihanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybatdauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayketthucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DESKTOP_RRRHOP4HD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOPDONGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(18, 72);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(428, 43);
            this.txtSearch.TabIndex = 6;
            // 
            // btnAddCon
            // 
            this.btnAddCon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCon.BackColor = System.Drawing.Color.Teal;
            this.btnAddCon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCon.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCon.ForeColor = System.Drawing.Color.White;
            this.btnAddCon.Location = new System.Drawing.Point(803, 59);
            this.btnAddCon.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCon.Name = "btnAddCon";
            this.btnAddCon.Size = new System.Drawing.Size(259, 56);
            this.btnAddCon.TabIndex = 5;
            this.btnAddCon.Text = "Thêm hợp đồng";
            this.btnAddCon.UseVisualStyleBackColor = false;
            this.btnAddCon.Click += new System.EventHandler(this.btnAddCon_Click);
            // 
            // dgvCon
            // 
            this.dgvCon.AllowUserToResizeColumns = false;
            this.dgvCon.AllowUserToResizeRows = false;
            this.dgvCon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCon.AutoGenerateColumns = false;
            this.dgvCon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCon.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("UVN Anh Hai", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHDDataGridViewTextBoxColumn,
            this.maKHDataGridViewTextBoxColumn,
            this.thoihanDataGridViewTextBoxColumn,
            this.ngaybatdauDataGridViewTextBoxColumn,
            this.ngayketthucDataGridViewTextBoxColumn,
            this.tienDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dgvCon.DataSource = this.hOPDONGBindingSource;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCon.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCon.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCon.Location = new System.Drawing.Point(18, 125);
            this.dgvCon.Name = "dgvCon";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("UVN Anh Hai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCon.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCon.RowHeadersVisible = false;
            this.dgvCon.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvCon.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCon.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCon.Size = new System.Drawing.Size(1044, 658);
            this.dgvCon.TabIndex = 62;
            this.dgvCon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCon_CellContentClick);
            this.dgvCon.DoubleClick += new System.EventHandler(this.dgvCon_DoubleClick);
            // 
            // _DESKTOP_RRRHOP4HD
            // 
            this._DESKTOP_RRRHOP4HD.DataSetName = "_DESKTOP_RRRHOP4HD";
            this._DESKTOP_RRRHOP4HD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOPDONGBindingSource
            // 
            this.hOPDONGBindingSource.DataMember = "HOPDONG";
            this.hOPDONGBindingSource.DataSource = this._DESKTOP_RRRHOP4HD;
            // 
            // hOPDONGTableAdapter
            // 
            this.hOPDONGTableAdapter.ClearBeforeFill = true;
            // 
            // maHDDataGridViewTextBoxColumn
            // 
            this.maHDDataGridViewTextBoxColumn.DataPropertyName = "maHD";
            this.maHDDataGridViewTextBoxColumn.HeaderText = "Mã HD";
            this.maHDDataGridViewTextBoxColumn.Name = "maHDDataGridViewTextBoxColumn";
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            this.maKHDataGridViewTextBoxColumn.DataPropertyName = "maKH";
            this.maKHDataGridViewTextBoxColumn.HeaderText = "Mã KH";
            this.maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
            // 
            // thoihanDataGridViewTextBoxColumn
            // 
            this.thoihanDataGridViewTextBoxColumn.DataPropertyName = "thoihan";
            this.thoihanDataGridViewTextBoxColumn.HeaderText = "Thời hạn";
            this.thoihanDataGridViewTextBoxColumn.Name = "thoihanDataGridViewTextBoxColumn";
            // 
            // ngaybatdauDataGridViewTextBoxColumn
            // 
            this.ngaybatdauDataGridViewTextBoxColumn.DataPropertyName = "ngaybatdau";
            this.ngaybatdauDataGridViewTextBoxColumn.HeaderText = "Ngày bắt đầu";
            this.ngaybatdauDataGridViewTextBoxColumn.Name = "ngaybatdauDataGridViewTextBoxColumn";
            // 
            // ngayketthucDataGridViewTextBoxColumn
            // 
            this.ngayketthucDataGridViewTextBoxColumn.DataPropertyName = "ngayketthuc";
            this.ngayketthucDataGridViewTextBoxColumn.HeaderText = "Ngày kết thúc";
            this.ngayketthucDataGridViewTextBoxColumn.Name = "ngayketthucDataGridViewTextBoxColumn";
            // 
            // tienDataGridViewTextBoxColumn
            // 
            this.tienDataGridViewTextBoxColumn.DataPropertyName = "tien";
            this.tienDataGridViewTextBoxColumn.HeaderText = "Thanh toán";
            this.tienDataGridViewTextBoxColumn.Name = "tienDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Ghi chú";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Loại HD";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(526, 59);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(259, 56);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm Hợp Đồng";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // HopDongGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.dgvCon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAddCon);
            this.Name = "HopDongGui";
            this.Size = new System.Drawing.Size(1080, 800);
            this.Load += new System.EventHandler(this.HopDongGui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DESKTOP_RRRHOP4HD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOPDONGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddCon;
        private System.Windows.Forms.DataGridView dgvCon;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoihanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaybatdauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayketthucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hOPDONGBindingSource;
        private _DESKTOP_RRRHOP4HD _DESKTOP_RRRHOP4HD;
        private _DESKTOP_RRRHOP4HDTableAdapters.HOPDONGTableAdapter hOPDONGTableAdapter;
        private System.Windows.Forms.Button btnSearch;
    }
}
