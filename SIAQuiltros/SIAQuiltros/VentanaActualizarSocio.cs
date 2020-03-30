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
    public partial class VentanaActualizarSocio : Form
    {
        public VentanaActualizarSocio(SqlDataReader query)
        {
            SqlDataReader lectura = query;
            InitializeComponent();
        }

        private void VentanaActualizarSocio_Load(object sender, EventArgs e)
        {

        }
    }
}
