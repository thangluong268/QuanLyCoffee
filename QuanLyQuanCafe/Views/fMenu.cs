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

namespace QuanLyQuanCafe
{
    public partial class fMenu : Form
    {
        BLMenu blMenu = new BLMenu();
        DataTable dtMenu = new DataTable();

        bool them = false;
        int SoLuongMon = 0;
        public fMenu()
        {
            InitializeComponent();
        }
        private void fMenu_Load(object sender, EventArgs e)
        {
            LaySoLuongMon();
            showChildPanel(pnlProduct, pnlToolProduct);
            LoadData();
            LoadDVT();
            LoadMaLoai();
            cbbTimKiem.SelectedIndex = 0;
        }

        private void LaySoLuongMon()
        {
            DataSet ds = blMenu.LaySoLuongMon();
            DataTable dtProduct = ds.Tables[0];
            SoLuongMon = Convert.ToInt32(dtProduct.Rows[0][0].ToString());
            SoLuongMon++;
        }
        private void LoadMaLoai()
        {
            DataTable dtMaLoai= new DataTable();
            dtMaLoai.Clear();

            DataSet ds = blMenu.LoadMaLoai();
            dtMaLoai = ds.Tables[0];

            cbMaLoai.ValueMember = "MaLoai";
            cbMaLoai.DataSource = dtMaLoai;
        }
        private void LoadDVT()
        {
            DataTable dtDVT = new DataTable();
            dtDVT.Clear();

            DataSet ds = blMenu.LoadDVT();
            dtDVT = ds.Tables[0];

            cbDVT.ValueMember = "DVT";
            cbDVT.DataSource = dtDVT;
        }

        private void LoadData()
        {
            try
            {
                // Khỏi tạo DataTable
                dtMenu = new DataTable();
                dtMenu.Clear();

                // Đổ dữ liệu từ DataSet lấy được từ database vào DataTable
                DataSet ds = blMenu.LoadThucDonChoQuanLy();
                dtMenu = ds.Tables[0]; // Lấy tất cả dữ liệu

                // Đưa dữ liệu từ DataTable lên DataGridView
                dgvMenu.DataSource = dtMenu;
                dgvMenu.AutoResizeColumns();

                txtMaMon.ResetText();
                cbMaLoai.ResetText();
                txtTenMon.ResetText();
                txtDonGia.ResetText();
                cbDVT.ResetText();
                cbTrangThai.ResetText();

                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;

                dgvMenu_CellClick(null, null);

            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được dữ liệu từ bảng ThucDon");
            }

            lblSoMon.Text = ((DataTable)dgvMenu.DataSource).Rows.Count.ToString() + " Hàng Hóa";
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tl == DialogResult.OK)
            {
                try
                {
                    BLMenu bLMenu = new BLMenu();
                    this.txtMaMon.Text.Trim();
                    bLMenu.XoaThucDon(this.txtMaMon.Text);
                    MessageBox.Show("Đã xóa thành công");
                }
                catch (Exception)
                {
                    MessageBox.Show("Không xóa được. Lỗi!");
                }
            }
            LoadData();
        }
        
        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            lblType.Text = "Sửa Món";
            dgvMenu_CellClick(null, null);

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.txtMaMon.Enabled = false;
            this.txtTenMon.Focus();

            showChildPanel(pnlEditProduct, pnlToolProduct);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadData();
            showChildPanel(pnlProduct, pnlToolProduct);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them)
            {
                try
                {
                    BLMenu blMenu = new BLMenu();
                    txtMaMon.Text.Trim();
                    txtTenMon.Text.Trim();
                    txtDonGia.Text.Trim();
                    blMenu.ThemThucDon(this.txtMaMon.Text, this.cbMaLoai.Text, this.txtTenMon.Text,
                                        this.txtDonGia.Text, this.cbDVT.Text, this.cbTrangThai.Checked.ToString());

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
                    BLMenu blMenu = new BLMenu();
                    txtMaMon.Text.Trim();
                    txtTenMon.Text.Trim();
                    txtDonGia.Text.Trim();
                    blMenu.CapNhatThucDon(this.txtMaMon.Text, this.cbMaLoai.Text, this.txtTenMon.Text,
                                        this.txtDonGia.Text, this.cbDVT.Text);
                    
                    MessageBox.Show("Đã sửa xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không sửa được. Lỗi rồi!");
                }

            }
            LoadData();
            showChildPanel(pnlProduct, pnlToolProduct);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            txtMaMon.Enabled = true;
            lblType.Text = "Thêm Món";

            txtMaMon.ResetText();
            txtTenMon.ResetText();
            txtDonGia.ResetText();

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.txtMaMon.Focus();

            showChildPanel(pnlEditProduct, pnlToolProduct);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataTable reader = new DataTable();
            DataSet ds = new DataSet();
            string strTimKiem = txtTimKiem.Text.Trim();
            if (strTimKiem == "") LoadData();
            if(strTimKiem != "")
            {
                int selectedIndex = cbbTimKiem.SelectedIndex;
                if(selectedIndex == 1)
                {
                    ds = blMenu.TimKiemThucDonTheoMa(strTimKiem);
                    reader = ds.Tables[0];
                    dgvMenu.DataSource = reader;
                    lblSoMon.Text = ((DataTable)dgvMenu.DataSource).Rows.Count.ToString() + " Món";

                }
                if (selectedIndex == 0) {
                    string strN = "N";
                    strN = strN.Substring(1, strN.Length - 1);
                    ds = blMenu.TimKiemThucDonTheoTen(strN, strTimKiem);
                    reader = ds.Tables[0];
                    dgvMenu.DataSource = reader;
                    lblSoMon.Text = ((DataTable)dgvMenu.DataSource).Rows.Count.ToString() + " Món";
                }
            }
        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvMenu.CurrentCell.RowIndex;
            txtMaMon.Text = dgvMenu.Rows[r].Cells[0].Value.ToString();
            cbMaLoai.SelectedValue = dgvMenu.Rows[r].Cells[1].Value.ToString();
            txtTenMon.Text = dgvMenu.Rows[r].Cells[2].Value.ToString();
            txtDonGia.Text = dgvMenu.Rows[r].Cells[3].Value.ToString();
            cbDVT.SelectedValue = dgvMenu.Rows[r].Cells[4].Value.ToString();
            try
            {
                cbTrangThai.Checked = (bool)dgvMenu.Rows[r].Cells[5].Value;
            }
            catch (Exception)
            {
                cbTrangThai.ResetText();
            }
        }

        
    }
}
