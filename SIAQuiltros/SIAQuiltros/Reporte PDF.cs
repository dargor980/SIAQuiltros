using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;




namespace SIAQuiltros
{
    public partial class Reporte_PDF : Form
    {
       

        public Reporte_PDF()
        {
            InitializeComponent();
        }

        private void Reporte_PDF_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'QUILTROSDataSet1.VOLUNTARIO' Puede moverla o quitarla según sea necesario.
            this.VOLUNTARIOTableAdapter.Fill(this.QUILTROSDataSet1.VOLUNTARIO);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
