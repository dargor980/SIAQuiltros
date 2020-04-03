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
    public partial class Ingresar_Donaciones : Form
    {
        public Ingresar_Donaciones()
        {
            InitializeComponent();
        }
        
        public bool IsRutExists()//Checks if the rut exists in the database.
        {
            try
            {
                SqlConnection con = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
                con.Open();
                String qry = "SELECT *FROM SOCIO WHERE rut='" + Rut.Text + "'";
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                if(rdr.Read())
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
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public bool IsTextboxNotNull()//Checks if the thextboxes are not null.
        {
            if(Rut.Text!="" && Monto.Text!="" && Fecha.Value.ToString()!="")
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        private void Ingresar_Donaciones_Load(object sender, EventArgs e)
        {

            
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            if(IsTextboxNotNull())
            {
                if(IsRutExists())
                {
                    try
                    {
                        SqlConnection con = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
                        con.Open();
                        String qry = "INSERT INTO DONACION VALUES('" + Rut.Text + "'," + Monto.Text + ",'" + Fecha.Value.ToString() + "')";
                        SqlCommand cmd = new SqlCommand(qry, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Datos de donación ingresados correctamente.");
                        con.Close();
                        Rut.Text = "";
                        Monto.Text = "";
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Rut inválido. Por favor, verifique que lo haya ingresado correctamente.");
                    Rut.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Campo(s) vacío(s). Por favor ingrese todos los datos.");
            }

        }
    }
}
