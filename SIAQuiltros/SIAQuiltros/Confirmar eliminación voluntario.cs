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
    public partial class Confirmar_eliminación_voluntario : Form
    {
        SqlCommand delete;
        public Confirmar_eliminación_voluntario(SqlCommand cmd)
        {
            InitializeComponent();
            SqlCommand comando = cmd;
            delete = cmd;
        }

        private void no_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yes_Click(object sender, EventArgs e)
        {
            delete.ExecuteNonQuery();
        }
    }
}
