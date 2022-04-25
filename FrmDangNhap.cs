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
        DBQuanLyThuVienDataContext db = new DBQuanLyThuVienDataContext();
        public FrmDangNhap()
        {
            InitializeComponent();
            this.ActiveControl = txtTenTaiKhoan;
            txtTenTaiKhoan.Focus();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {          

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

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenTaiKhoan.Text.Trim().Length.Equals(0))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTaiKhoan.Focus();
            }
            else
            if (txtMatKhau.Text.Trim().Length.Equals(0))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
            }
            else
            {
                TaiKhoan check = db.TaiKhoans.SingleOrDefault(n => n.TK.Equals(txtTenTaiKhoan.Text.Trim()) && n.MK.Equals(txtMatKhau.Text.Trim()));

                if (check == null)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    TaiKhoan checkrole = db.TaiKhoans.SingleOrDefault(n => n.TK.Equals(txtTenTaiKhoan.Text.Trim()) && n.MK.Equals(txtMatKhau.Text.Trim()) && n.Quyen.Equals("User"));
                    if(checkrole == null)
                    {
                        MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        FrmQuanLy frmQL = new FrmQuanLy();
                        frmQL.ShowDialog();
                    }
                    else
                    {
                        Model.maTT = check.MaTT;
                        MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        FrmChinh frmChinh = new FrmChinh();
                        frmChinh.ShowDialog();
                    }
                }
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangKy frmDK = new FrmDangKy();
            frmDK.Show();
        }
    }
}
