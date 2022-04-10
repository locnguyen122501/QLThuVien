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
    public partial class FrmChinh : Form
    {
        private Form activeForm;
        public FrmChinh()
        {
            InitializeComponent();
        }

        private void FrmChinh_Load(object sender, EventArgs e)
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

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmQLySach(), sender);
        }

        private void đọcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDocGia(), sender);
        }

        private void thủThưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmThuThu(), sender);
        }

        private void thẻToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmQLyThe(), sender);
        }

        private void tàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmTaiKhoan(), sender);
        }
    }
}
