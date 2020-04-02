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
    public partial class consultar_adoptante : Form
    {
        public consultar_adoptante()
        {
            InitializeComponent();
        }

        public bool IsRutVoid()
        {
            if(Rut.Text=="")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsNameVoid()
        {
            if(Name.Text=="")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            if(SearchParameter.SelectedItem.ToString()==null)
            {
                MessageBox.Show("Por favor, seleccione un parámetro de búsqueda.");
            }
            else
            {
                if (SearchParameter.SelectedItem.ToString() == "Rut")
                {
                    if (!IsRutVoid())
                    {
                        try
                        {
                            SqlConnection con = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
                            con.Open();
                            String qry = "SELECT *FROM ADOPTANTE WHERE rut='" + Rut.Text + "'";
                            SqlCommand cmd = new SqlCommand(qry, con);
                            SqlDataReader rdr = cmd.ExecuteReader();
                            if(rdr.Read())
                            {

                            }
                            else
                            {
                                MessageBox.Show("Rut inválido. Por favor verifique que lo haya ingresado correctamente.");
                                Rut.Text = "";
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese un rut.");
                    }
                }
                else
                {
                    if (SearchParameter.SelectedItem.ToString() == "Nombre")
                    {
                        if (!IsNameVoid())
                        {
                            try
                            {
                                SqlConnection con = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
                                con.Open();
                                String qry = "SELECT *FROM ADOPTANTE WHERE nombre='" + Name.Text + "'";
                                SqlCommand cmd = new SqlCommand(qry, con);
                                SqlDataReader rdr = cmd.ExecuteReader();
                                if(rdr.Read())
                                {

                                }
                                else
                                {
                                    MessageBox.Show("Nombre inválido. Por favor, verifique que lo haya ingresado correctamente.");
                                    Name.Text = "";
                                }

                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message);
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

        private void SearchParameter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SearchParameter.SelectedItem.ToString()=="Rut")
            {
                Rut.Enabled = true;
                Name.Enabled = false;
            }
            else
            {
                if(SearchParameter.SelectedItem.ToString()=="Nombre")
                {
                    Name.Enabled = true;
                    Rut.Enabled = false;
                }
            }
        }

        private void consultar_adoptante_Load(object sender, EventArgs e)
        {
            Rut.Enabled = false;
            Name.Enabled = false;
            SearchParameter.Items.Add("Rut");
            SearchParameter.Items.Add("Nombre");
        }
    }
}
