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
using System.IO;

namespace SIAQuiltros
{
    public partial class FichaMascota : Form
    {
        SqlDataReader datos;
        String cod_mascota;

        public void LoadImage()
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
                conexion.Open();
                String qry = "SELECT imagen FROM MASCOTA WHERE cod_chip='" + cod_mascota + "'";
                SqlCommand cmd = new SqlCommand(qry, conexion);
                SqlDataReader rdr = cmd.ExecuteReader();
                Image newImage = null;
                if (rdr.Read())
                {
                    byte[] imgData = (byte[])rdr.GetValue(0);

                    using (MemoryStream ms = new MemoryStream(imgData, 0, imgData.Length))
                    {
                        ms.Write(imgData, 0, imgData.Length);
                        newImage = Image.FromStream(ms, true);
                    }
                    ImgMascota.Image = newImage;
                    newImage = null;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }
        public void ShowAntecedentesMascota(SqlDataReader rdr)
        {   
                PetName.Text = rdr["nombre"].ToString();
                Cod_chip.Text = rdr["cod_chip"].ToString();
                Age.Text = rdr["edad"].ToString();
                Specie.Text = rdr["especie"].ToString();
                Tamaño.Text = rdr["tamaño"].ToString();
                Color.Text = rdr["color"].ToString();
                Descripción.Text = rdr["descripcion"].ToString();
                Status.Text = rdr["estado"].ToString();
                cod_mascota= rdr["cod_chip"].ToString();
        }

        public void ShowInfoAdoptante(String cod_mascota)
        {
            SqlConnection con = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
            con.Open();
            String qry = "SELECT a.rut,a.nombre,a.direccion,a.telefono,a.comuna FROM ADOPTANTE a, MASCOTA m WHERE m.cod_adoptante=a.rut AND m.cod_chip='" + cod_mascota + "'";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if(rdr.Read())
            {
                Rut.Text = rdr["rut"].ToString();
                NombreAdoptante.Text = rdr["nombre"].ToString();
                DireccionAdoptante.Text = rdr["direccion"].ToString();
                Telefono.Text = rdr["telefono"].ToString();
                Comuna.Text = rdr["comuna"].ToString();
                con.Close();
            }


        }
        public void ShowinfoHogar(String cod_mascota)
        {
            SqlConnection con = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
            con.Open();
            String qry = "SELECT s.nombre, h.direccion, h.comuna, h.fecha_llegada, h.fecha_salida FROM SOCIO s, HOGAR_TEMPORAL h WHERE s.rut=h.cod_socio AND h.cod_mascota='"+cod_mascota+"'";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if(rdr.Read())
            {
                DueñoHogar.Text = rdr["nombre"].ToString();
                DireccionHogar.Text = rdr["direccion"].ToString();
                ComunaHogar.Text = rdr["comuna"].ToString();
                FechaLLegada.Text = rdr["fecha_llegada"].ToString();
                FechaSalida.Text = rdr["fecha_salida"].ToString();
                con.Close();
            }
        }
        public FichaMascota(SqlDataReader Data)
        {
            datos = Data;
            InitializeComponent();
            ShowAntecedentesMascota(datos);
            ShowInfoAdoptante(cod_mascota);
            ShowinfoHogar(cod_mascota);
            ShowInfoAdoptante(cod_mascota);
            LoadImage();
        }
            private void groupBox1_Enter(object sender, EventArgs e)
            {

            }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FichaMascota_Load(object sender, EventArgs e)
        {

        }
    }
}
