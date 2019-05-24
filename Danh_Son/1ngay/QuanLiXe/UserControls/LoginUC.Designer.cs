namespace QuanLiXe
{
    partial class LoginUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUC));
            this.radioAdmin = new System.Windows.Forms.RadioButton();
            this.radioMember = new System.Windows.Forms.RadioButton();
            this.radioNhanVien = new System.Windows.Forms.RadioButton();
            this.ButtonRegister = new System.Windows.Forms.Button();
            this.button_LOGIN = new System.Windows.Forms.Button();
            this.button_CANCEL = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButtonTho = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioAdmin
            // 
            this.radioAdmin.AutoSize = true;
            this.radioAdmin.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAdmin.Location = new System.Drawing.Point(481, 319);
            this.radioAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioAdmin.Name = "radioAdmin";
            this.radioAdmin.Size = new System.Drawing.Size(149, 26);
            this.radioAdmin.TabIndex = 46;
            this.radioAdmin.TabStop = true;
            this.radioAdmin.Text = "Quản Trị Viên";
            this.radioAdmin.UseVisualStyleBackColor = true;
            // 
            // radioMember
            // 
            this.radioMember.AutoSize = true;
            this.radioMember.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMember.Location = new System.Drawing.Point(652, 288);
            this.radioMember.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioMember.Name = "radioMember";
            this.radioMember.Size = new System.Drawing.Size(130, 26);
            this.radioMember.TabIndex = 47;
            this.radioMember.TabStop = true;
            this.radioMember.Text = "Thành Viên";
            this.radioMember.UseVisualStyleBackColor = true;
            // 
            // radioNhanVien
            // 
            this.radioNhanVien.AutoSize = true;
            this.radioNhanVien.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNhanVien.Location = new System.Drawing.Point(481, 288);
            this.radioNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioNhanVien.Name = "radioNhanVien";
            this.radioNhanVien.Size = new System.Drawing.Size(122, 26);
            this.radioNhanVien.TabIndex = 45;
            this.radioNhanVien.TabStop = true;
            this.radioNhanVien.Text = "Nhân Viên";
            this.radioNhanVien.UseVisualStyleBackColor = true;
            // 
            // ButtonRegister
            // 
            this.ButtonRegister.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRegister.ForeColor = System.Drawing.Color.DarkBlue;
            this.ButtonRegister.Location = new System.Drawing.Point(415, 410);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(307, 54);
            this.ButtonRegister.TabIndex = 44;
            this.ButtonRegister.Text = "Register";
            this.ButtonRegister.UseVisualStyleBackColor = false;
            // 
            // button_LOGIN
            // 
            this.button_LOGIN.BackColor = System.Drawing.Color.LightGreen;
            this.button_LOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LOGIN.ForeColor = System.Drawing.Color.DarkGreen;
            this.button_LOGIN.Location = new System.Drawing.Point(578, 350);
            this.button_LOGIN.Name = "button_LOGIN";
            this.button_LOGIN.Size = new System.Drawing.Size(145, 54);
            this.button_LOGIN.TabIndex = 43;
            this.button_LOGIN.Text = "Login";
            this.button_LOGIN.UseVisualStyleBackColor = false;
            this.button_LOGIN.Click += new System.EventHandler(this.button_LOGIN_Click);
            // 
            // button_CANCEL
            // 
            this.button_CANCEL.BackColor = System.Drawing.Color.Coral;
            this.button_CANCEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CANCEL.ForeColor = System.Drawing.Color.Maroon;
            this.button_CANCEL.Location = new System.Drawing.Point(415, 350);
            this.button_CANCEL.Name = "button_CANCEL";
            this.button_CANCEL.Size = new System.Drawing.Size(157, 54);
            this.button_CANCEL.TabIndex = 42;
            this.button_CANCEL.Text = "Cancel";
            this.button_CANCEL.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(511, 245);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(212, 35);
            this.txtPassword.TabIndex = 40;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(511, 170);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(212, 35);
            this.txtUsername.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(508, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 26);
            this.label3.TabIndex = 38;
            this.label3.Text = "Mật Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(505, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 26);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tên Đăng Nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(446, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 46);
            this.label1.TabIndex = 36;
            this.label1.Text = "Đăng Nhập";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(172, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // radioButtonTho
            // 
            this.radioButtonTho.AutoSize = true;
            this.radioButtonTho.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTho.Location = new System.Drawing.Point(652, 318);
            this.radioButtonTho.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonTho.Name = "radioButtonTho";
            this.radioButtonTho.Size = new System.Drawing.Size(111, 26);
            this.radioButtonTho.TabIndex = 46;
            this.radioButtonTho.TabStop = true;
            this.radioButtonTho.Text = "Giám Sát";
            this.radioButtonTho.UseVisualStyleBackColor = true;
            // 
            // LoginUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.radioButtonTho);
            this.Controls.Add(this.radioAdmin);
            this.Controls.Add(this.radioMember);
            this.Controls.Add(this.radioNhanVien);
            this.Controls.Add(this.ButtonRegister);
            this.Controls.Add(this.button_LOGIN);
            this.Controls.Add(this.button_CANCEL);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Location = new System.Drawing.Point(350, 0);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginUC";
            this.Size = new System.Drawing.Size(894, 509);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonRegister;
        private System.Windows.Forms.Button button_LOGIN;
        private System.Windows.Forms.Button button_CANCEL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.RadioButton radioAdmin;
        public System.Windows.Forms.RadioButton radioMember;
        public System.Windows.Forms.RadioButton radioNhanVien;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtUsername;
        public System.Windows.Forms.RadioButton radioButtonTho;
    }
}
