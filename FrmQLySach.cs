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
    public partial class FrmQLySach : Form
    {
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public override string ToString()
            {
                return Text;
            }

        }


        private List<Book> books = new List<Book>();
        private const String URI = "http://localhost:3002/api/book";

        private List<NXB> nxb = new List<NXB>();
        private const String URI2 = "http://localhost:3002/api/nhaxuatban";

        private List<Theloai> tl = new List<Theloai>();
        private const String URI3 = "http://localhost:3002/api/theloai";

        DataTable dataTable = new DataTable();

        public FrmQLySach()
        {
            InitializeComponent();
            cbbTenTL.Items.Add("GMBT");
            cbbTenTL.Items.Add("KTKH");
            cbbTenTL.Items.Add("TT");
            cbbTenTL.Items.Add("VHNC");
            cbbTenTL.Items.Add("VHVN");
            cbbTenTL.Items.Add("WB");
            cbbTinhTrangSach.Items.Add("Tốt");
            cbbTinhTrangSach.Items.Add("Xấu");



        }

        private void FrmQLySach_Load(object sender, EventArgs e)
        {
            GetAll();

        }


        // Tacgia
        private void dgvNXB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GetAll();
        }

        //theloai
        private void dgvTheLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GetAll();
        }

        private void GetAll()
        {

            //Tạo ra một đối tượng client để kết nối 
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            String json = client.DownloadString(URI); //HTTp GET, tạo Http Request, format json 
            books = JsonConvert.DeserializeObject<List<Book>>(json); //Chuyển từ list thành đối tượng 
            dgvSach.DataSource = books;
            //Tacgia
            WebClient client2 = new WebClient();
            String json2 = client.DownloadString(URI2);
            nxb = JsonConvert.DeserializeObject<List<NXB>>(json2);
            dgvNXB.DataSource = nxb;
            //Theloai
            WebClient client3 = new WebClient();
            String json3 = client.DownloadString(URI3); //HTTp GET, tạo Http Request, format json 
            tl = JsonConvert.DeserializeObject<List<Theloai>>(json3);
            dgvTheLoai.DataSource = tl;
        }


        private void btnThemSach_Click(object sender, EventArgs e)
        {
            try
            {

                // Get new Id
                int newId = books.OrderByDescending(n => n.MaSach).Select(n => n.MaSach).FirstOrDefault() + 1;
                System.Object[] ItemObject = new System.Object[10];
                for (int i = 0; i <= 9; i++)
                {

                    ItemObject[i] = "Item" + i;
                }
                cbbTenTL.Items.AddRange(ItemObject);
                cbbTinhTrangSach.Items.AddRange(ItemObject);

                //int selectedIndex = comboBox1.SelectedIndex;
                //Object selectedItem = comboBox1.SelectedItem;
                //Khởi tạo một cuốn sách mới 
                Book newBook = new Book()
                {
                    //Mã số tự động sinh ra nên cho bằng không 
                    MaSach = newId,
                    TenSach = txtTenSach.Text.Trim(),
                    TacGia = txtTacGia.Text.Trim(),
                    MaTheLoai = cbbTenTL.Text.Trim(),
                    MaNXB = int.Parse(txtNXB.Text.Trim()),
                    DonGia = int.Parse(txtDonGia.Text.Trim()),
                    SoLuongTon = int.Parse(txtSoLuongTon.Text.Trim()),
                    SoLanMuon = int.Parse(txtSoLanMuon.Text.Trim()),
                    TinhTrang = cbbTinhTrangSach.Text.Trim()
                };

                String data = JsonConvert.SerializeObject(newBook); // Chuyển đối tượng sang JSON
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

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            int masach = int.Parse(txtMaSach.Text.Trim());
            WebClient client = new WebClient();
            try
            {
                String json = client.UploadString(URI + "/delete/" + masach, "DELETE", "");
                GetAll();
                MessageBox.Show("Xóa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            try
            {
                Book newBook = new Book()
                {
                    //Mã số tự động sinh ra nên cho bằng không 
                    MaSach = int.Parse(txtMaSach.Text.Trim()),
                    TenSach = txtTenSach.Text.Trim(),
                    TacGia = txtTacGia.Text.Trim(),
                    MaTheLoai = cbbTenTL.Text.Trim(),
                    MaNXB = int.Parse(txtNXB.Text.Trim()),
                    DonGia = int.Parse(txtDonGia.Text.Trim()),
                    SoLuongTon = int.Parse(txtSoLuongTon.Text.Trim()),
                    SoLanMuon = int.Parse(txtSoLanMuon.Text.Trim()),
                    TinhTrang = cbbTinhTrangSach.Text.Trim()
                };
                String data = JsonConvert.SerializeObject(newBook); // Chuyển đối tượng sang JSON
                WebClient client = new WebClient();
                client.Encoding = System.Text.Encoding.UTF8;
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                String response = client.UploadString(URI + "/" + int.Parse(txtMaSach.Text.Trim()), "PUT", data);
                GetAll();
                MessageBox.Show("Đã cập nhật thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã Bị Lỗi");
            }
        }

        //NXB
        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            try
            {
                // Get new NXN
                int newMa = nxb.OrderByDescending(n => n.MaNXB).Select(n => n.MaNXB).FirstOrDefault() + 1;
                System.Object[] ItemObject = new System.Object[10];
                for (int i = 0; i <= 9; i++)
                {

                    ItemObject[i] = "Item" + i;
                }

                //int selectedIndex = comboBox1.SelectedIndex;
                //Object selectedItem = comboBox1.SelectedItem;
                //Khởi tạo một cuốn sách mới 
                NXB newNXB = new NXB()
                {
                    //Mã số tự động sinh ra nên cho bằng không 
                    MaNXB = newMa,
                    TenNXB = txtTenNXB.Text.Trim(),
                    DiaChi = txtDiaChiNXB.Text.Trim(),
                    NgayThanhLap = dtNgayThanhLap.Value


                };

                String data = JsonConvert.SerializeObject(newNXB); // Chuyển đối tượng sang JSON
                WebClient client2 = new WebClient();
                client2.Encoding = System.Text.Encoding.UTF8;
                client2.Headers[HttpRequestHeader.ContentType] = "application/json";
                String response = client2.UploadString(URI2, "POST", data);   //Http Post
                GetAll();
                MessageBox.Show("Đã thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã Bị Lỗi");
            }
        }

        private void btnXoaNXB_Click(object sender, EventArgs e)
        {
            int manxb = int.Parse(txtMaNXB.Text.Trim());
            WebClient client2 = new WebClient();
            try
            {
                String json = client2.UploadString(URI2 + "/delete/" + manxb, "DELETE", "");
                GetAll();
                MessageBox.Show("Xóa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnSuaNXB_Click(object sender, EventArgs e)
        {
            try
            {
                NXB newNXB = new NXB()
                {
                    //Mã số tự động sinh ra nên cho bằng không 
                    MaNXB = int.Parse(txtMaNXB.Text.Trim()),
                    TenNXB = txtTenNXB.Text.Trim(),
                    DiaChi = txtDiaChiNXB.Text.Trim(),
                    NgayThanhLap = dtNgayThanhLap.Value

                };
                String data = JsonConvert.SerializeObject(newNXB); // Chuyển đối tượng sang JSON
                WebClient client2 = new WebClient();
                client2.Encoding = System.Text.Encoding.UTF8;
                client2.Headers[HttpRequestHeader.ContentType] = "application/json";
                String response = client2.UploadString(URI2 + "/" + int.Parse(txtMaNXB.Text.Trim()), "PUT", data);
                GetAll();
                MessageBox.Show("Đã cập nhật thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã Bị Lỗi");
            }
        }

        // Dieu chinh loai

        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            try
            {

                Theloai newTL = new Theloai()
                {
                    //Mã số tự động sinh ra nên cho bằng không 
                    MaTheLoai = txtMaTheLoai.Text.Trim(),
                    TenLoai = txtTenTheLoai.Text.Trim()

                };

                String data = JsonConvert.SerializeObject(newTL); // Chuyển đối tượng sang JSON
                WebClient client = new WebClient();
                client.Encoding = System.Text.Encoding.UTF8;
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                String response = client.UploadString(URI3, "POST", data);   //Http Post
                GetAll();
                MessageBox.Show("Đã thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã Bị Lỗi");
            }
        }

        private void btnSuaTheLoai_Click(object sender, EventArgs e)
        {
            try
            {
                Theloai newTL = new Theloai()
                {
                    //Mã số tự động sinh ra nên cho bằng không 
                    MaTheLoai = txtMaTheLoai.Text.Trim(),
                    TenLoai = txtTenTheLoai.Text.Trim()
                };
                String data = JsonConvert.SerializeObject(newTL); // Chuyển đối tượng sang JSON
                WebClient client3 = new WebClient();
                client3.Encoding = System.Text.Encoding.UTF8;
                client3.Headers[HttpRequestHeader.ContentType] = "application/json";
                String response = client3.UploadString(URI3 + "/" + txtMaTheLoai.Text.Trim(), "PUT", data);
                GetAll();
                MessageBox.Show("Đã cập nhật thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã Bị Lỗi");
            }
        }


        private void btnXoaTheLoai_Click(object sender, EventArgs e)
        {
            string masach = txtMaTheLoai.Text.Trim();
            WebClient client = new WebClient();
            try
            {
                String json = client.UploadString(URI3 + "/delete/" + masach, "DELETE", "");
                GetAll();
                MessageBox.Show("Xóa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
        }




        // Click để ra thông tin
        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvSach.Rows[e.RowIndex];
                txtMaSach.Text = row.Cells[0].Value.ToString();
                txtTenSach.Text = row.Cells[1].Value.ToString();
                txtTacGia.Text = row.Cells[2].Value.ToString();
                cbbTenTL.Text = row.Cells[3].Value.ToString();
                txtNXB.Text = row.Cells[4].Value.ToString();
                txtDonGia.Text = row.Cells[5].Value.ToString();
                txtSoLuongTon.Text = row.Cells[6].Value.ToString();
                txtSoLanMuon.Text = row.Cells[7].Value.ToString();
                cbbTinhTrangSach.Text = row.Cells[8].Value.ToString();


            }
        }

        private void dgvTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTheLoai.Rows[e.RowIndex];
                txtMaTheLoai.Text = row.Cells[0].Value.ToString();
                txtTenTheLoai.Text = row.Cells[1].Value.ToString();
            }
        }

        private void dgvNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvNXB.Rows[e.RowIndex];
                txtMaNXB.Text = row.Cells[0].Value.ToString();
                txtTenNXB.Text = row.Cells[1].Value.ToString();
                txtDiaChiNXB.Text = row.Cells[2].Value.ToString();
                dtNgayThanhLap.Text = row.Cells[3].Value.ToString();
            }
        }

        //
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

            //  string rowFilter = string.Format("{0} like '{1}'", "Name", "*" + txtTimKiem.Text + "*");
            //  ((DataTable)dgvSach.DataSource).DefaultView.RowFilter = string.Format("TenSach like '%{0}%'", txtTimKiem.Text.Trim().Replace("'", "''"));
            // btnTimKiemSach_Click(sender, e);
            dgvSach.DataSource = books.Where(p => p.TenSach.ToLower().Contains(txtTimKiem.Text.Trim().ToLower())).ToList();
        }

        private void btnTimKiemSach_Click(object sender, EventArgs e)
        {
            try
            {

                dgvSach.DataSource = books.Where(p => p.TenSach.ToLower().Contains(txtTimKiem.Text.Trim().ToLower())).ToList();

            }
            catch (Exception) { }
        }

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

