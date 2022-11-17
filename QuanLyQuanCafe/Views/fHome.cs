using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class fHome : Form
    {
        fProfile formAccount = new fProfile();
        Views.fPos formPos = new Views.fPos();
        
        public fHome()
        {
            InitializeComponent();
        }
        private void showChildForm(Form childForm)
        {
            pnlChuaFormChild.Controls.Clear();
            childForm.TopLevel = false;
            pnlChuaFormChild.Controls.Add(childForm);
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
        }

        private void resetColor()
        {
            btnTaiKhoan.ForeColor = SystemColors.ControlText;
            btnPos.ForeColor = SystemColors.ControlText;
        }

        private void fHome_Load(object sender, EventArgs e)
        {
            
        }


        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            resetColor();
            btnPos.ForeColor = Color.FromArgb(255, 128, 0);
            showChildForm(formPos);
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            resetColor();
            btnTaiKhoan.ForeColor = Color.FromArgb(255, 128, 0);
            showChildForm(formAccount);
        }

    }
}
