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
using aspirante_datos;

namespace aspirantes_presentacion
{
    public partial class frmListaAspirantes : Form
    {
        public frmListaAspirantes()
        {
            InitializeComponent();
        }

        private void CargarCarreras()
        {
            carreraBindingSource.DataSource =
               Carrera_BO.getListByFiltro(""); 
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.aspiranteBindingSource.DataSource =
                aspirantes_negocio.Aspirante_BO
                .getListaByFiltroAndCarrera(this.txtFiltro.Text, 
                GetCarreraActual().carrera_id);
            Cursor.Current = Cursors.Arrow;
        }

        private Carrera GetCarreraActual()
        {
            return (Carrera)carreraBindingSource.Current;
        }

        private void frmListaAspirantes_Load(object sender, EventArgs e)
        {
            CargarCarreras();
        }

        private void carreraComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Carrera Actual:" + GetCarreraActual().carrera_nombre);
        }
    }
}
