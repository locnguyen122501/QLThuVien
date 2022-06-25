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
    public partial class FrmMuonTraSach : Form
    {
        private List<Themuon> phieumuon = new List<Themuon>();
        private const String URI = "http://localhost:3002/api/phieumuon";

        private List<Thetra> phieutra = new List<Thetra>();
        private const String URI2 = "http://localhost:3002/api/phieutra";

        DataTable dataTable = new DataTable();

        public FrmMuonTraSach()
        {
            InitializeComponent();
        }


        private void FrmMuonTraSach_Load(object sender, EventArgs e)
        {
            GetAll();
        }
        private void GetAll()
        {

            //Tạo ra một đối tượng client để kết nối 

            //muon sach
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            String json = client.DownloadString(URI); //HTTp GET, tạo Http Request, format json 
            phieumuon = JsonConvert.DeserializeObject<List<Themuon>>(json); //Chuyển từ list thành đối tượng 
            dgvMuonSach.DataSource = phieumuon;

            //tra sach
            WebClient client2 = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            String json2 = client.DownloadString(URI2); //HTTp GET, tạo Http Request, format json 
            phieutra = JsonConvert.DeserializeObject<List<Thetra>>(json2); //Chuyển từ list thành đối tượng 
            dgvTraSach.DataSource = phieutra;
        }

        private void dgvMuonSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            GetAll();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSoLuongMuon1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvMuonSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvMuonSach.Rows[e.RowIndex];
                txtMaPhieuMuon.Text = row.Cells[0].Value.ToString();
                txtMaSach.Text = row.Cells[1].Value.ToString();
                txtTenSach1.Text = row.Cells[2].Value.ToString();
                txtMaThe1.Text = row.Cells[3].Value.ToString();
                txtTenTheLoai.Text = row.Cells[4].Value.ToString();
                dtNgayMuon.Text = row.Cells[5].Value.ToString();
                dtNgayTra1.Text = row.Cells[6].Value.ToString();
                txtSoLuongMuon1.Text = row.Cells[7].Value.ToString();
            }
        }

        private void dgvTraSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTraSach.Rows[e.RowIndex];
                txtMaPhieuTra.Text = row.Cells[0].Value.ToString();
                txtMaDocGia.Text = row.Cells[1].Value.ToString();
                txtMaThe2.Text = row.Cells[2].Value.ToString();
                txtTenSach2.Text = row.Cells[3].Value.ToString();
                txtSoLuongMuon2.Text = row.Cells[4].Value.ToString();
                txtSoLuongTra.Text = row.Cells[5].Value.ToString();
                dtNgayTra2.Text = row.Cells[6].Value.ToString();
                cbbTinhTrangSach.Text = row.Cells[7].Value.ToString();
            }
        }

        private void btnChoMuon_Click(object sender, EventArgs e)
        {
            try
            {
                int newId = phieumuon.OrderByDescending(n => n.MaPhieuMuon).Select(n => n.MaPhieuMuon).FirstOrDefault() + 1;
                System.Object[] ItemObject = new System.Object[10];
                for (int i = 0; i <= 9; i++)
                {

                    ItemObject[i] = "Item" + i;
                }
                //Khởi tạo một cuốn sách mới 
                Themuon newMuon = new Themuon()
                {
                    //Mã số tự động sinh ra nên cho bằng không 
                    MaPhieuMuon = newId,
                    MaSach = int.Parse(txtMaSach.Text.Trim()),
                    TenSach = txtTenSach1.Text.Trim(),
                    MaThe = txtMaThe1.Text.Trim(),
                    MaTheLoai = txtTenTheLoai.Text.Trim(),
                    NgayMuon = Convert.ToDateTime(dtNgayMuon.Text.Trim()),
                    NgayTra = Convert.ToDateTime(dtNgayTra1.Text.Trim()),
                    SoLuongMuon = Convert.ToInt32(txtSoLuongMuon1.Text.Trim()),
                    MaTT = txtMaTT1.Text.Trim(),
                };               

                String data = JsonConvert.SerializeObject(newMuon); // Chuyển đối tượng sang JSON
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

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            int mapm = int.Parse(txtMaPhieuMuon.Text.Trim());
            WebClient client = new WebClient();
            try
            {
                String json = client.UploadString(URI + "/delete/" + mapm, "DELETE", "");
                GetAll();
                MessageBox.Show("Đã xóa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra");
            }
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            try
            {
                int newId = phieutra.OrderByDescending(n => n.MaPhieuTra).Select(n => n.MaPhieuTra).FirstOrDefault() + 1;
                System.Object[] ItemObject = new System.Object[10];
                for (int i = 0; i <= 9; i++)
                {

                    ItemObject[i] = "Item" + i;
                }
                //Khởi tạo một cuốn sách mới 
                Thetra newTra = new Thetra()
                {
                    //Mã số tự động sinh ra nên cho bằng không 
                    MaPhieuTra = newId,
                    MaDocGia = int.Parse(txtMaDocGia.Text.Trim()),
                    MaThe = txtMaThe1.Text.Trim(),
                    MaSach = int.Parse(txtTenSach2.Text.Trim()),
                    SoLuongMuon = int.Parse(txtSoLuongMuon2.Text.Trim()),
                    SoLuongTra = int.Parse(txtSoLuongTra.Text.Trim()),
                    NgayTra = Convert.ToDateTime(dtNgayTra2.Text.Trim()),
                    TinhTrangSach = cbbTinhTrangSach.Text.Trim(),
                    MaTT = txtMaTT2.Text.Trim(),
                };

                String data = JsonConvert.SerializeObject(newTra); // Chuyển đối tượng sang JSON
                WebClient client = new WebClient();
                client.Encoding = System.Text.Encoding.UTF8;
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                String response = client.UploadString(URI2, "POST", data);   //Http Post
                GetAll();
                MessageBox.Show("Đã thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra");
            }
        }

        private void btnXoa2_Click(object sender, EventArgs e)
        {
            int mapt = int.Parse(txtMaPhieuTra.Text.Trim());
            WebClient client = new WebClient();
            try
            {
                String json = client.UploadString(URI2 + "/delete/" + mapt, "DELETE", "");
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
