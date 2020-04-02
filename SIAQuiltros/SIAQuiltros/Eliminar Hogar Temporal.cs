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
    public partial class Eliminar_Hogar_Temporal : Form
    {
        public void LoadHogarTemporal() //Gets the temporal homes and pushes in the combobox.
        {
            try
            {
                SqlConnection con = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
                con.Open();
                String qry = "SELECT s.nombre FROM SOCIO s, HOGAR_TEMPORAL h WHERE s.rut=h.cod_socio";
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                while(rdr.Read())
                {
                    HogarTemporal.Items.Add(rdr["nombre"].ToString());
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public Eliminar_Hogar_Temporal()
        {
            InitializeComponent();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Eliminar_Hogar_Temporal_Load(object sender, EventArgs e)
        {
            LoadHogarTemporal();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            String hogar = HogarTemporal.SelectedItem.ToString();
            Form confirmacion = new Confirmacion_eliminar_hogar_temporal(hogar);
            confirmacion.Show();
            this.Close();
        }
    }
}
