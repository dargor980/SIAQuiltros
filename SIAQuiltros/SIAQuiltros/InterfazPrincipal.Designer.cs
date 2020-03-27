﻿namespace SIAQuiltros
{
    partial class InterfazPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEstadoDeSocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hogaresTemporalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEstadoHogaresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarHogarAMascotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mascotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarListaDeSociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.sociosToolStripMenuItem,
            this.hogaresTemporalesToolStripMenuItem,
            this.mascotasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // sociosToolStripMenuItem
            // 
            this.sociosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarEstadoDeSocioToolStripMenuItem,
            this.mostrarListaDeSociosToolStripMenuItem});
            this.sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
            this.sociosToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.sociosToolStripMenuItem.Text = "Socios";
            // 
            // consultarEstadoDeSocioToolStripMenuItem
            // 
            this.consultarEstadoDeSocioToolStripMenuItem.Name = "consultarEstadoDeSocioToolStripMenuItem";
            this.consultarEstadoDeSocioToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.consultarEstadoDeSocioToolStripMenuItem.Text = "Consultar estado de socio";
            this.consultarEstadoDeSocioToolStripMenuItem.Click += new System.EventHandler(this.consultarEstadoDeSocioToolStripMenuItem_Click);
            // 
            // hogaresTemporalesToolStripMenuItem
            // 
            this.hogaresTemporalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarEstadoHogaresToolStripMenuItem,
            this.asignarHogarAMascotaToolStripMenuItem});
            this.hogaresTemporalesToolStripMenuItem.Name = "hogaresTemporalesToolStripMenuItem";
            this.hogaresTemporalesToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.hogaresTemporalesToolStripMenuItem.Text = "Hogares Temporales";
            // 
            // consultarEstadoHogaresToolStripMenuItem
            // 
            this.consultarEstadoHogaresToolStripMenuItem.Name = "consultarEstadoHogaresToolStripMenuItem";
            this.consultarEstadoHogaresToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.consultarEstadoHogaresToolStripMenuItem.Text = "Consultar Estado hogares";
            this.consultarEstadoHogaresToolStripMenuItem.Click += new System.EventHandler(this.consultarEstadoHogaresToolStripMenuItem_Click);
            // 
            // asignarHogarAMascotaToolStripMenuItem
            // 
            this.asignarHogarAMascotaToolStripMenuItem.Name = "asignarHogarAMascotaToolStripMenuItem";
            this.asignarHogarAMascotaToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.asignarHogarAMascotaToolStripMenuItem.Text = "Asignar hogar a Mascota";
            // 
            // mascotasToolStripMenuItem
            // 
            this.mascotasToolStripMenuItem.Name = "mascotasToolStripMenuItem";
            this.mascotasToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.mascotasToolStripMenuItem.Text = "Mascotas";
            // 
            // mostrarListaDeSociosToolStripMenuItem
            // 
            this.mostrarListaDeSociosToolStripMenuItem.Name = "mostrarListaDeSociosToolStripMenuItem";
            this.mostrarListaDeSociosToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.mostrarListaDeSociosToolStripMenuItem.Text = "Mostrar lista de socios";
            // 
            // InterfazPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InterfazPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiltros- Plataforma de gestión integrada";
            this.Load += new System.EventHandler(this.InterfazPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarEstadoDeSocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarListaDeSociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hogaresTemporalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarEstadoHogaresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarHogarAMascotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mascotasToolStripMenuItem;
    }
}