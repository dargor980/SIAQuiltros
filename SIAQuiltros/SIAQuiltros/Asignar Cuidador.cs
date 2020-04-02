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
    public partial class Asignar_Cuidador : Form
    {

        public void LoadComboBox()
        {
            SqlConnection con = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
            con.Open();
            String qry = "SELECT nombre FROM VOLUNTARIO WHERE nombre NOT IN (SELECT v.nombre FROM VOLUNTARIO v, CUIDA c, MASCOTA m WHERE v.rut=c.cod_voluntario AND c.cod_mascota=m.cod_chip)";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            try
            {
                while (rdr.Read())
                {
                    Voluntario.Items.Add(rdr["nombre"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            con.Close();
            con.Open();
            string qry2 = "SELECT nombre FROM MASCOTA WHERE nombre NOT IN (SELECT m.nombre FROM VOLUNTARIO v, MASCOTA m, CUIDA c WHERE c.cod_voluntario=v.rut AND c.cod_mascota=m.cod_chip) ";
            SqlCommand cmd2 = new SqlCommand(qry2, con);
            SqlDataReader rdr2 = cmd2.ExecuteReader();
            try
            {
                while (rdr2.Read())
                {
                    Mascota.Items.Add(rdr2["nombre"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            con.Close();
        }

        public Asignar_Cuidador()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Voluntario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Asignar_Cuidador_Load(object sender, EventArgs e)
        {
            LoadComboBox();
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String voluntario = Voluntario.Text;
            String mascota = Mascota.Text;
            Form confirmacion = new Confirmar_asignación_de_cuidador(voluntario,mascota);
            confirmacion.Show();
            LoadComboBox();
        }
    }
}
