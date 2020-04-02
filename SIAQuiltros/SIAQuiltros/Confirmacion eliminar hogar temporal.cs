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
    
    public partial class Confirmacion_eliminar_hogar_temporal : Form
    {
        String hogar;
        public Confirmacion_eliminar_hogar_temporal(string home)
        {
            hogar = home;
            InitializeComponent();
            label1.Text = "¿Está seguro de querer eliminar el hogar temporal de " + home + "?";
        }

        private void Confirmacion_eliminar_hogar_temporal_Load(object sender, EventArgs e)
        {

        }

        private void No_Click(object sender, EventArgs e)
        {
            Form back = new Eliminar_Hogar_Temporal();
            back.Show();
            this.Close();
        }

        private void Si_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
                con.Open();
                String qry = "DELETE FROM HOGAR_TEMPORAL WHERE cod_socio=(SELECT rut FROM SOCIO WHERE nombre='" + hogar + "')";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("El hogar de " + hogar + " Ha sido eliminado correctamente.");
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            Form back = new Eliminar_Hogar_Temporal();
            back.Show();
            this.Close();

        }
    }
}
