using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

using QuanLyQuanCafe.DBLayer;

namespace QuanLyQuanCafe.BSLayer
{
    class BLLogin
    {
        DBMain db = null;
        public BLLogin()
        {
            db = new DBMain();
        }

        public DataSet DangNhap(string TaiKhoan, string MatKhau, string Quyen)
        {
            return db.GoiThuTucOrHam("select dbo.f_DangNhap(@taikhoan, @matkhau, @quyen)", CommandType.Text,
                new SqlParameter("@taikhoan", TaiKhoan),
                new SqlParameter("@matkhau", MatKhau),
                new SqlParameter("@quyen", Quyen));
        }
    }
}
