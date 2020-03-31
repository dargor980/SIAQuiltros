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

using PdfSharp.Pdf;


namespace SIAQuiltros
{
    public partial class Ingresar_voluntario : Form
    {
        public Ingresar_voluntario()
        {
            InitializeComponent();
        }

        public void resetBox()
        {
            name.Text = "";
            rut.Text = "";
            phone.Text = "";
            address.Text = "";
            email.Text = "";
            user.Text = "";
            password.Text = "";
            confirmPassword.Text = "";
        }
         
        public bool IsNotNull()
        {
            if(name.Text!="" && rut.Text!="" &&phone.Text!="" && address.Text!="" && email.Text!="" && user.Text!= "" && password.Text !="" && confirmPassword.Text!= "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsPassNotNull()
        {
            if(password.Text!="" && confirmPassword.Text!="")
            { return true; }
            else
            { return false; };
        }
        private void Insert_Click(object sender, EventArgs e)
        {
            Insert.Enabled = false;
            SqlConnection conexion = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
            conexion.Open();
            String nombre = name.Text;
            String RUT = rut.Text;
            String telefono= phone.Text;
            String direecion = address.Text;
            String correo = email.Text;
            String usuario = user.Text;
            String pass = password.Text;
            String confirmPass = confirmPassword.Text;
            String cadenaCredencial = "insert into CREDENCIAL (usuario,contraseña) values('" + usuario + "','" + pass + "')";
            SqlCommand comandoCredencial = new SqlCommand(cadenaCredencial, conexion);
            String KEYUSER = "Select cod_credencial from CREDENCIAL where usuario='" + usuario + "'";
            String FK;
            String cadenaVoluntario;
            if(pass==confirmPass && IsPassNotNull())
            {
                comandoCredencial.ExecuteNonQuery();
                SqlCommand comandoKey = new SqlCommand(KEYUSER, conexion);
                SqlDataReader read_Key = comandoKey.ExecuteReader();
                if(read_Key.Read() && IsNotNull())
                {
                    FK = read_Key["cod_credencial"].ToString();
                    cadenaVoluntario = "insert into VOLUNTARIO(rut,cod_credencial,nombre,telefono,direccion,correo) values('" + RUT + "'," + FK + ",'" + nombre + "','" + telefono + "','" + direecion + "','" + correo + "')";
                    conexion.Close();
                    conexion.Open();
                    SqlCommand comandoVoluntario = new SqlCommand(cadenaVoluntario, conexion);
                    comandoVoluntario.ExecuteNonQuery();
                    MessageBox.Show("Datos ingresados correctamente.");
                    Insert.Enabled = true;
                    resetBox();

                }

            }
            else
            {
                if(!IsNotNull() && !IsPassNotNull())
                {
                    MessageBox.Show("Campos vacíos. Verifique que haya ingresado todos los datos.");
                }
                else
                {
                    if(IsNotNull()&& IsPassNotNull())
                    {
                        MessageBox.Show("Las contraseñas no coinciden. Verifique que haya ingresado correctamente");
                        password.Text = "";
                        confirmPassword.Text = "";
                    }
                }
                
                Insert.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ingresar_voluntario_Load(object sender, EventArgs e)
        {

        }
    }
}
