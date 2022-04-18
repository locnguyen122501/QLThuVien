
namespace QuanLyThuVien
{
    partial class FrmThongKe
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
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.cbbSoSach = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gvMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSoLanMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AllowUserToAddRows = false;
            this.dgvThongKe.AllowUserToDeleteRows = false;
            this.dgvThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvMaSach,
            this.gvTenSach,
            this.gvSoLanMuon});
            this.dgvThongKe.Location = new System.Drawing.Point(1, 161);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.ReadOnly = true;
            this.dgvThongKe.Size = new System.Drawing.Size(1196, 557);
            this.dgvThongKe.TabIndex = 29;
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
            this.label10.Size = new System.Drawing.Size(138, 39);
            this.label10.TabIndex = 30;
            this.label10.Text = "Thống kê";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.Location = new System.Drawing.Point(42, 102);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(132, 39);
            this.btnXuatFile.TabIndex = 31;
            this.btnXuatFile.Text = "Xuất File Excel";
            this.btnXuatFile.UseVisualStyleBackColor = true;
            // 
            // cbbSoSach
            // 
            this.cbbSoSach.FormattingEnabled = true;
            this.cbbSoSach.Location = new System.Drawing.Point(812, 120);
            this.cbbSoSach.Name = "cbbSoSach";
            this.cbbSoSach.Size = new System.Drawing.Size(73, 21);
            this.cbbSoSach.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(891, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "cuốn sách được mượn nhiều nhất";
            // 
            // gvMaSach
            // 
            this.gvMaSach.HeaderText = "Mã sách";
            this.gvMaSach.Name = "gvMaSach";
            this.gvMaSach.ReadOnly = true;
            // 
            // gvTenSach
            // 
            this.gvTenSach.HeaderText = "Tên sách";
            this.gvTenSach.Name = "gvTenSach";
            this.gvTenSach.ReadOnly = true;
            // 
            // gvSoLanMuon
            // 
            this.gvSoLanMuon.HeaderText = "Số lần mượn";
            this.gvSoLanMuon.Name = "gvSoLanMuon";
            this.gvSoLanMuon.ReadOnly = true;
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 719);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbSoSach);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvThongKe);
            this.Name = "FrmThongKe";
            this.Text = "FrmThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.ComboBox cbbSoSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSoLanMuon;
    }
}