using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLyQuanCafe.DBLayer;

namespace QuanLyQuanCafe.BSLayer
{
    class BLMenu
    {
        DBMain db = null;
        public BLMenu()
        {
            db = new DBMain();
        }

        public DataSet LoadThucDonChoQuanLy()
        {
            return db.GoiThuTucOrHam("p_LoadThucDonChoQuanLy", CommandType.StoredProcedure);
        }
        public DataSet LoadMaLoai()
        {
            return db.GoiThuTucOrHam("p_LoadMaLoai", CommandType.StoredProcedure);
        }
        public DataSet LoadDVT()
        {
            return db.GoiThuTucOrHam("p_LoadDVT", CommandType.StoredProcedure);
        }
        public DataSet ThemThucDon(string MaMon, string MaLoai, string TenMon, string DonGia, string DVT, string TrangThai)
        {
            return db.GoiThuTucOrHam("p_ThemThucDon", CommandType.StoredProcedure,
                new SqlParameter("@mamon", MaMon),
                new SqlParameter("@maloai", MaLoai),
                new SqlParameter("@tenmon", TenMon),
                new SqlParameter("@dongia", DonGia),
                new SqlParameter("@dvt", DVT),
                new SqlParameter("@trangthai", TrangThai));
        }
        public DataSet CapNhatThucDon(string MaMon, string MaLoai, string TenMon, string DonGia, string DVT)
        {
            return db.GoiThuTucOrHam("p_CapNhatThucDon", CommandType.StoredProcedure,
                new SqlParameter("@mamon", MaMon),
                new SqlParameter("@maloai", MaLoai),
                new SqlParameter("@tenmon", TenMon),
                new SqlParameter("@dongia", DonGia),
                new SqlParameter("@dvt", DVT));
        }
        public DataSet XoaThucDon(string MaMon)
        {
            return db.GoiThuTucOrHam("p_XoaThucDon", CommandType.StoredProcedure,
                new SqlParameter("@mamon", MaMon));
        }
        public DataSet TimKiemThucDonTheoMa(string MaMon)
        {
            return db.GoiThuTucOrHam("p_TimKiemThucDonTheoMa", CommandType.StoredProcedure,
                new SqlParameter("@mamon", MaMon));
        }
        public DataSet TimKiemThucDonTheoTen(string strN, string TenMon)
        {
            return db.GoiThuTucOrHam("p_TimKiemThucDonTheoTen", CommandType.StoredProcedure,
                new SqlParameter("@N", strN),
                new SqlParameter("@tenmon", TenMon));
        }
        public DataSet LaySoLuongMon()
        {
            return db.GoiThuTucOrHam("p_LaySoLuongMon", CommandType.StoredProcedure);
        }
    }
}
