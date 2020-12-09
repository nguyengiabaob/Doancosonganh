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
    public partial class baocaohangbanchay : Form
    {
        public baocaohangbanchay()
        {
            InitializeComponent();
        }
        TBhoadonct tbhoadonct = new TBhoadonct("select MASAPHAM,TENSANPHAM,sum(SOLUONG) as SOLUONG,Sum(GIA) as GIA from TBL_HOADONCT   "
 + " group by MASAPHAM, TENSANPHAM");
        ComboBox Loai = null;
        TextBox Ten = null;
        DateTimePicker Tu = null;
        DateTimePicker Den = null;
        Button Xembaocao = null;

        DataClasses1DataContext db = new DataClasses1DataContext();
        Table<TBL_LOAISANPHAM> Loaisp;
        public baocaohangbanchay(ComboBox loai,TextBox ten,DateTimePicker tu ,DateTimePicker den,Button xembaocao)
        {
            Loai = loai;
            Ten = ten;
            Tu = tu;
            Den = den;
            Xembaocao = xembaocao;
            InitializeComponent();
        }

        private void baocaohangbanchay_Load(object sender, EventArgs e)
        {
            //loadcomboxloai();
            //Xembaocao.Click += new EventHandler(xembaocao_Click);
            //Loai.SelectedIndexChanged += new EventHandler(Loai_SelectedIndexChanged);
            dataGridViewbanchay.DataSource = null;
            dataGridViewbanchay.DataSource = tbhoadonct;
        }
        private void loadcomboxloai()
        { Loaisp = db.GetTable<TBL_LOAISANPHAM>();
            Loai.DataSource = Loaisp;
            Loai.DisplayMember = "LOAISANPHAM";
            Loai.ValueMember = "MASANPHAM";
        }
        private void xembaocao_Click(object sender, EventArgs e)
        {
            if (Loai.SelectedIndex == 0)
            {
                dataGridViewbanchay.DataSource = null;
                dataGridViewbanchay.DataSource = tbhoadonct;
                

            }
            else
                 if (Loai.SelectedIndex > 0 && Ten.Text != "")
            {
                TBhoadonct tbhoadonct_1 = new TBhoadonct("select MASAPHAM,TENSANPHAM,sum(SOLUONG),Sum(GIA) from TBL_HOADONCT"
  + "group by MASAPHAM, TENSANPHAM where LOAISANPHAM='" + Loai.SelectedItem.ToString() + "' and TENSANPHAM= '" + Ten.Text + "'");
                dataGridViewbanchay.DataSource = null;
                dataGridViewbanchay.DataSource = tbhoadonct_1;
            }
            else
                 if (Loai.SelectedIndex > 0)
            {
                TBhoadonct tbhoadonct_1 = new TBhoadonct("select MASAPHAM,TENSANPHAM,sum(SOLUONG),Sum(GIA) from TBL_HOADONCT"
 + "group by MASAPHAM, TENSANPHAM where LOAISANPHAM='" + Loai.SelectedItem.ToString() + "'");
                dataGridViewbanchay.DataSource = null;
                dataGridViewbanchay.DataSource = tbhoadonct_1;
            }
            else
                     if (Ten.Text != "")
            {

                TBhoadonct tbhoadonct_1 = new TBhoadonct("select MASAPHAM,TENSANPHAM,sum(SOLUONG),Sum(GIA) from TBL_HOADONCT"
 + "group by MASAPHAM, TENSANPHAM where TENSANPHAM='" + Ten.Text + "'");
                dataGridViewbanchay.DataSource = null;
                dataGridViewbanchay.DataSource = tbhoadonct_1;
               
            }
        }
        private void Loai_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Loai.SelectedIndex == 0)
            {
                dataGridViewbanchay.DataSource = null;
                dataGridViewbanchay.DataSource = tbhoadonct;


            }
            else
                 if (Loai.SelectedIndex > 0 && Ten.Text != "")
            {
                TBhoadonct tbhoadonct_1 = new TBhoadonct("select MASAPHAM,TENSANPHAM,sum(SOLUONG),Sum(GIA) from TBL_HOADONCT"
  + "group by MASAPHAM, TENSANPHAM where LOAISANPHAM='" + Loai.SelectedItem.ToString() + "' and TENSANPHAM= '" + Ten.Text + "'");
                dataGridViewbanchay.DataSource = null;
                dataGridViewbanchay.DataSource = tbhoadonct_1;
            }
            else
                 if (Loai.SelectedIndex > 0)
            {
                TBhoadonct tbhoadonct_1 = new TBhoadonct("select MASAPHAM,TENSANPHAM,sum(SOLUONG),Sum(GIA) from TBL_HOADONCT"
 + "group by MASAPHAM, TENSANPHAM where LOAISANPHAM='" + Loai.SelectedItem.ToString() + "'");
                dataGridViewbanchay.DataSource = null;
                dataGridViewbanchay.DataSource = tbhoadonct_1;
            }
            else
                     if (Ten.Text != "")
            {

                TBhoadonct tbhoadonct_1 = new TBhoadonct("select MASAPHAM,TENSANPHAM,sum(SOLUONG),Sum(GIA) from TBL_HOADONCT"
 + "group by MASAPHAM, TENSANPHAM where TENSANPHAM='" + Ten.Text + "'");
                dataGridViewbanchay.DataSource = null;
                dataGridViewbanchay.DataSource = tbhoadonct_1;

            }
        }

        private void dataGridViewbanchay_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach(DataGridViewRow r in dataGridViewbanchay.Rows)
            {
                r.Cells[0].Value = r.Index + 1;
            }
        }
    }
}
