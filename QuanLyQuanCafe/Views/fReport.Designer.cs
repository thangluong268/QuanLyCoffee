
namespace QuanLyQuanCafe.Views
{
    partial class fReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNam1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNam2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNam3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXem1 = new System.Windows.Forms.Button();
            this.btnXem2 = new System.Windows.Forms.Button();
            this.btnTyTrong = new System.Windows.Forms.Button();
            this.lblTyTrong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartReport)).BeginInit();
            this.SuspendLayout();
            // 
            // chartReport
            // 
            chartArea2.Name = "ChartArea1";
            this.chartReport.ChartAreas.Add(chartArea2);
            legend2.Name = "Doanh Thu";
            this.chartReport.Legends.Add(legend2);
            this.chartReport.Location = new System.Drawing.Point(44, 30);
            this.chartReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartReport.Name = "chartReport";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Doanh Thu";
            series2.Name = "Doanh thu";
            this.chartReport.Series.Add(series2);
            this.chartReport.Size = new System.Drawing.Size(858, 543);
            this.chartReport.TabIndex = 0;
            this.chartReport.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(943, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống kê theo tháng/năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(945, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập năm";
            // 
            // txtNam1
            // 
            this.txtNam1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam1.Location = new System.Drawing.Point(949, 101);
            this.txtNam1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNam1.Name = "txtNam1";
            this.txtNam1.Size = new System.Drawing.Size(120, 38);
            this.txtNam1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(943, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thống kê theo năm";
            // 
            // txtNam2
            // 
            this.txtNam2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam2.Location = new System.Drawing.Point(949, 306);
            this.txtNam2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNam2.Name = "txtNam2";
            this.txtNam2.Size = new System.Drawing.Size(120, 38);
            this.txtNam2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(945, 282);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Từ năm";
            // 
            // txtNam3
            // 
            this.txtNam3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam3.Location = new System.Drawing.Point(1106, 306);
            this.txtNam3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNam3.Name = "txtNam3";
            this.txtNam3.Size = new System.Drawing.Size(120, 38);
            this.txtNam3.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1103, 282);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Đến năm";
            // 
            // btnXem1
            // 
            this.btnXem1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem1.Location = new System.Drawing.Point(1106, 101);
            this.btnXem1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXem1.Name = "btnXem1";
            this.btnXem1.Size = new System.Drawing.Size(110, 37);
            this.btnXem1.TabIndex = 9;
            this.btnXem1.Text = "Xem";
            this.btnXem1.UseVisualStyleBackColor = true;
            this.btnXem1.Click += new System.EventHandler(this.btnXem1_Click);
            // 
            // btnXem2
            // 
            this.btnXem2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem2.Location = new System.Drawing.Point(1249, 306);
            this.btnXem2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXem2.Name = "btnXem2";
            this.btnXem2.Size = new System.Drawing.Size(110, 37);
            this.btnXem2.TabIndex = 10;
            this.btnXem2.Text = "Xem";
            this.btnXem2.UseVisualStyleBackColor = true;
            this.btnXem2.Click += new System.EventHandler(this.btnXem2_Click);
            // 
            // btnTyTrong
            // 
            this.btnTyTrong.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTyTrong.Location = new System.Drawing.Point(949, 405);
            this.btnTyTrong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTyTrong.Name = "btnTyTrong";
            this.btnTyTrong.Size = new System.Drawing.Size(300, 37);
            this.btnTyTrong.TabIndex = 11;
            this.btnTyTrong.Text = "Tỷ trọng so với năm ngoái";
            this.btnTyTrong.UseVisualStyleBackColor = true;
            this.btnTyTrong.Click += new System.EventHandler(this.btnTyTrong_Click);
            // 
            // lblTyTrong
            // 
            this.lblTyTrong.AutoSize = true;
            this.lblTyTrong.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTyTrong.Location = new System.Drawing.Point(1075, 462);
            this.lblTyTrong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTyTrong.Name = "lblTyTrong";
            this.lblTyTrong.Size = new System.Drawing.Size(40, 34);
            this.lblTyTrong.TabIndex = 12;
            this.lblTyTrong.Text = "%";
            // 
            // fReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 745);
            this.Controls.Add(this.lblTyTrong);
            this.Controls.Add(this.btnTyTrong);
            this.Controls.Add(this.btnXem2);
            this.Controls.Add(this.btnXem1);
            this.Controls.Add(this.txtNam3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNam2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNam1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartReport);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fReport";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.fReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNam1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNam2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNam3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnXem1;
        private System.Windows.Forms.Button btnXem2;
        private System.Windows.Forms.Button btnTyTrong;
        private System.Windows.Forms.Label lblTyTrong;
    }
}