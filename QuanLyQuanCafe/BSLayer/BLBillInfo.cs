using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLyQuanCafe.DBLayer;

namespace QuanLyQuanCafe.BSLayer
{
    class BLBillInfo
    {
        DBMain db = null;
        public BLBillInfo()
        {
            db = new DBMain();
        }

        public DataSet LoadCTHD(string MaHD)
        {
            return db.GoiThuTucOrHam("p_LoadCTHD", CommandType.StoredProcedure,
                new SqlParameter("@mahd", MaHD));
        }

        public DataSet LayTongTien(string MaHD)
        {
            return db.GoiThuTucOrHam("p_LayTongTien", CommandType.StoredProcedure,
                new SqlParameter("@mahd", MaHD));
        }
    }
}
