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

namespace doancosonganh
{
    public partial class reporthangbanchay : Form
    {
        public reporthangbanchay()
        {
            InitializeComponent();
        }

        private void reporthangbanchay_Load(object sender, EventArgs e)
        {
            var query = "SELECT TBL_HOADONCT.MASAPHAM, TBL_HOADONCT.TENSANPHAM, TBL_HOADONCT.SOLUONG, TBL_HOADONCT.GIA, TBL_HOADON.NGAYBAN " +
"FROM TBL_HOADON CROSS JOIN TBL_HOADONCT";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query, ModuleDB.cnn);
                SqlCommandBuilder cmm = new SqlCommandBuilder(da);
                DataTable a = new DataTable();
                da.Fill(a);
                rpbaocaohangbanchay rphbc = new rpbaocaohangbanchay();
                rphbc.SetDataSource(a);
                crystalReportViewer1.ReportSource = rphbc;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
