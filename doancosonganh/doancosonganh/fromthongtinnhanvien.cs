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
using System.IO;
using System.Drawing.Imaging;
using System.Data.SqlClient;

namespace doancosonganh
{
    public partial class fromthongtinnhanvien : Form
    {
        public fromthongtinnhanvien()
        {
            InitializeComponent();
        }
        BindingManagerBase nhanvien;
        BindingManagerBase nhanvien_1;
        DataClasses1DataContext db = new DataClasses1DataContext();
        Table<TBL_NHANVIEN> tbnhanvien;
        bangnhanvien tbnhanv = new bangnhanvien();
        Bitmap bitmap;
        int dem = 0;
        private void loadthongtin()
        { TBL_NHANVIEN a = new TBL_NHANVIEN();
            
            tbnhanvien = db.GetTable<TBL_NHANVIEN>();
            
            tbxmnv.DataBindings.Add("text", tbnhanv, "MANV", true);
            tbxtenhanvien.DataBindings.Add("text", tbnhanv, "TENNHANVIEN", true);
            dateTimePickerngaysinh.DataBindings.Add("Value", tbnhanv, "NGAYSINH", true);
            tbxdiachi.DataBindings.Add("text", tbnhanv, "DIACHI", true);
            cbxchucvu.DataBindings.Add("SelectedItem", tbnhanv, "CHUCVU", true);
            pbxhinh.DataBindings.Add("IMAGE", tbnhanv, "HINH", true);
            tbxluong.DataBindings.Add("Text", tbnhanv, "LUONG", true);
            a = tbnhanvien.Single(p => p.MANV.Equals(tbxmnv.Text));
            if(a.GIOITINH=="Nam")
            {
                radioButtonnam.Checked = true;
            }
            else
            if(a.GIOITINH=="Nữ")
            {
                radioButtonnu.Checked = true;
            }
            nhanvien = this.BindingContext[tbnhanv];
            nhanvien_1 = this.BindingContext[tbnhanvien];
            nhanvien.PositionChanged+= new EventHandler(nhanvien_PositonChanged);
        }

        private void loadcbxchucvu()
        {
            cbxchucvu.Items.Add("Phục vụ");
            cbxchucvu.Items.Add("Quản lý nhập kho");
           
        }
        private void fromthongtinnhanvien_Load(object sender, EventArgs e)
        {
            tbnhanvien = db.GetTable<TBL_NHANVIEN>();
            loadcbxchucvu();
            loadthongtin();
            foreach (TBL_NHANVIEN r in tbnhanvien)
            {
                dem++;
            }
            lbhientai.Text =( nhanvien.Position + 1).ToString();
            labtong.Text = dem.ToString();

            
        }

        private void radioButtonnam_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonnam.Checked = !radioButtonnu.Checked;
        }

