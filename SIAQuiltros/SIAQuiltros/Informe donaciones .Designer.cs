namespace SIAQuiltros
{
    partial class Informe_donaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informe_donaciones));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Donaciones = new SIAQuiltros.Donaciones();
            this.DONACIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DONACIONTableAdapter = new SIAQuiltros.DonacionesTableAdapters.DONACIONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Donaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DONACIONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ListaDonaciones";
            reportDataSource1.Value = this.DONACIONBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SIAQuiltros.ReporteDonaciones.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Donaciones
            // 
            this.Donaciones.DataSetName = "Donaciones";
            this.Donaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DONACIONBindingSource
            // 
            this.DONACIONBindingSource.DataMember = "DONACION";
            this.DONACIONBindingSource.DataSource = this.Donaciones;
            // 
            // DONACIONTableAdapter
            // 
            this.DONACIONTableAdapter.ClearBeforeFill = true;
            // 
            // Informe_donaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Informe_donaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informe de donaciones";
            this.Load += new System.EventHandler(this.Informe_donaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Donaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DONACIONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DONACIONBindingSource;
        private Donaciones Donaciones;
        private DonacionesTableAdapters.DONACIONTableAdapter DONACIONTableAdapter;
    }
}