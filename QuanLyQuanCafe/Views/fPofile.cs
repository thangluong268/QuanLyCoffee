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
    public partial class fProfile : Form
    {
        BLProfile blProfile = new BLProfile();
        DataTable dtProfile = new DataTable();

        public static string maNV { get; set; }

        public fProfile()
        {
            InitializeComponent();
        }
        private void LoadData(string MaNV)
        {
            try
            {
                // Khỏi tạo DataTable
                dtProfile = new DataTable();
                dtProfile.Clear();

                // Đổ dữ liệu từ DataSet lấy được từ database vào DataTable
                DataSet ds = blProfile.LoadNhanVienTheoMa(MaNV);
                dtProfile = ds.Tables[0]; // Lấy tất cả dữ liệu

                txtMaNV.Text = dtProfile.Rows[0][0].ToString();
                txtHoTen.Text = dtProfile.Rows[0][1].ToString();
                txtDiaChi.Text = dtProfile.Rows[0][2].ToString();
                txtSDT.Text = dtProfile.Rows[0][3].ToString();
                dtpNgayVaoLam.Text = dtProfile.Rows[0][4].ToString();
                txtSoNgayLam.Text = dtProfile.Rows[0][5].ToString();
                cbGioiTinh.Checked = (bool)dtProfile.Rows[0][6];
                dtpNgaySinh.Text = dtProfile.Rows[0][7].ToString();
                txtChucVu.Text = dtProfile.Rows[0][8].ToString();

                txtUserName.Text = dtProfile.Rows[0][0].ToString();

                this.btnChangePass.Enabled = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được dữ liệu từ bảng NhanVien");
            }
            
        }

        private void fProfile_Load(object sender, EventArgs e)
        {
            LoadData(maNV);
            showChildPanel(pnlEditAccount);
        }

        private void showChildPanel(Panel childName)
        {
            this.Controls.Clear();
            this.Controls.Add(childName);
            childName.SetBounds(0, 0, 1876, 1000);
            childName.BringToFront();
            childName.Show();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            showChildPanel(pnlChangePass);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            showChildPanel(pnlEditAccount);
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                txtPass.PasswordChar = '\0';
                txtNewPass.PasswordChar = '\0';
                txtRePass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '✽';
                txtNewPass.PasswordChar = '✽';
                txtRePass.PasswordChar = '✽';
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataSet ds = blProfile.KiemTraDangNhap(maNV, txtPass.Text.Trim());
            DataTable dt = ds.Tables[0];
            int check = Int32.Parse(dt.Rows[0][0].ToString());
            if (txtNewPass.Text.Trim() == txtRePass.Text.Trim() && check == 1)
            {
                try
                {
                    DialogResult tl = MessageBox.Show("Bạn có chắc muốn đổi mật khẩu hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (tl == DialogResult.Yes)
                    {
                        BLAccount blAccount = new BLAccount();
                        txtUserName.Text.Trim(); // tên tài khoản cho TaiKhoan
                        txtPass.Text.Trim();
                        txtNewPass.Text.Trim();

                        string tenTaiKhoan = txtUserName.Text.Trim(); // tên tài khoản cho Login
                        tenTaiKhoan = tenTaiKhoan.Substring(0, tenTaiKhoan.Length);

                        blAccount.DoiMatKhau(this.txtUserName.Text, tenTaiKhoan, this.txtPass.Text, this.txtNewPass.Text);
                        MessageBox.Show("Đã đổi xong!");

                        this.Close();
                        FLogin formLogin = new FLogin();
                        formLogin.ShowDialog();
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không đổi được. Lỗi rồi!");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không hợp lệ!");
            }
        }

    }
}
