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
    public partial class Eliminar_Voluntario : Form
    {
        public Eliminar_Voluntario()
        {
            InitializeComponent();
        }

        public bool IsNameVoid() //Checks if the Name Textbox is void.
        {
            if(NAME.Text!="")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsRutVoid() //Checks if the Rut Textbox is void
        {
            if(RUT.Text!="")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        
        public bool IsRutExists()  //Checks if the Rut exists.
        {
            SqlConnection con = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
            con.Open();
            String qry = "SELECT *FROM VOLUNTARIO WHERE rut='" + RUT.Text + "'";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if(rdr.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
        public bool IsNameExists() //Checks if the Name exists.
        {
            SqlConnection con = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
            con.Open();
            String qry = "SELECT *FROM VOLUNTARIO WHERE nombre='" + NAME.Text + "'";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }

        public String GetCodCredencial(String parameter, String data)
        {
            SqlConnection con = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
            con.Open();
            String qry = "SELECT cod_credencial FROM VOLUNTARIO WHERE " + parameter + "='" + data + "'";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if(rdr.Read())
            {
                return rdr["cod_credencial"].ToString();
            }
            else
            {
                return null;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (SearchParameter.SelectedItem == null)
            {
                MessageBox.Show("Por favor, elija un parámetro de búsqueda");
            }
            else
            {
                if (SearchParameter.SelectedItem.ToString() == "Rut")
                {
                    if (!IsRutVoid())
                    {
                        if (IsRutExists())
                        {
                            String parameter ="Rut";
                            String Data = RUT.Text;
                            SqlConnection conexion = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
                            conexion.Open();
                            String qry = "DELETE FROM VOLUNTARIO WHERE rut='" + RUT.Text + "'";
                            SqlCommand cmd = new SqlCommand(qry, conexion);
                            String credencial = GetCodCredencial(parameter, Data);
                            Form confirm = new Confirmar_eliminación_voluntario(cmd,credencial);
                            confirm.Show();
                        }
                        else
                        {
                            MessageBox.Show("El rut no se encuentra en los registros. Verifique que lo haya ingresado correctamente");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor ingrese el Rut");
                    }
                }
                else
                {
                    if (SearchParameter.SelectedItem.ToString() == "Nombre")
                    {
                        if (!IsNameVoid())
                        {
                            if (IsNameExists())
                            {
                                String parameter = "Rut";
                                String Data = RUT.Text;
                                SqlConnection conexion = new SqlConnection("server=AMADEUS ; databse=QUILTROS ; integrated security=True");
                                conexion.Open();
                                String qry = "DELETE FROM VOLUNTARIO WHERE nombre='" + NAME.Text + "'";
                                SqlCommand cmd = new SqlCommand(qry, conexion);
                                String credencial = GetCodCredencial(parameter, Data);
                                Form confirm = new Confirmar_eliminación_voluntario(cmd,credencial);
                                confirm.Show();

                            }
                            else
                            {
                                MessageBox.Show("El nombre no se encuentra en los registros. Verifique que lo haya ingresado correctamente");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor ingrese un nombre.");
                        }
                    }

                }

            }                     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Eliminar_Voluntario_Load(object sender, EventArgs e)
        {
            SearchParameter.Items.Add("Rut");
            SearchParameter.Items.Add("Nombre");
            RUT.Enabled = false;
            NAME.Enabled = false;
        }

        private void SearchParameter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SearchParameter.SelectedItem.ToString()=="Rut")
            {
                RUT.Enabled = true;
                NAME.Enabled = false;
            }
            else
            {
                RUT.Enabled = false;
                NAME.Enabled = true;
            }
        }
    }
}
