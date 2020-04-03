namespace SIAQuiltros
{
    partial class Ingresar_Donaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingresar_Donaciones));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Rut = new System.Windows.Forms.TextBox();
            this.Monto = new System.Windows.Forms.TextBox();
            this.Ingresar = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar Donación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese rut del socio (sin puntos ni guión):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha: ";
            // 
            // Rut
            // 
            this.Rut.Location = new System.Drawing.Point(238, 67);
            this.Rut.MaxLength = 9;
            this.Rut.Name = "Rut";
            this.Rut.Size = new System.Drawing.Size(100, 20);
            this.Rut.TabIndex = 4;
            // 
            // Monto
            // 
            this.Monto.Location = new System.Drawing.Point(76, 97);
            this.Monto.Name = "Monto";
            this.Monto.Size = new System.Drawing.Size(100, 20);
            this.Monto.TabIndex = 5;
            // 
            // Ingresar
            // 
            this.Ingresar.Location = new System.Drawing.Point(260, 212);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(75, 23);
            this.Ingresar.TabIndex = 9;
            this.Ingresar.Text = "Ingresar";
            this.Ingresar.UseVisualStyleBackColor = true;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(179, 212);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 10;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(33, 155);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(200, 20);
            this.Fecha.TabIndex = 11;
            // 
            // Ingresar_Donaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 255);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.Ingresar);
            this.Controls.Add(this.Monto);
            this.Controls.Add(this.Rut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(363, 294);
            this.MinimumSize = new System.Drawing.Size(363, 294);
            this.Name = "Ingresar_Donaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar Donación";
            this.Load += new System.EventHandler(this.Ingresar_Donaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Rut;
        private System.Windows.Forms.TextBox Monto;
        private System.Windows.Forms.Button Ingresar;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.DateTimePicker Fecha;
    }
}