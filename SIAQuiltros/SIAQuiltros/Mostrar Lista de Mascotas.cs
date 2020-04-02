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
    public partial class Mostrar_Lista_de_Mascotas : Form
    {
        public Mostrar_Lista_de_Mascotas()
        {
            InitializeComponent();
        }

        private void Mostrar_Lista_de_Mascotas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'listadeMascotas.MASCOTA' Puede moverla o quitarla según sea necesario.
            this.mASCOTATableAdapter.Fill(this.listadeMascotas.MASCOTA);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
