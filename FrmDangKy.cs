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
    public partial class FrmDangKy : Form
    {
        DBQuanLyThuVienDataContext db = new DBQuanLyThuVienDataContext();
        public FrmDangKy()
        {
            InitializeComponent();
            this.ActiveControl = txtTenTaiKhoan;
            txtTenTaiKhoan.Focus();
        }

        private void FrmDangKy_Load(object sender, EventArgs e)
        {

        }
        private void checkboxHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxHienMatKhau.Checked)
            {
                txtMatKhau.PasswordChar = '\0';
                txtXacNhanMatKhau.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
                txtXacNhanMatKhau.PasswordChar = '*';
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtTenTaiKhoan.Text.Trim().Length.Equals(0))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTaiKhoan.Focus();
            }
            else
            {
                if (txtMatKhau.Text.Trim().Length.Equals(0))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhau.Focus();
                }
                else
                {
                    if(txtXacNhanMatKhau.Text.Trim().Length.Equals(0))
                    {
                        MessageBox.Show("Vui lòng xác nhận lại mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtXacNhanMatKhau.Focus();
                    }
                    else
                    {
                        TaiKhoan check = db.TaiKhoans.SingleOrDefault(n => n.TK.Equals(txtTenTaiKhoan.Text.Trim()));
                        if (check == null)
                        {
                            TaiKhoan tk = new TaiKhoan();
                            //db.TaiKhoan.Add(tk);
                            
                        }
                    }
                }
            }
            
        }

        private void lbTroVeDangNhap_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            FrmDangNhap frmDN = new FrmDangNhap();*/
            this.Hide();
            FrmDangNhap frmDN = new FrmDangNhap();
            frmDN.Show();
        }

        private void FrmDangKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            FrmDangNhap frmDN = new FrmDangNhap();
            frmDN.Show();
        }


    }
}
