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
    public partial class Form1 : Form
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
        public Form1()
        {

            InitializeComponent();
            comboBox1.Items.Add("GMBT");
            comboBox1.Items.Add("KTKH");
            comboBox1.Items.Add("TT");
            comboBox1.Items.Add("VHNC");
            comboBox1.Items.Add("VHVN");
            comboBox1.Items.Add("WB");


        }

        private void Form1_Load(object sender, EventArgs e)
        {


            GetAll();
        }


        //Thêm một cuốn sách 
        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
           
              

                // Get new Id
                int newId =  books.OrderByDescending(n => n.MaSach).Select(n=>n.MaSach).FirstOrDefault() + 1;
                System.Object[] ItemObject = new System.Object[10];
                for (int i = 0; i <= 9; i++)
                {

                    ItemObject[i] = "Item" + i;
                }
                comboBox1.Items.AddRange(ItemObject);

                //int selectedIndex = comboBox1.SelectedIndex;
                //Object selectedItem = comboBox1.SelectedItem;
                //Khởi tạo một cuốn sách mới 
                Book newBook = new Book()
                {
                    //Mã số tự động sinh ra nên cho bằng không 
                    MaSach = newId,
                    TenSach = textBox2.Text.Trim(),
                    TacGia = textBox3.Text.Trim(),                   
                    
                    MaTheLoai = comboBox1.Text.Trim(),
                    MaNXB = int.Parse(textBox5.Text.Trim()),
                    DonGia = int.Parse(textBox6.Text.Trim()),
                    SoLuongTon = int.Parse(textBox7.Text.Trim()),
                    SoLanMuon = int.Parse(textBox8.Text.Trim()),
                    TinhTrang = textBox9.Text.Trim()
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
        //Khởi tạo shorrtcut
        private void GetAll()
        {

            //Tạo ra một đối tượng client để kết nối 
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            String json = client.DownloadString(URI); //HTTp GET, tạo Http Request, format json 
            books = JsonConvert.DeserializeObject<List<Book>>(json); //Chuyển từ list thành đối tượng 
            dataGridView1.DataSource = books;

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int masach = int.Parse(textBox1.Text.Trim());
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Book newBook = new Book()
                {
                    //Mã số tự động sinh ra nên cho bằng không 
                    MaSach = int.Parse(textBox1.Text.Trim()),
                    TenSach = textBox2.Text.Trim(),
                    TacGia = textBox3.Text.Trim(),
                    MaTheLoai = comboBox1.Text.Trim(),
                    MaNXB = int.Parse(textBox5.Text.Trim()),
                    DonGia = int.Parse(textBox6.Text.Trim()),
                    SoLuongTon = int.Parse(textBox7.Text.Trim()),
                    SoLanMuon = int.Parse(textBox8.Text.Trim()),
                    TinhTrang = textBox9.Text.Trim()
                };
                String data = JsonConvert.SerializeObject(newBook); // Chuyển đối tượng sang JSON
                WebClient client = new WebClient();
                client.Encoding = System.Text.Encoding.UTF8;
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                String response = client.UploadString(URI + "/" + int.Parse(textBox1.Text.Trim()), "PUT", data);
                GetAll();
                MessageBox.Show("Đã cập nhật thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã Bị Lỗi");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //if (dataGridView1.SelectedRows.Count > 0)
            //{
            //    int masach = int.Parse(dataGridView1.SelectedRows[0].Cells["MaSach"].Value.ToString());
            //    //Tạo ra một đối tượng client để kết nối 
            //    WebClient client = new WebClient();
            //    String json = client.DownloadString(URI + masach); //HTTp GET, tạo Http Request, format json 
            //    Book books = JsonConvert.DeserializeObject<Book>(json); //Chuyển từ list thành đối tượng 
            //    if (books != null)
            //    {
            //        textBox1.Text = books.MaSach.ToString();
            //        textBox2.Text = books.TenSach;
            //        textBox3.Text = books.TacGia;
            //        textBox4.Text = books.MaTheLoai;
            //        textBox5.Text = books.MaNXB.ToString();
            //        textBox6.Text = books.DonGia.ToString();
            //        textBox7.Text = books.SoLuongTon.ToString();
            //        textBox8.Text = books.SoLanMuon.ToString();
            //        textBox9.Text = books.TinhTrang;
            //    }
            //}
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                comboBox1.Text = row.Cells[3].Value.ToString();
                textBox5.Text = row.Cells[4].Value.ToString();
                textBox6.Text = row.Cells[5].Value.ToString();
                textBox7.Text = row.Cells[6].Value.ToString();
                textBox8.Text = row.Cells[7].Value.ToString();
                textBox9.Text = row.Cells[8].Value.ToString();


            }
        }
    }
}
