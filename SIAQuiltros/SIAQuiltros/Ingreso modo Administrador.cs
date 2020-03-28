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
    public partial class Ingreso_modo_Administrador : Form
    {
        public Ingreso_modo_Administrador()
        {
            InitializeComponent();
        }

        private void Ingreso_modo_Administrador_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
            conexion.Open();
            string query=""
        }
    }
}
