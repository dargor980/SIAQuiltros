using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIAQuiltros
{
    public partial class ConsultarVoluntario : Form
    {
        public ConsultarVoluntario()
        {
            InitializeComponent();
        }

        private void ConsultarVoluntario_Load(object sender, EventArgs e)
        {
            optionQuery.Items.Add("rut");
            optionQuery.Items.Add("Nombre");
            rut.Enabled = false;
            name.Enabled = false;
        }

        private void optionQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(optionQuery.SelectedItem.ToString()=="rut")
            {
                name.Enabled = false;
                rut.Enabled = true;
            }
            else
            {
                if(optionQuery.SelectedItem.ToString()=="Nombre")
                {
                    rut.Enabled = false;
                    name.Enabled = true;
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
