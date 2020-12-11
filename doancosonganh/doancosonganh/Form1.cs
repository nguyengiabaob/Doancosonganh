using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doancosonganh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void tileBarDropDownContainer1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            
                int index = tabControl1.TabPages.IndexOfKey("tabpageMonan");
                if (index > 0)
                {
                    tabControl1.SelectedIndex = index;

                }
                else
                {
                FormMonAn a = new FormMonAn();        
                    TabPage p = new TabPage(a.Text);
                    p.Name = "tabpageMonan";
                    a.TopLevel = false;
                    p.Controls.Add(a);
                    a.Dock = DockStyle.Fill;
                    a.FormBorderStyle = FormBorderStyle.None;
                    tabControl1.TabPages.Add(p);
                    a.Show();

                }
            
          

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabControl1.TabPages.IndexOfKey("tabpagenuocuong");
            if (index > 0)
            {
                tabControl1.SelectedIndex = index;

            }
            else
            {
                FormNuocUong a = new FormNuocUong();
                TabPage p = new TabPage(a.Text);
                p.Name = "tabpagenuocuong";
                a.TopLevel = false;
                p.Controls.Add(a);
                a.Dock = DockStyle.Fill;
                a.FormBorderStyle = FormBorderStyle.None;
                tabControl1.TabPages.Add(p);
                a.Show();

            }

            //FormNuocUong f = new FormNuocUong();
            //f.WindowState = FormWindowState.Normal;
            //f.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabControl1.TabPages.IndexOfKey("tabpagebanan");
            if (index > 0)
            {
                tabControl1.SelectedIndex = index;

            }
            else
            {
                Danhsachbanan a = new Danhsachbanan();
                TabPage p = new TabPage(a.Text);
                p.Name = "tabpageban";
                a.TopLevel = false;
                p.Controls.Add(a);
                a.Dock = DockStyle.Fill;
                a.FormBorderStyle = FormBorderStyle.None;
                tabControl1.TabPages.Add(p);
                a.Show();

            }

            //Danhsachbanan f = new Danhsachbanan();
            //f.WindowState = FormWindowState.Normal;
            //f.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabControl1.TabPages.IndexOfKey("tabpagedatmon");
            if (index > 0)
            {
                tabControl1.SelectedIndex = index;

            }
            else
            {
                Formdatmon a = new Formdatmon();
                TabPage p = new TabPage(a.Text);
                p.Name = "tabpagedatmon";
                a.TopLevel = false;
                p.Controls.Add(a);
                a.Dock = DockStyle.Fill;
                a.FormBorderStyle = FormBorderStyle.None;
                tabControl1.TabPages.Add(p);
                a.Show();

            }

            //Formdatmon datmon = new Formdatmon();
            //datmon.WindowState = FormWindowState.Normal;
            //datmon.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabControl1.TabPages.IndexOfKey("tabpagethongtinnhanvien");
            if (index > 0)
            {
                tabControl1.SelectedIndex = index;

            }
            else
            {
                fromthongtinnhanvien a = new fromthongtinnhanvien();
                TabPage p = new TabPage(a.Text);
                p.Name = "tabpagethongtinnhanvien";
                a.TopLevel = false;
                p.Controls.Add(a);
                a.Dock = DockStyle.Fill;
                a.FormBorderStyle = FormBorderStyle.None;
                tabControl1.TabPages.Add(p);
                a.Show();

            }
            //fromthongtinnhanvien f = new fromthongtinnhanvien();
            //f.WindowState = FormWindowState.Normal;
            //f.StartPosition = FormStartPosition.CenterScreen;
            //f.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabControl1.TabPages.IndexOfKey("tabpagetinhluong");
            if (index > 0)
            {
                tabControl1.SelectedIndex = index;

            }
            else
            {
                tinhluong a = new tinhluong();
                TabPage p = new TabPage(a.Text);
                p.Name = "tabpagtinhluong";
                a.TopLevel = false;
                p.Controls.Add(a);
                a.Dock = DockStyle.Fill;
                a.FormBorderStyle = FormBorderStyle.None;
                tabControl1.TabPages.Add(p);
                a.Show();

            }
            //tinhluong f = new tinhluong();
            //f.WindowState = FormWindowState.Normal;
            //f.StartPosition = FormStartPosition.CenterScreen;
            //f.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabControl1.TabPages.IndexOfKey("tabpageNhapkho");
            if (index > 0)
            {
                tabControl1.SelectedIndex = index;

            }
            else
            {
                Formnhapkho a = new Formnhapkho();
                TabPage p = new TabPage(a.Text);
                p.Name = "tabpageNhapkho";
                a.TopLevel = false;
                p.Controls.Add(a);
                a.Dock = DockStyle.Fill;
                a.FormBorderStyle = FormBorderStyle.None;
                tabControl1.TabPages.Add(p);
                a.Show();

            }

            //Formnhapkho f = new Formnhapkho();
            //f.WindowState = FormWindowState.Normal;
            //f.StartPosition = FormStartPosition.CenterScreen;
            //f.Show();
        }
        public void enablebutton(int ma)
        {
           if(ma>=2)
            {
                ribbonPage2.Visible = false;
                ribbonPage5.Visible = false;
                ribbonPage7.Visible = false;

            }
           
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            int index = tabControl1.TabPages.IndexOfKey("tabpagexemdannhsachthongke");
            if (index > 0)
            {
                tabControl1.SelectedIndex = index;

            }
            else
            {
                baocaothongke a = new baocaothongke();
                TabPage p = new TabPage(a.Text);
                p.Name = "tabpagexemdannhsachthongke";
                a.TopLevel = false;
                p.Controls.Add(a);
                a.Dock = DockStyle.Fill;
                a.FormBorderStyle = FormBorderStyle.None;
                tabControl1.TabPages.Add(p);
                a.Show();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formdangnhap dangnhap = new formdangnhap(this);
            dangnhap.StartPosition = FormStartPosition.CenterScreen;
            dangnhap.WindowState = FormWindowState.Normal;
            dangnhap.ShowDialog();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            tabControl1.TabPages.Clear();
            this.Hide();
            Form1_Load(sender, e);
            this.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("bạn có muốn thoát khỏi chương trình ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
        }
    }
}
