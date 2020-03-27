using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

using iTextSharp.text;

using System.Data.SqlClient;

namespace SIAQuiltros
{
    public partial class Detalles_consulta_socio : Form
    {
        public Detalles_consulta_socio(String query)
        {
            string consulta = query;
            InitializeComponent();
            SqlConnection conexion = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
            conexion.Open();
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader read = comando.ExecuteReader();
            if(read.Read())
            {

            }
            nombre.Text = read["nombre"].ToString();
            rut.Text = read["rut"].ToString();
            direccion.Text = read["direccion"].ToString();
            telefono.Text = read["telefono"].ToString();
            cuentabancaria.Text = read["cuenta_bancaria"].ToString();
            Banco.Text = read["banco"].ToString();

            
        }

        private void Detalles_consulta_socio_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
