using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace doancosonganh
{
    public partial class formdangnhap : Form
    {
        public formdangnhap()
        {
            InitializeComponent();
        }
        Form1 c= null;

        public formdangnhap(Form1 f)
        {
            c = f;
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            taikhoan a = new taikhoan("select * from TBL_QUANLYTAIKHOAN join TBL_NHANVIEN on TBL_QUANLYTAIKHOAN.MANV=TBL_NHANVIEN.MANV ");
            var b = a.Select("TENTAIKHOAN='" + tbxtendangnhap.Text + "'and MATKHAU ='" + tbxmatkhau.Text + "'");
   
            if(b.Count()>0)
            {
                c.Text = "Xin chào" + b[0]["TENNHANVIEN"].ToString();
                MessageBox.Show(b[0]["MATAIKHOAN"].ToString());
                c.enablebutton(int.Parse(b[0]["MATAIKHOAN"].ToString()));
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btndangnhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(int)Keys.Enter)
            {
                btndangnhap_Click(sender, e);
            }
        }

        private void formdangnhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void formdangnhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                btndangnhap_Click(sender, e);
            }
        }
    }
}
