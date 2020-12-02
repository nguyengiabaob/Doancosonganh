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
using System.Data.SqlClient;

namespace doancosonganh
{
    public partial class Formnhapkho : Form
    {
        public Formnhapkho()
        {
            InitializeComponent();
        }
        BindingManagerBase nhapkho;
        private void loaddatagrid()

        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            Table<TBL_SANPHAM> tbsanp = db.GetTable<TBL_SANPHAM>();
            dataGridViewnhapkho.AutoGenerateColumns = false;
            dataGridViewnhapkho.DataSource = tbsanp;
        }
        private void savedatabase()
        {
            int dem = -1;
            DataClasses1DataContext db = new DataClasses1DataContext();
            Table<TBL_SANPHAM> tbsanp = db.GetTable<TBL_SANPHAM>();
            foreach( TBL_SANPHAM r in tbsanp)
            {
                if(r.MASANPHAM!=null)
                {
                    dem += 1;
                }
            }
            TBL_SANPHAM a = new TBL_SANPHAM();


          for(int j=dem+1;j<dataGridViewnhapkho.Rows.Count-1;j++)
            {
                ModuleDB.cnn = new SqlConnection(ModuleDB.cnnstr);
                SqlCommand cm = new SqlCommand("SELECT dbo.fu_createMANK()",ModuleDB.cnn);
                ModuleDB.cnn.Open();
                a.MASANPHAM = cm.ExecuteScalar().ToString();
                nhapkho.EndCurrentEdit();
                a.TENSANPHAM = dataGridViewnhapkho.Rows[j].Cells[1].Value.ToString();
                a.LOAISANPHAM = dataGridViewnhapkho.Rows[j].Cells[2].Value.ToString();
                a.SOLUONG=(int)dataGridViewnhapkho.Rows[j].Cells[3].Value;
                a.GIA = (double)dataGridViewnhapkho.Rows[j].Cells[4].Value;
                a.THOIGIAN = dateTimePicker1.Value;
                db.TBL_SANPHAMs.InsertOnSubmit(a);
                db.SubmitChanges();
                ModuleDB.cnn.Close();

            }
            MessageBox.Show("Thêm vào kho thành công");
           
        }

        private void Formnhapkho_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            Table <TBL_SANPHAM> a= db.GetTable<TBL_SANPHAM>();
            nhapkho = this.BindingContext[a];
            dataGridViewnhapkho.AutoGenerateColumns = false;
            dataGridViewnhapkho.DataSource = a;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nhapkho.AddNew();
            //MessageBox.Show(dataGridViewnhapkho.Rows.Count.ToString());
             //MessageBox.Show(dataGridViewnhapkho.Rows[0].Cells[2].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            savedatabase();
            dataGridViewnhapkho.DataSource = null;
            loaddatagrid();
        }

        private void dataGridViewnhapkho_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach(DataGridViewRow r in dataGridViewnhapkho.Rows)
            {
                r.Cells[0].Value = r.Index + 1;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DataClasses1DataContext db = new DataClasses1DataContext();
            if(cbxthang.SelectedIndex>=0)
            {
                dataGridViewnhapkho.DataSource = from sp in db.TBL_SANPHAMs
                                                 where sp.THOIGIAN.Value.Month.Equals(cbxthang.SelectedItem)
                                                 select sp;
            }
            if(cbxthang.SelectedIndex==-1)
            {
                loaddatagrid();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            if (cbxnguyenlieu.SelectedIndex >= 0)
            {
                dataGridViewnhapkho.DataSource = from sp in db.TBL_SANPHAMs
                                                 where sp.LOAISANPHAM.Equals(cbxnguyenlieu.SelectedItem)
                                                 select sp;
            }
            if (cbxnguyenlieu.SelectedIndex == -1)
            {
                loaddatagrid();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxtenhang.Text == "") 
            {
                loaddatagrid();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            if (textBoxtenhang.Text != "") ;
            {
                dataGridViewnhapkho.DataSource = from sp in db.TBL_SANPHAMs
                                                 where sp.TENSANPHAM. Equals(textBoxtenhang.Text)
                                                 select sp;
            }
            
                
        }

        private void dataGridViewnhapkho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex<=6&&e.RowIndex>=0)
            {
                if(e.ColumnIndex==5)
                {
                    nhapkho.Position = e.RowIndex;
                    DataClasses1DataContext db = new DataClasses1DataContext();
                    TBL_SANPHAM a = new TBL_SANPHAM();
                    a = (TBL_SANPHAM)nhapkho.Current;
                    TBL_SANPHAM b = new TBL_SANPHAM();
                    b = db.TBL_SANPHAMs.Single(p => p.MASANPHAM.Equals(a.MASANPHAM));
                    db.TBL_SANPHAMs.DeleteOnSubmit(b);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa thành công");
                    loaddatagrid();
                }

            }
            nhapkho.Position = 0;

        }
    }
}
