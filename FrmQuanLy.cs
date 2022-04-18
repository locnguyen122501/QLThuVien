using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class FrmQuanLy : Form
    {
        private Form activeForm;
        public FrmQuanLy()
        {
            InitializeComponent();
        }

        private void FrmQuanLy_Load(object sender, EventArgs e)
        {

        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmTaiKhoan(), sender);
        }

        private void thủThưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmThuThu(), sender);
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmThongKe(), sender);
        }

        private void quyĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmQuyDinh(), sender);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                FrmDangNhap frmDN = new FrmDangNhap();
                frmDN.Show();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }



    }
}
