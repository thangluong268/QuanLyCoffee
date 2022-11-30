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
    public partial class fStaff : Form
    {
        BLStaff blStaff = new BLStaff();
        DataTable dtStaff = new DataTable();

        bool them = false;

        public fStaff()
        {
            InitializeComponent();
        }

        private void LoadCa()
        {
            DataTable dtCa = new DataTable();
            dtCa.Clear();

            DataSet ds = blStaff.LoadCa();
            dtCa = ds.Tables[0];

            cbCa.ValueMember = "Ca";
            cbCa.DataSource = dtCa;
        }
        private void LoadData()
        {
            try
            {
                // Khỏi tạo DataTable
                dtStaff = new DataTable();
                dtStaff.Clear();

                // Đổ dữ liệu từ DataSet lấy được từ database vào DataTable
                DataSet ds = blStaff.LoadNhanVien();
                dtStaff = ds.Tables[0]; // Lấy tất cả dữ liệu

                // Đưa dữ liệu từ DataTable lên DataGridView
                dgvStaff.DataSource = dtStaff;
                dgvStaff.AutoResizeColumns();

                txtMaNV.ResetText();
                txtHoTen.ResetText();
                txtDiaChi.ResetText();
                txtSDT.ResetText();
                txtSoNgayLam.ResetText();
                txtChucVu.ResetText();

                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;

                //dgvStaff_CellClick(null, null);

            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được dữ liệu từ bảng NhanVien");
            }
            lblSoNhanVien.Text = ((DataTable)dgvStaff.DataSource).Rows.Count.ToString() + " Nhân Viên";
        }    

        private void fStaff_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCa();
            showChildPanel(pnlNV, pnlToolNV);
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
            showChildPanel(pnlNV, pnlToolNV);
            LoadData();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            dgvStaff_CellClick(null, null);

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.txtMaNV.Enabled = false;
            this.txtHoTen.Focus();
            showChildPanel(pnlEditNV, pnlToolNV);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            txtMaNV.Enabled = true;

            txtMaNV.ResetText();
            txtHoTen.ResetText();
            txtDiaChi.ResetText();
            txtSDT.ResetText();
            txtSoNgayLam.ResetText();
            txtChucVu.ResetText();

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.txtMaNV.Focus();
            showChildPanel(pnlEditNV, pnlToolNV);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataSet ds = blStaff.KiemTraNhanVienTrongHoaDon(this.txtMaNV.Text.Trim());
            DataTable dt = ds.Tables[0];
            int check = Int32.Parse(dt.Rows[0][0].ToString());
            if (check == 1)
            {
                MessageBox.Show("Thông báo: Nhân viên này có liên quan tới hóa đơn và ảnh hưởng tới doanh thu của quán." +
                    " Vì vậy không thể xóa");
                return;
            }

            DialogResult tl = MessageBox.Show("Bạn có chắc muốn xóa NV này (Y/N)", "Thông báo",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (tl == DialogResult.Yes)
            {
                try
                {
                    BLStaff blStaff = new BLStaff();
                    this.txtMaNV.Text.Trim(); // xóa nhân viên

                    string tenTaiKhoan = this.txtMaNV.Text.Trim(); // xóa tài khoản trong login
                    tenTaiKhoan = tenTaiKhoan.Substring(0, tenTaiKhoan.Length);

                    blStaff.XoaNhanVien(this.txtMaNV.Text.Trim(), tenTaiKhoan, this.txtChucVu.Text.Trim());
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Không xóa được. Lỗi!" + ex);
                }
            }
            LoadData();
        }

        private string TaoMaCa()
        {
            DataSet ds = new DataSet();
            ds = blStaff.LayTongMaCa();
            DataTable dt = ds.Tables[0];
            int ketqua = Int32.Parse(dt.Rows[0][0].ToString());
            ketqua++; // tạo mã ca tiếp theo => + 1
            string maCa = null;
            if (ketqua < 10)
                maCa = "MC0" + ketqua.ToString();
            else
                maCa = "MC" + ketqua.ToString();
            return maCa;
        }


        // tạo mã ca mới khi bị trùng
        private string TaoMaCaNew(int trung)
        {
            DataSet ds = new DataSet();
            ds = blStaff.LayTongMaCa();
            DataTable dt = ds.Tables[0];
            int ketqua = Int32.Parse(dt.Rows[0][0].ToString());
            ketqua++; // tạo mã ca tiếp theo => + 1
            ketqua += trung;
            string maCa = null;
            if (ketqua < 10)
                maCa = "MC0" + ketqua.ToString();
            else
                maCa = "MC" + ketqua.ToString();
            return maCa;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them)
            {
                try
                {
                    BLStaff blStaff = new BLStaff();
                    txtMaNV.Text.Trim();// mã nhân viên cho insert @manv1
                    txtHoTen.Text.Trim();
                    txtDiaChi.Text.Trim();
                    txtSDT.Text.Trim();
                    txtSoNgayLam.Text.Trim();
                    txtChucVu.Text.Trim();

                    string maNV = txtMaNV.Text.Trim(); // mã nhân viên cho create user @manv2
                    maNV = maNV.Substring(0, maNV.Length);

                    int ca = Int32.Parse(cbCa.Text);

                    string maCa = TaoMaCa();
                    DataSet dsCa = blStaff.KiemTraMaCa(maCa);
                    DataTable dtCa = dsCa.Tables[0];
                    bool checkMaCa = (bool)dtCa.Rows[0][0];
                    int trung = 0;

                    // checkMaCa == true : đã tồn tại mã ca -> tạo mã ca mới
                    while (checkMaCa == true)
                    {
                        trung++;
                        maCa = TaoMaCaNew(trung);
                        DataSet dsCaNew = blStaff.KiemTraMaCa(maCa);
                        DataTable dtCaNew = dsCaNew.Tables[0];
                        checkMaCa = (bool)dtCaNew.Rows[0][0];
                    }


                    blStaff.ThemNhanVien(this.txtMaNV.Text, maNV, this.txtHoTen.Text, this.txtDiaChi.Text, txtSDT.Text,
                                        this.dtpNgayVaoLam.Value.ToString(), this.txtSoNgayLam.Text, this.cbGioiTinh.Checked.ToString(),
                                        this.dtpNgaySinh.Value.ToString(), this.txtChucVu.Text, maCa, ca);

                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!" + ex);
                }
            }
            else
            {
                try
                {
                    BLStaff blStaff = new BLStaff();
                    txtMaNV.Text.Trim();
                    txtHoTen.Text.Trim();
                    txtDiaChi.Text.Trim();
                    txtSDT.Text.Trim();
                    txtSoNgayLam.Text.Trim();
                    txtChucVu.Text.Trim();

                    int ca = Int32.Parse(cbCa.Text);

                    blStaff.CapNhatNhanVien(this.txtMaNV.Text, this.txtHoTen.Text, this.txtDiaChi.Text, txtSDT.Text,
                                        this.dtpNgayVaoLam.Value.ToString(), this.txtSoNgayLam.Text, this.cbGioiTinh.Checked.ToString(),
                                        this.dtpNgaySinh.Value.ToString(), this.txtChucVu.Text, ca);

                    MessageBox.Show("Đã sửa xong!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Không sửa được. Lỗi rồi!" + ex);
                }

            }
            
            showChildPanel(pnlEditNV, pnlToolNV);
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvStaff.CurrentCell.RowIndex;

            txtMaNV.Text = dgvStaff.Rows[r].Cells[0].Value.ToString();
            txtHoTen.Text = dgvStaff.Rows[r].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvStaff.Rows[r].Cells[2].Value.ToString();
            txtSDT.Text = dgvStaff.Rows[r].Cells[3].Value.ToString();
            try
            {
                dtpNgayVaoLam.Value = (DateTime)dgvStaff.Rows[r].Cells[4].Value;
            }
            catch (Exception)
            {
                dtpNgayVaoLam.ResetText();
            }
            txtSoNgayLam.Text = dgvStaff.Rows[r].Cells[5].Value.ToString();
            try
            {
                cbGioiTinh.Checked = (bool)dgvStaff.Rows[r].Cells[6].Value;
            }
            catch (Exception)
            {
                cbGioiTinh.ResetText();
            }
            try
            {
                dtpNgaySinh.Value = (DateTime)dgvStaff.Rows[r].Cells[7].Value;
            }
            catch (Exception)
            {
                dtpNgaySinh.ResetText();
            }
            txtChucVu.Text = dgvStaff.Rows[r].Cells[8].Value.ToString();
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
                    ds = blStaff.TimKiemNhanVienTheoMa(strTimKiem);
                    reader = ds.Tables[0];
                    dgvStaff.DataSource = reader;
                    lblSoNhanVien.Text = ((DataTable)dgvStaff.DataSource).Rows.Count.ToString() + " Nhân Viên";

                }
                if (selectedIndex == 0)
                {
                    string strN = "N";
                    strN = strN.Substring(1, strN.Length - 1);
                    ds = blStaff.TimKiemNhanVienTheoTen(strN, strTimKiem);
                    reader = ds.Tables[0];
                    dgvStaff.DataSource = reader;
                    lblSoNhanVien.Text = ((DataTable)dgvStaff.DataSource).Rows.Count.ToString() + " Nhân Viên";
                }
            }
        }
    }
}
