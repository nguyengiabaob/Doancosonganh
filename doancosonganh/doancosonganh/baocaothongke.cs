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
    public partial class baocaothongke : Form
    {
        public baocaothongke()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void loadbaocaothongkenhapkho()
        {
            if (cbxloai.SelectedItem.ToString()=="--Chọn tất cả--") 
            {
                dataGridViewnhapkho.AutoGenerateColumns = false;
                dataGridViewnhapkho.DataSource = null;   
                dataGridViewnhapkho.DataSource = from sp in db.TBL_SANPHAMs
                                                 select sp;

            }
            else
                if (cbxloai.SelectedItem.ToString()!="" && tbxsanpham.Text != "")
            {
                dataGridViewnhapkho.AutoGenerateColumns = false;
                dataGridViewnhapkho.DataSource = null;
                dataGridViewnhapkho.DataSource = from sp in db.TBL_SANPHAMs
                                                 where sp.LOAISANPHAM.Equals(cbxloai.SelectedItem.ToString()) && sp.TENSANPHAM.Equals(tbxsanpham.Text)
                                                 select sp;
            }
            else
                if (cbxloai.SelectedItem.ToString() != "")
                {
                dataGridViewnhapkho.AutoGenerateColumns = false;
                dataGridViewnhapkho.DataSource = null;
                dataGridViewnhapkho.DataSource = from sp in db.TBL_SANPHAMs
                                                     where sp.LOAISANPHAM.Equals(cbxloai.SelectedItem.ToString())
                                                     select sp;
                }
                else
                    if (tbxsanpham.Text != "")
            {
                dataGridViewnhapkho.AutoGenerateColumns = false;
                dataGridViewnhapkho.DataSource = null;
                dataGridViewnhapkho.DataSource = from sp in db.TBL_SANPHAMs
                                                 where sp.TENSANPHAM.Equals(tbxsanpham.Text)
                                                 select sp;
            }
        }
        private void loadcbxloai()
        {
            //cbxloai.Items.Add("--Chọn tất cả--");
            cbxloai.Items.Add("Thịt");
            cbxloai.Items.Add("Rau củ");
            cbxloai.Items.Add("lon/hộp/chai/lọ");
        }

        private void dataGridViewnhapkho_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dataGridViewnhapkho.Rows)
            {
                r.Cells[0].Value = r.Index + 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void baocaothongke_Load(object sender, EventArgs e)
        {
            loadcbxloai();
            cbxloai.SelectedItem = "--Chọn tất cả--";
            loadbaocaothongkenhapkho();
           
        }

        private void cbxloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxloai.SelectedIndex>=0)
                if (cbxloai.SelectedItem.ToString() == "--Chọn tất cả--")
                {
                    dataGridViewnhapkho.AutoGenerateColumns = false;
                    dataGridViewnhapkho.DataSource = null;
                    dataGridViewnhapkho.DataSource = from sp in db.TBL_SANPHAMs
                                                     select sp;

                }else
                       if (cbxloai.SelectedItem.ToString() != "" && tbxsanpham.Text != "Nhập mã, tên" && tbxsanpham.Text != "")
                {
                    dataGridViewnhapkho.AutoGenerateColumns = false;
                    dataGridViewnhapkho.DataSource = null;
                    dataGridViewnhapkho.DataSource = from sp in db.TBL_SANPHAMs
                                                     where sp.LOAISANPHAM.Equals(cbxloai.SelectedItem.ToString()) && sp.TENSANPHAM.Equals(tbxsanpham.Text)
                                                     select sp;
                }
                else
           if (cbxloai.SelectedItem.ToString() != "")
                {
                    dataGridViewnhapkho.AutoGenerateColumns = false;
                    dataGridViewnhapkho.DataSource = null;
                    dataGridViewnhapkho.DataSource = from sp in db.TBL_SANPHAMs
                                                     where sp.LOAISANPHAM.Equals(cbxloai.SelectedItem.ToString())
                                                     select sp;
                }
                else
               if (tbxsanpham.Text != "")
                {
                    dataGridViewnhapkho.AutoGenerateColumns = false;
                    dataGridViewnhapkho.DataSource = null;
                    dataGridViewnhapkho.DataSource = from sp in db.TBL_SANPHAMs
                                                     where sp.TENSANPHAM.Equals(tbxsanpham.Text)
                                                     select sp;
                }
            }
        }
    }