        private void bthinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "JPG Files|*.jpg|PNG Files|*.png|ALL Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bitmap = new Bitmap(openFileDialog1.FileName);

            }
            pbxhinh.Image = bitmap;
           // MessageBox.Show(pbxhinh.Image.ToString());

        }

        private void btthemmoi_Click(object sender, EventArgs e)
        {
           
            tbxmnv.Text = "";
            tbxdiachi.Text = "";
            tbxluong.Text = "";
            tbxtenhanvien.Text = "";
            cbxchucvu.SelectedIndex = -1;
            dateTimePickerngaysinh.Text = DateTime.Now.ToString();
            nhanvien.AddNew();
            dem++;
            labtong.Text = dem.ToString();
            try
            {
                ModuleDB.cnn.Open();
                SqlCommand cmm = new SqlCommand("Select dbo.fu_CreateMaNV()", ModuleDB.cnn);

                tbxmnv.Text = cmm.ExecuteScalar().ToString();
            }
            catch(Exception ex)
            {
                throw ex;
            }
               
           
           ModuleDB.cnn.Close();
        }
        //int phanbiet = 0;
        

        private void btxoa_Click(object sender, EventArgs e)
        {
            nhanvien_1.Position = nhanvien.Position;
            db.TBL_NHANVIENs.DeleteOnSubmit((TBL_NHANVIEN)nhanvien_1.Current);
            db.SubmitChanges();
            MessageBox.Show("Xóa thành công");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MemoryStream stream = new MemoryStream();
            //if (phanbiet == 1)
            {

                ////pbxhinh.Image.Save(stream, ImageFormat.Jpeg);
                //pbxhinh.Image.Save(stream, ImageFormat.Png);

                //nhanvien.EndCurrentEdit();
                //TBL_NHANVIEN a = new TBL_NHANVIEN();
                //a.MANV = tbxmanhanvien.Text;
                //a.TENNHANVIEN = tbxtenhanvien.Text;
                //a.DIACHI = tbxdiachi.Text;
                //a.NGAYSINH = dateTimePickerngaysinh.Value;
                //a.LUONG = double.Parse(tbxluong.Text);
                //a.CHUCVU = cbxchucvu.SelectedItem.ToString();
                //a.HINH = stream.ToArray();
                //db.TBL_NHANVIENs.InsertOnSubmit(a);
                //db.SubmitChanges();
                //MessageBox.Show("Thêm thành công!!!");
                //phanbiet = 0;

                string gioitinh = "";
                if (tbxtenhanvien.Text == null || tbxdiachi.Text == null || tbxluong.Text == null || cbxchucvu.SelectedIndex == -1)
                    MessageBox.Show("Thông tin còn thiếu !!!");
                nhanvien.EndCurrentEdit();
                if (radioButtonnam.Checked == true)
                    gioitinh = "Nam";
                if (radioButtonnu.Checked == true)
                    gioitinh = "Nữ ";
                DataRow[] r = tbnhanv.Select("MANV='" + tbxmnv.Text + "'");
                r[0]["GIOITINH"] = gioitinh.ToString();
                try
                {
                    if (tbnhanv.ghi() == true)
                    {
                        MessageBox.Show("Lưu thành công");

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //if(phanbiet==-1)
            //{
               
            //    pbxhinh.Image.Save(stream, ImageFormat.Jpeg);
            //    pbxhinh.Image.Save(stream, ImageFormat.Png);
            //    TBL_NHANVIEN d = new TBL_NHANVIEN();
            //    d = (TBL_NHANVIEN)nhanvien.Current;
            //    TBL_NHANVIEN t = new TBL_NHANVIEN();
            //    nhanvien.EndCurrentEdit();
            //    t = db.TBL_NHANVIENs.Single(p => p.MANV.Equals(tbxmanhanvien.Text));
            //    {
            //        t.TENNHANVIEN = tbxtenhanvien.Text;
            //        t.DIACHI = tbxdiachi.Text;
            //        t.NGAYSINH = dateTimePickerngaysinh.Value;
            //        t.LUONG = double.Parse(tbxluong.Text);
            //        t.CHUCVU = cbxchucvu.SelectedItem.ToString();
            //        t.HINH = stream.ToArray();
            //        db.SubmitChanges();
            //        MessageBox.Show("sửa thành công!!!");
            //        phanbiet = 0;
            //    }
            //}
        }
        private void loadgioitinh()
        {
            TBL_NHANVIEN a = new TBL_NHANVIEN();

            tbnhanvien = db.GetTable<TBL_NHANVIEN>();
            a = tbnhanvien.Single(p => p.MANV.Equals(tbxmnv.Text));
            if (a.GIOITINH == "Nam")
            {
                radioButtonnam.Checked = true;
            }
            else
            if (a.GIOITINH == "Nữ")
            {
                radioButtonnu.Checked = true;
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nhanvien.Position = 0;
            lbhientai.Text = (nhanvien.Position + 1).ToString();
            loadgioitinh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (nhanvien.Position < dem)

            {
                nhanvien.Position += 1;
                lbhientai.Text = (nhanvien.Position +1).ToString();
                loadgioitinh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (nhanvien.Position > 0)
            {
                nhanvien.Position -= 1;
                lbhientai.Text = (nhanvien.Position+1).ToString();
                loadgioitinh();
            }
        }

        private void tbxtimkiem_MouseClick(object sender, MouseEventArgs e)
        {
            tbxtimkiem.Text = "";
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            tbnhanvien = db.GetTable<TBL_NHANVIEN>();
            int vt = -1;
            foreach (TBL_NHANVIEN r in tbnhanvien)
            {
                vt++;
                if (r.TENNHANVIEN == tbxtimkiem.Text)
                    break;
            }
            nhanvien.Position = vt;

            loadgioitinh();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            nhanvien.Position = dem-1;
            lbhientai.Text = (nhanvien.Position + 1).ToString();
            loadgioitinh();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            //phanbiet = -1;
        }

        private void tbxtimkiem_TextChanged(object sender, EventArgs e)
        {

        }
        private void nhanvien_PositonChanged(object sender,EventArgs e)
        {
            int r = nhanvien.Position + 1;
            lbhientai.Text = r.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
   
}
