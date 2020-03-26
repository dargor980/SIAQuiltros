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
    public partial class Consultar_estado_de_socio : Form
    {
        public Consultar_estado_de_socio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
            conexion.Open();
            String rut = textBox1.Text;
            String query = "select *from SOCIO where rut='" + rut + "'";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader consulta = comando.ExecuteReader();
            if(consulta.Read())
            {
                Form search_socio = new Detalles_consulta_socio(query);
                search_socio.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Rut inválido. Ingrese nuevamente");
            }

        }
    }
}
