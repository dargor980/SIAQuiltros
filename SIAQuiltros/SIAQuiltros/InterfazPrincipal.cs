﻿using System;
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

        private void EliminarHogarTemporalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form deletehogar = new Eliminar_Hogar_Temporal();
            deletehogar.Show();
        }

        private void actualizarDatosDeSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form UpdateSocios = new ActualizarDatosSocios();
            UpdateSocios.Show();
        }

        private void ingresarSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form InsertSocio = new IngresarSocio();
            InsertSocio.Show();
        }

        private void revisarVoluntarioEnEspecíficoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form SearchVoluntario = new ConsultarVoluntario();
            SearchVoluntario.Show();
        }

        private void mostrarListaDeVoluntariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ShowlistVoluntarios = new MostrarListadeVoluntarios();
            ShowlistVoluntarios.Show();
        }

        private void ingresarMascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form InsertMascota = new Ingresar_Mascota();
            InsertMascota.Show();
        }

        private void mostrarFichaMascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FichaMascota = new ConsultarMascota();
            FichaMascota.Show();
        }

        private void eliminarVoluntarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form delete = new Eliminar_Voluntario();
            delete.Show();
        }

        private void asignarCuidadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form asignar = new Asignar_Cuidador();
            asignar.Show();
        }

        private void mostrarListaDeMascotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form listMAscotas = new Mostrar_Lista_de_Mascotas();
            listMAscotas.Show();
        }

        private void eliminarMascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form eliminar = new Eliminar_Mascota();
            eliminar.Show();
        }

        private void ingresarAdoptanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ingresarAdoptante = new Ingresar_Adoptante();
            ingresarAdoptante.Show();
        }

        private void consultarAdoptanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form consultarAdoptante = new consultar_adoptante();
            consultarAdoptante.Show();
        }

        private void donacionesPorSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form donacionSocio = new Donaciones_de_socio();
            donacionSocio.Show();
        }

        private void mostrarTodasLasDonacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form listDonaciones = new Mostrar_Lista_de_Donaciones();
            listDonaciones.Show();
        }

        private void ingresarDonacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form IngresarDonacion = new Ingresar_Donaciones();
            IngresarDonacion.Show();
        }

        private void calendarioDeActividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form calendarioActividades = new Calendario_de_actividades();
            calendarioActividades.Show();
        }

        private void historialDeActividadesRealizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ACtividadesRealizadas = new HistorialActividadesRealizadas();
            ACtividadesRealizadas.Show();
        }

        private void eliminarAdoptanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form deleteAdoptante = new Eliminar_Adoptante();
            deleteAdoptante.Show();
        }
    }
}
