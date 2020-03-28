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
    public partial class Consultar_estado_hogares : Form
    {
        public Consultar_estado_hogares()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
            conexion.Open();
            String rut = textBox1.Text;
            String query = "SELECT *FROM SOCIO s, HOGAR_TEMPORAL h, MASCOTA m WHERE s.rut=h.cod_socio AND s.rut='"+rut+"'";
            SqlCommand comando = new SqlCommand(query,conexion);
            SqlDataReader lectura = comando.ExecuteReader();
            if(lectura.Read())
            {
                Form search = new ResultadoConsultaHogarTemporal(lectura);
                search.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Rut invalido");
            }

            
        }

        private void Consultar_estado_hogares_Load(object sender, EventArgs e)
        {

        }
    }
}
