using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

using QuanLyQuanCafe.BSLayer;

namespace QuanLyQuanCafe.Views
{
    public partial class fForgetPass : Form
    {
        BLForgetPass blForgetPass = new BLForgetPass();

        public fForgetPass()
        {
            InitializeComponent();
        }

        private void fForgetPass_Load(object sender, EventArgs e)
        {

        }

        private void btnLayLaiMatKhau_Click(object sender, EventArgs e)
        {
            try
            {
                string strN = "N";
                strN = strN.Substring(1, strN.Length - 1);
                string maNV = this.txtMaNV.Text.Trim();
                string hoTen = this.txtHoTen.Text.Trim();
                string sdt = this.txtSDT.Text.Trim();

                DataSet ds = blForgetPass.LayLaiMatKhau(strN, maNV, hoTen, sdt);
                DataTable dt = ds.Tables[0];

                if(dt.Rows.Count > 0)
                    this.lblMatKhau.Text = "Mật khẩu của bạn là: " + dt.Rows[0][0].ToString();
                else
                    MessageBox.Show("Thông tin không hợp lệ!");
            }
            catch(Exception)
            {
                MessageBox.Show("Không lấy lại được mật khẩu, Lỗi!");
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
