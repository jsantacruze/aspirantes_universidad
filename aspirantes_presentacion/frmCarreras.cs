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
    public partial class frmCarreras : frmBase
    {
        public frmCarreras()
        {
            InitializeComponent();
        }

        private void frmCarreras_Load(object sender, EventArgs e)
        {
            carreraBindingSource.DataSource =
                aspirantes_negocio.Carrera_BO.getListByFiltro("");
        }

        public override void Nuevo()
        {
            MessageBox.Show("Ud está intentando crear una nueva carrera");
        }
    }
}
