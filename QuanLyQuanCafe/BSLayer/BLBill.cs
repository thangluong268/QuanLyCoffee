using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLyQuanCafe.DBLayer;

namespace QuanLyQuanCafe.BSLayer
{
    class BLBill
    {
        DBMain db = null;
        public BLBill()
        {
            db = new DBMain();
        }

        public DataSet LoadHoaDon()
        {
            return db.GoiThuTucOrHam("p_LoadHoaDon", CommandType.StoredProcedure);
        }

        public DataSet TimKiemHoaDonTheoMaHD(string MaHD)
        {
            return db.GoiThuTucOrHam("p_TimKiemHoaDonTheoMaHD", CommandType.StoredProcedure,
                new SqlParameter("@mahd", MaHD));
        }

        public DataSet TimKiemHoaDonTheoMaNV(string MaNV)
        {
            return db.GoiThuTucOrHam("p_TimKiemHoaDonTheoMaNV", CommandType.StoredProcedure,
                new SqlParameter("@manv", MaNV));
        }

        public DataSet TimKiemHoaDonTheoMaBan(string MaBan)
        {
            return db.GoiThuTucOrHam("p_TimKiemHoaDonTheoMaBan", CommandType.StoredProcedure,
                new SqlParameter("@maban", MaBan));
        }
    }
}
