using QuanLyQuanCafe.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class fMain : Form
    {
        fMenu formProduct = new fMenu();
        fAccount formAccount = new fAccount();
        fStaff formStaff = new fStaff();
        fBill formBill = new fBill();
        fTable formTable = new fTable();
        fType formType = new fType();
        fSalary formSalary = new fSalary();
        fReport formReport = new fReport();
        public fMain()
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
            btnProduct.ForeColor = SystemColors.ControlText;
            btnAccount.ForeColor = SystemColors.ControlText;
            btnBill.ForeColor = SystemColors.ControlText; ;
            btnStaff.ForeColor = SystemColors.ControlText;
            btnTable.ForeColor = SystemColors.ControlText;
            btnType.ForeColor = SystemColors.ControlText;
            btnSalary.ForeColor = SystemColors.ControlText;
            btnReport.ForeColor = SystemColors.ControlText;
        }
        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetColor();
            btnProduct.ForeColor = Color.FromArgb(255, 128, 0);
            showChildForm(formProduct);
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            resetColor();
            btnAccount.ForeColor = Color.FromArgb(255, 128, 0);
            showChildForm(formAccount);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            resetColor();
            btnStaff.ForeColor = Color.FromArgb(255, 128, 0);
            showChildForm(formStaff);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            resetColor();
            btnBill.ForeColor = Color.FromArgb(255, 128, 0);
            showChildForm(formBill);
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            resetColor();
            btnTable.ForeColor = Color.FromArgb(255, 128, 0);
            showChildForm(formTable);
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            resetColor();
            btnType.ForeColor = Color.FromArgb(255, 128, 0);
            showChildForm(formType);
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            resetColor();
            btnSalary.ForeColor = Color.FromArgb(255, 128, 0);
            showChildForm(formSalary);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            resetColor();
            btnReport.ForeColor = Color.FromArgb(255, 128, 0);
            showChildForm(formReport);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
