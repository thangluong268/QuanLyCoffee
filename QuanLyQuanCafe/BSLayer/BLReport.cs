using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLyQuanCafe.DBLayer;

namespace QuanLyQuanCafe.BSLayer
{
    class BLReport
    {
        DBMain db = null;
        public BLReport()
        {
            db = new DBMain();
        }

        public DataSet ThongKeTheoThang(string Nam)
        {
            return db.GoiThuTucOrHam("p_ThongKeTheoThang", CommandType.StoredProcedure,
                new SqlParameter("@nam", Nam));
        }

        public DataSet ThongKeTheoNam(string NamTu, string NamDen)
        {
            return db.GoiThuTucOrHam("p_ThongKeTheoNam", CommandType.StoredProcedure,
                new SqlParameter("@namtu", NamTu),
                new SqlParameter("@namden", NamDen));
        }

        public DataSet TinhTongTienNamHienTai()
        {
            return db.GoiThuTucOrHam("select dbo.f_TinhTongTienNamHienTai()", CommandType.Text);
        }

        public DataSet TinhTongTienNamNgoai()
        {
            return db.GoiThuTucOrHam("select dbo.f_TinhTongTienNamNgoai()", CommandType.Text);
        }
    }
}
