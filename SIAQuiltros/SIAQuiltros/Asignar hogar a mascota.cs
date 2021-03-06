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
            List<String> listacod_socio = new List<string>();
            SqlConnection conexion = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
            conexion.Open();
            String query = "SELECT * FROM HOGAR_TEMPORAL WHERE cod_mascota IS NULL";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader lectura = comando.ExecuteReader();
            while(lectura.Read())
            {
                listacod_socio.Add(lectura["cod_socio"].ToString());
            }
            conexion.Close();
            foreach(string lista in listacod_socio)
            {
                conexion.Open();
                query= "Select nombre FROM SOCIO WHERE rut='" + lista + "'";
                SqlCommand comando3 = new SqlCommand(query, conexion);
                SqlDataReader LECTURA = comando3.ExecuteReader();
                while(LECTURA.Read())
                {
                    comboBox1.Items.Add(LECTURA["nombre"].ToString());
                }
            }
            conexion.Close();
            conexion.Open();
            String query2 = "SELECT nombre FROM MASCOTA WHERE cod_chip NOT IN(SELECT h.cod_mascota FROM HOGAR_TEMPORAL h,  MASCOTA m where h.cod_mascota=m.cod_chip)";
            SqlCommand comando2 = new SqlCommand(query2, conexion);
            SqlDataReader lectura2 = comando2.ExecuteReader();
            while(lectura2.Read())
            {
                comboBox2.Items.Add(lectura2["nombre"].ToString());
            }
            conexion.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String mascota = comboBox2.Text;
            String hogar = comboBox1.Text;
            if(mascota!="" && hogar!="")
            {
                Form confirmacion = new Confirmar_hogartemporal(mascota, hogar);
                confirmacion.Show();
            }
            else
            {
                MessageBox.Show("Por favor, verifique que haya ingresado los datos.");
            }
            
        }
    }
}
