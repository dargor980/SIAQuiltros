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
    public partial class ConsultarVoluntario : Form
    {
        public ConsultarVoluntario()
        {
            InitializeComponent();
        }

        private void ConsultarVoluntario_Load(object sender, EventArgs e)
        {
            optionQuery.Items.Add("rut");
            optionQuery.Items.Add("Nombre");
            rut.Enabled = false;
            name.Enabled = false;
        }

        private void optionQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(optionQuery.SelectedItem.ToString()=="rut")
            {
                name.Enabled = false;
                rut.Enabled = true;
            }
            else
            {
                if(optionQuery.SelectedItem.ToString()=="Nombre")
                {
                    rut.Enabled = false;
                    name.Enabled = true;
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if(optionQuery.Text=="")
            {
                MessageBox.Show("Por favor seleccione un parámetro de búsqueda.");
            }
            else
            {
                SqlConnection conexion = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
                conexion.Open();
                if (optionQuery.Text == "rut")
                {
                    if (rut.Text == "")
                    {
                        MessageBox.Show("Por favor Ingrese un rut");
                    }
                    else
                    {
                        String query = "SELECT *FROM VOLUNTARIO WHERE rut='" + rut.Text + "'";
                        SqlCommand comando = new SqlCommand(query, conexion);
                        SqlDataReader lectura = comando.ExecuteReader();
                        if (lectura.Read())
                        {

                        }
                        else
                        {
                            MessageBox.Show("Rut inválido. Verifique que lo haya ingresado correctamente.");
                        }
                    }

                }
                else
                {
                    if (optionQuery.Text == "Nombre")
                    {
                        if (name.Text == "")
                        {
                            MessageBox.Show("Por favor, Ingrese un nombre.");
                        }
                        else
                        {
                            String query = "SELECT *FROM VOLUNTARIO WHERE nombre='" + name.Text + "'";
                            SqlCommand comando = new SqlCommand(query, conexion);
                            SqlDataReader lectura = comando.ExecuteReader();
                            if (lectura.Read())
                            {
                                Form consultaVoluntario = new ResultadoConsultaVoluntario();
                                consultaVoluntario.Show();
                            }
                            else
                            {
                                MessageBox.Show("Nombre inválido. verifique que lo haya ingresado correctamente.");
                            }
                        }
                    }
                }

            }                
        }
    }
}
