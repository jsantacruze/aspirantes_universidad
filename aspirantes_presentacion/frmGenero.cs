using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using aspirantes_negocio;

namespace aspirantes_presentacion
{
    public partial class frmGenero : Form
    {
        private void CargarDatos()
        {
            generoBindingSource.DataSource = Genero_BO.getList();
        }
        public frmGenero()
        {
            InitializeComponent();
        }

        private void frmGenero_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
