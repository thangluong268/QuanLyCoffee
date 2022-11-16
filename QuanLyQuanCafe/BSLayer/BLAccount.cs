using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLyQuanCafe.DBLayer;

namespace QuanLyQuanCafe.BSLayer
{
    class BLAccount
    {
        DBMain db = null;
        public BLAccount()
        {
            db = new DBMain();
        }

        public DataSet LoadTaiKhoan()
        {
            return db.GoiThuTucOrHam("p_LoadTaiKhoan", CommandType.StoredProcedure);
        }
        public DataSet LoadQuyen()
        {
            return db.GoiThuTucOrHam("p_LoadQuyen", CommandType.StoredProcedure);
        }
        public DataSet DoiMatKhau(string TenTaiKhoan1, string TenTaiKhoan2, string MatKhauCu, string MatKhauMoi)
        {
            return db.GoiThuTucOrHam("p_DoiMatKhau", CommandType.StoredProcedure,
                new SqlParameter("@tentk1", TenTaiKhoan1),
                new SqlParameter("@tentk2", TenTaiKhoan2),
                new SqlParameter("@matkhaucu", MatKhauCu),
                new SqlParameter("@matkhaumoi", MatKhauMoi));
        }
        public DataSet TimKiemTaiKhoan(string strN, string TenTaiKhoan, string Quyen)
        {
            return db.GoiThuTucOrHam("p_TimKiemTaiKhoan", CommandType.StoredProcedure,
                new SqlParameter("@n", strN),
                new SqlParameter("@tentaikhoan", TenTaiKhoan),
                new SqlParameter("@quyen", Quyen));
        }
        public DataSet LaySoLuongTaiKhoan()
        {
            return db.GoiThuTucOrHam("p_LaySoLuongTaiKhoan", CommandType.StoredProcedure);
        }
    }
}
