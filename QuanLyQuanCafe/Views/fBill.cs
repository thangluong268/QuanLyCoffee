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
    public partial class fBill : Form
    {
        BLBill blBill = new BLBill();
        DataTable dtBill = new DataTable();

        public fBill()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                // Khỏi tạo DataTable
                dtBill = new DataTable();
                dtBill.Clear();

                // Đổ dữ liệu từ DataSet lấy được từ database vào DataTable
                DataSet ds = blBill.LoadHoaDon();
                dtBill = ds.Tables[0]; // Lấy tất cả dữ liệu

                // Đưa dữ liệu từ DataTable lên DataGridView
                dgvHoaDon.DataSource = dtBill;
                dgvHoaDon.AutoResizeColumns();

                //dgvHoaDon_CellClick(null, null);

            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được dữ liệu từ bảng HoaDon");
            }
            lblSoHoaDon.Text = ((DataTable)dgvHoaDon.DataSource).Rows.Count.ToString() + " Hóa Đơn";
        }

        private void fBill_Load(object sender, EventArgs e)
        {
            LoadData();
            showChildPanel(pnlHoaDon, pnlToolHD);
        }

        private void showChildPanel(Panel childName, Panel tool)
        {
            this.Controls.Clear();
            this.Controls.Add(tool);
            tool.SetBounds(5, 23, 1883, 127);
            tool.BringToFront();
            tool.Show();

            this.Controls.Add(childName);
            childName.SetBounds(5, 150, 1883, 743);
            childName.BringToFront();
            childName.Show();
        }

        private void dgvHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHoaDon.CurrentCell != null)
            {
                string maHD = dgvHoaDon.Rows[dgvHoaDon.CurrentCell.RowIndex].Cells[0].Value.ToString();
                fBillInfo formChiTietHoaDon = new fBillInfo(maHD);
                formChiTietHoaDon.Show();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataTable reader = new DataTable();
            DataSet ds = new DataSet();
            string strTimKiem = txtTimKiem.Text.Trim();
            if (strTimKiem == "") LoadData();
            if (strTimKiem != "")
            {
                int selectedIndex = cbbTimKiem.SelectedIndex;
                if (selectedIndex == 0)
                {
                    ds = blBill.TimKiemHoaDonTheoMaHD(strTimKiem);
                    reader = ds.Tables[0];
                    dgvHoaDon.DataSource = reader;
                    lblSoHoaDon.Text = ((DataTable)dgvHoaDon.DataSource).Rows.Count.ToString() + " Hóa đơn";
                }
                if (selectedIndex == 1)
                {
                    ds = blBill.TimKiemHoaDonTheoMaNV(strTimKiem);
                    reader = ds.Tables[0];
                    dgvHoaDon.DataSource = reader;
                    lblSoHoaDon.Text = ((DataTable)dgvHoaDon.DataSource).Rows.Count.ToString() + " Hóa đơn";
                }
                if (selectedIndex == 2)
                {
                    ds = blBill.TimKiemHoaDonTheoMaBan(strTimKiem);
                    reader = ds.Tables[0];
                    dgvHoaDon.DataSource = reader;
                    lblSoHoaDon.Text = ((DataTable)dgvHoaDon.DataSource).Rows.Count.ToString() + " Hóa đơn";
                }
            }
        }
    }
}
