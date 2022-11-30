using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using QuanLyQuanCafe.DBLayer;

namespace QuanLyQuanCafe.BSLayer
{
    class BLSalary
    {
        DBMain db = null;
        public BLSalary()
        {
            db = new DBMain();
        }

        public DataSet LoadTinhLuong()
        {
            return db.GoiThuTucOrHam("p_LoadTinhLuong", CommandType.StoredProcedure);
        }


        public DataSet TinhLuong()
        {
            return db.GoiThuTucOrHam("p_TinhLuong", CommandType.StoredProcedure);
        }
    }
}
