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
    public partial class Ingreso_modo_Administrador : Form
    {
        public Ingreso_modo_Administrador()
        {
            InitializeComponent();
        }

        private void Ingreso_modo_Administrador_Load(object sender, EventArgs e)
        {
            
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
                conexion.Open();
                String user = User.Text;
                String password = Password.Text;
                String User_comfirm;
                String password_comfirm;
                String query = "SELECT c.usuario, c.contraseña FROM VOLUNTARIO v, credencial c WHERE c.usuario='admin' AND c.contraseña='admin'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader lectura = comando.ExecuteReader();
                if (lectura.Read())
                {
                    User_comfirm = lectura["usuario"].ToString();
                    password_comfirm = lectura["contraseña"].ToString();
                    if (User_comfirm == user && password == password_comfirm)
                    {
                        MessageBox.Show("entro owo");
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña inválida. Intente nuevamente.");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
