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
    public partial class Ingresar_Mascota : Form
    {
        public void resetBox()
        {
            Cod_chip.Text = "";
            Name.Text = "";
            Age.Text = "";
            Specie.Text = "";
            Tamaño.Text = "";
            Color.Text = "";
            Desciption.Text = "";
            Status.Text = "";
        }

        public bool IsPetNotExists()
        {
            SqlConnection conexion = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
            conexion.Open();
            String query = "SELECT *FROM MASCOTA WHERE cod_chip='" + Cod_chip.Text + "'";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader lectura = comando.ExecuteReader();
            if (lectura.Read())
            {
                return false;

            }
            else
            {
                return true;
            }
        }

        public bool IsTextBoxVoid()
        {
            if(Cod_chip.Text=="" || Name.Text=="" || Age.Text=="" || Specie.Text=="" || Tamaño.Text=="" || Color.Text=="" || Desciption.Text=="" || Status.Text=="")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Ingresar_Mascota()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!IsTextBoxVoid())
            {
                if (IsPetNotExists())
                {
                    SqlConnection conexion = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
                    conexion.Open();
                    String query = "INSERT INTO MASCOTA(cod_chip,nombre,edad,especie,tamaño,color,descripcion,estado) VALUES('" + Cod_chip.Text + "','" + Name.Text + "'," + Age.Text + ",'" + Specie.Text + "','" + Tamaño.Text + "','" + Color.Text + "','" + Desciption.Text + "','" + Status.Text + "')";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("Mascota registrada correctamente");
                    resetBox();
                }
                else
                {
                    MessageBox.Show("La mascota ya existe en nuestros registros.");
                }
            }
            else
            {
                MessageBox.Show("Campo(s) Vacío(s). Por favor ingrese los datos faltantes.");
            }
            
            
        }
    }
}
