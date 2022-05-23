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
    public partial class FrmTaiKhoan : Form
    {
        private List<Taikhoan> tk = new List<Taikhoan>();
        private const String URI = "http://localhost:3002/api/taikhoan";
        public FrmTaiKhoan()
        {
            InitializeComponent();
            cbbLoaiTaiKhoan.Items.Add("User");
            cbbLoaiTaiKhoan.Items.Add("Admin");
            cbbMaThuThu.Items.Add("TT001");
            cbbMaThuThu.Items.Add("TT002");
            cbbMaThuThu.Items.Add("TT003");
            cbbMaThuThu.Items.Add("TT004");
        }

        private void FrmTaiKhoan_Load(object sender, EventArgs e)
        {
            GetAll();
        }
        private void GetAll()
        {

            //Tạo ra một đối tượng client để kết nối 
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            String json = client.DownloadString(URI); //HTTp GET, tạo Http Request, format json 
            tk = JsonConvert.DeserializeObject<List<Taikhoan>>(json); //Chuyển từ list thành đối tượng 
            dgvThuThu.DataSource = tk;
        }

        private void dgvThuThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvThuThu.Rows[e.RowIndex];
                txtMaTaiKhoan.Text = row.Cells[0].Value.ToString();
                txtTenTaiKhoan.Text = row.Cells[1].Value.ToString();
                txtPass.Text = row.Cells[2].Value.ToString();
                cbbMaThuThu.Text = row.Cells[3].Value.ToString();
                cbbLoaiTaiKhoan.Text = row.Cells[4].Value.ToString();
            }
            }

        private void btnThemTT_Click(object sender, EventArgs e)
        {
            try
            {
             
                int newMa = tk.OrderByDescending(n => n.MaTK).Select(n => n.MaTK).FirstOrDefault() + 1;
                System.Object[] ItemObject = new System.Object[10];
                for (int i = 0; i <= 9; i++)
                {

                    ItemObject[i] = "Item" + i;
                }
                cbbMaThuThu.Items.AddRange(ItemObject);
                cbbLoaiTaiKhoan.Items.AddRange(ItemObject);
                //int selectedIndex = comboBox1.SelectedIndex;
                //Object selectedItem = comboBox1.SelectedItem;
                //Khởi tạo một cuốn sách mới 
                Taikhoan newtk = new Taikhoan()
                {
                    //Mã số tự động sinh ra nên cho bằng không                   
                    TK = txtTenTaiKhoan.Text.Trim(),
                    MK = txtPass.Text.Trim(),
                    MaTT = cbbMaThuThu.Text.Trim(),
                    Quyen = cbbLoaiTaiKhoan.Text.Trim()


                };

                String data = JsonConvert.SerializeObject(newtk); // Chuyển đối tượng sang JSON
                WebClient client = new WebClient();
                client.Encoding = System.Text.Encoding.UTF8;
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                String response = client.UploadString(URI, "POST", data);   //Http Post
                GetAll();
                MessageBox.Show("Đã thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra");
            }
        }

        private void btnSuaTT_Click(object sender, EventArgs e)
        {
            try
            {
                Taikhoan newtk = new Taikhoan()
                {
                    //Mã số tự động sinh ra nên cho bằng không 
                    MaTK = int.Parse(txtMaTaiKhoan.Text.Trim()),
                    TK = txtTenTaiKhoan.Text.Trim(),
                    MK = txtPass.Text.Trim(),
                    MaTT = cbbMaThuThu.Text.Trim(),
                    Quyen = cbbLoaiTaiKhoan.Text.Trim()
                };
                String data = JsonConvert.SerializeObject(newtk); // Chuyển đối tượng sang JSON
                WebClient client = new WebClient();
                client.Encoding = System.Text.Encoding.UTF8;
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                String response = client.UploadString(URI + "/" + int.Parse(txtMaTaiKhoan.Text.Trim()), "PUT", data);
                GetAll();
                MessageBox.Show("Đã cập nhật thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra");
            }
        }

        private void btnXoaTT_Click(object sender, EventArgs e)
        {
            int manxb = int.Parse(txtMaTaiKhoan.Text.Trim());
            WebClient client = new WebClient();
            try
            {
                String json = client.UploadString(URI + "/delete/" + manxb, "DELETE", "");
                GetAll();
                MessageBox.Show("Đã xóa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra");
            }
        }
    }
}

