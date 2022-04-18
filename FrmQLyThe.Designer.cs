
namespace QuanLyThuVien
{
    partial class FrmQLyThe
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
            this.dgvThuThu = new System.Windows.Forms.DataGridView();
            this.gvMaThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvMaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvNgayCapThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvNgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvMaThuThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSuaThe = new System.Windows.Forms.Button();
            this.btnThemThe = new System.Windows.Forms.Button();
            this.btnXoaThe = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtNgayCapThe = new System.Windows.Forms.DateTimePicker();
            this.dtNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenDG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaThe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuThu)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.dgvThuThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvMaThe,
            this.gvMaDocGia,
            this.gvNgayCapThe,
            this.gvNgayHetHan,
            this.gvMaThuThu});
            this.dgvThuThu.Location = new System.Drawing.Point(1, 314);
            this.dgvThuThu.Name = "dgvThuThu";
            this.dgvThuThu.ReadOnly = true;
            this.dgvThuThu.Size = new System.Drawing.Size(1196, 404);
            this.dgvThuThu.TabIndex = 30;
            // 
            // gvMaThe
            // 
            this.gvMaThe.HeaderText = "Mã thẻ";
            this.gvMaThe.Name = "gvMaThe";
            this.gvMaThe.ReadOnly = true;
            // 
            // gvMaDocGia
            // 
            this.gvMaDocGia.HeaderText = "Mã đọc giả";
            this.gvMaDocGia.Name = "gvMaDocGia";
            this.gvMaDocGia.ReadOnly = true;
            // 
            // gvNgayCapThe
            // 
            this.gvNgayCapThe.HeaderText = "Ngày cấp thẻ";
            this.gvNgayCapThe.Name = "gvNgayCapThe";
            this.gvNgayCapThe.ReadOnly = true;
            // 
            // gvNgayHetHan
            // 
            this.gvNgayHetHan.HeaderText = "Ngày hết hạn";
            this.gvNgayHetHan.Name = "gvNgayHetHan";
            this.gvNgayHetHan.ReadOnly = true;
            // 
            // gvMaThuThu
            // 
            this.gvMaThuThu.HeaderText = "Mã thủ thư";
            this.gvMaThuThu.Name = "gvMaThuThu";
            this.gvMaThuThu.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox4.Controls.Add(this.btnSuaThe);
            this.groupBox4.Controls.Add(this.btnThemThe);
            this.groupBox4.Controls.Add(this.btnXoaThe);
            this.groupBox4.Controls.Add(this.btnHuy);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(904, 71);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 135);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
            // 
            // btnSuaThe
            // 
            this.btnSuaThe.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaThe.Location = new System.Drawing.Point(136, 36);
            this.btnSuaThe.Name = "btnSuaThe";
            this.btnSuaThe.Size = new System.Drawing.Size(90, 30);
            this.btnSuaThe.TabIndex = 4;
            this.btnSuaThe.Text = "Sửa";
            this.btnSuaThe.UseVisualStyleBackColor = true;
            // 
            // btnThemThe
            // 
            this.btnThemThe.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemThe.Location = new System.Drawing.Point(31, 36);
            this.btnThemThe.Name = "btnThemThe";
            this.btnThemThe.Size = new System.Drawing.Size(90, 30);
            this.btnThemThe.TabIndex = 2;
            this.btnThemThe.Text = "Thêm";
            this.btnThemThe.UseVisualStyleBackColor = true;
            // 
            // btnXoaThe
            // 
            this.btnXoaThe.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaThe.Location = new System.Drawing.Point(31, 71);
            this.btnXoaThe.Name = "btnXoaThe";
            this.btnXoaThe.Size = new System.Drawing.Size(90, 30);
            this.btnXoaThe.TabIndex = 3;
            this.btnXoaThe.Text = "Xóa";
            this.btnXoaThe.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(136, 71);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(90, 30);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
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
            this.label10.Size = new System.Drawing.Size(167, 39);
            this.label10.TabIndex = 21;
            this.label10.Text = "Quản lý thẻ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.dtNgayCapThe);
            this.groupBox1.Controls.Add(this.dtNgayHetHan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTenDG);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaThe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 232);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thẻ";
            // 
            // dtNgayCapThe
            // 
            this.dtNgayCapThe.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayCapThe.Location = new System.Drawing.Point(545, 71);
            this.dtNgayCapThe.Name = "dtNgayCapThe";
            this.dtNgayCapThe.Size = new System.Drawing.Size(220, 29);
            this.dtNgayCapThe.TabIndex = 30;
            // 
            // dtNgayHetHan
            // 
            this.dtNgayHetHan.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayHetHan.Location = new System.Drawing.Point(545, 130);
            this.dtNgayHetHan.Name = "dtNgayHetHan";
            this.dtNgayHetHan.Size = new System.Drawing.Size(220, 29);
            this.dtNgayHetHan.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(444, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Ngày hết hạn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(444, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ngày cấp thẻ:";
            // 
            // txtTenDG
            // 
            this.txtTenDG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDG.Location = new System.Drawing.Point(136, 130);
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.Size = new System.Drawing.Size(220, 26);
            this.txtTenDG.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên đọc giả:";
            // 
            // txtMaThe
            // 
            this.txtMaThe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThe.Location = new System.Drawing.Point(136, 71);
            this.txtMaThe.Name = "txtMaThe";
            this.txtMaThe.Size = new System.Drawing.Size(220, 26);
            this.txtMaThe.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã thẻ:";
            // 
            // FrmQLyThe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1197, 719);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgvThuThu);
            this.Name = "FrmQLyThe";
            this.Text = "FrmThe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuThu)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThuThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvMaThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvMaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvNgayCapThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvNgayHetHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvMaThuThu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSuaThe;
        private System.Windows.Forms.Button btnThemThe;
        private System.Windows.Forms.Button btnXoaThe;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtNgayHetHan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenDG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaThe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtNgayCapThe;
    }
}