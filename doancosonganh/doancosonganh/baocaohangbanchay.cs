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
            loadcomboxloai();
            Xembaocao.Click += new EventHandler(xembaocao_Click);
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
                dataGridViewbanchay.DataSource = from sp in db.TBL_HOADONCTs
      
                                                 select sp;
                

            }
            else
                 if (Loai.SelectedIndex > 0 && Ten.Text != "")
            {
                dataGridViewbanchay.DataSource = null;
                dataGridViewbanchay.DataSource = from sp in db.TBL_SANPHAMs 
                                                 where sp.LOAISANPHAM.Equals(Loai.SelectedItem.ToString()) && sp.TENSANPHAM.Equals(Ten.Text)
                                                 select sp;
            }
            else
                 if (Loai.SelectedIndex > 0)
            {
                dataGridViewbanchay.DataSource = null;
                dataGridViewbanchay.DataSource = from sp in db.TBL_SANPHAMs
                                                 where sp.LOAISANPHAM.Equals(Loai.SelectedItem.ToString())
                                                 select sp;
            }
            else
                     if (Ten.Text != "")
            {
                dataGridViewbanchay.DataSource = null;
                dataGridViewbanchay.DataSource = from sp in db.TBL_SANPHAMs
                                                 where sp.TENSANPHAM.Equals(Ten.Text)
                                                 select sp;
            }
        }
    }
}
