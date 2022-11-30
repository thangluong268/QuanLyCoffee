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
    public partial class fSalary : Form
    {
        BLSalary blSalary = new BLSalary();
        DataTable dtSalary = new DataTable();

        public fSalary()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                // Khỏi tạo DataTable
                dtSalary = new DataTable();
                dtSalary.Clear();

                // Đổ dữ liệu từ DataSet lấy được từ database vào DataTable
                DataSet ds = blSalary.LoadTinhLuong();
                dtSalary = ds.Tables[0]; // Lấy tất cả dữ liệu

                // Đưa dữ liệu từ DataTable lên DataGridView
                dgvSalary.DataSource = dtSalary;
                dgvSalary.AutoResizeColumns();

            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được dữ liệu");
            }
        }

        private void fSalary_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            try
            {
                blSalary.TinhLuong();
                MessageBox.Show("Tính lương thành công!");
            }
            catch(Exception)
            {
                MessageBox.Show("Không tính lương được, Lỗi!");
            }
            
            LoadData();
        }
    }
}
