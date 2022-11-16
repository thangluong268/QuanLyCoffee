using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class fManager : Form
    {
        fAccountManager formAccount = new fAccountManager();
        Views.fPos formPos = new Views.fPos();
        
        public fManager()
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
        private void fManager_Load(object sender, EventArgs e)
        {
            showChildForm(formAccount);
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showChildForm(formAccount);
        }

        private void formPosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showChildForm(formPos);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
