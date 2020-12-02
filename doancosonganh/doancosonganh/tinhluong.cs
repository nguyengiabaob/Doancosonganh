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
    public partial class tinhluong : Form
    {
        public tinhluong()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        Table<TBL_NHANVIEN> tbnhanvien;
        
        private void loadlistbox()
        {
            
            tbnhanvien = db.GetTable<TBL_NHANVIEN>();
            Danhsachnhanvien.DataSource = tbnhanvien;
            Danhsachnhanvien.DisplayMember = "TENNHANVIEN";
            Danhsachnhanvien.ValueMember = "MANV";
            Danhsachnhanvien.SelectedIndex = -1;
            //MessageBox.Show(Danhsachnhanvien.SelectedIndex.ToString());
        }

        private void tinhluong_Load(object sender, EventArgs e)
        {
            loadlistbox();
            //Danhsachnhanvien.SelectedIndex = -1;
            loaddatagridview();
        }

        private void Danhsachnhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
           string manv = "";
            if (Danhsachnhanvien.SelectedIndex >= 0)
            {
                if (Danhsachnhanvien.SelectedIndex == 0)
                { TBL_NHANVIEN a = new TBL_NHANVIEN();
                    tbnhanvien = db.GetTable<TBL_NHANVIEN>();
                    a = tbnhanvien.First();

                    tbxmanhanvien.Text = a.MANV ;
                    tbxchucvu.Text = a.CHUCVU;
                    tbxluong.Text = a.LUONG.ToString();
                    
                }
                if((Danhsachnhanvien.SelectedIndex >0))
                {
                    TBL_NHANVIEN b = new TBL_NHANVIEN();
                    b = db.TBL_NHANVIENs.Single(p => p.MANV.Equals(Danhsachnhanvien.SelectedValue));
                    tbxmanhanvien.Text = b.MANV;
                    tbxchucvu.Text = b.CHUCVU;
                    tbxluong.Text = b.LUONG.ToString();
                }

            }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tongluong = 0;
            if(tbxluong.Text==null|| numericUpDownsogio.Value==0)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên để tính lương");

            }
            else
            {
                tongluong = int.Parse(tbxluong.Text) * (int)numericUpDownsogio.Value;
            }
            tbxtongluong.Text = tongluong.ToString();
            TBL_TINHLUONG_1 a = new TBL_TINHLUONG_1();
            a.MANV = tbxmanhanvien.Text;
            a.LUONG = int.Parse(tbxtongluong.Text);
            a.NGAYNHAN = dateTimePicker1.Value;
            a.CHUCVU = tbxchucvu.Text;
            Table<TBL_TINHLUONG_1> b = db.GetTable<TBL_TINHLUONG_1>();
            b.InsertOnSubmit(a);
            db.SubmitChanges();
            loaddatagridview();

        }
        private void adddatagridview()
        {
            Table<TBL_TINHLUONG_1> tbtinhluong = db.GetTable<TBL_TINHLUONG_1>();
            TBL_TINHLUONG_1 a = new TBL_TINHLUONG_1();
            a.MANV = tbxmanhanvien.Text;
            a.CHUCVU = tbxchucvu.Text;
            a.LUONG = int.Parse(tbxluong.Text);
            a.NGAYNHAN = dateTimePicker1.Value;
            tbtinhluong.InsertOnSubmit(a);
            db.SubmitChanges();
            
        }
        private void loaddatagridview()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = from nhanvien in db.TBL_NHANVIENs
                                       join luong in db.TBL_TINHLUONG_1s on nhanvien.MANV equals luong.MANV
                                       select new { nhanvien.MANV, nhanvien.TENNHANVIEN, nhanvien.GIOITINH, luong.CHUCVU, luong.LUONG };
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex <= 4)
            {
                if (e.ColumnIndex == 5)
                {
                    TBL_TINHLUONG_1 a = new TBL_TINHLUONG_1();
                    a = db.TBL_TINHLUONG_1s.Single(p => p.MANV.Equals(dataGridView1.Rows[e.RowIndex].Cells[1]));
                    a.LUONG = int.Parse(tbxluong.Text);
                    db.SubmitChanges();
                    loaddatagridview();
                }
                else
                    if (e.ColumnIndex == 6)
                {
                    TBL_TINHLUONG_1 a = new TBL_TINHLUONG_1();
                    a = db.TBL_TINHLUONG_1s.Single(p => p.MANV.Equals(dataGridView1.Rows[e.RowIndex].Cells[1]));
                    db.TBL_TINHLUONG_1s.DeleteOnSubmit(a);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa thành công");
                    loaddatagridview();
                }
            }
                   
            

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Xóa.Visible = true;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex <= 4)
            {
                lưu.Visible = true;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex <= 4)
            {
                lưu.Visible = true;
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Cells[0].Value = r.Index + 1;
            }
        }
    }
    
}
