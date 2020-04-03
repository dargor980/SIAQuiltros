namespace SIAQuiltros
{
    partial class Mostrar_Lista_de_Donaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mostrar_Lista_de_Donaciones));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.donaciones = new SIAQuiltros.Donaciones();
            this.dONACIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dONACIONTableAdapter = new SIAQuiltros.DonacionesTableAdapters.DONACIONTableAdapter();
            this.GenerarReporteDonaciones = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.coddonacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codsocioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONACIONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de donaciones recibidas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coddonacionDataGridViewTextBoxColumn,
            this.codsocioDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dONACIONBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(443, 431);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // donaciones
            // 
            this.donaciones.DataSetName = "Donaciones";
            this.donaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dONACIONBindingSource
            // 
            this.dONACIONBindingSource.DataMember = "DONACION";
            this.dONACIONBindingSource.DataSource = this.donaciones;
            // 
            // dONACIONTableAdapter
            // 
            this.dONACIONTableAdapter.ClearBeforeFill = true;
            // 
            // GenerarReporteDonaciones
            // 
            this.GenerarReporteDonaciones.Location = new System.Drawing.Point(352, 514);
            this.GenerarReporteDonaciones.Name = "GenerarReporteDonaciones";
            this.GenerarReporteDonaciones.Size = new System.Drawing.Size(105, 23);
            this.GenerarReporteDonaciones.TabIndex = 2;
            this.GenerarReporteDonaciones.Text = "Generar reporte";
            this.GenerarReporteDonaciones.UseVisualStyleBackColor = true;
            this.GenerarReporteDonaciones.Click += new System.EventHandler(this.GenerarReporteDonaciones_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(271, 514);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 3;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // coddonacionDataGridViewTextBoxColumn
            // 
            this.coddonacionDataGridViewTextBoxColumn.DataPropertyName = "cod_donacion";
            this.coddonacionDataGridViewTextBoxColumn.FillWeight = 50F;
            this.coddonacionDataGridViewTextBoxColumn.HeaderText = "cod_donacion";
            this.coddonacionDataGridViewTextBoxColumn.Name = "coddonacionDataGridViewTextBoxColumn";
            this.coddonacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codsocioDataGridViewTextBoxColumn
            // 
            this.codsocioDataGridViewTextBoxColumn.DataPropertyName = "cod_socio";
            this.codsocioDataGridViewTextBoxColumn.HeaderText = "Rut Socio";
            this.codsocioDataGridViewTextBoxColumn.Name = "codsocioDataGridViewTextBoxColumn";
            this.codsocioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Mostrar_Lista_de_Donaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 549);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.GenerarReporteDonaciones);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mostrar_Lista_de_Donaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar_Lista_de_Donaciones";
            this.Load += new System.EventHandler(this.Mostrar_Lista_de_Donaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONACIONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Donaciones donaciones;
        private System.Windows.Forms.BindingSource dONACIONBindingSource;
        private DonacionesTableAdapters.DONACIONTableAdapter dONACIONTableAdapter;
        private System.Windows.Forms.Button GenerarReporteDonaciones;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn coddonacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codsocioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
    }
}