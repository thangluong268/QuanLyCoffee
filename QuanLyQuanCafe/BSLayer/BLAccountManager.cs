using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLyQuanCafe.DBLayer;

namespace QuanLyQuanCafe.BSLayer
{
    class BLAccountManager
    {
        DBMain db = null;
        public BLAccountManager()
        {
            db = new DBMain();
        }

        public DataSet LoadNhanVienTheoMa(string MaNV)
        {
            return db.GoiThuTucOrHam("p_LoadNhanVienTheoMa", CommandType.StoredProcedure,
                new SqlParameter("@manv", MaNV));
        }
        public DataSet KiemTraDangNhap(string TenTaiKhoan, string MatKhau)
        {
            return db.GoiThuTucOrHam("select dbo.f_KiemTraMatKhau(@taikhoan, @matkhau)", CommandType.Text,
                new SqlParameter("@taikhoan", TenTaiKhoan),
                new SqlParameter("@matkhau", MatKhau));
        }
    }
}
