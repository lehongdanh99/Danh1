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
            this.dgvCon = new System.Windows.Forms.DataGridView();
            this.btnAddCon = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCon
            // 
            this.dgvCon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCon.Location = new System.Drawing.Point(3, 146);
            this.dgvCon.Name = "dgvCon";
            this.dgvCon.RowTemplate.Height = 24;
            this.dgvCon.Size = new System.Drawing.Size(1160, 387);
            this.dgvCon.TabIndex = 0;
            // 
            // btnAddCon
            // 
            this.btnAddCon.Location = new System.Drawing.Point(881, 59);
            this.btnAddCon.Name = "btnAddCon";
            this.btnAddCon.Size = new System.Drawing.Size(185, 47);
            this.btnAddCon.TabIndex = 1;
            this.btnAddCon.Text = "Thêm Hợp Động";
            this.btnAddCon.UseVisualStyleBackColor = true;
            this.btnAddCon.Click += new System.EventHandler(this.btnAddCon_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(37, 59);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(569, 52);
            this.txtSearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // HopDongGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddCon);
            this.Controls.Add(this.dgvCon);
            this.Name = "HopDongGui";
            this.Size = new System.Drawing.Size(1163, 536);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCon;
        private System.Windows.Forms.Button btnAddCon;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
    }
}
