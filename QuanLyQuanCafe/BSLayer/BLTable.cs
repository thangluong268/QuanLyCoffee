using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLyQuanCafe.DBLayer;

namespace QuanLyQuanCafe.BSLayer
{
    class BLTable
    {
        DBMain db = null;
        public BLTable()
        {
            db = new DBMain();
        }

        public DataSet LoadBan()
        {
            return db.GoiThuTucOrHam("p_LoadBan", CommandType.StoredProcedure);
        }

        public DataSet ThemBan(string MaBan, string TenBan, string TrangThai)
        {
            return db.GoiThuTucOrHam("p_ThemBan", CommandType.StoredProcedure,
                new SqlParameter("@maban", MaBan),
                new SqlParameter("@tenban", TenBan),
                new SqlParameter("@trangthai", TrangThai));
        }
        public DataSet CapNhatBan(string MaBan, string TenBan, string TrangThai)
        {
            return db.GoiThuTucOrHam("p_CapNhatBan", CommandType.StoredProcedure,
                new SqlParameter("@maban", MaBan),
                new SqlParameter("@tenban", TenBan),
                new SqlParameter("@trangthai", TrangThai));
        }
        public DataSet XoaBan(string MaBan)
        {
            return db.GoiThuTucOrHam("p_XoaBan", CommandType.StoredProcedure,
                new SqlParameter("@maban", MaBan));
        }
        public DataSet TimKiemBanTheoMa(string MaBan)
        {
            return db.GoiThuTucOrHam("p_TimKiemBanTheoMa", CommandType.StoredProcedure,
                new SqlParameter("@maban", MaBan));
        }
        public DataSet TimKiemBanTheoTen(string TenBan)
        {
            return db.GoiThuTucOrHam("p_TimKiemBanTheoTen", CommandType.StoredProcedure,
                new SqlParameter("@tenban", TenBan));
        }

    }
}
