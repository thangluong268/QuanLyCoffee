
namespace QuanLyQuanCafe
{
    partial class fAccount
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
            this.pnlToolAccount = new System.Windows.Forms.Panel();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.cbBQuyen = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblSoTaiKhoan = new System.Windows.Forms.Label();
            this.pnlAccount = new System.Windows.Forms.Panel();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.pnlEditAccount = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.cbShowPass = new System.Windows.Forms.CheckBox();
            this.txtRePass = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.TenTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlToolAccount.SuspendLayout();
            this.pnlAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.pnlEditAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlToolAccount
            // 
            this.pnlToolAccount.Controls.Add(this.btnChangePass);
            this.pnlToolAccount.Controls.Add(this.cbBQuyen);
            this.pnlToolAccount.Controls.Add(this.txtTimKiem);
            this.pnlToolAccount.Controls.Add(this.lblSoTaiKhoan);
            this.pnlToolAccount.Location = new System.Drawing.Point(4, 19);
            this.pnlToolAccount.Margin = new System.Windows.Forms.Padding(2);
            this.pnlToolAccount.Name = "pnlToolAccount";
            this.pnlToolAccount.Size = new System.Drawing.Size(1412, 100);
            this.pnlToolAccount.TabIndex = 12;
            this.pnlToolAccount.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlToolAccount_Paint);
            // 
            // btnChangePass
            // 
            this.btnChangePass.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.Location = new System.Drawing.Point(1069, 29);
            this.btnChangePass.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(186, 39);
            this.btnChangePass.TabIndex = 39;
            this.btnChangePass.Text = "Đổi Mật Khẩu";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // cbBQuyen
            // 
            this.cbBQuyen.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBQuyen.FormattingEnabled = true;
            this.cbBQuyen.Items.AddRange(new object[] {
            "Nhân Viên",
            "Quản Lý"});
            this.cbBQuyen.Location = new System.Drawing.Point(8, 28);
            this.cbBQuyen.Margin = new System.Windows.Forms.Padding(2);
            this.cbBQuyen.Name = "cbBQuyen";
            this.cbBQuyen.Size = new System.Drawing.Size(179, 35);
            this.cbBQuyen.TabIndex = 0;
            this.cbBQuyen.SelectedIndexChanged += new System.EventHandler(this.cbBQuyen_SelectedIndexChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(211, 29);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(616, 35);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lblSoTaiKhoan
            // 
            this.lblSoTaiKhoan.AutoSize = true;
            this.lblSoTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTaiKhoan.Location = new System.Drawing.Point(837, 27);
            this.lblSoTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoTaiKhoan.Name = "lblSoTaiKhoan";
            this.lblSoTaiKhoan.Size = new System.Drawing.Size(202, 36);
            this.lblSoTaiKhoan.TabIndex = 2;
            this.lblSoTaiKhoan.Text = "xx Tài Khoản";
            // 
            // pnlAccount
            // 
            this.pnlAccount.Controls.Add(this.dgvAccount);
            this.pnlAccount.Location = new System.Drawing.Point(2, 612);
            this.pnlAccount.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAccount.Name = "pnlAccount";
            this.pnlAccount.Size = new System.Drawing.Size(1410, 479);
            this.pnlAccount.TabIndex = 11;
            // 
            // dgvAccount
            // 
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenTaiKhoan,
            this.MatKhau,
            this.Quyen});
            this.dgvAccount.Location = new System.Drawing.Point(123, 9);
            this.dgvAccount.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.ReadOnly = true;
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.RowTemplate.Height = 29;
            this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccount.Size = new System.Drawing.Size(1033, 454);
            this.dgvAccount.TabIndex = 6;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            // 
            // pnlEditAccount
            // 
            this.pnlEditAccount.Controls.Add(this.label12);
            this.pnlEditAccount.Controls.Add(this.cbShowPass);
            this.pnlEditAccount.Controls.Add(this.txtRePass);
            this.pnlEditAccount.Controls.Add(this.label16);
            this.pnlEditAccount.Controls.Add(this.btnHuy);
            this.pnlEditAccount.Controls.Add(this.btnLuu);
            this.pnlEditAccount.Controls.Add(this.txtNewPass);
            this.pnlEditAccount.Controls.Add(this.label15);
            this.pnlEditAccount.Controls.Add(this.txtPass);
            this.pnlEditAccount.Controls.Add(this.label14);
            this.pnlEditAccount.Controls.Add(this.label13);
            this.pnlEditAccount.Controls.Add(this.txtUserName);
            this.pnlEditAccount.Location = new System.Drawing.Point(2, 123);
            this.pnlEditAccount.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEditAccount.Name = "pnlEditAccount";
            this.pnlEditAccount.Size = new System.Drawing.Size(1412, 485);
            this.pnlEditAccount.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label12.Location = new System.Drawing.Point(18, 20);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(289, 49);
            this.label12.TabIndex = 38;
            this.label12.Text = "Đổi Mật Khẩu";
            // 
            // cbShowPass
            // 
            this.cbShowPass.AutoSize = true;
            this.cbShowPass.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.cbShowPass.Location = new System.Drawing.Point(617, 450);
            this.cbShowPass.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbShowPass.Name = "cbShowPass";
            this.cbShowPass.Size = new System.Drawing.Size(203, 31);
            this.cbShowPass.TabIndex = 37;
            this.cbShowPass.Text = "Hiển thị mật khẩu";
            this.cbShowPass.UseVisualStyleBackColor = true;
            this.cbShowPass.CheckedChanged += new System.EventHandler(this.cbShowPass_CheckedChanged);
            // 
            // txtRePass
            // 
            this.txtRePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.txtRePass.Location = new System.Drawing.Point(620, 378);
            this.txtRePass.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.PasswordChar = '✽';
            this.txtRePass.Size = new System.Drawing.Size(517, 56);
            this.txtRePass.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(279, 382);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(313, 42);
            this.label16.TabIndex = 35;
            this.label16.Text = "Xác nhận mật khẩu:";
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(1071, 2);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(94, 40);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(1169, 2);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(88, 40);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.txtNewPass.Location = new System.Drawing.Point(620, 300);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '✽';
            this.txtNewPass.Size = new System.Drawing.Size(514, 56);
            this.txtNewPass.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(279, 305);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(234, 42);
            this.label15.TabIndex = 33;
            this.label15.Text = "Mật khẩu mới:";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.txtPass.Location = new System.Drawing.Point(617, 213);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '✽';
            this.txtPass.Size = new System.Drawing.Size(517, 56);
            this.txtPass.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(279, 218);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(292, 42);
            this.label14.TabIndex = 31;
            this.label14.Text = "Mật khẩu hiện tại: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(279, 122);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(248, 42);
            this.label13.TabIndex = 30;
            this.label13.Text = "Tên Tài Khoản:";
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.txtUserName.Location = new System.Drawing.Point(617, 118);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(517, 56);
            this.txtUserName.TabIndex = 29;
            // 
            // TenTaiKhoan
            // 
            this.TenTaiKhoan.DataPropertyName = "TenTaiKhoan";
            this.TenTaiKhoan.HeaderText = "Tên Tài Khoản";
            this.TenTaiKhoan.MinimumWidth = 6;
            this.TenTaiKhoan.Name = "TenTaiKhoan";
            this.TenTaiKhoan.ReadOnly = true;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Password";
            this.MatKhau.MinimumWidth = 6;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.ReadOnly = true;
            // 
            // Quyen
            // 
            this.Quyen.DataPropertyName = "Quyen";
            this.Quyen.HeaderText = "Quyền";
            this.Quyen.MinimumWidth = 6;
            this.Quyen.Name = "Quyen";
            this.Quyen.ReadOnly = true;
            // 
            // fAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pnlEditAccount);
            this.Controls.Add(this.pnlAccount);
            this.Controls.Add(this.pnlToolAccount);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAccount";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fAccount_Load);
            this.pnlToolAccount.ResumeLayout(false);
            this.pnlToolAccount.PerformLayout();
            this.pnlAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.pnlEditAccount.ResumeLayout(false);
            this.pnlEditAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlToolAccount;
        private System.Windows.Forms.ComboBox cbBQuyen;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblSoTaiKhoan;
        private System.Windows.Forms.Panel pnlAccount;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Panel pnlEditAccount;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cbShowPass;
        private System.Windows.Forms.TextBox txtRePass;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quyen;
    }
}