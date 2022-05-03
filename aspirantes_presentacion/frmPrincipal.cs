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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void CatalogoAspirantes()
        {
            frmListaAspirantes lista = new frmListaAspirantes();
            lista.MdiParent = this;
            lista.Show();
        }

        private void CatalogoCarreras()
        {
            frmCarreras lista = new frmCarreras();
            lista.MdiParent = this;
            lista.Show();
        }

        private void CatalogoGeneros()
        {
            frmGenero lista = new frmGenero();
            lista.MdiParent = this;
            lista.Show();
        }


        private void catálogoDeAspirantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogoAspirantes();
        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogoCarreras();
        }

        private void génerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogoGeneros();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Está seguro de salir?", "Aspirantes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is frmBase)
            {
                ((frmBase)this.ActiveMdiChild).Nuevo();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is frmBase)
            {
                ((frmBase)this.ActiveMdiChild).Editar();
            }
        }
    }
}
