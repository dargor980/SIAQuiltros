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
    public partial class InterfazPrincipal : Form
    {
        public InterfazPrincipal(string user_info)
        {
            String buffer = user_info;
            InitializeComponent();
        }

        private void InterfazPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void consultarEstadoDeSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form consulta_socio = new Consultar_estado_de_socio();
            consulta_socio.Show();
        }
    }
}
