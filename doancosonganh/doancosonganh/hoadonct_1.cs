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
    public partial class hoadonct_1 : Form
    {
        public hoadonct_1()
        {
            InitializeComponent();
        }
        public string hd;
        public hoadonct_1(string mhadon)
        {
            hd = mhadon;
            InitializeComponent();
        }

     
        //Table<TBL_HOADONCT> hoadonchitiet;
        private void hoadonct_Load(object sender, EventArgs e)
        {

            loadtbxmahadon();
            loaddatagrid();
            tongtien();
        }
        private void loadtbxmahadon()
        {
            Formdatmon e = new Formdatmon(hd);
           
            tbxmahoadon.Text = hd;
        }
        private void loaddatagrid()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            dataGridViewhoadonct.DataSource = from hdct in db.TBL_HOADONCTs
                                              where hdct.MAHDBAN.Equals(tbxmahoadon.Text)
                                              select new { hdct.TENSANPHAM, hdct.SOLUONG, hdct.GIA };
                                              
            

        }
        private void tongtien()
        {
            int tongtien = 0;
            DataClasses1DataContext db = new DataClasses1DataContext();
            var a= from hdct in db.TBL_HOADONCTs
                   where hdct.MAHDBAN.Equals(tbxmahoadon.Text)
                   select new { hdct.TENSANPHAM, hdct.SOLUONG, hdct.GIA };
            foreach(var b in a )
            {
                tongtien +=(int) b.GIA;
            }
            tbxtongtien.Text = tongtien.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            check();
        }
        private void check()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            if (tbxthanhtoan.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập thanh toán");
            }
            else
            {
                int sotienconlai = int.Parse(tbxthanhtoan.Text) - int.Parse(tbxtongtien.Text);
                tbxsotienconlai.Text = sotienconlai.ToString();
                if(sotienconlai>0)
                {
                    TBL_HOADON b = db.TBL_HOADONs.Single(p => p.MAHDBAN.Equals(tbxmahoadon.Text));
                    b.THANHTOAN = true;
                }
            }
        }

        private void dataGridViewhoadonct_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach(DataGridViewRow r in dataGridViewhoadonct.Rows )
            {
                r.Cells[0].Value = r.Index + 1;
            }
        }
    }
}
