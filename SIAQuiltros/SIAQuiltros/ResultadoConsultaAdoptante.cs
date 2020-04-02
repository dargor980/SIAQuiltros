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
    public partial class ResultadoConsultaAdoptante : Form
    {
        public void ShowInfo(String data)
        {
            try
            {
                SqlConnection con = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
                con.Open();
                String qry = "SELECT *FROM ADOPTANTE WHERE nombre='" + data + "'";
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                if(rdr.Read())
                {
                    Rut.Text = rdr["rut"].ToString();
                    Name.Text = rdr["nombre"].ToString();
                    Address.Text = rdr["direccion"].ToString();
                    Phone.Text = rdr["telefono"].ToString();
                    Comuna.Text = rdr["comuna"].ToString();
                    con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        public ResultadoConsultaAdoptante(String data)
        {
            
            InitializeComponent();
            ShowInfo(data);
        }

        private void ResultadoConsultaAdoptante_Load(object sender, EventArgs e)
        {

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
