using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

using QuanLyQuanCafe.BSLayer;

namespace QuanLyQuanCafe.Views
{
    public partial class fBillInfo : Form
    {
        BLBillInfo blBillInfo = new BLBillInfo();
        DataTable dtBillInfo = new DataTable();

        string maHoaDonHienTai;

        public fBillInfo(string maHD)
        {
            this.maHoaDonHienTai = maHD;
            InitializeComponent();
        }

        private void LoadData()
        {
            DataSet ds = blBillInfo.LoadCTHD(maHoaDonHienTai);
            dtBillInfo = ds.Tables[0];

            dgvCTHD.DataSource = dtBillInfo;
            dgvCTHD.AutoResizeColumns();
        }

        private void fChiTietHoaDon_Load(object sender, EventArgs e)
        {
            setLabel();
            LoadData();
        }

        private void setLabel()
        {
            lblSoHoaDon.Text = "Hóa Đơn #" + maHoaDonHienTai.Trim();
            DataSet ds = blBillInfo.LayTongTien(maHoaDonHienTai);
            dtBillInfo = ds.Tables[0];

            lblTongTien.Text = "Tổng Tiền: " + dtBillInfo.Rows[0][0].ToString();
        }

    }
}
