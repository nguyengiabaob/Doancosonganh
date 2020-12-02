using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace doancosonganh
{
    class ModuleDB:DataTable
    {
        #region Fields
        public static string manhanvien = "";
        public static string cnnstr = "Data Source=DESKTOP-T11FG2C\\SQLEXPRESS;Initial Catalog=QUANLYQUANAN;Integrated Security=True";
        public static SqlConnection cnn;
        private SqlDataAdapter da = new SqlDataAdapter();
        private string _query;
        private string _name;
        #endregion
        #region properties
        public string query
        {
            get { return _query; }
            set { _query = value; }
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int getcount
        {
            get { return this.DefaultView.Count; }
        }
        #endregion
        #region constructor
        public ModuleDB() : base() { }
        public ModuleDB(string pname)
        {
            _name = pname;
            docbang();
        }
        public ModuleDB(string pname, string pquery)
        {
            _name = pname;
            _query = pquery;
            docbang();
        }
        #endregion
        #region methods
        public void docbang()
        {
            if (_query == null)
                _query = "select * from " + _name;
            if (cnn == null)
            {
                cnn = new SqlConnection(cnnstr);
            }
            try
            {
                da = new SqlDataAdapter(_query, cnnstr);
                da.FillSchema(this, SchemaType.Mapped);
                da.Fill(this);
                //da.RowUpdated += new SqlRowUpdatedEventHandler(da_RowUpdated);
                SqlCommandBuilder cmdb = new SqlCommandBuilder(da);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        public Boolean ghi()
        {
            Boolean result = true;
            try
            {
                da.Update(this);
                this.AcceptChanges();

            }
            catch (SqlException ex)
            {
                this.RejectChanges();
                result = false;
                throw ex;

            }
            return result;

        }
        public void locdulieu(string pdieukien)
        {
            try
            {
                this.DefaultView.RowFilter = pdieukien;

            }
            catch (SqlException ex)
            {
                throw ex;

            }

        }
        public static int thuc_hien_lenh(string pquery)
        {
            if (cnn == null)
            {
                cnn = new SqlConnection(cnnstr);
            }
            try
            {
                SqlCommand cmd = new SqlCommand(pquery, cnn);
                cnn.Open();
                int result = cmd.ExecuteNonQuery();
                cnn.Close();
                return result;
            }
            catch
            {
                return -1;
            }
        }
        public static object thuc_hien_lenh_tinh_toan(string pquery)
        {
            if (cnn == null)
            {
                cnn = new SqlConnection(cnnstr);
            }
            try
            {
                SqlCommand cmd = new SqlCommand(pquery, cnn);
                cnn.Open();

                Object result = cmd.ExecuteScalar();
                cnn.Close();
                return result;
            }
            catch
            {
                return null;
            }
        }
        public object thuc_hien_StoreProcedure(String nameProc, SqlParameter[] p)
        {
            if (cnn == null)
            {
                cnn = new SqlConnection(cnnstr);

            }
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nameProc;
                cmd.Parameters.AddRange(p);
                cnn.Open();
                object result = cmd.ExecuteScalar();
                cnn.Close();
                return result;

            }
            catch
            {
                return null;
            }
        }
    }
}
