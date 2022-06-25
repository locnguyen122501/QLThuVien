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
    public partial class FrmQLyThe : Form
    {
        private List<TheDocGia> the = new List<TheDocGia>();
        private const String URI = "http://localhost:3002/api/the";
        DataTable dataTable = new DataTable();
        public FrmQLyThe()
        {
            InitializeComponent();
        }

        private void GetAll()
        {

            //Tạo ra một đối tượng client để kết nối 
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            String json = client.DownloadString(URI); //HTTp GET, tạo Http Request, format json 
            the = JsonConvert.DeserializeObject<List<TheDocGia>>(json); //Chuyển từ list thành đối tượng 
            dgvThuThu.DataSource = the;

        }

        private void FrmQLyThe_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnThemThe_Click(object sender, EventArgs e)
        {
            try
            {

                //int selectedIndex = comboBox1.SelectedIndex;
                //Object selectedItem = comboBox1.SelectedItem;
                //Khởi tạo một thẻ mới 
                TheDocGia newthe = new TheDocGia()
                {
                    //Mã số tự động sinh ra nên cho bằng không 

                    MaThe = txtMaThe.Text.Trim(),
                    MaDocGia = int.Parse(txtMa.Text.Trim()),
                    NgayCapThe = dtNgayCapThe.Value,
                    NgayHetHan = dtNgayHetHan.Value,
                    MaTT = txtMaTT.Text.Trim()
                };

                String data = JsonConvert.SerializeObject(newthe); // Chuyển đối tượng sang JSON
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

        private void dgvThuThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvThuThu.Rows[e.RowIndex];
                txtMaThe.Text = row.Cells[0].Value.ToString();
                txtMa.Text = row.Cells[1].Value.ToString();
                dtNgayCapThe.Text = row.Cells[2].Value.ToString();
                dtNgayHetHan.Text = row.Cells[3].Value.ToString();
                txtMaTT.Text = row.Cells[4].Value.ToString();

            }
        }

        private void btnSuaThe_Click(object sender, EventArgs e)
        {
            try
            {
                TheDocGia newthe = new TheDocGia()
                {
                    //Mã số tự động sinh ra nên cho bằng không 
                    MaThe = txtMaThe.Text.Trim(),
                    MaDocGia = int.Parse(txtMa.Text.Trim()),
                    NgayCapThe = dtNgayCapThe.Value,
                    NgayHetHan = dtNgayHetHan.Value,
                    MaTT = txtMaTT.Text.Trim(),


                };
                String data = JsonConvert.SerializeObject(newthe); // Chuyển đối tượng sang JSON
                WebClient client = new WebClient();
                client.Encoding = System.Text.Encoding.UTF8;
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                String response = client.UploadString(URI + "/" + int.Parse(txtMa.Text.Trim()), "PUT", data);
                GetAll();
                MessageBox.Show("Đã cập nhật thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra");
            }
        }

        private void btnXoaThe_Click(object sender, EventArgs e)
        {
            string mathe = txtMaThe.Text.Trim();
            WebClient client = new WebClient();
            try
            {
                String json = client.UploadString(URI + "/delete/" + mathe, "DELETE", "");
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
