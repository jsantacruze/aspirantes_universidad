using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using aspirante_datos;
using aspirantes_negocio;

namespace aspirantes_presentacion
{
    public partial class frmAspiranteDetail : Form
    {
        private long _id_aspirante;
        private bool _is_nuevo = false;
        private Aspirante _registro_actual;
        /// <summary>
        /// NUEVO REGISTRO
        /// </summary>
        public frmAspiranteDetail()
        {
            InitializeComponent();
            CargarClasificadores();

            _is_nuevo = true;
            Nuevo();
        }

        private void Nuevo()
        { 
            _registro_actual = new Aspirante();
            _registro_actual.aspirante_apellidos = "";
            _registro_actual.aspirante_nombres = "";
            _registro_actual.aspirante_email = "";
            _registro_actual.aspirante_cedula = "";
            _registro_actual.aspirante_movil = "";
            _registro_actual.aspirante_direccion = "";
            _registro_actual.aspirante_fecha_registro = DateTime.Now;
            _registro_actual.aspirante_user_id = "dad85f2d-af85-4cf3-ac96-7aa3fbf42825";

            aspiranteBindingSource.DataSource = _registro_actual;
            //    .Add(_registro_actual);
            //aspiranteBindingSource.MoveLast();
        }

        private void CargarAspirante()
        {
            _registro_actual = Aspirante_BO.getById(_id_aspirante);
            aspiranteBindingSource.DataSource = _registro_actual;
        }

        /// <summary>
        /// EDITAR REGISTRO
        /// </summary>
        /// <param name="id_aspirante"></param>
        public frmAspiranteDetail(long id_aspirante)
        {
            InitializeComponent();
            CargarClasificadores();

            this._id_aspirante = id_aspirante;
            _is_nuevo = false;
            CargarAspirante();
        }

        private void CargarClasificadores()
        {
            carreraBindingSource.DataSource = Carrera_BO.getListByFiltro("");
            generoBindingSource.DataSource = Genero_BO.getList();
        }

        private void frmAspiranteDetail_Load(object sender, EventArgs e)
        {
        }

        private void AddOrUpdate()
        {
            int result = Aspirante_BO.AddOrUpdate
                ((Aspirante)aspiranteBindingSource.Current);
            if (result > 0)
            {
                MessageBox.Show("Datos almacenados");
            }
        }

        private void frmAspiranteDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                AddOrUpdate();
            }
        }
    }
}
