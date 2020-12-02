using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Data.Sql;

namespace doancosonganh
{
    public partial class Danhsachbanan : Form
    {
        public Danhsachbanan()
        {
            InitializeComponent();
        }
        Bangloaisanpham bangloaisanpham = new Bangloaisanpham();
        BindingManagerBase b;
        Table<TBL_BAN> tbban;
        int i = 0;
        int luu = 0;
        int them = 0;
        string maban;
        private void loadlistban()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            tbban = db.GetTable<TBL_BAN>();
            listViewbanan.Items.Clear();
            listViewbanan.View = View.Details;
            foreach (TBL_BAN r in tbban)
            {
                listViewbanan.Items.Add("Bàn " + r.SOBAN.ToString(), 0);
                listViewbanan.Items[i].SubItems.Add((i + 1).ToString());
                listViewbanan.Items[i].SubItems.Add(r.SONGUOI.ToString());
                listViewbanan.Items[i].SubItems.Add(r.TRANGTHAI.ToString());
                listViewbanan.Items[i].SubItems.Add(r.MASOBAN.ToString());


                i++;
            }
            b = BindingContext[tbban];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            them = 1;
            createmaban();
            createsoban();
            numericUpDownsonguoi.Value = 0;
            radioButtondadat.Checked = false;
            radioButtontrong.Checked = true;
            luu = 0;


        }
        private bool check()
        {
            if (numericUpDownsonguoi.Value == 0 || (radioButtondadat.Checked == false && radioButtontrong.Checked == false) || (radioButtondadat.Checked == true && radioButtontrong.Checked == true))
            {
                MessageBox.Show("Thông tin yêu cầu chưa đầy đủ");
                return false;
            }
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (luu == 1)
            {
                savedatabase();
                luu = 0;
            }
            if (them == 1)
            {
                if (check() == true)
                {
                    listViewbanan.Items.Add("Bàn " + tbxsoban.Text, 0);
                    listViewbanan.Items[i].SubItems.Add((i + 1).ToString());
                    listViewbanan.Items[i].SubItems.Add(numericUpDownsonguoi.Value.ToString());
                    if (radioButtondadat.Checked == true)
                    {
                        listViewbanan.Items[i].SubItems.Add(radioButtondadat.Text);
                    }
                    else if (radioButtontrong.Checked == true)
                    {
                        listViewbanan.Items[i].SubItems.Add(radioButtontrong.Text);
                    }
                    listViewbanan.Items[i].SubItems.Add(tbxmanban.Text);
                    savedatabaseadd();
                }
                i++;
                them = 0;
                loadcomboxban();
            }

        }
        private void savedatabaseadd()
        {
            try
            {
                DataClasses1DataContext db = new DataClasses1DataContext();
                TBL_BAN ban = new TBL_BAN();
                tbban = db.GetTable<TBL_BAN>();
                ban.MASOBAN = tbxmanban.Text;
                ban.SOBAN = int.Parse(tbxsoban.Text);
                ban.SONGUOI = (int)numericUpDownsonguoi.Value;
                if (radioButtondadat.Checked == true)
                    ban.TRANGTHAI = radioButtondadat.Text;
                else
                    if (radioButtontrong.Checked == true)
                {
                    ban.TRANGTHAI = radioButtontrong.Text;
                }
                tbban.InsertOnSubmit(ban);
                db.SubmitChanges();
                MessageBox.Show("Lưu thành công");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Danhsachbanan_Load(object sender, EventArgs e)
        {
            i = 0;
            loadlistban();
            radioButtontrong.Checked = true;
            loadcomboxban();
        }
        private void createmaban()
        {


            SqlCommand cmm = new SqlCommand("select dbo.fu_createMABAN()", ModuleDB.cnn);
            ModuleDB.cnn.Open();
            tbxmanban.Text = cmm.ExecuteScalar().ToString();
            ModuleDB.cnn.Close();

        }
        private void createsoban()
        {
            SqlCommand cmm = new SqlCommand("select dbo.fu_createSOBAN()", ModuleDB.cnn);

            ModuleDB.cnn.Open();
            tbxsoban.Text = cmm.ExecuteScalar().ToString();
            ModuleDB.cnn.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int c = 0;
            DataClasses1DataContext db = new DataClasses1DataContext();
            tbban = db.GetTable<TBL_BAN>();
            TBL_BAN BAN = new TBL_BAN();
            for (int i = 0; i < listViewbanan.Items.Count; i++)
            {
                if (listViewbanan.Items[i].Selected)
                {
                    c = 1;
                    BAN = db.TBL_BANs.Single(p => p.MASOBAN.Equals(listViewbanan.Items[i].SubItems[4].Text));
                    listViewbanan.Items[i].Remove();
                    db.TBL_BANs.DeleteOnSubmit(BAN);
                    db.SubmitChanges();
                    i--;
                }

            }

            if (c == 1)

            {
                MessageBox.Show("Xóa thành công");
                loadagainlistban(0);
            }
            else
                if (c == 0)
            {
                MessageBox.Show("Không tìm thấy để xóa");
            }
        }
        TBL_BAN BAN = new TBL_BAN();

        private void button5_Click(object sender, EventArgs e)
        {
            luu = 1;
            DataClasses1DataContext db = new DataClasses1DataContext();
            tbban = db.GetTable<TBL_BAN>();

            for (int i = 0; i < listViewbanan.Items.Count; i++)
            {
                if (listViewbanan.Items[i].Selected)
                {
                    maban = listViewbanan.Items[i].SubItems[4].Text;
                    BAN = db.TBL_BANs.Single(p => p.MASOBAN.Equals(listViewbanan.Items[i].SubItems[4].Text));
                    tbxmanban.Text = listViewbanan.Items[i].SubItems[4].Text;
                    tbxsoban.Text = listViewbanan.Items[i].SubItems[0].Text.Substring(4, 1);
                    numericUpDownsonguoi.Value = int.Parse(listViewbanan.Items[i].SubItems[2].Text);
                    if (listViewbanan.Items[i].SubItems[3].Text.Equals("Trống"))
                    {
                        radioButtontrong.Checked = true;
                    }
                    else
                        radioButtondadat.Checked = true;
                    break;
                }


            }
        }
        private void savedatabase()
        {
            try
            {
                DataClasses1DataContext db = new DataClasses1DataContext();

                BAN = db.TBL_BANs.Single(p => p.MASOBAN.Equals(maban));
                BAN.MASOBAN = tbxmanban.Text;
                BAN.SOBAN = int.Parse(tbxsoban.Text);
                BAN.SONGUOI = (int)numericUpDownsonguoi.Value;
                if (radioButtondadat.Checked == true)
                    BAN.TRANGTHAI = radioButtondadat.Text;
                else
                    if (radioButtontrong.Checked == true)
                {
                    BAN.TRANGTHAI = radioButtontrong.Text;
                }

                db.SubmitChanges();
                MessageBox.Show("Lưu thành công");
                loadagainlistban(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void loadagainlistban(int statindex)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            tbban = db.GetTable<TBL_BAN>();
            listViewbanan.Items.Clear();
            listViewbanan.View = View.Details;
            foreach (TBL_BAN r in tbban)
            {
                listViewbanan.Items.Add("Bàn " + r.SOBAN.ToString(), 0);
                listViewbanan.Items[statindex].SubItems.Add((statindex + 1).ToString());
                listViewbanan.Items[statindex].SubItems.Add(r.SONGUOI.ToString());
                listViewbanan.Items[statindex].SubItems.Add(r.TRANGTHAI.ToString());
                listViewbanan.Items[statindex].SubItems.Add(r.MASOBAN.ToString());


                statindex++;
            }
        }
        string trangthai;
        int songuoi;
        private void button2_Click(object sender, EventArgs e)
        {
            int t = 0;
            if ((tbxsoban.Text == null || tbxsoban.Text == "") && numericUpDownsonguoi.Value == 0)
            {
                MessageBox.Show("Bạn chưa nhập số bàn!!!");
            }
            else
            {
                DataClasses1DataContext db = new DataClasses1DataContext();
                tbban = db.GetTable<TBL_BAN>();
                TBL_BAN exampleban = new TBL_BAN();
                if (radioButtondadat.Checked == true)
                {
                    trangthai = radioButtondadat.Text;
                }
                else
                    if (radioButtontrong.Checked == true)
                {
                    trangthai = radioButtontrong.Text;
                }


               if (tbxsoban.Text != null && numericUpDownsonguoi.Value == 0)
                    {
                        t = 0;
                        exampleban = db.TBL_BANs.Single(p => (p.SOBAN.Equals(tbxsoban.Text)) && p.TRANGTHAI.Equals(trangthai));
                        listViewbanan.Items.Clear();
                        listViewbanan.View = View.Details;
                        foreach (TBL_BAN r in tbban)
                        {
                            if (r == exampleban)
                            {
                                listViewbanan.Items.Add("Bàn " + r.SOBAN.ToString(),0);
                                listViewbanan.Items[t].SubItems.Add((t + 1).ToString());
                                listViewbanan.Items[t].SubItems.Add(r.SONGUOI.ToString());
                                listViewbanan.Items[t].SubItems.Add(r.TRANGTHAI.ToString());
                                listViewbanan.Items[t].SubItems.Add(r.MASOBAN.ToString());
                                t++;
                            }
                            
                        }
                    }
                
                else
                    if (tbxsoban.Text != "" && numericUpDownsonguoi.Value > 0)
                {
                    listViewbanan.Items.Clear();
                    t = 0;
                    songuoi = (int)numericUpDownsonguoi.Value;
                    foreach (TBL_BAN r in tbban)
                    {
                        if (r.SOBAN == int.Parse(tbxsoban.Text) && r.TRANGTHAI == trangthai && r.SONGUOI == songuoi)
                        {
                            listViewbanan.Items.Add("Bàn " + r.SOBAN.ToString(),0);
                            listViewbanan.Items[t].SubItems.Add((t + 1).ToString());
                            listViewbanan.Items[t].SubItems.Add(r.SONGUOI.ToString());
                            listViewbanan.Items[t].SubItems.Add(r.TRANGTHAI.ToString());
                            listViewbanan.Items[t].SubItems.Add(r.MASOBAN.ToString());
                            t++;
                        }
                       
                    }
                }

                else
                    if (tbxsoban.Text == "" && numericUpDownsonguoi.Value > 0)
                {
                    songuoi = (int)numericUpDownsonguoi.Value;
                    listViewbanan.Items.Clear();
                    t = 0;
                    foreach (TBL_BAN r in tbban)
                    {
                        if (r.TRANGTHAI == trangthai && r.SONGUOI == songuoi)
                        {
                            listViewbanan.Items.Add("Bàn " + r.SOBAN.ToString(),0);
                            listViewbanan.Items[t].SubItems.Add((t + 1).ToString());
                            listViewbanan.Items[t].SubItems.Add(r.SONGUOI.ToString());
                            listViewbanan.Items[t].SubItems.Add(r.TRANGTHAI.ToString());
                            listViewbanan.Items[t].SubItems.Add(r.MASOBAN.ToString());
                            t++;
                        }
                        

                    }
                }
                else
                {
                    MessageBox.Show("không tìm thấy");
                }

            }
        }

        private void listViewbanan_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadagainlistban(0);
        }

        private void Danhsachbanan_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadagainlistban(0);
        }
        private void loadcomboxban()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            tbban = db.GetTable<TBL_BAN>();
            foreach(TBL_BAN r in tbban)
            {
                if(r.TRANGTHAI.Equals("Trống"))
                {
                    cbxsoban.Items.Add(r.SOBAN);
                       
                }
            }
        }

        private void cbxsoban_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataClasses1DataContext db = new DataClasses1DataContext();
            tbban = db.GetTable<TBL_BAN>();

            if (cbxsoban.SelectedIndex>=0)
            {
                foreach (TBL_BAN r in tbban)
                {
                  if(r.SOBAN==int.Parse(cbxsoban.SelectedItem.ToString()))
                    {
                        tbxmabandat.Text = r.MASOBAN;
                        numericUpDownsonguoidat.Value =(int)r.SONGUOI;
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (cbxsoban.SelectedIndex < 0 || tbxtenkhachhang.Text == "")
            {
                MessageBox.Show("Thông tin chưa đầy đủ");
            }
            else
            {
                DataClasses1DataContext db = new DataClasses1DataContext();
                tbban = db.GetTable<TBL_BAN>();
                TBL_BAN a = new TBL_BAN();
                foreach (TBL_BAN r in tbban)
                {
                    if (r.MASOBAN == tbxmabandat.Text)
                    {
                        a = db.TBL_BANs.Single(p => p.MASOBAN.Equals(tbxmabandat.Text));
                        a.TRANGTHAI = "Đã đặt";
                        a.TENKHACHHANG = tbxtenkhachhang.Text;
                        db.SubmitChanges();
                    }
                }
                loadcomboxban();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(tbxmabandat.Text==""||tbxtenkhachhang.Text=="")
            {
                MessageBox.Show("Hãy điền mã bàn và tên khách hàng để hủy đặt bàn");
            }
            else
            {
                DataClasses1DataContext db = new DataClasses1DataContext();
                tbban = db.GetTable<TBL_BAN>();
                TBL_BAN a = new TBL_BAN();
                foreach (TBL_BAN r in tbban)
                {
                    if(r.MASOBAN==tbxmabandat.Text&&r.TENKHACHHANG==tbxtenkhachhang.Text&&r.TRANGTHAI.Equals("Đã đặt"))
                    {
                        a = db.TBL_BANs.Single(p => p.MASOBAN.Equals(tbxmabandat.Text));
                        a.TRANGTHAI = "Trống";
                        a.TENKHACHHANG ="";
                        db.SubmitChanges();
                    }
                }
                loadcomboxban();
             }
        }
    }

}
    
    

