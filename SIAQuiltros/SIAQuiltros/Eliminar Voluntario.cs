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
                return true;
            }
            else
            {
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(SearchParameter.SelectedItem.ToString()=="Rut" && !IsRutVoid())
            {
                if(IsRutExists())
                {
                    SqlConnection conexion = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
                    conexion.Open();
                    String qry = "DELETE FROM VOLUNTARIO WHERE rut='" + RUT.Text + "'";
                    SqlCommand cmd = new SqlCommand(qry, conexion);
                    Form confirm = new Confirmar_eliminación_voluntario(cmd);
                    confirm.Show();
                }
                else
                {
                    MessageBox.Show("El rut no se encuentra en los registros. Verifique que lo haya ingresado correctamente");
                }
                

            }
            else
            {
                if(SearchParameter.SelectedItem.ToString()=="Nombre" && !IsNameVoid())
                {
                    if(IsNameExists())
                    {
                        SqlConnection conexion = new SqlConnection("server=AMADEUS ; databse=QUILTROS ; integrated security=True");
                        conexion.Open();
                        String qry = "DELETE FROM VOLUNTARIO WHERE nombre='" + NAME.Text + "'";
                        SqlCommand cmd = new SqlCommand(qry, conexion);
                        Form confirm = new Confirmar_eliminación_voluntario(cmd);
                        confirm.Show();

                    }
                    else
                    {
                        MessageBox.Show("El nombre no se encuentra en los registros. Verifique que lo haya ingresado correctamente");
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
