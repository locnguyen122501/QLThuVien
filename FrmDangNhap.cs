using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class FrmDangNhap : Form
    {
        //DBQuanLyThuVienDataContext db = new DBQuanLyThuVienDataContext();
        private List<Taikhoan> tk = new List<Taikhoan>();
        private const String URI = "http://localhost:3002/api/taikhoan";
        public FrmDangNhap()
        {
            InitializeComponent();
            this.ActiveControl = txtTenTaiKhoan;
            txtTenTaiKhoan.Focus();
        }

        private void GetAll()
        {
            //Tạo ra một đối tượng client để kết nối 
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            String json = client.DownloadString(URI); //HTTp GET, tạo Http Request, format json 
            tk = JsonConvert.DeserializeObject<List<Taikhoan>>(json); //Chuyển từ list thành đối tượng 
           
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            //GetAll();
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
            /*if (txtTenTaiKhoan.Text.Trim().Length.Equals(0))
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
                
                
                
                //khac
                /*GetAll();
                string tk = txtTenTaiKhoan.Text;
                string mk = txtMatKhau.Text;
                
                char check = tk.SingleOrDefault(n => n. Equals(txtTenTaiKhoan.Text.Trim()) && n.Equals(txtMatKhau.Text.Trim()));
                if(check == null)
                {

                }
                //"khac" het tai day



                check = tk.SingleOrDefault(p => p.TK.Equals(txtTenTaiKhoan.Text.Trim()) && p.MK.Equals(txtMatKhau.Text.Trim()));
                if (check == null)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    checkrole = tk.SingleOrDefault(p => p.Quyen.Equals("User"));
                    //tk checkrole = tk.Where(p => p.Quyen.Equals("User")).ToList();
                    if(checkrole == null)
                    {
                        MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        FrmQuanLy frmQL = new FrmQuanLy();
                        frmQL.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        FrmChinh frmMain = new FrmChinh();
                        frmMain.ShowDialog();
                    }    
                }
            }*/

            MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        FrmChinh frmChinh = new FrmChinh();
                        frmChinh.ShowDialog();



            //code cũ của SQL Server
            /*else
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
            }*/
        }

        /*private void btnDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangKy frmDK = new FrmDangKy();
            frmDK.Show();
        }*/

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
