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
    public partial class FrmDocGia : Form
    {
        private List<Docgia> docgia = new List<Docgia>();
        private const String URI = "http://localhost:3002/api/docgia";
        DataTable dataTable = new DataTable();
        public FrmDocGia()
        {
            InitializeComponent();
            cbGioitinh.Items.Add("Nam");
            cbGioitinh.Items.Add("Nữ");
        }

        private void GetAll()
        {

            //Tạo ra một đối tượng client để kết nối 
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            String json = client.DownloadString(URI); //HTTp GET, tạo Http Request, format json 
            docgia = JsonConvert.DeserializeObject<List<Docgia>>(json); //Chuyển từ list thành đối tượng 
            dgvDocGia.DataSource = docgia;
     
        }

        private void FrmDocGia_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnThemDG_Click(object sender, EventArgs e)
        {
            try
            {

                // Get new Id
                int newId = docgia.OrderByDescending(n => n.MaDocGia).Select(n => n.MaDocGia).FirstOrDefault() + 1;
                System.Object[] ItemObject = new System.Object[10];
                for (int i = 0; i <= 9; i++)
                {

                    ItemObject[i] = "Item" + i;
                }


                //int selectedIndex = comboBox1.SelectedIndex;
                //Object selectedItem = comboBox1.SelectedItem;
                //Khởi tạo một cuốn sách mới 
                Docgia newdg = new Docgia()
                {
                    //Mã số tự động sinh ra nên cho bằng không 
                    MaDocGia = newId,
                    Hoten = txtHoTenDocGia.Text.Trim(),
                    GioiTinh = cbGioitinh.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim(),
                    NgaySinh = dtNgaySinh.Value,
                    SoDienThoai = txtSDT.Text.Trim()                    
                };

                String data = JsonConvert.SerializeObject(newdg); // Chuyển đối tượng sang JSON
                WebClient client = new WebClient();
                client.Encoding = System.Text.Encoding.UTF8;
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                String response = client.UploadString(URI, "POST", data);   //Http Post
                GetAll();
                MessageBox.Show("Đã thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã Bị Lỗi");
            }
        }

        private void btnXoaDG_Click(object sender, EventArgs e)
        {
            int madg = int.Parse(txtMaDocGia.Text.Trim());
            WebClient client = new WebClient();
            try
            {
                String json = client.UploadString(URI + "/delete/" + madg, "DELETE", "");
                GetAll();
                MessageBox.Show("Xóa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnSuaDG_Click(object sender, EventArgs e)
        {
            try
            {
                Docgia newdg = new Docgia()
                {
                    //Mã số tự động sinh ra nên cho bằng không 
                    MaDocGia = int.Parse(txtMaDocGia.Text.Trim()),
                    Hoten = txtHoTenDocGia.Text.Trim(),
                    GioiTinh = cbGioitinh.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim(),
                    NgaySinh= dtNgaySinh.Value,
                    SoDienThoai = txtSDT.Text.Trim()

                };
                String data = JsonConvert.SerializeObject(newdg); // Chuyển đối tượng sang JSON
                WebClient client2 = new WebClient();
                client2.Encoding = System.Text.Encoding.UTF8;
                client2.Headers[HttpRequestHeader.ContentType] = "application/json";
                String response = client2.UploadString(URI + "/" + int.Parse(txtMaDocGia.Text.Trim()), "PUT", data);
                GetAll();
                MessageBox.Show("Đã cập nhật thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã Bị Lỗi");
            }
        }

        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDocGia.Rows[e.RowIndex];
                txtMaDocGia.Text = row.Cells[0].Value.ToString();
                txtHoTenDocGia.Text = row.Cells[1].Value.ToString();
                cbGioitinh.Text = row.Cells[2].Value.ToString();
                txtDiaChi.Text = row.Cells[3].Value.ToString();
                dtNgaySinh.Text = row.Cells[4].Value.ToString();
                txtSDT.Text = row.Cells[5].Value.ToString();
            }
    }
    }
}
