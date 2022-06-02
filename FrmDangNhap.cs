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
        private List<Taikhoan> users = new List<Taikhoan>();
        private const String URI = "http://localhost:3002/api/taikhoan";
        public FrmDangNhap()
        {
            InitializeComponent();
            this.ActiveControl = txtTenTaiKhoan;
            txtTenTaiKhoan.Focus();
        }

        private void GetAllUsers()
        {
            //Tạo ra một đối tượng client để kết nối 
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            String json = client.DownloadString(URI); //HTTp GET, tạo Http Request, format json 
            users = JsonConvert.DeserializeObject<List<Taikhoan>>(json); //Chuyển từ json thành đối tượng List<Taikhoan>
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

        /// <summary>
        /// Step 1: Lất toàn bộ danh sách user từ database thông qua api/user
        /// Step 2: Kiểm tra đầu vào người dùng nhập username và password
        /// Step 3: So sánh đầu vào và database
        /// Case: Đúng -> Frm...
        /// Case: Sai -> Error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            /*try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }*/

            // Get all list users from api
            GetAllUsers();

            // Check input username
            if (txtTenTaiKhoan.Text.Trim().Length.Equals(0)) // Case: Check exist input
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
            else // Case: Check user 
            {
                // Dung linQ
                var user = users.Where(n => n.TK.CompareTo(txtTenTaiKhoan.Text) == 0 && n.MK.CompareTo(txtMatKhau.Text) == 0).FirstOrDefault();
                if (user == null) // Case: Không tồn tại tài khoản
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else // Case: Đăng nhập thành công
                {
                    //check quyen user
                    var checkrole = users.Where(n => n.TK.CompareTo(txtTenTaiKhoan.Text) == 0 && n.MK.CompareTo(txtMatKhau.Text) == 0 && n.Quyen.Contains("User")).FirstOrDefault();
                    if (checkrole == null) //neu khong phai role User thi vao form quan ly cua admin
                    {
                        MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        FrmQuanLy frmQuanLy = new FrmQuanLy();
                        frmQuanLy.ShowDialog();
                    }
                    else //neu dung thi vao form quan ly cua thu thug
                    {
                        MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        FrmChinh frmChinh = new FrmChinh();
                        frmChinh.ShowDialog();
                    }
                }
            }
        }
           


        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
