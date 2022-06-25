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
    public partial class FrmQuyDinh : Form
    {
        private List<Quydinh> qd = new List<Quydinh>();
        private const String URI = "http://localhost:3002/api/quydinh";
        DataTable dataTable = new DataTable();
        private void GetAllQuyDinh()
        {

            //Tạo ra một đối tượng client để kết nối 
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            String json = client.DownloadString(URI); //HTTp GET, tạo Http Request, format json 
            qd = JsonConvert.DeserializeObject<List<Quydinh>>(json); //Chuyển từ list thành đối tượng 
            dgvQuyDinh.DataSource = qd;

        }
        public FrmQuyDinh()
        {
            InitializeComponent();
        }

        private void FrmQuyDinh_Load(object sender, EventArgs e)
        {
            GetAllQuyDinh();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Quydinh newqd = new Quydinh()
                {
                    //Mã số tự động sinh ra nên cho bằng không 
                    MaQD = int.Parse(txtMaQuyDinh.Text.Trim()),
                    TenQD = txtTenQuyDinh.Text.Trim(),
                    SoLuongQD = int.Parse(txtSoLuongQuyDinh.Text.Trim()),


                };
                String data = JsonConvert.SerializeObject(newqd); // Chuyển đối tượng sang JSON
                WebClient client = new WebClient();
                client.Encoding = System.Text.Encoding.UTF8;
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                String response = client.UploadString(URI + "/" + int.Parse(txtMaQuyDinh.Text.Trim()), "PUT", data);
                GetAllQuyDinh();
                MessageBox.Show("Đã cập nhật thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra");
            }
        }

        private void dgvQuyDinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvQuyDinh.Rows[e.RowIndex];
                txtMaQuyDinh.Text = row.Cells[0].Value.ToString();
                txtTenQuyDinh.Text = row.Cells[1].Value.ToString();
                txtSoLuongQuyDinh.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
