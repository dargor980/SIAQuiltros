using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIAQuiltros
{
    public partial class Mostrar_Lista_de_Donaciones : Form
    {
        public Mostrar_Lista_de_Donaciones()
        {
            InitializeComponent();
        }

        private void Mostrar_Lista_de_Donaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'donaciones.DONACION' Puede moverla o quitarla según sea necesario.
            this.dONACIONTableAdapter.Fill(this.donaciones.DONACION);

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GenerarReporteDonaciones_Click(object sender, EventArgs e)
        {

        }
    }
}
