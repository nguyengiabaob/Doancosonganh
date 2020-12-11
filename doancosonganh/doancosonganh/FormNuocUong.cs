using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;
using System.Data.Linq;

namespace doancosonganh
{
    public partial class FormNuocUong : Form
    {
        public FormNuocUong()
        {
            InitializeComponent();
        }
        Bitmap bitmap;
        int i = 0;
        int indexhinh;
        List<Image> hinh = new List<Image>();
        Bangloaisanpham banglsp = new Bangloaisanpham();
        BindingManagerBase sanpham;
        int phanbiet = 0;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void loadlistviewnuocuong()

        {
            listviewnuocuong.Items.Clear();

            listviewnuocuong.View = View.Details;





            listviewnuocuong.FullRowSelect = true;

            //listViewmonan.FullRowSelect = true;
            int dem = 0;
            foreach (DataRow r in banglsp.Rows)
            {
                if (r["LOAISANPHAM"].ToString() == "NUOC")
                {
                    
                    if (r["HINH"] == System.DBNull.Value)

                    {
                        listviewnuocuong.Items.Add(r["TENSANPHAM"].ToString());
                    }
                    else
                    if (r["HINH"] != System.DBNull.Value)
                    {
                        listviewnuocuong.Items.Add(r["TENSANPHAM"].ToString(), dem);
                        dem++;
                    }
                    listviewnuocuong.Items[i].SubItems.Add(r["MASANPHAM"].ToString());
                    listviewnuocuong.Items[i].SubItems.Add((i + 1).ToString());
                    listviewnuocuong.Items[i].SubItems.Add(r["DONGIA"].ToString());
                    i++;
                }
               
                sanpham = BindingContext[banglsp];
            }


        }

        private void FormNuocUong_Load(object sender, EventArgs e)
        {
            i = 0;
            loadimagelist();
            loadlistviewnuocuong();
            //pictureBox1.DataBindings.Add("IMAGE", banglsp, "HINH", true);
            //pictureBox1.Image=null;
            buttonxoanuoc.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            TBL_LOAISANPHAM b = new TBL_LOAISANPHAM();
            b = db.TBL_LOAISANPHAMs.Single(p => p.TENSANPHAM.Equals(tbxtensanpham.Text));
           // ListViewItem monan = listviewnuocuong.FindItemWithText(tbxtensanpham.Text, true, 0);
            //MessageBox.Show(monan.Text);
            tbxmasanpham.Text =b.MASANPHAM;
            numupdowgia.Value = System.Decimal.Parse(b.DONGIA.ToString());
            numericUpDownSL1.Value = System.Decimal.Parse(b.SOLUONG.ToString());
            buttonxoanuoc.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            phanbiet = 1;
            tbxmasanpham1.Text = "";
            tbxtensanpham1.Text = "";
            numupdowsoluong.Value = 0;
            sanpham.AddNew();
            SqlCommand cmm = new SqlCommand("SELECT dbo.fu_createMASP()", ModuleDB.cnn);
            ModuleDB.cnn.Open();
            tbxmasanpham1.Text = cmm.ExecuteScalar().ToString();
            ModuleDB.cnn.Close();
        }
        private bool check()
        {
            if (tbxtensanpham1.Text == "" || numupdowsoluong.Value == 0||numupdow2.Value==0)
                return false;
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(check()==true&&phanbiet==1)
            {
                addimagelist();
                listviewnuocuong.Items.Add(tbxtensanpham1.Text);
                listviewnuocuong.Items[i].SubItems.Add(tbxmasanpham1.Text);
                listviewnuocuong.Items[i].SubItems.Add((i + 1).ToString());
                listviewnuocuong.Items[i].SubItems.Add(numupdow2.Value.ToString());
                i++;
                //SqlCommand cmm = new SqlCommand("insert into TBL_LOAISANPHAM (MASANPHAM,LOAISANPHAM,TENSANPHAM,SOLUONG,DONGIA,HINH) values('" + tbxmasanpham1.Text + "','" + "Mon'" + ",'" + tbxtensanpham1.Text + "'," + numupdowsoluong.Value + "," + numupdow2.Value + "," + pictureBox1.Image+")");

                //ModuleDB.cnn.Open();
                //cmm.ExecuteNonQuery();
                //ModuleDB.cnn.Close();
                saveimages();
                loadlistviewnuocuong();
                phanbiet = 0;
            }
            else
            if(check() == true && phanbiet == -1)
            {
                i = 0;
                repairdatabase();
                imageList1.Images.Clear();
                loadimagelist();
                loadlistviewnuocuong();
                phanbiet = 0;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //sanpham.RemoveAt(sanpham)
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            TBL_LOAISANPHAM b = new TBL_LOAISANPHAM();
            b = db.TBL_LOAISANPHAMs.Single(p => p.MASANPHAM.Equals(tbxmasanpham.Text));
            db.TBL_LOAISANPHAMs.DeleteOnSubmit(b);
            xoatronglist();
            i--;
            MessageBox.Show("Xóa thành công");
            loadimagelist();
            loadlistviewnuocuong();
        }
        private void xoatronglist()
        {
            ListViewItem f = listviewnuocuong.FindItemWithText(tbxtensanpham.Text);
            listviewnuocuong.Items.Remove(f);
        }
        private void saveimages()
        {   
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream, ImageFormat.Png);
            DataClasses1DataContext lsanpham = new DataClasses1DataContext();
            TBL_LOAISANPHAM tblloaisanpham = new TBL_LOAISANPHAM();
            tblloaisanpham.HINH = stream.ToArray();
            tblloaisanpham.MASANPHAM = tbxmasanpham1.Text;
            tblloaisanpham.TENSANPHAM = tbxtensanpham1.Text;
            tblloaisanpham.SOLUONG = (int)numupdowsoluong.Value;
            tblloaisanpham.DONGIA = (int)numupdow2.Value;
            tblloaisanpham.LOAISANPHAM = "NUOC";
            lsanpham.TBL_LOAISANPHAMs.InsertOnSubmit(tblloaisanpham);
            lsanpham.SubmitChanges();


        }
        private void repairdatabase()
        {
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream, ImageFormat.Png);
            DataClasses1DataContext lsanpham = new DataClasses1DataContext();
            TBL_LOAISANPHAM tblloaisanpham = new TBL_LOAISANPHAM();
            tblloaisanpham = lsanpham.TBL_LOAISANPHAMs.Single(p => p.MASANPHAM.Equals(tbxmasanpham1.Text));
            tblloaisanpham.HINH = stream.ToArray();
           
