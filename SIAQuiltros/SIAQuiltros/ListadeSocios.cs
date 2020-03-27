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
    public partial class ListadeSocios : Form
    {
        public ListadeSocios()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListadeSocios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'qUILTROSDataSet.SOCIO' Puede moverla o quitarla según sea necesario.
            this.sOCIOTableAdapter.Fill(this.qUILTROSDataSet.SOCIO);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
