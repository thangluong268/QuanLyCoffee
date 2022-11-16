using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLyQuanCafe.DBLayer;

namespace QuanLyQuanCafe.BSLayer
{
    class BLStaff
    {
        DBMain db = null;
        public BLStaff()
        {
            db = new DBMain();
        }

        public DataSet LoadNhanVien()
        {
            return db.GoiThuTucOrHam("p_LoadNhanVien", CommandType.StoredProcedure);
        }
        public DataSet LoadCa()
        {
            return db.GoiThuTucOrHam("p_LoadCa", CommandType.StoredProcedure);
        }
        public DataSet ThemNhanVien(string MaNV1, string MaNV2, string HoTen, string DiaChi, string SDT, 
                                    string NgayVaoLam, string SoNgayLam, string GioiTinh, string NgaySinh, 
                                    string ChucVu, string MaCa, int Ca)
        {
            return db.GoiThuTucOrHam("p_ThemNhanVien", CommandType.StoredProcedure,
                new SqlParameter("@manv1", MaNV1),
                new SqlParameter("@manv2", MaNV2),
                new SqlParameter("@hoten", HoTen),
                new SqlParameter("@diachi", DiaChi),
                new SqlParameter("@sdt", SDT),
                new SqlParameter("@ngayvaolam", NgayVaoLam),
                new SqlParameter("@songaylam", SoNgayLam),
                new SqlParameter("@gioitinh", GioiTinh),
                new SqlParameter("@ngaysinh", NgaySinh),
                new SqlParameter("@chucvu", ChucVu),
                new SqlParameter("@maca", MaCa),
                new SqlParameter("@ca", Ca));
        }
        public DataSet CapNhatNhanVien(string MaNV, string HoTen, string DiaChi, string SDT,
                string NgayVaoLam, string SoNgayLam, string GioiTinh, string NgaySinh, string ChucVu, int Ca)
        {
            return db.GoiThuTucOrHam("p_CapNhatNhanVien", CommandType.StoredProcedure,
                new SqlParameter("@manv", MaNV),
                new SqlParameter("@hoten", HoTen),
                new SqlParameter("@diachi", DiaChi),
                new SqlParameter("@sdt", SDT),
                new SqlParameter("@ngayvaolam", NgayVaoLam),
                new SqlParameter("@songaylam", SoNgayLam),
                new SqlParameter("@gioitinh", GioiTinh),
                new SqlParameter("@ngaysinh", NgaySinh),
                new SqlParameter("@chucvu", ChucVu),
                new SqlParameter("@ca", Ca));
        }
        public DataSet XoaNhanVien(string MaNV, string TenTaiKhoan, string ChucVu)
        {
            return db.GoiThuTucOrHam("p_XoaNhanVien", CommandType.StoredProcedure,
                new SqlParameter("@manv1", MaNV),
                new SqlParameter("@manv2", TenTaiKhoan),
                new SqlParameter("@chucvu", ChucVu));
        }
        public DataSet TimKiemNhanVienTheoMa(string MaNV)
        {
            return db.GoiThuTucOrHam("p_TimKiemNhanVienTheoMa", CommandType.StoredProcedure,
                new SqlParameter("@manv", MaNV));
        }
        public DataSet TimKiemNhanVienTheoTen(string strN, string HoTen)
        {
            return db.GoiThuTucOrHam("p_TimKiemNhanVienTheoTen", CommandType.StoredProcedure,
                new SqlParameter("@n", strN),
                new SqlParameter("@hoten", HoTen));
        }
        public DataSet LaySoLuongNhanVien()
        {
            return db.GoiThuTucOrHam("p_LaySoLuongNhanVien", CommandType.StoredProcedure);
        }

        public DataSet LayTongMaCa()
        {
            return db.GoiThuTucOrHam("p_LayTongMaCa", CommandType.StoredProcedure);
        }

        public DataSet KiemTraNhanVienTrongHoaDon(string MaNV)
        {
            return db.GoiThuTucOrHam("select dbo.f_KiemTraNhanVienTrongHoaDon(@manv)", CommandType.Text,
                new SqlParameter("@manv", MaNV));
        }

        public DataSet KiemTraMaCa(string MaCa)
        {
            return db.GoiThuTucOrHam("select dbo.f_KiemTraMaCa(@maca)", CommandType.Text,
                new SqlParameter("@maca", MaCa));
        }
    }
}
