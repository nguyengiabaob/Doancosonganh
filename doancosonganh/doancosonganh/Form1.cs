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
            FormMonAn f = new FormMonAn();
            f.WindowState = FormWindowState.Normal;
            f.Show();

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormNuocUong f = new FormNuocUong();
            f.WindowState = FormWindowState.Normal;
            f.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Danhsachbanan f = new Danhsachbanan();
            f.WindowState = FormWindowState.Normal;
            f.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formdatmon datmon = new Formdatmon();
            datmon.WindowState = FormWindowState.Normal;
            datmon.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fromthongtinnhanvien f = new fromthongtinnhanvien();
            f.WindowState = FormWindowState.Normal;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tinhluong f = new tinhluong();
            f.WindowState = FormWindowState.Normal;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formnhapkho f = new Formnhapkho();
            f.WindowState = FormWindowState.Normal;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
    }
}
