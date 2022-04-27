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

        private void Buscar()
        {
            Cursor.Current = Cursors.WaitCursor;
            this.aspiranteBindingSource.DataSource =
                aspirantes_negocio.Aspirante_BO
                .getListaByFiltroAndCarrera(this.txtFiltro.Text,
                GetCarreraActual().carrera_id);
            Cursor.Current = Cursors.Arrow;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
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

        private void Nuevo()
        {
            frmAspiranteDetail detalle = new frmAspiranteDetail();
            if (detalle.ShowDialog() == DialogResult.OK)
            {
                Buscar();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void Editar()
        {
            Aspirante actual = (Aspirante)aspiranteBindingSource.Current;
            if (actual != null)
            {
                frmAspiranteDetail detalle = new frmAspiranteDetail(actual.aspirante_id);
                if (detalle.ShowDialog() == DialogResult.OK)
                {
                    Buscar();
                }
            }
            else
            {
                MessageBox.Show("Ningún registro fue seleccionado", "Aspirantes", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }
    }
}
