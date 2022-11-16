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
    public partial class fType : Form
    {
        BLType blType = new BLType();
        DataTable dtType = new DataTable();

        bool them = false;
        public fType()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                // Khỏi tạo DataTable
                dtType = new DataTable();
                dtType.Clear();

                // Đổ dữ liệu từ DataSet lấy được từ database vào DataTable
                DataSet ds = blType.LoadLoaiMon();
                dtType = ds.Tables[0]; // Lấy tất cả dữ liệu

                // Đưa dữ liệu từ DataTable lên DataGridView
                dgvLoaiMon.DataSource = dtType;
                dgvLoaiMon.AutoResizeColumns();

                txtMaLoai.ResetText();
                txtTenLoai.ResetText();

                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;

                dgvLoaiMon_CellClick(null, null);

            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được dữ liệu từ bảng LoaiMon");
            }
            lblSoLoai.Text = ((DataTable)dgvLoaiMon.DataSource).Rows.Count.ToString() + " Loại";
        }

        private void fType_Load(object sender, EventArgs e)
        {
            LoadData();
            showChildPanel(pnlLoaiMon, pnlToolLoaiMon);
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
            showChildPanel(pnlLoaiMon, pnlToolLoaiMon);
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            dgvLoaiMon_CellClick(null, null);

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.txtMaLoai.Enabled = false;
            this.txtTenLoai.Focus();
            showChildPanel(pnlEditLoaiMon, pnlToolLoaiMon);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            txtMaLoai.Enabled = true;

            txtMaLoai.ResetText();
            txtTenLoai.ResetText();

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.txtMaLoai.Focus();
            showChildPanel(pnlEditLoaiMon, pnlToolLoaiMon);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có chắc muốn xóa Loại Món này (Y/N)", "Thông báo"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                try
                {
                    BLType blType = new BLType();
                    this.txtMaLoai.Text.Trim();
                    blType.XoaLoaiMon(this.txtMaLoai.Text);
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
                    BLType blType = new BLType();
                    txtMaLoai.Text.Trim();
                    txtTenLoai.Text.Trim();

                    blType.ThemLoaiMon(this.txtMaLoai.Text, this.txtTenLoai.Text, this.cbTrangThai.Checked.ToString());

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
                    BLType blType = new BLType();
                    txtMaLoai.Text.Trim();
                    txtTenLoai.Text.Trim();

                    blType.CapNhatLoaiMon(this.txtMaLoai.Text, this.txtTenLoai.Text, this.cbTrangThai.Checked.ToString());

                    MessageBox.Show("Đã sửa xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không sửa được. Lỗi rồi!");
                }

            }

            showChildPanel(pnlEditLoaiMon, pnlToolLoaiMon);
            LoadData();
        }

        private void dgvLoaiMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvLoaiMon.CurrentCell.RowIndex;

            txtMaLoai.Text = dgvLoaiMon.Rows[r].Cells[0].Value.ToString();
            txtTenLoai.Text = dgvLoaiMon.Rows[r].Cells[1].Value.ToString();
            cbTrangThai.Checked = (bool)dgvLoaiMon.Rows[r].Cells[2].Value;
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
                    ds = blType.TimKiemLoaiMonTheoMa(strTimKiem);
                    reader = ds.Tables[0];
                    dgvLoaiMon.DataSource = reader;
                    lblSoLoai.Text = ((DataTable)dgvLoaiMon.DataSource).Rows.Count.ToString() + " Loại";

                }
                if (selectedIndex == 0)
                {
                    string strN = "N";
                    strN = strN.Substring(1, strN.Length - 1);
                    ds = blType.TimKiemLoaiMonTheoTen(strN, strTimKiem);
                    reader = ds.Tables[0];
                    dgvLoaiMon.DataSource = reader;
                    lblSoLoai.Text = ((DataTable)dgvLoaiMon.DataSource).Rows.Count.ToString() + " Loại";
                }
            }
        }
    }
}
