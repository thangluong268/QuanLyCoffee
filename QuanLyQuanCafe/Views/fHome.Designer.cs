
namespace QuanLyQuanCafe
{
    partial class fHome
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
            this.btnTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.pnlChuaFormChild = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTaiKhoan,
            this.btnPos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1827, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(127, 31);
            this.btnTaiKhoan.Text = "Tài Khoản";
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnPos
            // 
            this.btnPos.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(61, 31);
            this.btnPos.Text = "Pos";
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Location = new System.Drawing.Point(1596, 2);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(231, 42);
            this.btnDangXuat.TabIndex = 6;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // pnlChuaFormChild
            // 
            this.pnlChuaFormChild.BackgroundImage = global::QuanLyQuanCafe.Properties.Resources.bg2;
            this.pnlChuaFormChild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlChuaFormChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChuaFormChild.Location = new System.Drawing.Point(0, 33);
            this.pnlChuaFormChild.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlChuaFormChild.Name = "pnlChuaFormChild";
            this.pnlChuaFormChild.Size = new System.Drawing.Size(1827, 889);
            this.pnlChuaFormChild.TabIndex = 1;
            // 
            // fHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1827, 922);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.pnlChuaFormChild);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem btnPos;
        private System.Windows.Forms.Panel pnlChuaFormChild;
        private System.Windows.Forms.Button btnDangXuat;
    }
}