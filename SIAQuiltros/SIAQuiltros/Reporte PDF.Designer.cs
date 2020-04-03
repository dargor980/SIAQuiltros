namespace SIAQuiltros
{
    partial class Reporte_PDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte_PDF));
            this.VOLUNTARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QUILTROSDataSet1 = new SIAQuiltros.QUILTROSDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VOLUNTARIOTableAdapter = new SIAQuiltros.QUILTROSDataSet1TableAdapters.VOLUNTARIOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VOLUNTARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUILTROSDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // VOLUNTARIOBindingSource
            // 
            this.VOLUNTARIOBindingSource.DataMember = "VOLUNTARIO";
            this.VOLUNTARIOBindingSource.DataSource = this.QUILTROSDataSet1;
            this.VOLUNTARIOBindingSource.CurrentChanged += new System.EventHandler(this.VOLUNTARIOBindingSource_CurrentChanged);
            // 
            // QUILTROSDataSet1
            // 
            this.QUILTROSDataSet1.DataSetName = "QUILTROSDataSet1";
            this.QUILTROSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VOLUNTARIOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SIAQuiltros.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // VOLUNTARIOTableAdapter
            // 
            this.VOLUNTARIOTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_PDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reporte_PDF";
            this.Text = "Reporte PDF";
            this.Load += new System.EventHandler(this.Reporte_PDF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VOLUNTARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUILTROSDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VOLUNTARIOBindingSource;
        private QUILTROSDataSet1 QUILTROSDataSet1;
        private QUILTROSDataSet1TableAdapters.VOLUNTARIOTableAdapter VOLUNTARIOTableAdapter;
    }
}