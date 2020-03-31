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
    public partial class MostrarListadeVoluntarios : Form
    {
        public MostrarListadeVoluntarios()
        {
            InitializeComponent();
        }

        private void MostrarListadeVoluntarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'qUILTROSDataSet1.VOLUNTARIO' Puede moverla o quitarla según sea necesario.
            this.vOLUNTARIOTableAdapter.Fill(this.qUILTROSDataSet1.VOLUNTARIO);

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Report = new Reporte_PDF();
            Report.Show();
        }
    }
}
