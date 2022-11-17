using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyQuanCafe.DBLayer
{
    class DBMain
    {
        // Chuỗi kết nối
        string connStr = null;

        // Đối tượng kết nối
        SqlConnection conn = null;
        SqlCommand comm = null;

        // Đối tượng đưa dữ liệu vào DataTable
        SqlDataAdapter da = null;

        public DBMain()
        {
            conn = new SqlConnection(connStr);
            comm = new SqlCommand();
        }

        public DataSet GoiThuTucOrHam(string strPro, CommandType ct, params SqlParameter[] param)
        {
            connStr = $@"Data Source=THANG\SQLEXPRESS; Initial Catalog=QuanLyCaPhe; User Id={FLogin.tenTaiKhoan}; Password={FLogin.matKhau};";
            conn = new SqlConnection(connStr);

            // Kiểm tra đối tượng kết nối
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();

            comm.Connection = conn;
            comm.CommandText = strPro;
            comm.CommandType = ct;

            comm.Parameters.Clear();

            foreach (SqlParameter p in param)
                comm.Parameters.Add(p);

            da = new SqlDataAdapter(comm);

            // Khởi tạo đối tượng DataSet
            DataSet ds = new DataSet();

            // Đổ dữ liệu lấy được vào DataSet
            da.Fill(ds);
            return ds;
        }
    }
}
