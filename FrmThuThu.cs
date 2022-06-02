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
    public partial class FrmThuThu : Form
    {
        private List<Thuthu> tt = new List<Thuthu>();
        private const String URI = "http://localhost:3002/api/thuthu";
        public FrmThuThu()
        {
            InitializeComponent();
            cbGt.Items.Add("Nam");
            cbGt.Items.Add("Nữ");
        }
        private void GetAll()
        {

            //Tạo ra một đối tượng client để kết nối 
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            String json = client.DownloadString(URI); //HTTp GET, tạo Http Request, format json 
            tt = JsonConvert.DeserializeObject<List<Thuthu>>(json); //Chuyển từ list thành đối tượng 
            dgvThuThu.DataSource = tt;
        }
        private void FrmThuThu_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnThemTT_Click(object sender, EventArgs e)
        {
            try
            {
                string newtt = tt.OrderByDescending(n => n.MaTT).Select(n => n.MaTT).FirstOrDefault() + 1;
                System.Object[] ItemObject = new System.Object[10];
                for (int i = 0; i <= 9; i++)
                {

                    ItemObject[i] = "Item" + i;
                }
                cbGt.Items.AddRange(ItemObject);

        
                //Khởi tạo một cuốn sách mới 
                Thuthu newThuthu = new Thuthu()
                {
                    //Mã số tự động sinh ra nên cho bằng không 
                    Hoten = txtHoTenThuThu.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim(),
                    SoDienThoai = txtSDT.Text.Trim(),
                    MaTT = txtMaThuThu.Text.Trim(),
                    NgaySinh = dtNgaySinh.Value,
                    GioiTinh = cbGt.Text.Trim()
                };

                String data = JsonConvert.SerializeObject(newThuthu); // Chuyển đối tượng sang JSON
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

        private void btnXoaTT_Click(object sender, EventArgs e)
        {
            string matt = txtMaThuThu.Text.Trim();
            WebClient client = new WebClient();
            try
            {
                String json = client.UploadString(URI + "/delete/" + matt, "DELETE", "");
                GetAll();
                MessageBox.Show("Đã xóa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra");
            }
        }

        private void dgvThuThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvThuThu.Rows[e.RowIndex];
                txtMaThuThu.Text = row.Cells[0].Value.ToString();
                txtHoTenThuThu.Text = row.Cells[1].Value.ToString();
                cbGt.Text = row.Cells[2].Value.ToString();
                txtDiaChi.Text = row.Cells[3].Value.ToString();
                dtNgaySinh.Text = row.Cells[4].Value.ToString();
                txtSDT.Text = row.Cells[5].Value.ToString();        
            }
        }

        private void btnSuaTT_Click(object sender, EventArgs e)
        {
            try
            {
                Thuthu newtt = new Thuthu()
                {
                    //Mã số tự động sinh ra nên cho bằng không 
                    MaTT = txtMaThuThu.Text.Trim(),
                    Hoten = txtHoTenThuThu.Text.Trim(),
                    GioiTinh = cbGt.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim(),
                    NgaySinh = dtNgaySinh.Value,
                    SoDienThoai = txtSDT.Text.Trim()           
                  
                   
                };
                String data = JsonConvert.SerializeObject(newtt); // Chuyển đối tượng sang JSON
                WebClient client = new WebClient();
                client.Encoding = System.Text.Encoding.UTF8;
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                String response = client.UploadString(URI + "/" + txtMaThuThu.Text.Trim(), "PUT", data);
                GetAll();
                MessageBox.Show("Đã cập nhật thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra");
            }
        }
    }
}
