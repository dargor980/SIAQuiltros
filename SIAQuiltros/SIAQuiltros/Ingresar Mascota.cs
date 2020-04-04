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
using System.IO;

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
            pictureBox1.Image = null;
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
                    byte[] data = System.IO.File.ReadAllBytes(FileImage.Text);
                    String query = "INSERT INTO MASCOTA(cod_chip,nombre,edad,especie,tamaño,color,descripcion,estado,sexo,imagen,raza) VALUES('" + Cod_chip.Text + "','" + Name.Text + "'," + Age.Text + ",'" + Specie.Text + "','" + Tamaño.Text + "','" + Color.Text + "','" + Desciption.Text + "','" + Status.Text + "','"+comboBox1.SelectedItem.ToString()+"',@primagen,'"+Raza.Text+"')";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.Add("@primagen", data);
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

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult r = dlgImagen.ShowDialog();
            if(r== DialogResult.OK)
            {
                FileImage.Text = dlgImagen.FileName;
                pictureBox1.Load(FileImage.Text);
            }
        }

        private void Ingresar_Mascota_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Macho");
            comboBox1.Items.Add("Hembra");
        }
    }
}
