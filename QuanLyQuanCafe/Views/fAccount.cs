using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using QuanLyQuanCafe.BSLayer;

namespace QuanLyQuanCafe
{
    public partial class fAccount : Form
    {
        BLAccount blAccount = new BLAccount();
        DataTable dtAccount = null;
        int soLuongTaiKhoan = 0;
        public fAccount()
        {
            InitializeComponent();
        }
        private void LaySoLuongTaiKhoan()
        {
            DataSet ds = blAccount.LaySoLuongTaiKhoan();
            DataTable dtAccount = ds.Tables[0];
            soLuongTaiKhoan = Convert.ToInt32(dtAccount.Rows[0][0].ToString());
            soLuongTaiKhoan++;
        }

        private void LoadQuyen()
        {
            DataTable dtQuyen = new DataTable();
            dtQuyen.Clear();

            DataSet ds = blAccount.LoadQuyen();
            dtQuyen = ds.Tables[0];

            cbBQuyen.ValueMember = "Quyen";
            cbBQuyen.DataSource = dtQuyen;
        }

        private void LoadData()
        {
            try
            {
                // Khỏi tạo DataTable
                dtAccount = new DataTable();
                dtAccount.Clear();

                // Đổ dữ liệu từ DataSet lấy được từ database vào DataTable
                DataSet ds = blAccount.LoadTaiKhoan();
                dtAccount = ds.Tables[0]; // Lấy tất cả dữ liệu

                // Đưa dữ liệu từ DataTable lên DataGridView
                dgvAccount.DataSource = dtAccount;
                dgvAccount.AutoResizeColumns();

                txtPass.ResetText();
                txtNewPass.ResetText();
                txtRePass.ResetText();

                this.btnChangePass.Enabled = true;

                dgvAccount_CellClick(null, null);

            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được dữ liệu từ bảng TaiKhoan");
            }
            lblSoTaiKhoan.Text = ((DataTable)dgvAccount.DataSource).Rows.Count.ToString() + " Tài Khoản";
        }    

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataTable reader = new DataTable();
            DataSet ds = new DataSet();
            string strTimKiem = txtTimKiem.Text.Trim();
            string quyen = null;
            if (strTimKiem == "") LoadData();
            if (strTimKiem != "")
            {
                int selectedIndex = cbBQuyen.SelectedIndex;
                if (selectedIndex == 1)
                    quyen = "Quản lý";
                if (selectedIndex == 0)
                    quyen = "Nhân viên";
                string strN = "N";
                strN = strN.Substring(1, strN.Length - 1);
                ds = blAccount.TimKiemTaiKhoan(strN, strTimKiem, quyen);
                reader = ds.Tables[0];
                dgvAccount.DataSource = reader;
                lblSoTaiKhoan.Text = ((DataTable)dgvAccount.DataSource).Rows.Count.ToString() + " Tài Khoản";

            }
        }

        private void fAccount_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadQuyen();
            LaySoLuongTaiKhoan();
            showChildPanel(pnlAccount, pnlToolAccount);
        }

        private void showChildPanel(Panel childName, Panel tool)
        {
            this.Controls.Clear();
            this.Controls.Add(tool);
            tool.SetBounds(5, 23, 1883, 70);
            tool.BringToFront();
            tool.Show();

            this.Controls.Add(childName);
            childName.SetBounds(5, 125, 1883, 743);
            childName.BringToFront();
            childName.Show();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadData();
            showChildPanel(pnlAccount, pnlToolAccount);
        }


        private void btnChangePass_Click(object sender, EventArgs e)
        {
            showChildPanel(pnlEditAccount, pnlToolAccount);
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvAccount.CurrentCell.RowIndex;

            txtUserName.Text = dgvAccount.Rows[r].Cells[0].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int r = dgvAccount.CurrentCell.RowIndex;
            string pass = dgvAccount.Rows[r].Cells[1].Value.ToString();
            
            if (txtNewPass.Text.Trim() == txtRePass.Text.Trim() && txtPass.Text.Trim() == pass)
            {
                try
                {
                    DialogResult tl = MessageBox.Show("Bạn có chắc muốn đổi mật khẩu hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(tl == DialogResult.Yes)
                    {
                        BLAccount blAccount = new BLAccount();
                        txtUserName.Text.Trim(); // tên tài khoản cho TaiKhoan
                        txtPass.Text.Trim();
                        txtNewPass.Text.Trim();

                        string tenTaiKhoan = txtUserName.Text.Trim(); // tên tài khoản cho Login
                        tenTaiKhoan = tenTaiKhoan.Substring(0, tenTaiKhoan.Length);

                        blAccount.DoiMatKhau(this.txtUserName.Text, tenTaiKhoan, this.txtPass.Text, this.txtNewPass.Text);
                        MessageBox.Show("Đã đổi xong!");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Không đổi được. Lỗi rồi!" + ex);
                }
            }    
            else
            {
                MessageBox.Show("Mật khẩu không hợp lệ!");
            }
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShowPass.Checked)
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

        private void cbBQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnlToolAccount_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
