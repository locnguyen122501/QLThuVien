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
        private List<PhieuMuon> phieumuon = new List<PhieuMuon>();
        private const String URI = "http://localhost:3002/api/phieumuon";

        private List<PhieuTra> phieutra = new List<PhieuTra>();
        private const String URI2 = "http://localhost:3002/api/phieutra";

        DataTable dataTable = new DataTable();

        public FrmMuonTraSach()
        {
            InitializeComponent();
        }

        private void FrmMuonTraSach_Load(object sender, EventArgs e)
        {
            GetAll();

            //Fix tam cho khong hien 4 cot bị dư của 2 bảng
            dgvMuonSach.Columns[9].Visible = false;
            dgvMuonSach.Columns[10].Visible = false;
            dgvMuonSach.Columns[11].Visible = false;
            dgvMuonSach.Columns[12].Visible = false;

            dgvTraSach.Columns[9].Visible = false;
            dgvTraSach.Columns[10].Visible = false;
            dgvTraSach.Columns[11].Visible = false;
            dgvTraSach.Columns[12].Visible = false;
        }
        private void GetAll()
        {

            //Tạo ra một đối tượng client để kết nối 

            //muon sach
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            String json = client.DownloadString(URI); //HTTp GET, tạo Http Request, format json 
            phieumuon = JsonConvert.DeserializeObject<List<PhieuMuon>>(json); //Chuyển từ list thành đối tượng 
            dgvMuonSach.DataSource = phieumuon;

            //tra sach
            WebClient client2 = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            String json2 = client.DownloadString(URI2); //HTTp GET, tạo Http Request, format json 
            phieutra = JsonConvert.DeserializeObject<List<PhieuTra>>(json2); //Chuyển từ list thành đối tượng 
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
                cbbMaSach.Text = row.Cells[1].Value.ToString();
                cbbTenSach1.Text = row.Cells[2].Value.ToString();
                cbbMaThe1.Text = row.Cells[3].Value.ToString();
                cbbTenTheLoai.Text = row.Cells[4].Value.ToString();
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
                cbbMaDocGia.Text = row.Cells[1].Value.ToString();
                cbbMaThe2.Text = row.Cells[2].Value.ToString();
                cbbTenSach2.Text = row.Cells[3].Value.ToString();
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
                //int newId = phieumuon.OrderByDescending(n => n.MaPhieuMuon).Select(n => n.MaSach).FirstOrDefault() + 1;
                int newId = 4;

                //Khởi tạo một cuốn sách mới 
                PhieuMuon newMuon = new PhieuMuon()
                {
                    //Mã số tự động sinh ra nên cho bằng không 
                    MaPhieuMuon = newId,
                    MaSach = int.Parse(cbbMaSach.Text.Trim()),
                    TenSach = cbbTenSach1.Text.Trim(),
                    MaThe = cbbMaThe1.Text.Trim(),
                    MaTheLoai = cbbTenTheLoai.Text.Trim(),
                    NgayMuon = Convert.ToDateTime(dtNgayMuon.Text.Trim()),
                    NgayTra = Convert.ToDateTime(dtNgayTra1.Text.Trim()),
                    SoLuongMuon = Convert.ToInt32(txtSoLuongMuon1.Text.Trim()),
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
    }
}
