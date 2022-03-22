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


    }
}
