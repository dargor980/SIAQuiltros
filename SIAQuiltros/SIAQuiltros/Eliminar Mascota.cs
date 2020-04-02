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
    public partial class Eliminar_Mascota : Form
    {
        public Eliminar_Mascota()
        {
            InitializeComponent();
        }
        public void GetMascotas()
        {
            SqlConnection con = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
            con.Open();
            String qry = "SELECT nombre FROM MASCOTA";
            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                while(rdr.Read())
                {
                    Mascota.Items.Add(rdr["nombre"].ToString());
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Eliminar_Mascota_Load(object sender, EventArgs e)
        {
            GetMascotas();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form confirmacion = new Confirmación_eliminación_de_mascota(Mascota.SelectedItem.ToString());
            confirmacion.Show();
            GetMascotas();
        }
    }
}
