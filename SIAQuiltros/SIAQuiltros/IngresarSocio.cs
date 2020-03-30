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
    public partial class IngresarSocio : Form
    {
        public void resetTextBox()
        {
            RUT.Text = "";
            NAME.Text = "";
            ADDRESS.Text = "";
            PHONE.Text = "";
            BANKNUMBER.Text = "";
            BANK.Text = "";
            HOMEADDRESS.Text = "";
            COMUNA.Text = "";
        }
        public bool IsTextBoxSocioVoid()
        {
            if(RUT.Text=="" || NAME.Text=="" || ADDRESS.Text=="" || PHONE.Text=="" || BANKNUMBER.Text=="" || BANK.Text=="" )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsTextBoxHogarVoid()
        {
            if(HOMEADDRESS.Text=="" || COMUNA.Text=="")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsSocioExists()
        {
            SqlConnection conexion = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
            conexion.Open();
            String query = "SELECT *FROM SOCIO WHERE rut='" + RUT.Text + "'";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader lectura = comando.ExecuteReader();
            if(lectura.Read())
            {
                return true;
            }
            else
            {
                conexion.Close();
                return false;
            }
        }
        public IngresarSocio()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ADDHOME.SelectedItem.ToString()=="Si")
            {
                HOMEADDRESS.Enabled = true;
                COMUNA.Enabled = true;

            }
            else
            {
                HOMEADDRESS.Enabled = false;
                COMUNA.Enabled = false;
            }
        }

        private void IngresarSocio_Load(object sender, EventArgs e)
        {
            ADDHOME.Items.Add("Si");
            ADDHOME.Items.Add("No");
            HOMEADDRESS.Enabled = false;
            COMUNA.Enabled = false;
           
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if(IsTextBoxSocioVoid())
            {
                MessageBox.Show("Campo(s) vacío(s). Verifique que haya ingresado todos los datos.");
            }
            else
            {
                if (!IsSocioExists() && ADDHOME.Text == "Si" && !IsTextBoxHogarVoid())
                {
                    SqlConnection conexion = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
                    conexion.Open();
                    String INSERT_SOCIO = "INSERT INTO SOCIO VALUES('" + RUT.Text + "','" + NAME.Text + "','" + ADDRESS.Text + "','" + PHONE.Text + "','" + BANKNUMBER.Text + "','" + BANK.Text + "')";
                    SqlCommand comando = new SqlCommand(INSERT_SOCIO, conexion);
                    comando.ExecuteNonQuery();
                    conexion.Close();
                    conexion.Open();
                    String INSERT_HOGAR_TEMPORAL = "INSERT INTO HOGAR_TEMPORAL (cod_socio,direccion,comuna) VALUES('" + RUT.Text + "','" + HOMEADDRESS.Text + "','" + COMUNA.Text + "')";
                    SqlCommand comando2 = new SqlCommand(INSERT_HOGAR_TEMPORAL, conexion);
                    comando2.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("Datos de socio y de Hogar temporal asociado ingresados correctamente.");
                    resetTextBox();
                    this.Close();
                }
                else
                {
                    if(!IsSocioExists() && ADDHOME.Text=="Si" && IsTextBoxHogarVoid())
                    {
                        MessageBox.Show("Campo(s) vacío(s) del Hogar temporal. Verifique que haya ingresado todos los datos");
                        
                    }
                    else
                    {
                        if (!IsSocioExists() && ADDHOME.Text == "No")
                        {
                            SqlConnection conexion = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
                            conexion.Open();
                            String INSERT_SOCIO = "INSERT INTO SOCIO VALUES('" + RUT.Text + "','" + NAME.Text + "','" + ADDRESS.Text + "','" + PHONE.Text + "','" + BANKNUMBER.Text + "','" + BANK.Text + "')";
                            SqlCommand comando = new SqlCommand(INSERT_SOCIO, conexion);
                            comando.ExecuteNonQuery();
                            conexion.Close();
                            MessageBox.Show("Datos de socios ingresados correctamente.");
                            resetTextBox();

                        }
                        else
                        {
                            MessageBox.Show("El rut ingresado ya existe en nuestros registros. Ingrese otro");
                            resetTextBox();
                        }

                    }

                }

            }
            
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
