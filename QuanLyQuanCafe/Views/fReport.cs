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
    public partial class fReport : Form
    {
        BLReport blReport = new BLReport();
        public fReport()
        {
            InitializeComponent();
        }

        private void fReport_Load(object sender, EventArgs e)
        {

        }

        private void btnXem1_Click(object sender, EventArgs e)
        {
            if(txtNam1.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập năm!");
                return;
            }    
            DataSet ds = blReport.ThongKeTheoThang(this.txtNam1.Text);
            chartReport.DataSource = ds;

            chartReport.Series["Doanh thu"].XValueMember = "ThangNam";
            chartReport.Series["Doanh thu"].YValueMembers = "TongTien";

            chartReport.Titles.Clear();
            chartReport.Titles.Add("Thống kê theo tháng/năm");
        }

        private void btnXem2_Click(object sender, EventArgs e)
        {
            if (txtNam2.Text.Trim() == "" || txtNam3.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập năm!");
                return;
            }
            DataSet ds = blReport.ThongKeTheoNam(this.txtNam2.Text, this.txtNam3.Text);
            chartReport.DataSource = ds;

            chartReport.Series["Doanh thu"].XValueMember = "Nam";
            chartReport.Series["Doanh thu"].YValueMembers = "TongTien";

            chartReport.Titles.Clear();
            chartReport.Titles.Add("Thống kê theo năm");
        }

        private void btnTyTrong_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsNamHienTai = blReport.TinhTongTienNamHienTai();
                DataTable dtNamHienTai = dsNamHienTai.Tables[0];
                int tongTienNamHienTai = Int32.Parse(dtNamHienTai.Rows[0][0].ToString());

                DataSet dsNamNgoai = blReport.TinhTongTienNamNgoai();
                DataTable dtNamNgoai = dsNamNgoai.Tables[0];
                int tongTienNamNgoai = Int32.Parse(dtNamNgoai.Rows[0][0].ToString());

                if (tongTienNamHienTai > tongTienNamNgoai)
                {
                    float tyTrong = (((float)tongTienNamHienTai / tongTienNamNgoai) - 1) * 100;
                    this.lblTyTrong.Text = "+" + String.Format("{0:0.00}", tyTrong) + "%";
                }
                else
                {
                    float tyTrong = (1 - ((float)tongTienNamHienTai / tongTienNamNgoai)) * 100;
                    this.lblTyTrong.Text = "-" + String.Format("{0:0.00}", tyTrong) + "%";
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Không tính được, Lỗi!");
            }
            
        }
    }
}
