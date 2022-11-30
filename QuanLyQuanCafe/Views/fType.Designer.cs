
namespace QuanLyQuanCafe.Views
{
    partial class fType
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
            this.cbbTimKiem = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblSoLoai = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvLoaiMon = new System.Windows.Forms.DataGridView();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSua = new System.Windows.Forms.Button();
            this.pnlLoaiMon = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.pnlToolLoaiMon = new System.Windows.Forms.Panel();
            this.cbTrangThai = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.pnlEditLoaiMon = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiMon)).BeginInit();
            this.pnlLoaiMon.SuspendLayout();
            this.pnlToolLoaiMon.SuspendLayout();
            this.pnlEditLoaiMon.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.Items.AddRange(new object[] {
            "Tên Loại",
            "Mã Loại"});
            this.cbbTimKiem.Location = new System.Drawing.Point(11, 34);
            this.cbbTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(237, 42);
            this.cbbTimKiem.TabIndex = 0;
            this.cbbTimKiem.SelectedIndexChanged += new System.EventHandler(this.cbbTimKiem_SelectedIndexChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(281, 36);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(820, 42);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lblSoLoai
            // 
            this.lblSoLoai.AutoSize = true;
            this.lblSoLoai.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLoai.Location = new System.Drawing.Point(1121, 34);
            this.lblSoLoai.Name = "lblSoLoai";
            this.lblSoLoai.Size = new System.Drawing.Size(139, 46);
            this.lblSoLoai.TabIndex = 2;
            this.lblSoLoai.Text = "xx Loại";
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(1348, 37);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(125, 42);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(1667, 37);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 43);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvLoaiMon
            // 
            this.dgvLoaiMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoai,
            this.TenLoai,
            this.TrangThai});
            this.dgvLoaiMon.Location = new System.Drawing.Point(37, 25);
            this.dgvLoaiMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLoaiMon.Name = "dgvLoaiMon";
            this.dgvLoaiMon.ReadOnly = true;
            this.dgvLoaiMon.RowHeadersWidth = 51;
            this.dgvLoaiMon.RowTemplate.Height = 29;
            this.dgvLoaiMon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiMon.Size = new System.Drawing.Size(1751, 410);
            this.dgvLoaiMon.TabIndex = 6;
            this.dgvLoaiMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiMon_CellClick);
            // 
            // MaLoai
            // 
            this.MaLoai.DataPropertyName = "MaLoai";
            this.MaLoai.HeaderText = "Mã Loại";
            this.MaLoai.MinimumWidth = 6;
            this.MaLoai.Name = "MaLoai";
            this.MaLoai.ReadOnly = true;
            // 
            // TenLoai
            // 
            this.TenLoai.DataPropertyName = "TenLoai";
            this.TenLoai.HeaderText = "Tên Loại";
            this.TenLoai.MinimumWidth = 6;
            this.TenLoai.Name = "TenLoai";
            this.TenLoai.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái (Còn bán)";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(1517, 37);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(117, 43);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // pnlLoaiMon
            // 
            this.pnlLoaiMon.Controls.Add(this.dgvLoaiMon);
            this.pnlLoaiMon.Location = new System.Drawing.Point(12, 742);
            this.pnlLoaiMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLoaiMon.Name = "pnlLoaiMon";
            this.pnlLoaiMon.Size = new System.Drawing.Size(1880, 590);
            this.pnlLoaiMon.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label5.Location = new System.Drawing.Point(681, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 32);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tên Loại *";
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Enabled = false;
            this.txtMaLoai.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoai.Location = new System.Drawing.Point(692, 143);
            this.txtMaLoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(285, 53);
            this.txtMaLoai.TabIndex = 13;
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Font = new System.Drawing.Font("Times New Roman", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoai.Location = new System.Drawing.Point(692, 242);
            this.txtTenLoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(525, 69);
            this.txtTenLoai.TabIndex = 12;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(995, 460);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(215, 47);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Cập Nhật";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // pnlToolLoaiMon
            // 
            this.pnlToolLoaiMon.Controls.Add(this.cbbTimKiem);
            this.pnlToolLoaiMon.Controls.Add(this.txtTimKiem);
            this.pnlToolLoaiMon.Controls.Add(this.lblSoLoai);
            this.pnlToolLoaiMon.Controls.Add(this.btnXoa);
            this.pnlToolLoaiMon.Controls.Add(this.btnSua);
            this.pnlToolLoaiMon.Controls.Add(this.btnThem);
            this.pnlToolLoaiMon.Location = new System.Drawing.Point(12, 5);
            this.pnlToolLoaiMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlToolLoaiMon.Name = "pnlToolLoaiMon";
            this.pnlToolLoaiMon.Size = new System.Drawing.Size(1883, 102);
            this.pnlToolLoaiMon.TabIndex = 17;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.AutoSize = true;
            this.cbTrangThai.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTrangThai.Location = new System.Drawing.Point(692, 370);
            this.cbTrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(138, 38);
            this.cbTrangThai.TabIndex = 36;
            this.cbTrangThai.Text = "Còn bán";
            this.cbTrangThai.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label2.Location = new System.Drawing.Point(681, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 32);
            this.label2.TabIndex = 33;
            this.label2.Text = "Mã Loại *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label3.Location = new System.Drawing.Point(659, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(504, 62);
            this.label3.TabIndex = 14;
            this.label3.Text = "Thông Tin Loại Món";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label9.Location = new System.Drawing.Point(681, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 32);
            this.label9.TabIndex = 28;
            this.label9.Text = "Trạng Thái *";
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(660, 460);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(221, 47);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy thao tác";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // pnlEditLoaiMon
            // 
            this.pnlEditLoaiMon.Controls.Add(this.label13);
            this.pnlEditLoaiMon.Controls.Add(this.cbTrangThai);
            this.pnlEditLoaiMon.Controls.Add(this.label2);
            this.pnlEditLoaiMon.Controls.Add(this.label3);
            this.pnlEditLoaiMon.Controls.Add(this.label9);
            this.pnlEditLoaiMon.Controls.Add(this.label5);
            this.pnlEditLoaiMon.Controls.Add(this.txtMaLoai);
            this.pnlEditLoaiMon.Controls.Add(this.txtTenLoai);
            this.pnlEditLoaiMon.Controls.Add(this.btnLuu);
            this.pnlEditLoaiMon.Controls.Add(this.btnHuy);
            this.pnlEditLoaiMon.Location = new System.Drawing.Point(12, 122);
            this.pnlEditLoaiMon.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pnlEditLoaiMon.Name = "pnlEditLoaiMon";
            this.pnlEditLoaiMon.Size = new System.Drawing.Size(1883, 594);
            this.pnlEditLoaiMon.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label13.Location = new System.Drawing.Point(810, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(312, 26);
            this.label13.TabIndex = 40;
            this.label13.Text = "Bắt đầu bằng ML. Vd: ML01";
            // 
            // fType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1817, 762);
            this.Controls.Add(this.pnlLoaiMon);
            this.Controls.Add(this.pnlToolLoaiMon);
            this.Controls.Add(this.pnlEditLoaiMon);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fType";
            this.Text = "fType";
            this.Load += new System.EventHandler(this.fType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiMon)).EndInit();
            this.pnlLoaiMon.ResumeLayout(false);
            this.pnlToolLoaiMon.ResumeLayout(false);
            this.pnlToolLoaiMon.PerformLayout();
            this.pnlEditLoaiMon.ResumeLayout(false);
            this.pnlEditLoaiMon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblSoLoai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvLoaiMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TrangThai;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Panel pnlLoaiMon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Panel pnlToolLoaiMon;
        private System.Windows.Forms.CheckBox cbTrangThai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel pnlEditLoaiMon;
        private System.Windows.Forms.Label label13;
    }
}