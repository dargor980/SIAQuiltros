namespace SIAQuiltros
{
    partial class Confirmacion_eliminar_hogar_temporal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirmacion_eliminar_hogar_temporal));
            this.label1 = new System.Windows.Forms.Label();
            this.Si = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // Si
            // 
            this.Si.Location = new System.Drawing.Point(449, 111);
            this.Si.Name = "Si";
            this.Si.Size = new System.Drawing.Size(75, 23);
            this.Si.TabIndex = 1;
            this.Si.Text = "Si";
            this.Si.UseVisualStyleBackColor = true;
            this.Si.Click += new System.EventHandler(this.Si_Click);
            // 
            // No
            // 
            this.No.Location = new System.Drawing.Point(368, 110);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(75, 23);
            this.No.TabIndex = 2;
            this.No.Text = "No";
            this.No.UseVisualStyleBackColor = true;
            this.No.Click += new System.EventHandler(this.No_Click);
            // 
            // Confirmacion_eliminar_hogar_temporal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 146);
            this.Controls.Add(this.No);
            this.Controls.Add(this.Si);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(552, 185);
            this.MinimumSize = new System.Drawing.Size(552, 185);
            this.Name = "Confirmacion_eliminar_hogar_temporal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmación";
            this.Load += new System.EventHandler(this.Confirmacion_eliminar_hogar_temporal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Si;
        private System.Windows.Forms.Button No;
    }
}