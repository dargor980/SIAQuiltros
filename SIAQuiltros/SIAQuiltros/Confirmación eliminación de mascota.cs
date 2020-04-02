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
    public partial class Confirmación_eliminación_de_mascota : Form
    {
        String Mascota;
        public Confirmación_eliminación_de_mascota(string mascota)
        {
            InitializeComponent();
            label1.Text = "¿Está seguro de querer eliminar a " + mascota + " de nuestros registros?";
            Mascota = mascota;
        }

        private void Confirmación_eliminación_de_mascota_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
                con.Open();
                String qry = "DELETE FROM MASCOTA WHERE nombre='" + Mascota + "'";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado exitosamente.");
                con.Close();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
