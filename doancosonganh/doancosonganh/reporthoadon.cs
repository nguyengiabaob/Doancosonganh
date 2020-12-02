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
using CrystalDecisions.Shared;
namespace doancosonganh
{
    public partial class reporthoadon : Form
    {
        string tienmat, tienthoilai,MAHDBAN,tennhanvien;
        DateTime ngayl;

        private void reporthoadon_Load(object sender, EventArgs e)
        {
            var query = "SELECT TBL_HOADONCT.MAHDBAN, TBL_HOADONCT.TENSANPHAM, TBL_HOADONCT.SOLUONG, TBL_HOADONCT.GIA, TBL_LOAISANPHAM.DONGIA"+
  " FROM TBL_HOADONCT INNER JOIN " +
                    " TBL_LOAISANPHAM ON TBL_HOADONCT.MASAPHAM = TBL_LOAISANPHAM.MASANPHAM";

            try
            {
                ParameterFields from = new ParameterFields();
                ParameterField tienm = new ParameterField();
                ParameterField tienthoil = new ParameterField();
                ParameterField MAHDBAN_1 = new ParameterField();
                ParameterField TENNHANVIEN = new ParameterField();
                ParameterField NGAYLAP = new ParameterField();
                tienm.Name = "TIENMAT";
                tienthoil.Name = "TIENTHOI";
                MAHDBAN_1.Name = "MAHDBAN";
                TENNHANVIEN.Name = "TENHANVIEN";
                NGAYLAP.Name = "NGAYLAP";
                ParameterDiscreteValue val = new ParameterDiscreteValue();
                ParameterDiscreteValue tienthoi = new ParameterDiscreteValue();
                ParameterDiscreteValue valMAHDBAN = new ParameterDiscreteValue();
                ParameterDiscreteValue valTENNHANVIEN = new ParameterDiscreteValue();
                ParameterDiscreteValue valNGAYLAP = new ParameterDiscreteValue();
                val.Value = tienmat;
                tienthoi.Value = tienthoilai;
                valMAHDBAN.Value = MAHDBAN;
                valTENNHANVIEN.Value = tennhanvien;
                valNGAYLAP.Value = ngayl;
                tienm.CurrentValues.Add(val);
                tienthoil.CurrentValues.Add(tienthoi);
                MAHDBAN_1.CurrentValues.Add(valMAHDBAN);
                TENNHANVIEN.CurrentValues.Add(valTENNHANVIEN);
                NGAYLAP.CurrentValues.Add(valNGAYLAP);
                from.Add(tienm);
                from.Add(tienthoil);
                from.Add(MAHDBAN_1);
                from.Add(TENNHANVIEN);
                from.Add(NGAYLAP);
                crystalReportViewer1.ParameterFieldInfo = from;
                SqlDataAdapter da = new SqlDataAdapter(query, ModuleDB.cnn);
                SqlCommandBuilder cmm = new SqlCommandBuilder(da);
                DataTable a = new DataTable();
                da.Fill(a);
                reportHoadonct rphd = new reportHoadonct();
                //rphd.SetParameterValue("TIENMAT", tienmat);
                //rphd.SetParameterValue("TIENTHOI", tienthoilai);
                //rphd.SetParameterValue("MAHDBAN", MAHDBAN);
                //rphd.SetParameterValue("TENNHANVIEN", tennhanvien);
                //rphd.SetParameterValue("NGAYLAP", ngayl);
                rphd.SetDataSource(a);
                
                crystalReportViewer1.ReportSource = rphd;
                //crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public reporthoadon()
        {
            InitializeComponent();
        }
        public reporthoadon(string tm, string ttl,string mhd,DateTime tg,string tennv)
        {
            tienmat = tm;
            tienthoilai = ttl;
            ngayl = tg;
            tennhanvien = tennv;
            MAHDBAN = mhd;
            InitializeComponent();
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
           
            //crystalReportViewer1.Refresh();
            
        }

        

    }
}
