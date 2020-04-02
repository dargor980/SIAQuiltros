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
    public partial class Ingresar_Adoptante : Form
    {
        public Ingresar_Adoptante()
        {
            InitializeComponent();
        }

        public bool IsTextboxNotVoid()
        {
            if(Rut.Text=="" || Name.Text=="" || Address.Text=="" || Phone.Text=="" || Comuna.Text=="" )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsRutExists() //Checks if the rut exist into the database.
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
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return true;
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            if(IsTextboxNotVoid())
            {
                if(!IsRutExists())
                {
                    try
                    {
                        SqlConnection con = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
                        con.Open();
                        String qry = "INSERT INTO ADOPTANTE(rut,nombre,direccion,telefono,comuna) VALUES('" + Rut.Text + "','" + Name.Text + "','" + Address + "','" + Phone.Text + "','" + Comuna.Text + "')";
                        SqlCommand cmd = new SqlCommand(qry, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Datos de adoptante ingresados correctamente.");
                        this.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    
                }
                else
                {
                    MessageBox.Show("El rut ingresado ya existe en los registros.");
                }
            }
            else
            {
                MessageBox.Show("Campo(s) vacío(s). Por favor, verifique que haya ingresado todos los datos solicitados.");
            }
            

        }
    }
}
