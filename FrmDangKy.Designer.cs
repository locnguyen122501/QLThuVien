
namespace QuanLyThuVien
{
    partial class FrmDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangKy));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtXacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkboxHienMatKhau = new System.Windows.Forms.CheckBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTroVeDangNhap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(132, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(134, 146);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(150, 212);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(215, 20);
            this.txtMatKhau.TabIndex = 22;
            // 
            // txtXacNhanMatKhau
            // 
            this.txtXacNhanMatKhau.Location = new System.Drawing.Point(150, 249);
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.PasswordChar = '*';
            this.txtXacNhanMatKhau.Size = new System.Drawing.Size(215, 20);
            this.txtXacNhanMatKhau.TabIndex = 23;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(150, 177);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(215, 20);
            this.txtTenTaiKhoan.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tên tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mật khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nhập lại mật khẩu:";
            // 
            // checkboxHienMatKhau
            // 
            this.checkboxHienMatKhau.AutoSize = true;
            this.checkboxHienMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.checkboxHienMatKhau.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxHienMatKhau.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkboxHienMatKhau.Location = new System.Drawing.Point(150, 275);
            this.checkboxHienMatKhau.Name = "checkboxHienMatKhau";
            this.checkboxHienMatKhau.Size = new System.Drawing.Size(146, 23);
            this.checkboxHienMatKhau.TabIndex = 28;
            this.checkboxHienMatKhau.Text = "Hiển thị mật khẩu";
            this.checkboxHienMatKhau.UseVisualStyleBackColor = false;
            this.checkboxHienMatKhau.CheckedChanged += new System.EventHandler(this.checkboxHienMatKhau_CheckedChanged);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(150, 304);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(75, 23);
            this.btnDangKy.TabIndex = 29;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(231, 304);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 30;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 19);
            this.label4.TabIndex = 31;
            this.label4.Text = "Bạn đã có tài khoản?";
            // 
            // lbTroVeDangNhap
            // 
            this.lbTroVeDangNhap.AutoSize = true;
            this.lbTroVeDangNhap.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTroVeDangNhap.ForeColor = System.Drawing.Color.Gold;
            this.lbTroVeDangNhap.Location = new System.Drawing.Point(146, 349);
            this.lbTroVeDangNhap.Name = "lbTroVeDangNhap";
            this.lbTroVeDangNhap.Size = new System.Drawing.Size(83, 19);
            this.lbTroVeDangNhap.TabIndex = 32;
            this.lbTroVeDangNhap.Text = "Đăng nhập";
            this.lbTroVeDangNhap.Click += new System.EventHandler(this.lbTroVeDangNhap_Click);
            // 
            // FrmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(399, 386);
            this.Controls.Add(this.lbTroVeDangNhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.checkboxHienMatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.Controls.Add(this.txtXacNhanMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.pictureBox3);
            this.MaximizeBox = false;
            this.Name = "FrmDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký tài khoản";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDangKy_FormClosing);
            this.Load += new System.EventHandler(this.FrmDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtXacNhanMatKhau;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkboxHienMatKhau;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTroVeDangNhap;
    }
}