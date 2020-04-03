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
    public partial class Informe_donaciones : Form
    {
        public Informe_donaciones()
        {
            InitializeComponent();
        }

        private void Informe_donaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Donaciones.DONACION' Puede moverla o quitarla según sea necesario.
            this.DONACIONTableAdapter.Fill(this.Donaciones.DONACION);

            this.reportViewer1.RefreshReport();
        }
    }
}
