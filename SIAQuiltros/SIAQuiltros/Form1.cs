using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using System.Data.SqlClient;

namespace SIAQuiltros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void ResetBox()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Iniciando Sesión";
            button1.Enabled = false;
            SqlConnection conexion = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
            conexion.Open();
            string user = textBox1.Text;
            string password = textBox2.Text;
            String token = "select nombre from voluntario v, credencial c where v.cod_credencial=c.cod_credencial and C.usuario='" + user + "' and c.contraseña='" + password + "'";
            SqlCommand comando = new SqlCommand(token, conexion);
            SqlDataReader auth = comando.ExecuteReader();
            if (auth.Read())
            {
                Form1 principal = this;
                Form Inicio = new InterfazPrincipal(token,principal);
                Thread.Sleep(2000);
                Inicio.Show();
                button1.Enabled = true;
                button1.Text = "Iniciar sesión";
                ResetBox();
            }
            else
            {
                MessageBox.Show("Usuario con contraseña errónea. Intente nuevamente.");
                button1.Enabled = true;
                button1.Text = "Iniciar sesión";
                ResetBox();
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            Form RecoverPass = new SolicitarContraseña();
            RecoverPass.Show();
        }
    }
}
