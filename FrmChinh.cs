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
    public partial class FrmChinh : Form
    {
        private Form activeForm;
        private List<Theloai> categories = new List<Theloai>();
        private const String URI = "http://localhost:3002/api/theloai";
        public static string categoryIdSelected = "";

        public FrmChinh()
        {
            InitializeComponent();
        }

        private void GetAll()
        {
            //Tạo ra một đối tượng client để kết nối 
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            String json = client.DownloadString(URI); //HTTp GET, tạo Http Request, format json 
            categories = JsonConvert.DeserializeObject<List<Theloai>>(json); //Chuyển từ list thành đối tượng 
        }

        private void FrmChinh_Load(object sender, EventArgs e)
        {
            this.dockPanel2.Options.ShowAutoHideButton = false;
            this.dockPanel2.Options.ShowCloseButton = false;
            this.dockPanel3.Options.ShowAutoHideButton = false;
            this.dockPanel3.Options.ShowCloseButton = false;
            GetAll();
            navBarRoot.ItemLinks.Clear();
            foreach (var category in categories)
            {
                DevExpress.XtraNavBar.NavBarItem navBarItem = new DevExpress.XtraNavBar.NavBarItem();
                navBarItem.LinkClicked += NavBarItem_LinkClicked;
                navBarItem.Caption = category.TenLoai + " - "+category.MaTheLoai;
                navBarRoot.ItemLinks.Add(navBarItem);
            }
        }

        private void NavBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var categoryName = e.Link.Caption;
            var arr = categoryName.Split('-');
            categoryIdSelected = arr.Last();
            OpenChildForm(new FrmQLySach(), sender);
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmQLySach(), sender);
        }

        private void đọcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDocGia(), sender);
        }

        private void thủThưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmThuThu(), sender);
        }

        private void thẻToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmQLyThe(), sender);
        }

        private void tàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmTaiKhoan(), sender);
        }

        private void defToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmMuonTraSach(), sender);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                FrmDangNhap frmDN = new FrmDangNhap();
                frmDN.Show();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Bạn có thực sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }
        }

        private void dockManager1_Sizing(object sender, DevExpress.XtraBars.Docking.SizingEventArgs e)
        {
            e.Cancel = true;
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var navBar = e.Link.Caption;

        }


        private void navBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
           
        }
    }
}
