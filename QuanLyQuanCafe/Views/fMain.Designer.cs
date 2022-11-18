
namespace QuanLyQuanCafe
{
    partial class fMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBill = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTable = new System.Windows.Forms.ToolStripMenuItem();
            this.btnType = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalary = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReport = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlChuaFormChild = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAccount,
            this.btnStaff,
            this.btnProduct,
            this.btnBill,
            this.btnTable,
            this.btnType,
            this.btnSalary,
            this.btnReport});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1827, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // btnAccount
            // 
            this.btnAccount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(93, 27);
            this.btnAccount.Text = "Account";
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(66, 27);
            this.btnStaff.Text = "Staff";
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.Black;
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(72, 27);
            this.btnProduct.Text = "Menu";
            this.btnProduct.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // btnBill
            // 
            this.btnBill.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(52, 27);
            this.btnBill.Text = "Bill";
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnTable
            // 
            this.btnTable.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(70, 27);
            this.btnTable.Text = "Table";
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnType
            // 
            this.btnType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(66, 27);
            this.btnType.Text = "Type";
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(78, 27);
            this.btnSalary.Text = "Salary";
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(83, 27);
            this.btnReport.Text = "Report";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // pnlChuaFormChild
            // 
            this.pnlChuaFormChild.BackgroundImage = global::QuanLyQuanCafe.Properties.Resources.bg2;
            this.pnlChuaFormChild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlChuaFormChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChuaFormChild.Location = new System.Drawing.Point(0, 31);
            this.pnlChuaFormChild.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlChuaFormChild.Name = "pnlChuaFormChild";
            this.pnlChuaFormChild.Size = new System.Drawing.Size(1827, 891);
            this.pnlChuaFormChild.TabIndex = 1;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Location = new System.Drawing.Point(1596, 0);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(231, 42);
            this.btnDangXuat.TabIndex = 5;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1827, 922);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.pnlChuaFormChild);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnAccount;
        private System.Windows.Forms.ToolStripMenuItem btnStaff;
        private System.Windows.Forms.ToolStripMenuItem btnProduct;
        private System.Windows.Forms.ToolStripMenuItem btnBill;
        private System.Windows.Forms.Panel pnlChuaFormChild;
        private System.Windows.Forms.ToolStripMenuItem btnTable;
        private System.Windows.Forms.ToolStripMenuItem btnType;
        private System.Windows.Forms.ToolStripMenuItem btnSalary;
        private System.Windows.Forms.ToolStripMenuItem btnReport;
        private System.Windows.Forms.Button btnDangXuat;
    }
}