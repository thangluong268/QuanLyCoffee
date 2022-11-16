using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLyQuanCafe.DBLayer;

namespace QuanLyQuanCafe.BSLayer
{
    class BLForgetPass
    {
        DBMain db = null;
        public BLForgetPass()
        {
            db = new DBMain();
        }

        public DataSet LayLaiMatKhau(string strN, string MaNV, string HoTen, string SDT)
        {
            return db.GoiThuTucOrHam("p_LayLaiMatKhau", CommandType.StoredProcedure,
                new SqlParameter("@n", strN),
                new SqlParameter("@manv", MaNV),
                new SqlParameter("@hoten", HoTen),
                new SqlParameter("@sdt", SDT));
        }
    }
}
