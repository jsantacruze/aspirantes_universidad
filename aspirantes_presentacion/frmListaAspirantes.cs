using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aspirantes_presentacion
{
    public partial class frmListaAspirantes : Form
    {
        public frmListaAspirantes()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.aspiranteBindingSource.DataSource =
                aspirantes_negocio.Aspirante_BO.getListaByFiltro(this.txtFiltro.Text);
        }
    }
}
