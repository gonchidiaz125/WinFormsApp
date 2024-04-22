using Datos.Entities;
using Datos;

namespace WinFormsApp
{

    public partial class FrmProvincias2 : Form
    {

        private ProvinciaRepository provinciaRepository;

        private Modo modo = Modo.SinDefinir;
        private Provincia? provinciaSeleccionada;

        public FrmProvincias2()
        {
            InitializeComponent();
            provinciaRepository = new ProvinciaRepository();
        }

        private void labelIdValue_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewProvincias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si el clic fue en una celda válida y no en los encabezados de columna
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener la entidad asociada a la fila
                var provincia = dataGridViewProvincias.Rows[e.RowIndex].DataBoundItem as Provincia;

                // Ahora puedes usar selectedEntity para mostrar los detalles
                provinciaSeleccionada = provincia;
                mostrarProvincia(provincia);
                modo = Modo.Consulta;
            }

        }
        private void mostrarProvincia(Provincia provincia)
        {
            lbtTituloModo.Visible = true;
            lbtTituloModo.Text = "Detalles de la provincia seleccionada";
            lblIdValue.Text = provincia.Id.ToString();
            txtProvincia.Text = provincia.Nombre;
            chkActivo.Checked = provincia.Activo;
            panelDetalles.Visible = true;
            btnGrabar.Visible = false;
            btnCancelar.Visible = false;
            HabilitarCamposDeEdicion(false);
        }
        private void HabilitarCamposDeEdicion(bool habilitar)
        {
            txtProvincia.Enabled = habilitar;
            chkActivo.Enabled = habilitar;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            modo = Modo.Alta;
            lbtTituloModo.Visible = true;
            lbtTituloModo.Text = "Crear una nueva provincia";
            panelDetalles.Visible = true;

            lblIdValue.Text = "";
            txtProvincia.Text = "";
            chkActivo.Checked = true;
            panelDetalles.Visible = true;
            btnGrabar.Visible = true;
            btnCancelar.Visible = true;
            HabilitarCamposDeEdicion(true);
            provinciaSeleccionada = null;
            txtProvincia.Focus();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (provinciaSeleccionada != null)
            {
                mostrarProvincia(provinciaSeleccionada);
                lbtTituloModo.Visible = true;
                lbtTituloModo.Text = "Editando una provincia existente";
                modo = Modo.Edicion;
                HabilitarCamposDeEdicion(true);
                btnGrabar.Visible = true;
                btnCancelar.Visible = true;
            }
        }
        private void GrabarModificando()
        {
            if (provinciaSeleccionada == null)
            {
                return;
            }

            provinciaSeleccionada.Nombre = txtProvincia.Text;
            provinciaSeleccionada.Activo = chkActivo.Checked;

            var resultado = provinciaRepository.Update(provinciaSeleccionada);

            // Si resultado == true
            if (resultado)
            {
                MessageBox.Show("Provincia modificada con éxito");
                OcultarDetalles();
                CargarProvincias();
            }
            else
            {
                MessageBox.Show("Error al intentar modificar la provincia");
            }
        }
        private void OcultarDetalles()
        {
            lbtTituloModo.Visible = false;
            lbtTituloModo.Text = "";
            panelDetalles.Visible = false;
            btnGrabar.Visible = false;
            btnCancelar.Visible = false;
        }
        private void GrabarNueva()
        {
            var provincia = new Provincia();
            provincia.Nombre = txtProvincia.Text;
            provincia.Activo = chkActivo.Checked;
            var idProvincia = provinciaRepository.Insert(provincia);

            if (idProvincia != 0)
            {
                MessageBox.Show("Provincia creada con éxito");
                OcultarDetalles();
                CargarProvincias();
            }
            else
            {
                MessageBox.Show("Error al intentar grabar la provincia");
            }
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmProvincias2_Load(object sender, EventArgs e)
        {
            CargarProvincias();
        }

        private void CargarProvincias()
        {
            var provincias = provinciaRepository.Get();

            dataGridViewProvincias.DataSource = provincias;
        }

        private void panelDetalles_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            switch (modo)
            {
                case Modo.Edicion:
                    GrabarModificando();
                    break;
                case Modo.Alta:
                    GrabarNueva();
                    break;
                default:
                    throw new Exception($"Modo {modo} no soporta grabación");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lbtTituloModo.Visible = false;
            lbtTituloModo.Text = "";
            OcultarDetalles();
            modo = Modo.SinDefinir;

        }

        
    }
}
