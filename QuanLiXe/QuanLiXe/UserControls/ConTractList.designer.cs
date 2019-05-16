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
            this.dgvCon.Location = new System.Drawing.Point(2, 119);
            this.dgvCon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCon.Name = "dgvCon";
            this.dgvCon.RowTemplate.Height = 24;
            this.dgvCon.Size = new System.Drawing.Size(870, 314);
            this.dgvCon.TabIndex = 0;
            // 
            // btnAddCon
            // 
            this.btnAddCon.Location = new System.Drawing.Point(661, 48);
            this.btnAddCon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddCon.Name = "btnAddCon";
            this.btnAddCon.Size = new System.Drawing.Size(139, 38);
            this.btnAddCon.TabIndex = 1;
            this.btnAddCon.Text = "Thêm Hợp Động";
            this.btnAddCon.UseVisualStyleBackColor = true;
            this.btnAddCon.Click += new System.EventHandler(this.btnAddCon_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(28, 48);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(428, 43);
            this.txtSearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // HopDongGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddCon);
            this.Controls.Add(this.dgvCon);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HopDongGui";
            this.Size = new System.Drawing.Size(872, 436);
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
