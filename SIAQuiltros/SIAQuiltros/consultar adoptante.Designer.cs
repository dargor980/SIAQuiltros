namespace SIAQuiltros
{
    partial class consultar_adoptante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultar_adoptante));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchParameter = new System.Windows.Forms.ComboBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.Rut = new System.Windows.Forms.TextBox();
            this.Consultar = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar datos adoptante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar por:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rut:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre:";
            // 
            // SearchParameter
            // 
            this.SearchParameter.FormattingEnabled = true;
            this.SearchParameter.Location = new System.Drawing.Point(107, 77);
            this.SearchParameter.Name = "SearchParameter";
            this.SearchParameter.Size = new System.Drawing.Size(121, 21);
            this.SearchParameter.TabIndex = 4;
            this.SearchParameter.SelectedIndexChanged += new System.EventHandler(this.SearchParameter_SelectedIndexChanged);
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(107, 137);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(220, 20);
            this.Name.TabIndex = 5;
            // 
            // Rut
            // 
            this.Rut.Location = new System.Drawing.Point(107, 107);
            this.Rut.Name = "Rut";
            this.Rut.Size = new System.Drawing.Size(121, 20);
            this.Rut.TabIndex = 6;
            // 
            // Consultar
            // 
            this.Consultar.Location = new System.Drawing.Point(312, 183);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(75, 23);
            this.Consultar.TabIndex = 7;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(231, 182);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 8;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // consultar_adoptante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 218);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.Rut);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.SearchParameter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "consultar_adoptante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consultar_adoptante";
            this.Load += new System.EventHandler(this.consultar_adoptante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SearchParameter;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Rut;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Button Cerrar;
    }
}