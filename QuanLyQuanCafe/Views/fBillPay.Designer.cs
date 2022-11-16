
namespace QuanLyQuanCafe.Views
{
    partial class fBillPay
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pLayCTHDChoThanhToanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyCaPheDataSet = new QuanLyQuanCafe.QuanLyCaPheDataSet();
            this.p_LayCTHDChoThanhToanTableAdapter = new QuanLyQuanCafe.QuanLyCaPheDataSetTableAdapters.p_LayCTHDChoThanhToanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pLayCTHDChoThanhToanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCaPheDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pLayCTHDChoThanhToanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyQuanCafe.Rdlc.BillPay.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(252, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(791, 758);
            this.reportViewer1.TabIndex = 1;
            // 
            // pLayCTHDChoThanhToanBindingSource
            // 
            this.pLayCTHDChoThanhToanBindingSource.DataMember = "p_LayCTHDChoThanhToan";
            this.pLayCTHDChoThanhToanBindingSource.DataSource = this.quanLyCaPheDataSet;
            // 
            // quanLyCaPheDataSet
            // 
            this.quanLyCaPheDataSet.DataSetName = "QuanLyCaPheDataSet";
            this.quanLyCaPheDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p_LayCTHDChoThanhToanTableAdapter
            // 
            this.p_LayCTHDChoThanhToanTableAdapter.ClearBeforeFill = true;
            // 
            // fBillPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1900, 780);
            this.Controls.Add(this.reportViewer1);
            this.Name = "fBillPay";
            this.Text = "fBillPay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fBillPay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pLayCTHDChoThanhToanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCaPheDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pLayCTHDChoThanhToanBindingSource;
        private QuanLyCaPheDataSet quanLyCaPheDataSet;
        private QuanLyCaPheDataSetTableAdapters.p_LayCTHDChoThanhToanTableAdapter p_LayCTHDChoThanhToanTableAdapter;
    }
}