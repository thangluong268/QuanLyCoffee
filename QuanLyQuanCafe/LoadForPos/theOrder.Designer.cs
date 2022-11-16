
namespace QuanLyQuanCafe.Views
{
    partial class theOrder
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
            this.lblTenMon = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblTenMon.ForeColor = System.Drawing.Color.Coral;
            this.lblTenMon.Location = new System.Drawing.Point(3, 7);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(155, 26);
            this.lblTenMon.TabIndex = 0;
            this.lblTenMon.Text = "Tên Món: xxx";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.lblGia.Location = new System.Drawing.Point(3, 28);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(99, 26);
            this.lblGia.TabIndex = 1;
            this.lblGia.Text = "Giá: xxx";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(8)))));
            this.lblTongTien.Location = new System.Drawing.Point(3, 53);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(114, 26);
            this.lblTongTien.TabIndex = 2;
            this.lblTongTien.Text = "Tổng: xxx";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.lblSoLuong.Location = new System.Drawing.Point(165, 28);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(36, 26);
            this.lblSoLuong.TabIndex = 3;
            this.lblSoLuong.Text = "x2";
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::QuanLyQuanCafe.Properties.Resources.icons8_cross_mark_button_48;
            this.btnXoa.Location = new System.Drawing.Point(701, 0);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(44, 45);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnTatTheOrder_Click);
            // 
            // theOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(749, 90);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblTenMon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "theOrder";
            this.Text = "theOrder";
            this.Load += new System.EventHandler(this.theOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Button btnXoa;
    }
}