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
    public partial class ConsultarMascota : Form
    {
        public ConsultarMascota()
        {
            InitializeComponent();
        }

        public bool IsNamevoid()
        {
            if(NAME.Text=="")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsCodChipVoid()
        {
            if(COD_CHIP.Text=="")
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

        private void ConsultarMascota_Load(object sender, EventArgs e)
        {
            SearchParameter.Items.Add("Nombre");
            SearchParameter.Items.Add("Código de chip");
            NAME.Enabled = false;
            COD_CHIP.Enabled = false;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if(SearchParameter.SelectedItem.ToString()==null)
            {
                MessageBox.Show("Por favor selecciones un parámetro de búsqueda");
            }
            else
            {
                if(SearchParameter.SelectedItem.ToString()=="Nombre")
                {
                    if(!IsNamevoid())
                    {
                        SqlConnection con = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
                        con.Open();
                        String qry = "SELECT *FROM MASCOTA WHERE nombre='" + NAME.Text + "'";
                        SqlCommand cmd = new SqlCommand(qry, con);
                        try
                        {
                            SqlDataReader rdr = cmd.ExecuteReader();
                            if(rdr.Read())
                            {
                                Form ficha = new FichaMascota(rdr);
                                ficha.Show();
                                this.Close();
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
                else
                {
                    if(SearchParameter.SelectedItem.ToString()=="Código de chip")
                    {
                        if(!IsCodChipVoid())
                        {
                            SqlConnection con = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
                            con.Open();
                            String qry = "SELECT *FROM MASCOTA WHERE cod_chip='" + COD_CHIP.Text + "'";
                            SqlCommand cmd = new SqlCommand(qry, con);
                            try
                            {
                                SqlDataReader rdr = cmd.ExecuteReader();
                                if (rdr.Read())
                                {
                                    Form ficha = new FichaMascota(rdr);
                                    ficha.Show();
                                    this.Close();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor ingrese el Código del chip de la mascota.");
                        }
                    }
                }
            }
            



        }

        private void SearchParameter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchParameter.SelectedItem.ToString() == "Nombre") 
            {
                NAME.Enabled = true;
                COD_CHIP.Enabled = false;
            }
            else
            {
                COD_CHIP.Enabled = true;
                NAME.Enabled = false;
            }
        }
    }
}
