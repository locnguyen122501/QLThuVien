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
        DataTable dataTable = new DataTable();

        private List<PhieuTra> phieutra = new List<PhieuTra>();
        private const String URI2 = "http://localhost:3002/api/phieutra";
        DataTable dataTable2 = new DataTable();
        public FrmMuonTraSach()
        {
            InitializeComponent();
        }

        private void FrmMuonTraSach_Load(object sender, EventArgs e)
        {
            GetAll();
            GetAll2();
        }
        private void GetAll()
        {

            //Tạo ra một đối tượng client để kết nối 
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            String json = client.DownloadString(URI); //HTTp GET, tạo Http Request, format json 
            phieumuon = JsonConvert.DeserializeObject<List<PhieuMuon>>(json); //Chuyển từ list thành đối tượng 
            dgvMuonSach.DataSource = phieumuon;

        }

        private void GetAll2()
        {

            //Tạo ra một đối tượng client để kết nối 
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            String json = client.DownloadString(URI); //HTTp GET, tạo Http Request, format json 
            phieutra = JsonConvert.DeserializeObject<List<PhieuTra>>(json); //Chuyển từ list thành đối tượng 
            dgvTraSach.DataSource = phieutra;

        }

        private void dgvMuonSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = this.dgvMuonSach.Rows[e.RowIndex];
            //     = row.Cells[0].Value.ToString();
            //    txtHoTenDocGia.Text = row.Cells[1].Value.ToString();
            //    cbGioitinh.Text = row.Cells[2].Value.ToString();
            //    txtDiaChi.Text = row.Cells[3].Value.ToString();
            //    dtNgaySinh.Text = row.Cells[4].Value.ToString();
            //    txtSDT.Text = row.Cells[5].Value.ToString();
            //}
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            GetAll2();
        }
    }
}
