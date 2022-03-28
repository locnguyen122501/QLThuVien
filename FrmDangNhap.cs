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
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }


        private void txtTenTaiKhoan_Enter(object sender, EventArgs e)
        {
            if (txtTenTaiKhoan.Text == "Nhập tên tài khoản")
            {
                txtTenTaiKhoan.Text = "";
                txtTenTaiKhoan.ForeColor = Color.Black;
            }
        }

        private void txtTenTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (txtTenTaiKhoan.Text == "")
            {
                txtTenTaiKhoan.Text = "Nhập tên tài khoản";
                txtTenTaiKhoan.ForeColor = Color.DarkGray;
            }
        }


        private void checkboxHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxHienMatKhau.Checked)
            {
                txtMatKhau.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            
            cbbVaiTro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbVaiTro.SelectedItem = "Member";
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            FrmDangKy frmDK = new FrmDangKy();*/
            new FrmDangKy().Show();
            this.Hide();
        }

        private void FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            new FrmChinh().Show();
            this.Hide();
        }
    }
}
