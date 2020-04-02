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
    public partial class Confirmación_eliminación_de_mascota : Form
    {
        public Confirmación_eliminación_de_mascota(string mascota)
        {
            InitializeComponent();
            label1.Text = "¿Está seguro de querer eliminar a " + mascota + " de nuestros registros?";
        }

        private void Confirmación_eliminación_de_mascota_Load(object sender, EventArgs e)
        {

        }
    }
}
