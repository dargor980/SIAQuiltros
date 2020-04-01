﻿using System;
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
    public partial class Confirmar_eliminación_voluntario : Form
    {
        SqlCommand delete;
        String cod_credencial;
        public Confirmar_eliminación_voluntario(SqlCommand cmd,String credencial)
        {
            InitializeComponent();
            SqlCommand comando = cmd;
            delete = cmd;
            cod_credencial = credencial;
        }

        public void DeleteCredential(String cod_credencial)
        {
            SqlConnection con = new SqlConnection("server=AMADEUS ; database=QUILTROS ; integrated security=True");
            con.Open();
            String qry = "DELETE FROM CREDENCIAL WHERE cod_credencial=" + cod_credencial;
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void no_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yes_Click(object sender, EventArgs e)
        {
            delete.ExecuteNonQuery();
            DeleteCredential(cod_credencial);
            MessageBox.Show("Datos borrados correctamente");
            this.Close();
        }
    }
}
