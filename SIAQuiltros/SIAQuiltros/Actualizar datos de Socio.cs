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
    
    public partial class ActualizarDatosSocios : Form
    {
        
        public ActualizarDatosSocios()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
            conexion.Open();
            String query = "Select *From Socio WHERE rut='" + rut.Text + "'";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader lectura = comando.ExecuteReader();
            if(lectura.Read())
            {
                Form actualizar = new VentanaActualizarSocio(lectura);
                actualizar.Show();
                this.Close();
            }  
            
            else
            {
                MessageBox.Show("Rut inválido. Verifique que lo haya ingresado correctamente.");
                rut.Text = "";
            }       
        }

        private void ActualizarDatosSocios_Load(object sender, EventArgs e)
        {

        }
    }
}