            tblloaisanpham.TENSANPHAM = tbxtensanpham1.Text;
            tblloaisanpham.SOLUONG = (int)numupdowsoluong.Value;
            tblloaisanpham.DONGIA = (int)numupdow2.Value;
            
         
           lsanpham.SubmitChanges();


        }
        private void addimagelist()
        {
            if (pictureBox1.Image != null)
            {
                hinh.Add(pictureBox1.Image);
               
                imageList1.Images.Add(pictureBox1.Image);
                indexhinh = imageList1.Images.Count - 1;


            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "JPG Files|*.jpg|PNG Files|*.png|ALL Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bitmap = new Bitmap(openFileDialog1.FileName);
                MessageBox.Show(openFileDialog1.FileName);
            }
            pictureBox1.Image = bitmap;
        }
        private void loadimagelist()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            Table<TBL_LOAISANPHAM> tbloaisanpham = db.GetTable<TBL_LOAISANPHAM>();
            foreach (TBL_LOAISANPHAM r in tbloaisanpham)

            {
                //Binary hinh0 = r.HINH;
                if (r.HINH != null)
                {
                    MemoryStream st = new MemoryStream(r.HINH.ToArray());
                    Image hinh1 = Image.FromStream(st);
                    if (hinh1 != null)
                        imageList1.Images.Add(hinh1);
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            phanbiet = -1;
            DataClasses1DataContext db = new DataClasses1DataContext();
            foreach(ListViewItem r in  listviewnuocuong.Items)
            {
                if(r.Selected==true)
                {
                    tbxmasanpham1.Text = r.SubItems[1].Text;
                    TBL_LOAISANPHAM b = new TBL_LOAISANPHAM();
                    b = db.TBL_LOAISANPHAMs.Single(p => p.MASANPHAM.Equals(tbxmasanpham1.Text));
                    tbxtensanpham1.Text = b.TENSANPHAM;
                    numupdow2.Value = (int)b.DONGIA;
                    numupdowsoluong.Value = (int)b.SOLUONG;
                }
            }
        }

        private void listviewnuocuong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
