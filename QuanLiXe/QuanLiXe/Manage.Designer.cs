namespace QuanLiXe
{
    partial class Manage
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
            this.btnGui = new System.Windows.Forms.Button();
            this.btnQuanLy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGui
            // 
            this.btnGui.Location = new System.Drawing.Point(111, 97);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(92, 60);
            this.btnGui.TabIndex = 0;
            this.btnGui.Text = "Gửi Xe";
            this.btnGui.UseVisualStyleBackColor = true;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.Location = new System.Drawing.Point(302, 97);
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Size = new System.Drawing.Size(92, 60);
            this.btnQuanLy.TabIndex = 0;
            this.btnQuanLy.Text = "Quản Lý";
            this.btnQuanLy.UseVisualStyleBackColor = true;
            this.btnQuanLy.Click += new System.EventHandler(this.btnQuanLy_Click);
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 293);
            this.Controls.Add(this.btnQuanLy);
            this.Controls.Add(this.btnGui);
            this.Name = "Manage";
            this.Text = "Manage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.Button btnQuanLy;
    }
}