namespace SIAQuiltros
{
    partial class ListadeSocios
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentabancariaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bancoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOCIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUILTROSDataSet = new SIAQuiltros.QUILTROSDataSet();
            this.sOCIOTableAdapter = new SIAQuiltros.QUILTROSDataSetTableAdapters.SOCIOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOCIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUILTROSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rutDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.cuentabancariaDataGridViewTextBoxColumn,
            this.bancoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sOCIOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 426);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rutDataGridViewTextBoxColumn
            // 
            this.rutDataGridViewTextBoxColumn.DataPropertyName = "rut";
            this.rutDataGridViewTextBoxColumn.HeaderText = "rut";
            this.rutDataGridViewTextBoxColumn.Name = "rutDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // cuentabancariaDataGridViewTextBoxColumn
            // 
            this.cuentabancariaDataGridViewTextBoxColumn.DataPropertyName = "cuenta_bancaria";
            this.cuentabancariaDataGridViewTextBoxColumn.HeaderText = "cuenta_bancaria";
            this.cuentabancariaDataGridViewTextBoxColumn.Name = "cuentabancariaDataGridViewTextBoxColumn";
            // 
            // bancoDataGridViewTextBoxColumn
            // 
            this.bancoDataGridViewTextBoxColumn.DataPropertyName = "banco";
            this.bancoDataGridViewTextBoxColumn.HeaderText = "banco";
            this.bancoDataGridViewTextBoxColumn.Name = "bancoDataGridViewTextBoxColumn";
            // 
            // sOCIOBindingSource
            // 
            this.sOCIOBindingSource.DataMember = "SOCIO";
            this.sOCIOBindingSource.DataSource = this.qUILTROSDataSet;
            // 
            // qUILTROSDataSet
            // 
            this.qUILTROSDataSet.DataSetName = "QUILTROSDataSet";
            this.qUILTROSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sOCIOTableAdapter
            // 
            this.sOCIOTableAdapter.ClearBeforeFill = true;
            // 
            // ListadeSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "ListadeSocios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadeSocios";
            this.Load += new System.EventHandler(this.ListadeSocios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOCIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUILTROSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QUILTROSDataSet qUILTROSDataSet;
        private System.Windows.Forms.BindingSource sOCIOBindingSource;
        private QUILTROSDataSetTableAdapters.SOCIOTableAdapter sOCIOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentabancariaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bancoDataGridViewTextBoxColumn;
    }
}