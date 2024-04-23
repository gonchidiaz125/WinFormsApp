using Datos;
using Datos.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FrmLocalidades : Form
    {
        private LocalidadRepository localidadRepository;
        private Modo modo = Modo.SinDefinir;
        private Localidad? localidadSeleccionada;
        public FrmLocalidades()
        {
            InitializeComponent();
            localidadRepository = new LocalidadRepository();
        }
        private void FrmLocalidades_Load(object sender, EventArgs e)
        {
            CargarLocalidades();
        }
        private void CargarLocalidades()
        {
            var localidades = localidadRepository.Get();

            dataGridViewLocalidades.DataSource = localidades;
        }
        private void dataGridViewLocalidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener la entidad asociada a la fila
                var localidad = dataGridViewLocalidades.Rows[e.RowIndex].DataBoundItem as Localidad;

                // Ahora puedes usar selectedEntity para mostrar los detalles
                localidadSeleccionada = localidad;
                mostrarLocalidad(localidad);
                modo = Modo.Consulta;
            }

        }

        private void mostrarLocalidad(Localidad localidad)
        {
            lbtTituloModo.Visible = true;
            lbtTituloModo.Text = "Detalles de la localidad seleccionada";
            lblIdValue.Text = localidad.Id.ToString();
            txtLocalidad.Text = localidad.Nombre;
            txtDepartamentoId.Text = localidad.IdDepartamento.ToString();
            chkActivo.Checked = localidad.Activo;
            panelDetalles.Visible = true;
            btnGrabar.Visible = false;
            btnCancelar.Visible = false;
            HabilitarCamposDeEdicion(false);
        }
        private void HabilitarCamposDeEdicion(bool habilitar)
        {
            txtLocalidad.Enabled = habilitar;
            txtDepartamentoId.Enabled = habilitar;
            chkActivo.Enabled = habilitar;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            modo = Modo.Alta;
            lbtTituloModo.Visible = true;
            lbtTituloModo.Text = "Crear una nueva localidad";
            panelDetalles.Visible = true;

            lblIdValue.Text = "";
            txtLocalidad.Text = "";
            chkActivo.Checked = true;
            panelDetalles.Visible = true;
            btnGrabar.Visible = true;
            btnCancelar.Visible = true;
            HabilitarCamposDeEdicion(true);
            localidadSeleccionada = null;
            txtLocalidad.Focus();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (localidadSeleccionada != null)
            {
                mostrarLocalidad(localidadSeleccionada);
                lbtTituloModo.Visible = true;
                lbtTituloModo.Text = "Editando una localidad existente";
                modo = Modo.Edicion;
                HabilitarCamposDeEdicion(true);
                btnGrabar.Visible = true;
                btnCancelar.Visible = true;
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
        private void GrabarModificando()
        {
            if (localidadSeleccionada == null)
            {
                return;
            }
            var departamentoIdString = txtDepartamentoId.Text;

            if (int.TryParse(departamentoIdString, out var departamentoId))
            {
                localidadSeleccionada.Nombre = txtLocalidad.Text;
                localidadSeleccionada.IdDepartamento = departamentoId;

                localidadSeleccionada.Activo = chkActivo.Checked;

                var resultado = localidadRepository.Update(localidadSeleccionada);

                // Si resultado == true
                if (resultado)
                {
                    MessageBox.Show("Localidad modificada con éxito");
                    OcultarDetalles();
                    CargarLocalidades();
                }
                else
                {
                    MessageBox.Show("Error al intentar modificar la localidad");
                }
            }
            else
            {
                MessageBox.Show("El valor de departamento ID debe ser numerico");
            }
        }
        private void GrabarNueva()
        {
            var departamentoIdString = txtDepartamentoId.Text;
            if (int.TryParse(departamentoIdString, out var departamentoId))
            {
                var localidad = new Localidad();
                localidad.Nombre = txtLocalidad.Text;
                localidad.IdDepartamento = departamentoId;
                localidad.Activo = chkActivo.Checked;
                var idLocalidad = localidadRepository.Insert(localidad);

                if (idLocalidad > 0)
                {
                    MessageBox.Show("Localidad creada con éxito");
                    OcultarDetalles();
                    CargarLocalidades();
                }
                else
                {
                    MessageBox.Show("Error al intentar grabar la localidad");
                }
            }
            else
            {
                MessageBox.Show("El valor de Departamento ID debe ser numerico");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lbtTituloModo.Visible = false;
            lbtTituloModo.Text = "";
            OcultarDetalles();
            modo = Modo.SinDefinir;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
