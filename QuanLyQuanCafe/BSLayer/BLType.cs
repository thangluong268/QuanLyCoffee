using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLyQuanCafe.DBLayer;

namespace QuanLyQuanCafe.BSLayer
{
    class BLType
    {
        DBMain db = null;
        public BLType()
        {
            db = new DBMain();
        }

        public DataSet LoadLoaiMon()
        {
            return db.GoiThuTucOrHam("p_LoadLoaiMon", CommandType.StoredProcedure);
        }

        public DataSet ThemLoaiMon(string MaLoai, string TenLoai, string TrangThai)
        {
            return db.GoiThuTucOrHam("p_ThemLoaiMon", CommandType.StoredProcedure,
                new SqlParameter("@maloai", MaLoai),
                new SqlParameter("@tenloai", TenLoai),
                new SqlParameter("@trangthai", TrangThai));
        }
        public DataSet CapNhatLoaiMon(string MaLoai, string TenLoai, string TrangThai)
        {
            return db.GoiThuTucOrHam("p_CapNhatLoaiMon", CommandType.StoredProcedure,
                new SqlParameter("@maloai", MaLoai),
                new SqlParameter("@tenloai", TenLoai),
                new SqlParameter("@trangthai", TrangThai));
        }
        public DataSet XoaLoaiMon(string MaLoai)
        {
            return db.GoiThuTucOrHam("p_XoaLoaiMon", CommandType.StoredProcedure,
                new SqlParameter("@maloai", MaLoai));
        }
        public DataSet TimKiemLoaiMonTheoMa(string MaLoai)
        {
            return db.GoiThuTucOrHam("p_TimKiemLoaiMonTheoMa", CommandType.StoredProcedure,
                new SqlParameter("@maloai", MaLoai));
        }
        public DataSet TimKiemLoaiMonTheoTen(string strN, string TenLoai)
        {
            return db.GoiThuTucOrHam("p_TimKiemLoaiMonTheoTen", CommandType.StoredProcedure,
                new SqlParameter("@n", strN),
                new SqlParameter("@tenloai", TenLoai));
        }
    }
}
