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
    public partial class Confirmar_eliminación_voluntario : Form
    {
        public Confirmar_eliminación_voluntario()
        {
            InitializeComponent();
        }

        private void no_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
