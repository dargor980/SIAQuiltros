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
    public partial class InterfazPrincipal : Form
    {
        Form1 LOGIN;
       
        public void WelcomeMessage(string token)
        {
            SqlConnection conexion = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
            conexion.Open();
            SqlCommand comando = new SqlCommand(token, conexion);
            SqlDataReader lectura = comando.ExecuteReader();
            if(lectura.Read())
            {
                label2.Text = lectura["nombre"].ToString();
            }
        }
       
        public InterfazPrincipal(string user_info,Form1 principal)
        {
           
            String buffer = user_info;
            InitializeComponent();
            Form1 p = principal;
            LOGIN = p;
            p.Hide();
            WelcomeMessage(buffer);
        }


        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LOGIN.Show();
            this.Close();
        }

        private void consultarEstadoDeSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form consulta_socio = new Consultar_estado_de_socio();
            consulta_socio.Show();
        }

        private void consultarEstadoHogaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form consultaEstadoHogares = new Consultar_estado_hogares();
            consultaEstadoHogares.Show();
        }

        private void asignarHogarAMascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form asignarHogar = new Asignar_hogar_a_mascota();
            asignarHogar.Show();
        }

        private void voluntarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ingresarVoluntariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ingresarVoluntario = new Ingresar_voluntario();
            ingresarVoluntario.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LOGIN.Close();
            this.Close();
            
        }

        private void mostrarListaDeSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ListSocios = new ListadeSocios();
            ListSocios.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeQuiltrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AboutUs = new Acerca_de_Quiltros();
            AboutUs.Show();
        }

        private void modoAdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ADMIN = new Ingreso_modo_Administrador();
            ADMIN.Show();
        }
    }
}
