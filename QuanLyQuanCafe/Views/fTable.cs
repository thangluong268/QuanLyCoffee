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
    public partial class fTable : Form
    {
        BLTable blTable = new BLTable();
        DataTable dtTable = new DataTable();

        bool them = false;

        public fTable()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                // Khỏi tạo DataTable
                dtTable = new DataTable();
                dtTable.Clear();

                // Đổ dữ liệu từ DataSet lấy được từ database vào DataTable
                DataSet ds = blTable.LoadBan();
                dtTable = ds.Tables[0]; // Lấy tất cả dữ liệu

                // Đưa dữ liệu từ DataTable lên DataGridView
                dgvTable.DataSource = dtTable;
                dgvTable.AutoResizeColumns();

                txtMaBan.ResetText();
                txtTenBan.ResetText();

                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;

                dgvTable_CellClick(null, null);

            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được dữ liệu từ bảng Ban");
            }
            lblSoBan.Text = ((DataTable)dgvTable.DataSource).Rows.Count.ToString() + " Bàn";
        }

        private void fTable_Load(object sender, EventArgs e)
        {
            LoadData();
            showChildPanel(pnlBan, pnlToolBan);
        }

        private void showChildPanel(Panel childName, Panel tool)
        {
            this.Controls.Clear();
            this.Controls.Add(tool);
            tool.SetBounds(5, 23, 1883, 127);
            tool.BringToFront();
            tool.Show();

            this.Controls.Add(childName);
            childName.SetBounds(5, 140, 1883, 743);
            childName.BringToFront();
            childName.Show();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            showChildPanel(pnlBan, pnlToolBan);
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            dgvTable_CellClick(null, null);

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.txtMaBan.Enabled = false;
            this.txtTenBan.Focus();
            showChildPanel(pnlEditBan, pnlToolBan);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            txtMaBan.Enabled = true;

            txtMaBan.ResetText();
            txtTenBan.ResetText();

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.txtMaBan.Focus();
            showChildPanel(pnlEditBan, pnlToolBan);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có chắc muốn xóa bàn này (Y/N)", "Thông báo"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                try
                {
                    BLTable blTable = new BLTable();
                    this.txtMaBan.Text.Trim();
                    blTable.XoaBan(this.txtMaBan.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Không xóa được. Lỗi!");
                }
            }
            LoadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them)
            {
                try
                {
                    BLTable blTable = new BLTable();
                    txtMaBan.Text.Trim();
                    txtTenBan.Text.Trim();

                    blTable.ThemBan(this.txtMaBan.Text, this.txtTenBan.Text, this.cbTrangThai.Checked.ToString());

                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                try
                {
                    BLTable blTable = new BLTable();
                    txtMaBan.Text.Trim();
                    txtTenBan.Text.Trim();

                    blTable.CapNhatBan(this.txtMaBan.Text, this.txtTenBan.Text, this.cbTrangThai.Checked.ToString());

                    MessageBox.Show("Đã sửa xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không sửa được. Lỗi rồi!");
                }

            }

            showChildPanel(pnlEditBan, pnlToolBan);
            LoadData();
        }

        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvTable.CurrentCell.RowIndex;

            txtMaBan.Text = dgvTable.Rows[r].Cells[0].Value.ToString();
            txtTenBan.Text = dgvTable.Rows[r].Cells[1].Value.ToString();
            cbTrangThai.Checked = (bool)dgvTable.Rows[r].Cells[2].Value;
        }

        private void cbbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                if (selectedIndex == 1)
                {
                    ds = blTable.TimKiemBanTheoMa(strTimKiem);
                    reader = ds.Tables[0];
                    dgvTable.DataSource = reader;
                    lblSoBan.Text = ((DataTable)dgvTable.DataSource).Rows.Count.ToString() + " Bàn";

                }
                if (selectedIndex == 0)
                {
                    ds = blTable.TimKiemBanTheoTen(strTimKiem);
                    reader = ds.Tables[0];
                    dgvTable.DataSource = reader;
                    lblSoBan.Text = ((DataTable)dgvTable.DataSource).Rows.Count.ToString() + " Bàn";
                }
            }
        }
    }
}
