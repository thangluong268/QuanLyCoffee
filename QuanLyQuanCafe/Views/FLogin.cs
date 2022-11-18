using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QuanLyQuanCafe.Views;

using QuanLyQuanCafe.BSLayer;

namespace QuanLyQuanCafe
{   
    public partial class FLogin : Form
    {
        BLLogin blLogin = new BLLogin();
        string quyen;

        public static string tenTaiKhoan { get; set; }
        public static string matKhau { get; set; }

        public FLogin()
        {
            InitializeComponent();
        }

        private int CheckLogin(string Username, string Password, bool Manager, bool Staff)
        {
            if (Manager == false && Staff == false)
                return -1;
            else if (Manager == true)
                quyen = "Quản lý";
            else if (Staff == true)
                quyen = "Nhân viên";
            DataSet ds = blLogin.DangNhap(Username, Password, quyen);
            DataTable dt = ds.Tables[0];
            int ketqua = Int32.Parse(dt.Rows[0][0].ToString());
            return ketqua;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            tenTaiKhoan = this.txtUsername.Text.Trim();
            matKhau = this.txtPass.Text.Trim();

            try
            {
                int check = CheckLogin(txtUsername.Text.Trim(), txtPass.Text.Trim(), rbManager.Checked, rbStaff.Checked);

                if (check == -1)
                    MessageBox.Show("Vui lòng chọn quyền đăng nhập!");
                else if (check == 1)
                {
                    Form formManager = new fMain();
                    this.Hide();
                    formManager.ShowDialog();
                }
                else if (check == 2)
                {
                    fProfile.maNV = txtUsername.Text.Trim();
                    Form formStaff = new fHome();
                    this.Hide();
                    formStaff.ShowDialog();
                }
                this.Show();
            }
            catch(Exception)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
            }
                
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult tl = MessageBox.Show("Thông báo", "Bạn có thật sự muốn thoát? (Y/N)", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (tl != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void FLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnForgetPass_Click(object sender, EventArgs e)
        {
            fForgetPass form = new fForgetPass();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
