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
    public partial class ResultadoConsultaHogarTemporal : Form
    {
        public ResultadoConsultaHogarTemporal(SqlDataReader query)
        {
            SqlDataReader consulta = query;
            InitializeComponent();
            rut.Text = consulta["rut"].ToString();
            name.Text = consulta["nombre"].ToString();
            address.Text = consulta["direccion"].ToString();
            phone.Text = consulta["Telefono"].ToString();
            homeAddress.Text = consulta["direccion"].ToString();
            homeComuna.Text = consulta["comuna"].ToString();
            if(consulta["cod_mascota"].ToString()!="")
            {
                IsPetAssociated.Text = "Si";
            }
            else
            {
                IsPetAssociated.Text = "No";
            }
            InDate.Text = consulta["fecha_llegada"].ToString();
            OutDate.Text = consulta["fecha_salida"].ToString();
            
        }

        private void ResultadoConsultaHogarTemporal_Load(object sender, EventArgs e)
        {

        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
