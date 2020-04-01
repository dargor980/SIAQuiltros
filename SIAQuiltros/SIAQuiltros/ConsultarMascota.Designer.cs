namespace SIAQuiltros
{
    partial class ConsultarMascota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarMascota));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchParameter = new System.Windows.Forms.ComboBox();
            this.COD_CHIP = new System.Windows.Forms.TextBox();
            this.NAME = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Ficha de Mascota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar por:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Codigo de Chip:";
            // 
            // SearchParameter
            // 
            this.SearchParameter.FormattingEnabled = true;
            this.SearchParameter.Location = new System.Drawing.Point(107, 67);
            this.SearchParameter.Name = "SearchParameter";
            this.SearchParameter.Size = new System.Drawing.Size(121, 21);
            this.SearchParameter.TabIndex = 4;
            this.SearchParameter.SelectedIndexChanged += new System.EventHandler(this.SearchParameter_SelectedIndexChanged);
            // 
            // COD_CHIP
            // 
            this.COD_CHIP.Location = new System.Drawing.Point(128, 127);
            this.COD_CHIP.Name = "COD_CHIP";
            this.COD_CHIP.Size = new System.Drawing.Size(100, 20);
            this.COD_CHIP.TabIndex = 5;
            // 
            // NAME
            // 
            this.NAME.Location = new System.Drawing.Point(107, 97);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(121, 20);
            this.NAME.TabIndex = 6;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(313, 174);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 7;
            this.Search.Text = "Buscar";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(232, 173);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 8;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // ConsultarMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 209);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.COD_CHIP);
            this.Controls.Add(this.SearchParameter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarMascota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Ficha Mascota";
            this.Load += new System.EventHandler(this.ConsultarMascota_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SearchParameter;
        private System.Windows.Forms.TextBox COD_CHIP;
        private System.Windows.Forms.TextBox NAME;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Cerrar;
    }
}