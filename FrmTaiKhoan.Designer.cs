
namespace QuanLyThuVien
{
    partial class FrmTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTaiKhoan));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSuaTT = new System.Windows.Forms.Button();
            this.btnThemTT = new System.Windows.Forms.Button();
            this.btnXoaTT = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.dgvThuThu = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.cbbMaThuThu = new System.Windows.Forms.ComboBox();
            this.cbbLoaiTaiKhoan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaTaiKhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuThu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox4.Controls.Add(this.btnSuaTT);
            this.groupBox4.Controls.Add(this.btnThemTT);
            this.groupBox4.Controls.Add(this.btnXoaTT);
            this.groupBox4.Controls.Add(this.btnHuy);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(904, 71);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 135);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
            // 
            // btnSuaTT
            // 
            this.btnSuaTT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTT.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaTT.Image")));
            this.btnSuaTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaTT.Location = new System.Drawing.Point(136, 28);
            this.btnSuaTT.Name = "btnSuaTT";
            this.btnSuaTT.Size = new System.Drawing.Size(93, 40);
            this.btnSuaTT.TabIndex = 4;
            this.btnSuaTT.Text = "Sửa";
            this.btnSuaTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaTT.UseVisualStyleBackColor = true;
            this.btnSuaTT.Click += new System.EventHandler(this.btnSuaTT_Click);
            // 
            // btnThemTT
            // 
            this.btnThemTT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTT.Image = ((System.Drawing.Image)(resources.GetObject("btnThemTT.Image")));
            this.btnThemTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemTT.Location = new System.Drawing.Point(32, 28);
            this.btnThemTT.Name = "btnThemTT";
            this.btnThemTT.Size = new System.Drawing.Size(93, 40);
            this.btnThemTT.TabIndex = 2;
            this.btnThemTT.Text = "Thêm";
            this.btnThemTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemTT.UseVisualStyleBackColor = true;
            this.btnThemTT.Click += new System.EventHandler(this.btnThemTT_Click);
            // 
            // btnXoaTT
            // 
            this.btnXoaTT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTT.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaTT.Image")));
            this.btnXoaTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaTT.Location = new System.Drawing.Point(32, 74);
            this.btnXoaTT.Name = "btnXoaTT";
            this.btnXoaTT.Size = new System.Drawing.Size(93, 40);
            this.btnXoaTT.TabIndex = 3;
            this.btnXoaTT.Text = "Xóa";
            this.btnXoaTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaTT.UseVisualStyleBackColor = true;
            this.btnXoaTT.Click += new System.EventHandler(this.btnXoaTT_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(136, 74);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(93, 40);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // dgvThuThu
            // 
            this.dgvThuThu.AllowUserToAddRows = false;
            this.dgvThuThu.AllowUserToDeleteRows = false;
            this.dgvThuThu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThuThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuThu.Location = new System.Drawing.Point(1, 314);
            this.dgvThuThu.Name = "dgvThuThu";
            this.dgvThuThu.ReadOnly = true;
            this.dgvThuThu.Size = new System.Drawing.Size(1196, 404);
            this.dgvThuThu.TabIndex = 30;
            this.dgvThuThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuThu_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.cbbMaThuThu);
            this.groupBox1.Controls.Add(this.cbbLoaiTaiKhoan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTenTaiKhoan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaTaiKhoan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 181);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(545, 90);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(220, 29);
            this.txtPass.TabIndex = 32;
            // 
            // cbbMaThuThu
            // 
            this.cbbMaThuThu.FormattingEnabled = true;
            this.cbbMaThuThu.Location = new System.Drawing.Point(153, 77);
            this.cbbMaThuThu.Name = "cbbMaThuThu";
            this.cbbMaThuThu.Size = new System.Drawing.Size(220, 32);
            this.cbbMaThuThu.TabIndex = 31;
            // 
            // cbbLoaiTaiKhoan
            // 
            this.cbbLoaiTaiKhoan.FormattingEnabled = true;
            this.cbbLoaiTaiKhoan.Location = new System.Drawing.Point(153, 121);
            this.cbbLoaiTaiKhoan.Name = "cbbLoaiTaiKhoan";
            this.cbbLoaiTaiKhoan.Size = new System.Drawing.Size(220, 32);
            this.cbbLoaiTaiKhoan.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(444, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Mật khẩu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(444, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tên tài khoản:";
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(545, 41);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(220, 26);
            this.txtTenTaiKhoan.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Loại tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mã thủ thư:";
            // 
            // txtMaTaiKhoan
            // 
            this.txtMaTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTaiKhoan.Location = new System.Drawing.Point(153, 41);
            this.txtMaTaiKhoan.Name = "txtMaTaiKhoan";
            this.txtMaTaiKhoan.Size = new System.Drawing.Size(220, 26);
            this.txtMaTaiKhoan.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã tài khoản:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(487, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(246, 39);
            this.label10.TabIndex = 33;
            this.label10.Text = "Quản lý tài khoản";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1197, 719);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvThuThu);
            this.Controls.Add(this.groupBox4);
            this.Name = "FrmTaiKhoan";
            this.Text = "FrmTaiKhoan";
            this.Load += new System.EventHandler(this.FrmTaiKhoan_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuThu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSuaTT;
        private System.Windows.Forms.Button btnThemTT;
        private System.Windows.Forms.Button btnXoaTT;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridView dgvThuThu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbbLoaiTaiKhoan;
        private System.Windows.Forms.ComboBox cbbMaThuThu;
        private System.Windows.Forms.TextBox txtPass;
    }
}