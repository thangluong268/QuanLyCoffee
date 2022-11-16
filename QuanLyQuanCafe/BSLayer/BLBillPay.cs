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
    class BLBillPay
    {
        DBMain db = null;
        public BLBillPay()
        {
            db = new DBMain();
        }

        public DataSet LayThongTinChoBillThanhToan(string MaHD, string MaNV, string MaBan)
        {
            return db.GoiThuTucOrHam("p_LayThongTinChoBillThanhToan", CommandType.StoredProcedure,
                new SqlParameter("@mahd", MaHD),
                new SqlParameter("@manv", MaNV),
                new SqlParameter("@maban", MaBan));
        }
    }
}
