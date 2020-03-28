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
    public partial class Asignar_hogar_a_mascota : Form
    {
        public Asignar_hogar_a_mascota()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Asignar_hogar_a_mascota_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
            conexion.Open();
            String query = "SELECT * FROM HOGAR_TEMPORAL WHERE cod_mascota IS NULL";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader lectura = comando.ExecuteReader();
            while(lectura.Read())
            {
                comboBox1.Items.Add(lectura["cod_socio"].ToString());
            }
            
        }
    }
}
