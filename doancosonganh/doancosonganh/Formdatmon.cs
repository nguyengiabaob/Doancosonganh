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
    
    public partial class Formdatmon : Form
    {
        public Formdatmon()
        {
            InitializeComponent();
        }
        public Formdatmon(string mahoadon)
        {
            InitializeComponent();
            mahoadon = tbxmahoadon.Text;
        }
        int i = 1;
        Bangloaisanpham tbloaisanpham_1 = new Bangloaisanpham();
        TBhoadonct tbhoadonct = new TBhoadonct();
        BindingManagerBase loaisanpham;
        Table<TBL_LOAISANPHAM> tbloaisanpham;
        Table<TBL_HOADONCT> tbsanpham;
        Table<TBL_BAN> tbban;
        Table<TBL_HOADON> tbhoadon;
        BindingManagerBase hoadonct;
        private void  loadcomboxdanhmucsanpham()
        {
            cbxdanhmucsanpham.Items.Add("Món ăn");
            cbxdanhmucsanpham.Items.Add("Nước uống");
        }
        private void loadcombotensanphammon()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var a = from sp in db.TBL_LOAISANPHAMs
                    where sp.LOAISANPHAM.Equals("MON")
                    select sp;
            cbxtensanpham.DataSource = a;
            cbxtensanpham.DisplayMember = "TENSANPHAM";
            cbxtensanpham.ValueMember="MASANPHAM";
        }
        private void loadcombotensanphamnuocuong()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var a = from sp in db.TBL_LOAISANPHAMs
                    where sp.LOAISANPHAM.Equals("NUOC")
                    select sp;
            cbxtensanpham.DataSource = a;
            cbxtensanpham.DisplayMember = "TENSANPHAM";
            cbxtensanpham.ValueMember = "MASANPHAM";
        }
        private void Formdatmon_Load(object sender, EventArgs e)
        {
            loadcomboxdanhmucsanpham();


            loadsanpham();
            loadpanelban();
            loadchuyenban();
            //datagridviewspdadat.DataSource = null;
        }

        private void cbxdanhmucsanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxdanhmucsanpham.SelectedIndex>=0)
            {
                if (cbxdanhmucsanpham.SelectedItem.ToString() == "Món ăn")
                {
                    loadcombotensanphammon();
                }
                else
                    if (cbxdanhmucsanpham.SelectedItem.ToString() == "Nước uống")
                {
                    loadcombotensanphamnuocuong();
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            tbsanpham = db.GetTable<TBL_HOADONCT>();
            int i = 1;
            
            TBL_HOADONCT a = new TBL_HOADONCT();
            TBL_LOAISANPHAM b = new TBL_LOAISANPHAM();
            a.PHANBIET = i;
            a.MASAPHAM = cbxtensanpham.SelectedValue.ToString();
            a.TENSANPHAM = cbxtensanpham.Text;
            a.SOLUONG =(int) numericUpDownsoluong.Value;
            a.MAHDBAN = tbxmahoadon.Text;
            b = db.TBL_LOAISANPHAMs.Single(p => p.MASANPHAM.Equals(a.MASAPHAM));
            a.GIA = b.DONGIA*(double)numericUpDownsoluong.Value;
            a.THANHTOAN = false;
            a.SOBAN = int.Parse(tbxtenban.Text.Substring(4, 1));
            db.TBL_HOADONCTs.InsertOnSubmit(a);
            db.SubmitChanges();
            tbhoadonct.ghi();
            datagridviewspdadat.AutoGenerateColumns = false;
            
            datagridviewspdadat.DataSource = tbsanpham.Where(p => p.MAHDBAN.Equals(tbxmahoadon.Text));
            loadtongtien();
            i++;
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            DataClasses1DataContext db = new DataClasses1DataContext();
            tbsanpham = db.GetTable<TBL_HOADONCT>();
            foreach (Button r in panelban.Controls)
            {
                if(r==sender)
                {

                    tbxtenban.Text = r.Text;
                }
            }
            if (capnhatmahoadon() == null)
            {
                createMAHD();
                i = 1;
                datagridviewspdadat.DataSource = null;
            }
            else
            {
                int tt = 1;
                tbxmahoadon.Text = capnhatmahoadon();
                datagridviewspdadat.AutoGenerateColumns = false;
                //tbhoadonct.DefaultView.RowFilter = "MAHDBAN='" + tbxmahoadon.Text + "'";
                var a = db.TBL_HOADONCTs.Where(p => p.MAHDBAN.Equals(tbxmahoadon.Text));
                foreach(var r in a)
                {
                    r.PHANBIET = tt;
                    tt++;
                }
                db.SubmitChanges();
                datagridviewspdadat.DataSource = tbsanpham.Where(p=>p.MAHDBAN.Equals(tbxmahoadon.Text)) ;
                loadtongtien();
            }
           

        }

        // private void datagirdviewloaisanpham_RowEnter(object sender, DataGridViewCellEventArgs e)
        // {

        // }

        // private void datagirdviewloaisanpham_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        // {   
        //     //if(tbxtenban.Text=="")
        //     //{
        //     //    MessageBox.Show("Bạn chưa chọn bàn để đặt món");
        //     //    return;
        //     //}
        //     //DataClasses1DataContext db = new DataClasses1DataContext();
        //     //tbloaisanpham = db.GetTable<TBL_LOAISANPHAM>();
        //     //tbhoadon = db.GetTable<TBL_HOADON>();
        //     //TBL_HOADON hoadon = new TBL_HOADON();
        //     // tbsanpham = db.GetTable<TBL_HOADONCT>();
        //     //TBL_HOADONCT sanpham = new TBL_HOADONCT();
        //     //TBL_LOAISANPHAM loaisanp = new TBL_LOAISANPHAM();
        //     //loaisanp = (TBL_LOAISANPHAM)loaisanpham.Current;
        //     //sanpham.MAHDBAN = tbxmahoadon.Text;
        //     //sanpham.MASAPHAM = loaisanp.MASANPHAM;
        //     //sanpham.TENSANPHAM = loaisanp.TENSANPHAM;
        //     //sanpham.GIA = loaisanp.DONGIA;
        //     //sanpham.SOLUONG = 1;
        //     //sanpham.SOBAN = int.Parse(tbxtenban.Text.Substring(4, 1));
        //     //hoadon.MAHDBAN = tbxmahoadon.Text;
        //     //hoadon.THANHTOAN = false;
        //     //tbhoadon.InsertOnSubmit(hoadon);
        //     //tbsanpham.InsertOnSubmit(sanpham);
        //     //db.SubmitChanges();
        //     //loadsanpham();
        //     //loadtongtien();
        // }
        private void loadsanpham()

        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            tbsanpham = db.GetTable<TBL_HOADONCT>();
            hoadonct = this.BindingContext[tbsanpham];
            //loadtongtien();
        }



        // private void textBox1_TextChanged(object sender, EventArgs e)
        //{


        //    //if(tbxtensanpham.Text== "")
        //    // {
        //    //     loadbangloaisanpham();
        //    // }
        //    //else
        //    //{
        //    //     //DataClasses1DataContext db = new DataClasses1DataContext();
        //    //     //datagirdviewloaisanpham.DataSource = from loaisp in db.TBL_LOAISANPHAMs
        //    //     //                                     where loaisp.TENSANPHAM.Equals(tbxtensanpham.Text) == true
        //    //     //                                    select loaisp;

        //    }
        // }

        // private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        // {
        //     //if (numericdowgia.Value ==0)
        //     //{
        //     //    loadbangloaisanpham();
        //     //}
        //     //else
        //     //{
        //     //    DataClasses1DataContext db = new DataClasses1DataContext();
        //     //    datagirdviewloaisanpham.DataSource = from loaisp in db.TBL_LOAISANPHAMs
        //     //                                         where loaisp.DONGIA.Equals(numericdowgia.Value) == true
        //     //                                         select loaisp;

        //     }
        // }
        private void loadtongtien()

        {
            int tongtien = 0;
            DataClasses1DataContext db = new DataClasses1DataContext();

            var b = from hdct in db.TBL_HOADONCTs
                    where hdct.MAHDBAN.Equals(tbxmahoadon.Text)
                    select hdct;
            foreach (var r in b)
            {
                tongtien += (int)r.GIA;
            }



              tbxtongtien.Text = tongtien.ToString();

            }

           
        private void createMAHD()
         {
             SqlCommand cmm = new SqlCommand("select dbo.fu_createMAHDBANN()", ModuleDB.cnn);
           ModuleDB.cnn.Open();
            tbxmahoadon.Text = cmm.ExecuteScalar().ToString();
            ModuleDB.cnn.Close();



        }

        // private void button1_Click(object sender, EventArgs e)
        // {

        // }
        private void createbuttonban(int lechdong, int lechcot, int soban, int dong, int cot, int xbandau, int ybandau,string trangthai)
        {

            string name = "Ban" + soban;
            Button ban1 = new Button();
            Size a = new Size();
            a.Height = 96;
            a.Width = 97;
            ban1.Size = a;
            Point A = new Point();
            A.X = xbandau + lechcot * cot;
            A.Y = ybandau + lechdong * dong;
            ban1.Location = A;
            ban1.Text = "Bàn " + soban;
            
            ban1.Image = Image.FromFile("D:\\doancosonganh\\doancosonganh\\doancosonganh\\Resources\\furniture.png");
            ban1.TextAlign = ContentAlignment.MiddleLeft;
            ban1.TextImageRelation = TextImageRelation.ImageBeforeText;
            panelban.Controls.Add(ban1);
            ban1.Click += new EventHandler(button1_Click);
            if(trangthai=="Trống")
            {
                ban1.BackColor = Color.MistyRose;
            }
            else
                if(trangthai=="Đã đặt")
            {
                ban1.BackColor = Color.LightSalmon;
            }

        }

        // //private void button1_Click_1(object sender, EventArgs e)
        // {
        //     //createMAHD();
        //     //tbxtenban.Text = button1.Text;
        // }
        private void loadpanelban()
        {
            int cot = 0;
            int dong = 0;
            panelban.Controls.Clear();
            DataClasses1DataContext db = new DataClasses1DataContext();
            tbban = db.GetTable<TBL_BAN>();
            foreach (TBL_BAN r in tbban)
            {
                int sb = (int)r.SOBAN;
                createbuttonban(129, 128, sb, dong, cot, 17, 7,r.TRANGTHAI);
                cot++;
                if (cot == 5)
                {
                    cot = 0;
                    dong++;
                }

            }

        }
        private void loadchuyenban()
         {
           DataClasses1DataContext db = new DataClasses1DataContext();
             tbban = db.GetTable<TBL_BAN>();
            foreach (TBL_BAN r in tbban)
            {
                if (r.TRANGTHAI == "Trống")
                {
                    cbxbanchuyen.Items.Add(r.SOBAN);

                }
                else if (r.TRANGTHAI == "Đã đặt")
                {
                    cbxbancanchuyen.Items.Add(r.SOBAN);
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int bancanchuyen = int.Parse(cbxbancanchuyen.SelectedItem.ToString());
            int banchuyen = int.Parse(cbxbanchuyen.SelectedItem.ToString());
            DataClasses1DataContext db = new DataClasses1DataContext();
            tbban = db.GetTable<TBL_BAN>();
            TBL_BAN bcc = new TBL_BAN();
            TBL_BAN bc = new TBL_BAN();
            bcc = db.TBL_BANs.Single(p => p.SOBAN.Equals(bancanchuyen));
            bcc.TRANGTHAI = "Trống";
            db.SubmitChanges();
            bc = db.TBL_BANs.Single(p => p.SOBAN.Equals(banchuyen));
            bc.TRANGTHAI = "Đã đặt";
            db.SubmitChanges();

        }
        private void loadsanphamchuyen()
        {

            DataClasses1DataContext db = new DataClasses1DataContext();
            var sapham = db.TBL_HOADONCTs.Where(p => p.SOBAN.Equals(int.Parse(cbxbancanchuyen.SelectedItem.ToString())));
            foreach (TBL_HOADONCT r in sapham)
            {
                r.SOBAN = int.Parse(cbxbanchuyen.SelectedItem.ToString());

            }
            db.SubmitChanges();
            Table<TBL_BAN> a = db.GetTable<TBL_BAN>();
            foreach(TBL_BAN r in a)
            {
                if(r.SOBAN== int.Parse(cbxbancanchuyen.SelectedItem.ToString()))
                    {
                    r.TRANGTHAI = "Trống";
                }
                if(r.SOBAN== int.Parse(cbxbanchuyen.SelectedItem.ToString()))
                    {
                    r.TRANGTHAI = "Đã đặt";
                }
            }
            db.SubmitChanges();
            loadpanelban();
            loadchuyenban();
            

        }
        private bool checkthanhtoan(string mhdon)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var SP = from hd in db.TBL_HOADONCTs
                     select new { hd.MAHDBAN, hd.MASAPHAM, hd.TENSANPHAM, hd.SOLUONG, hd.SOBAN, hd.GIA, hd.THANHTOAN };
            foreach (var r in SP)
            {
                if (r.THANHTOAN == false && r.SOBAN == int.Parse(tbxtenban.Text.Substring(4, 1)))
                {
                    mhdon = r.MAHDBAN;
                    return false;

                }
                //else
                //if(SP==null)
                // {

                // }
            }
            return true;
        }
        private string capnhatmahoadon()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var SP = from hd in db.TBL_HOADONCTs
                     select new { hd.MAHDBAN, hd.MASAPHAM, hd.TENSANPHAM, hd.SOLUONG, hd.SOBAN, hd.GIA, hd.THANHTOAN };
            foreach (var r in SP)
            {
                if (r.THANHTOAN == false && r.SOBAN == int.Parse(tbxtenban.Text.Substring(4, 1)))
                {
                    return r.MAHDBAN;

                }
            }
            return null;
        }

        

        private void datagridviewspdadat_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in datagridviewspdadat.Rows)
            {
                r.Cells[0].Value = r.Index + 1;
            }
        }

        private void datagridviewspdadat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0 && e.ColumnIndex <= 5)
            {
                int INDEX=0;
                foreach (DataGridViewRow r in datagridviewspdadat.Rows)
                {
                    if (r.Index == e.RowIndex)
                    {

                        INDEX = int.Parse(r.Cells[0].Value.ToString());
                    }
                }
                MessageBox.Show(e.ColumnIndex.ToString());
                if (e.ColumnIndex == 4)
                {
                    
                    DataClasses1DataContext db = new DataClasses1DataContext();
                    tbsanpham = db.GetTable<TBL_HOADONCT>();
                    
                    //TBL_HOADONCT a = new TBL_HOADONCT();
                    //a = (TBL_HOADONCT)hoadonct.Current;

                    TBL_HOADONCT b = db.TBL_HOADONCTs.Single(p => p.MAHDBAN.Equals(tbxmahoadon.Text) && p.PHANBIET.Equals(INDEX));
                    b.SOLUONG += 1;
                    db.SubmitChanges();
                    TBL_HOADONCT c = db.TBL_HOADONCTs.Single(p => p.MAHDBAN.Equals(tbxmahoadon.Text) && p.PHANBIET.Equals(INDEX));
                    c.GIA = c.SOLUONG * c.GIA;
                    db.SubmitChanges();
                    tbhoadonct.ghi();

                    //datagridviewspdadat.AutoGenerateColumns = false;
                    //tbhoadonct.DefaultView.RowFilter = "MAHDBAN='" + tbxmahoadon.Text + "'";
                    datagridviewspdadat.DataSource = tbsanpham.Where(p => p.MAHDBAN.Equals(tbxmahoadon.Text));
                    loadtongtien();
                }


                else
                    if (e.ColumnIndex == 5)
                    {
                        DataClasses1DataContext db = new DataClasses1DataContext();
                    tbsanpham = db.GetTable<TBL_HOADONCT>();
                    TBL_HOADONCT a = (TBL_HOADONCT)hoadonct.Current;
                    TBL_HOADONCT b = new TBL_HOADONCT();
                    b = db.TBL_HOADONCTs.Single(p => p.MAHDBAN.Equals(tbxmahoadon.Text) && p.PHANBIET.Equals(INDEX));
                    db.TBL_HOADONCTs.DeleteOnSubmit(b);
                    db.SubmitChanges();
                    //datagridviewspdadat.AutoGenerateColumns = false;
                    //tbhoadonct.DefaultView.RowFilter = "MAHDBAN='" + tbxmahoadon.Text + "'";
                    datagridviewspdadat.DataSource = tbsanpham.Where(p => p.MAHDBAN.Equals(tbxmahoadon.Text));
                    loadtongtien();

                }


            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            if (tbxthanhtoan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thanh toán");
            }
            else
            {
                int sotienconlai = int.Parse(tbxthanhtoan.Text) - int.Parse(tbxtongtien.Text);
                tbxsotienconlai.Text = sotienconlai.ToString();
                if (sotienconlai > 0)
                {
                    var b = db.TBL_HOADONCTs.Where(p => p.MAHDBAN.Equals(tbxmahoadon.Text));
                    foreach (var r in b)
                    {
                        r.THANHTOAN = true;
                    }
                    TBL_HOADON a = new TBL_HOADON();
                    a.MAHDBAN = tbxmahoadon.Text;
                    a.MANV = "NV02";
                    a.TONGTIEN = int.Parse(tbxtongtien.Text);
                    a.NGAYBAN = dateTimengaylap.Value;
                    a.THANHTOAN = true;
                    Table<TBL_HOADON> c = db.GetTable<TBL_HOADON>();
                    c.InsertOnSubmit(a);
                    db.SubmitChanges();
                }

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            reporthoadon a = new reporthoadon(tbxthanhtoan.Text,tbxsotienconlai.Text,tbxmahoadon.Text,dateTimengaylap.Value,"a");
            a.WindowState = FormWindowState.Normal;
            a.Show();

          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            loadsanphamchuyen();
        }

        // private void button13_Click(object sender, EventArgs e)
        // {
        //     hoadonct a = new hoadonct(tbxmahoadon.Text);
        //     a.WindowState = FormWindowState.Normal;
        //     a.Show();
        // }
    }
}
