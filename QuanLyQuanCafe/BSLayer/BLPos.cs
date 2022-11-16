using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLyQuanCafe.DBLayer;

namespace QuanLyQuanCafe.BSLayer
{
    class BLPos
    {
        DBMain db = null;
        public BLPos()
        {
            db = new DBMain();
        }
        public DataSet LoadMenu()
        {
            return db.GoiThuTucOrHam("p_LoadThucDonChoGoiMon", CommandType.StoredProcedure);
        }

        public DataSet LoadThucDonChoGoiMonTheoMa(string MaMon)
        {
            return db.GoiThuTucOrHam("p_LoadThucDonChoGoiMonTheoMa", CommandType.StoredProcedure,
                new SqlParameter("mamon", MaMon));
        }

        public DataSet LoadMenuTheoLoai(string strN, string TenLoai)
        {
            return db.GoiThuTucOrHam("p_LoadThucDonChoGoiMonTheoTenLoai", CommandType.StoredProcedure,
                new SqlParameter("@n", strN),
                new SqlParameter("@tenloai", TenLoai));
        }

        public DataSet LoadBan()
        {
            return db.GoiThuTucOrHam("p_LoadBan", CommandType.StoredProcedure);
        }

        public DataSet LoadDVT()
        {
            return db.GoiThuTucOrHam("p_LoadDVT", CommandType.StoredProcedure);
        }

        public DataSet LayMaHoaDon(string MaBan)
        {
            return db.GoiThuTucOrHam("p_LayMaHoaDonChuaThanhToan", CommandType.StoredProcedure,
                new SqlParameter("@maban", MaBan));
        }

        public DataSet LayTongSoLuongHoaDon()
        {
            return db.GoiThuTucOrHam("p_LayTongSoLuongHoaDon", CommandType.StoredProcedure);
        }
        public DataSet LayTongSoLuongCTHD()
        {
            return db.GoiThuTucOrHam("p_LayTongSoLuongCTHD", CommandType.StoredProcedure);
        }
        public DataSet ThemHoaDon(string MaHD, string MaNV, string MaBan, string NgayTao, float GiamGia, int TongTien, int TrangThai)
        {
            return db.GoiThuTucOrHam("p_ThemHoaDon", CommandType.StoredProcedure,
                new SqlParameter("@mahd", MaHD),
                new SqlParameter("@manv", MaNV),
                new SqlParameter("@maban", MaBan),
                new SqlParameter("@ngaytao", NgayTao),
                new SqlParameter("@giamgia", GiamGia),
                new SqlParameter("@tongtien", TongTien),
                new SqlParameter("@trangthai", TrangThai)); ;
        }

        public DataSet ThemCTHD(string MaCTHD, string MaHD, string MaMon, string SoLuong)
        {
            return db.GoiThuTucOrHam("p_ThemCTHD", CommandType.StoredProcedure,
                new SqlParameter("@macthd", MaCTHD),
                new SqlParameter("@mahd", MaHD),
                new SqlParameter("@mamon", MaMon),
                new SqlParameter("@soluong", SoLuong));
        }

        public DataSet CapNhatHoaDon(string MaHD, int TongTien, int TrangThai)
        {
            return db.GoiThuTucOrHam("p_CapNhatHoaDon", CommandType.StoredProcedure,
                new SqlParameter("@mahd", MaHD),
                new SqlParameter("@tongtien", TongTien),
                new SqlParameter("@trangthai", TrangThai));
        }

        public DataSet KiemTraHoaDonCuaBan(string MaBan)
        {
            return db.GoiThuTucOrHam("p_KiemTraHoaDonCuaBan", CommandType.StoredProcedure,
                new SqlParameter("@maban", MaBan));
        }

        public DataSet LoadTenBan()
        {
            return db.GoiThuTucOrHam("p_LoadTenBan", CommandType.StoredProcedure);
        }

        public DataSet LayMaBan(string TenBan)
        {
            return db.GoiThuTucOrHam("p_LayMaBan", CommandType.StoredProcedure,
                new SqlParameter("@tenban", TenBan));
        }

        public DataSet KiemTraTrangThaiBan(string MaBan)
        {
            return db.GoiThuTucOrHam("p_KiemTraTrangThaiBan", CommandType.StoredProcedure,
                new SqlParameter("@maban", MaBan));
        }

        public DataSet CapNhatMaBanCuaHoaDon(string MaHD, string MaBan)
        {
            return db.GoiThuTucOrHam("p_CapNhatMaBanCuaHoaDon", CommandType.StoredProcedure,
                new SqlParameter("@mahd", MaHD),
                new SqlParameter("@maban", MaBan));
        }

        public DataSet CapNhatBan(string MaBan, int TrangThai)
        {
            return db.GoiThuTucOrHam("p_CapNhatBan", CommandType.StoredProcedure,
                new SqlParameter("@maban", MaBan),
                new SqlParameter("@trangthai", TrangThai));
        }

        public DataSet XoaHoaDon(string MaHD)
        {
            return db.GoiThuTucOrHam("p_XoaHoaDon", CommandType.StoredProcedure,
                new SqlParameter("@mahd", MaHD));
        }


        public DataSet KiemTraMaHD(string MaHD)
        {
            return db.GoiThuTucOrHam("select dbo.f_KiemTraMaHD(@mahd)", CommandType.Text,
                new SqlParameter("@mahd", MaHD));
        }

    }
}
