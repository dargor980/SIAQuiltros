namespace SIAQuiltros
{
    partial class Asignar_Cuidador
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Voluntario = new System.Windows.Forms.ComboBox();
            this.Mascota = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione voluntario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione mascota:";
            // 
            // Voluntario
            // 
            this.Voluntario.FormattingEnabled = true;
            this.Voluntario.Location = new System.Drawing.Point(138, 57);
            this.Voluntario.Name = "Voluntario";
            this.Voluntario.Size = new System.Drawing.Size(273, 21);
            this.Voluntario.TabIndex = 2;
            this.Voluntario.SelectedIndexChanged += new System.EventHandler(this.Voluntario_SelectedIndexChanged);
            // 
            // Mascota
            // 
            this.Mascota.FormattingEnabled = true;
            this.Mascota.Location = new System.Drawing.Point(138, 87);
            this.Mascota.Name = "Mascota";
            this.Mascota.Size = new System.Drawing.Size(273, 21);
            this.Mascota.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Asignar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(373, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Asignar_Cuidador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 194);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Mascota);
            this.Controls.Add(this.Voluntario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Asignar_Cuidador";
            this.Text = "Asignar_Cuidador";
            this.Load += new System.EventHandler(this.Asignar_Cuidador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Voluntario;
        private System.Windows.Forms.ComboBox Mascota;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}