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
    public partial class Confirmar_asignación_de_cuidador : Form
    {
        String name;
        String pet;
        public Confirmar_asignación_de_cuidador(String voluntario, String mascota)
        {
            InitializeComponent();
            label1.Text = "¿Está seguro de querer asignar el cuidado de " + mascota + " al voluntario " + voluntario + "?";
            name = voluntario;
            pet = mascota;
        }

        private void Confirmar_asignación_de_cuidador_Load(object sender, EventArgs e)
        {
           
        }

        private void No_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
                con.Open();
                String qry = "INSERT INTO CUIDA(cod_voluntario,cod_mascota) VALUES((SELECT rut FROM VOLUNTARIO WHERE nombre= '" + name + "'),(SELECT cod_chip FROM MASCOTA WHERE nombre='" + pet + "'))";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            MessageBox.Show("La aignación ha sido realizada exitosamente.");
            this.Close();
            

        }
    }
}
