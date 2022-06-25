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
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace QuanLyThuVien
{
    public partial class FrmThongKe : Form
    {
        private List<Book> thongke = new List<Book>();
        private const String URI = "http://localhost:3002/api/book";

        private List<Quydinh> qd = new List<Quydinh>();
        private const String URI2 = "http://localhost:3002/api/quydinh";

        System.Data.DataTable dataTable = new System.Data.DataTable();
        //không sử dụng tên class DataTable được vì cả System.Data và Microsoft.Office.Interop đều có class DataTable
        //Vì vậy mỗi khi cần gọi DataTable của System.Data thì phải gọi cả cụm System.Data.DataTable

        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void GetAllBook()
        {
            //Tạo ra một đối tượng client để kết nối 
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            String json = client.DownloadString(URI); //HTTp GET, tạo Http Request, format json 
            thongke = JsonConvert.DeserializeObject<List<Book>>(json); //Chuyển từ list thành đối tượng 
            dgvThongKe.DataSource = thongke;
        }

        private void GetAllQuyDinh()
        {

            //Tạo ra một đối tượng client để kết nối 
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            String json = client.DownloadString(URI); //HTTp GET, tạo Http Request, format json 
            qd = JsonConvert.DeserializeObject<List<Quydinh>>(json); //Chuyển từ list thành đối tượng 
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            GetAllBook();

            //vì đang dùng table book nên cần ẩn các cột không cần thiết 
            dgvThongKe.Columns[2].Visible = false;
            dgvThongKe.Columns[3].Visible = false;
            dgvThongKe.Columns[4].Visible = false;
            dgvThongKe.Columns[5].Visible = false;
            dgvThongKe.Columns[6].Visible = false;
            dgvThongKe.Columns[8].Visible = false;

        }

        private void xuatfileExcel(DataGridView g, string path, string tenfile)
        {
            try
            {
                //vì đang dùng table book nên khi xuất file thì cần loại bỏ những cột không cần thiết trước

                app obj = new app();
                obj.Application.Workbooks.Add(Type.Missing);
                obj.Columns.ColumnWidth = 30;

                for (int i = 1; i < g.ColumnCount - 6; i++)
                {
                    obj.Cells[1, i] = g.Columns[i - 1].HeaderText;       //lấy 2 cột đầu tiên      
                }
                obj.Cells[1, 3] = g.Columns[7].HeaderText; //lấy cột 7 là cột "số lần mượn"
                for (int i = 0; i < g.Rows.Count; i++)
                {
                    for (int j = 0; j < g.Columns.Count - 7; j++)
                    {
                        if (g.Rows[i].Cells[j].Value != null)
                        {
                            obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString(); //lấy các giá trị của 2 cột đầu tiên
                            obj.Cells[i + 2, 3] = g.Rows[i].Cells[7].Value.ToString(); //lấy các giá trị của cột "số lần mượn"
                        }
                    }
                }

                obj.ActiveWorkbook.SaveCopyAs(path + tenfile + ".xlsx"); //lưu dưới định dạng xlsx
                obj.ActiveWorkbook.Saved = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra");
            }           
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            try
            {
                xuatfileExcel(dgvThongKe, @"D:\", "fileThongKe"); // Xuất file xlsx vào ổ D
                MessageBox.Show("Đã xuất file vào ổ D thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra");
            }           
        }

        private void cbbSoSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbbSoSach.Text == "")
            //{
            //    GetAllBook();
            //}
            //else
            //{
            //    var load = (from a in Book
            //                orderby a.SoLanMuon descending
            //                select new
            //                {
            //                    a.MaSach,
            //                    a.TenSach,
            //                    a.SoLanMuon
            //                }).Take(int.Parse(cbbSoSach.Text.ToString()));
            //    dgvThongKe.DataSource = load;
            //}
        }
    }
}
