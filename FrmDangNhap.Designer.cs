
namespace QuanLyThuVien
{
    partial class FrmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangNhap));
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.checkboxHienMatKhau = new System.Windows.Forms.CheckBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.cbbVaiTro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(115, 200);
            this.txtTenTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenTaiKhoan.Multiline = true;
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(215, 25);
            this.txtTenTaiKhoan.TabIndex = 13;
            this.txtTenTaiKhoan.Text = "Nhập tên tài khoản";
            this.txtTenTaiKhoan.Enter += new System.EventHandler(this.txtTenTaiKhoan_Enter);
            this.txtTenTaiKhoan.Leave += new System.EventHandler(this.txtTenTaiKhoan_Leave);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(114, 239);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(216, 25);
            this.txtMatKhau.TabIndex = 14;
            // 
            // checkboxHienMatKhau
            // 
            this.checkboxHienMatKhau.AutoSize = true;
            this.checkboxHienMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.checkboxHienMatKhau.ForeColor = System.Drawing.SystemColors.Control;
            this.checkboxHienMatKhau.Location = new System.Drawing.Point(115, 271);
            this.checkboxHienMatKhau.Name = "checkboxHienMatKhau";
            this.checkboxHienMatKhau.Size = new System.Drawing.Size(109, 17);
            this.checkboxHienMatKhau.TabIndex = 15;
            this.checkboxHienMatKhau.Text = "Hiển thị mật khẩu";
            this.checkboxHienMatKhau.UseVisualStyleBackColor = false;
            this.checkboxHienMatKhau.CheckedChanged += new System.EventHandler(this.checkboxHienMatKhau_CheckedChanged);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(115, 322);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(75, 23);
            this.btnDangNhap.TabIndex = 16;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(66, 231);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(132, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(134, 146);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(196, 321);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(75, 23);
            this.btnDangKy.TabIndex = 21;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // cbbVaiTro
            // 
            this.cbbVaiTro.FormattingEnabled = true;
            this.cbbVaiTro.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.cbbVaiTro.Location = new System.Drawing.Point(115, 294);
            this.cbbVaiTro.Name = "cbbVaiTro";
            this.cbbVaiTro.Size = new System.Drawing.Size(156, 21);
            this.cbbVaiTro.TabIndex = 22;
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(399, 386);
            this.Controls.Add(this.cbbVaiTro);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.checkboxHienMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.MaximizeBox = false;
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.FrmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.CheckBox checkboxHienMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.ComboBox cbbVaiTro;
    }
}

