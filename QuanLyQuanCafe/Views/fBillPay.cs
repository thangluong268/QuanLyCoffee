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
using Microsoft.Reporting.WebForms;

namespace QuanLyQuanCafe.Views
{
    public partial class fBillPay : Form
    {
        BLBillPay blBillPay = new BLBillPay();

        public fBillPay()
        {
            InitializeComponent();
        }


        private void fBillPay_Load(object sender, EventArgs e)
        {

            this.p_LayCTHDChoThanhToanTableAdapter.FillBy(
                this.quanLyCaPheDataSet.p_LayCTHDChoThanhToan, 
                fPos.maHD, fAccountManager.maNV, fPos.maBanDangChon);

            this.reportViewer1.RefreshReport();
        }

    }
}
