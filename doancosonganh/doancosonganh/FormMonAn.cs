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
    public partial class FormMonAn : Form
    {
        public FormMonAn()
        {
            InitializeComponent();
        }
        Bitmap bitmap;
         public int i ;
        int indexhinh;
        List<Image> hinh = new List<Image>() ;
        Bangloaisanpham banglsp = new Bangloaisanpham();
        BindingManagerBase sanpham;
        int phanbiet = 0;
        public ImageFormat ImageFomat { get; private set; }
        public object MyDbContextDataContext { get; private set; }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void loadimagelist()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            Table<TBL_LOAISANPHAM> tbloaisanpham = db.GetTable<TBL_LOAISANPHAM>();
            foreach(TBL_LOAISANPHAM r in tbloaisanpham)
              
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
        private void loadlistviewmonan()
            
        {
            listViewmonan.Items.Clear();

            listViewmonan.View = View.Details;

           

            

            listViewmonan.FullRowSelect = true;

            //listViewmonan.FullRowSelect = true;
            int dem = 0;
            foreach (DataRow r in banglsp.Rows)
             
            {
                if (r["LOAISANPHAM"].ToString() == "MON")
                {
                    
                    if (r["HINH"] == System.DBNull.Value)

                    {
                        listViewmonan.Items.Add(r["TENSANPHAM"].ToString());
                    }
                    else
                    if (r["HINH"] != System.DBNull.Value)
                    {
                        listViewmonan.Items.Add(r["TENSANPHAM"].ToString(), dem);
                        dem++;
                    }
                    listViewmonan.Items[i].SubItems.Add(r["MASANPHAM"].ToString());
                    listViewmonan.Items[i].SubItems.Add((i + 1).ToString());
                    listViewmonan.Items[i].SubItems.Add(r["DONGIA"].ToString());

                    i++;

                }
            }
            sanpham = BindingContext[banglsp];
          
            
        }
        private void FormMonAn_Load(object sender, EventArgs e)
        {
            i = 0;
            loadimagelist();
            loadlistviewmonan();
            //pictureBox1.DataBindings.Add("IMAGE", banglsp, "HINH", true);
            //pictureBox1.Image = null;
            btxoa.Enabled = false;
        }

        private void listViewmonan_SearchForVirtualItem(object sender, SearchForVirtualItemEventArgs e)
        {
            //listViewmonan.FindItemWithText(tbxtensanpham.Text, true, 0);
        }

        private void button7_Click(object sender, EventArgs e)
        {


            DataClasses1DataContext db = new DataClasses1DataContext();
            TBL_LOAISANPHAM a = new TBL_LOAISANPHAM();
            a = db.TBL_LOAISANPHAMs.Single(p => p.TENSANPHAM.Equals(tbxtensanpham.Text));

            //MessageBox.Show(monan.Text);
                tbxmasanpham.Text =a.MASANPHAM;
                numupdowgia.Value = System.Decimal.Parse(a.DONGIA.ToString());
            numericUpDown1.Value = System.Decimal.Parse(a.SOLUONG.ToString());
            btxoa.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbxmasanpham1.Text = "";
            tbxtensanpham1.Text = "";
            numericUpDownsoluong.Value = 0;
            numupdow2.Value = 0;
            sanpham.AddNew();
            SqlCommand cmm = new SqlCommand("SELECT dbo.fu_createMASP()", ModuleDB.cnn);
            ModuleDB.cnn.Open();
            tbxmasanpham1.Text = cmm.ExecuteScalar().ToString();
           
            ModuleDB.cnn.Close();

        }
        private bool check()
        {
            if (tbxtensanpham1.Text == "" || numupdow2.Value == 0||pictureBox1.Image==null||numericUpDownsoluong.Value==0) 
                return false;
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
              
           
                if (check() == true&& phanbiet==1)
                {
                    
                    addimagelist();
                    
               
                    listViewmonan.Items.Add(tbxtensanpham1.Text,indexhinh);
                    listViewmonan.Items[i].SubItems.Add(tbxmasanpham1.Text);
                    listViewmonan.Items[i].SubItems.Add((i + 1).ToString());
                    listViewmonan.Items[i].SubItems.Add(numupdow2.Value.ToString());
                   
                    i++;

                //string cmmtext = "insert into TBL_LOAISANPHAM (MASANPHAM,LOAISANPHAM,TENSANPHAM,SOLUONG,DONGIA,HINH)values('"
                //        + tbxmasanpham1.Text + "','" + "Mon" + "','" + tbxtensanpham1.Text.Trim() + "'," + numericUpDownsoluong.Value + "," + numupdow2.Value +","+stream.ToArray()+")";
                //    SqlCommand cmm = new SqlCommand(cmmtext,ModuleDB.cnn);

                //    ModuleDB.cnn.Open();
                //    cmm.ExecuteNonQuery();
                //    ModuleDB.cnn.Close();
                saveimages();
                phanbiet = 0;
               
                }
            else
                if (check() == true && phanbiet == -1)
            {
                i = 0;
                repairdatabase();
                imageList1.Images.Clear();
                loadimagelist();
                loadlistviewmonan();
                phanbiet = 0;
            }


        }
        private void luuanh()
        {
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream, ImageFormat.Png);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sanpham.RemoveAt(sanpham.Position);
            if(banglsp.ghi()==true)
            {
                MessageBox.Show("Xóa thành công");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter= "JPG Files|*.jpg|PNG Files|*.png|ALL Files|*.*";
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                bitmap = new Bitmap(openFileDialog1.FileName);
                MessageBox.Show(openFileDialog1.FileName);
            }
            pictureBox1.Image = bitmap;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //try
            //{ 
            //if(ModuleDB.cnn.State==ConnectionState.Closed)
            //    {
            //        ModuleDB.cnn.Open();
            //    }
            //SqlCommand cmm = new SqlCommand("DELETE From TBL_LOAISANPHAM WHERE MASANPHAM='" + tbxmasanpham.Text+"'",ModuleDB.cnn);
            //cmm.ExecuteNonQuery();
            //  ModuleDB.cnn.Close();
            //}
            //catch(Exception EX)
            //{
            //    throw EX;
            //}
            DataClasses1DataContext db = new DataClasses1DataContext();
            TBL_LOAISANPHAM a = new TBL_LOAISANPHAM();
            a = db.TBL_LOAISANPHAMs.Single(p => p.MASANPHAM.Equals(tbxmasanpham.Text));
            db.TBL_LOAISANPHAMs.DeleteOnSubmit(a);
            db.SubmitChanges();
            xoatronglist();
            i--;
            MessageBox.Show("Xóa thành công");
            loadimagelist();
            loadlistviewmonan();
            

        }
        private void xoatronglist()
        { ListViewItem f = listViewmonan.FindItemWithText(tbxtensanpham.Text);
            listViewmonan.Items.Remove(f);
        }
        private void addimagelist()
        {  if (pictureBox1.Image != null)
            {
                hinh.Add(pictureBox1.Image);
               
                imageList1.Images.Add(pictureBox1.Image);
                indexhinh = imageList1.Images.Count - 1;

            }
            
        }
        private void saveimages()
        {
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream, ImageFormat.Png);
            DataClasses1DataContext lsanpham = new DataClasses1DataContext();
            TBL_LOAISANPHAM tblloaisanpham = new TBL_LOAISANPHAM();
            tblloaisanpham.HINH = stream.GetBuffer();
            tblloaisanpham.MASANPHAM = tbxmasanpham1.Text;
            tblloaisanpham.TENSANPHAM = tbxtensanpham1.Text;
            tblloaisanpham.SOLUONG =(int)numericUpDownsoluong.Value;
            tblloaisanpham.DONGIA = (int)numupdow2.Value;
            tblloaisanpham.LOAISANPHAM = "MON";
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
            tblloaisanpham.SOLUONG = (int)numericUpDownsoluong.Value;
            tblloaisanpham.DONGIA = (int)numupdow2.Value;


            lsanpham.SubmitChanges();


        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            phanbiet = -1;
            DataClasses1DataContext db = new DataClasses1DataContext();
            foreach (ListViewItem r in listViewmonan.Items)
            {
                if (r.Selected == true)
                {
                    tbxmasanpham1.Text = r.SubItems[1].Text;
                    TBL_LOAISANPHAM b = new TBL_LOAISANPHAM();
                    b = db.TBL_LOAISANPHAMs.Single(p => p.MASANPHAM.Equals(tbxmasanpham1.Text));
                    tbxtensanpham1.Text = b.TENSANPHAM;
                    numupdow2.Value = (int)b.DONGIA;
                    numericUpDownsoluong.Value = (int)b.SOLUONG;
                }
            }
        }
    }
}
