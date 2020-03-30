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

    public partial class Confirmar_hogartemporal : Form
    {
        String PET;
        String HOME;
        public Confirmar_hogartemporal(String PetName,String home)
        {
            String mascota = PetName;
            String hogar = home;
            InitializeComponent();
            label1.Text = "¿Está seguro de querer asignar a " + PetName + " al " + home + "?";
            PET = mascota;
            HOME = hogar;

            
        }

        private void Confirmar_hogartemporal_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
                conexion.Open();
                String query = "UPDATE HOGAR_TEMPORAL SET cod_mascota = (SELECT cod_chip FROM MASCOTA WHERE nombre='" + PET + "'), fecha_llegada=SYSDATETIME() WHERE cod_socio =(SELECT rut FROM SOCIO WHERE nombre='" + HOME + "')";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("La mascota ha sido ingresada correctamente.");
            }
            catch(SqlException ex)
            {
                string error = ex.ToString();
                MessageBox.Show("Error: " + error);
            }
            this.Close();
                
           
        }
    }
}
