
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            chartArea1.Name = "ChartArea1";
            this.chartReport.ChartAreas.Add(chartArea1);
            legend1.Name = "Doanh Thu";
            this.chartReport.Legends.Add(legend1);
            this.chartReport.Location = new System.Drawing.Point(59, 37);
            this.chartReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartReport.Name = "chartReport";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Doanh Thu";
            series1.Name = "Doanh thu";
            this.chartReport.Series.Add(series1);
            this.chartReport.Size = new System.Drawing.Size(1144, 668);
            this.chartReport.TabIndex = 0;
            this.chartReport.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1257, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống kê theo tháng/năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1260, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập năm";
            // 
            // txtNam1
            // 
            this.txtNam1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam1.Location = new System.Drawing.Point(1265, 124);
            this.txtNam1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNam1.Name = "txtNam1";
            this.txtNam1.Size = new System.Drawing.Size(159, 45);
            this.txtNam1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1257, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 43);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thống kê theo năm";
            // 
            // txtNam2
            // 
            this.txtNam2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam2.Location = new System.Drawing.Point(1265, 377);
            this.txtNam2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNam2.Name = "txtNam2";
            this.txtNam2.Size = new System.Drawing.Size(159, 45);
            this.txtNam2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1260, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Từ năm";
            // 
            // txtNam3
            // 
            this.txtNam3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam3.Location = new System.Drawing.Point(1475, 377);
            this.txtNam3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNam3.Name = "txtNam3";
            this.txtNam3.Size = new System.Drawing.Size(159, 45);
            this.txtNam3.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1471, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "Đến năm";
            // 
            // btnXem1
            // 
            this.btnXem1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem1.Location = new System.Drawing.Point(1475, 124);
            this.btnXem1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXem1.Name = "btnXem1";
            this.btnXem1.Size = new System.Drawing.Size(147, 46);
            this.btnXem1.TabIndex = 9;
            this.btnXem1.Text = "Xem";
            this.btnXem1.UseVisualStyleBackColor = true;
            this.btnXem1.Click += new System.EventHandler(this.btnXem1_Click);
            // 
            // btnXem2
            // 
            this.btnXem2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem2.Location = new System.Drawing.Point(1665, 377);
            this.btnXem2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXem2.Name = "btnXem2";
            this.btnXem2.Size = new System.Drawing.Size(147, 46);
            this.btnXem2.TabIndex = 10;
            this.btnXem2.Text = "Xem";
            this.btnXem2.UseVisualStyleBackColor = true;
            this.btnXem2.Click += new System.EventHandler(this.btnXem2_Click);
            // 
            // btnTyTrong
            // 
            this.btnTyTrong.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTyTrong.Location = new System.Drawing.Point(1265, 498);
            this.btnTyTrong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTyTrong.Name = "btnTyTrong";
            this.btnTyTrong.Size = new System.Drawing.Size(400, 46);
            this.btnTyTrong.TabIndex = 11;
            this.btnTyTrong.Text = "Tỷ trọng so với năm ngoái";
            this.btnTyTrong.UseVisualStyleBackColor = true;
            this.btnTyTrong.Click += new System.EventHandler(this.btnTyTrong_Click);
            // 
            // lblTyTrong
            // 
            this.lblTyTrong.AutoSize = true;
            this.lblTyTrong.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTyTrong.Location = new System.Drawing.Point(1433, 569);
            this.lblTyTrong.Name = "lblTyTrong";
            this.lblTyTrong.Size = new System.Drawing.Size(51, 43);
            this.lblTyTrong.TabIndex = 12;
            this.lblTyTrong.Text = "%";
            // 
            // fReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1827, 917);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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