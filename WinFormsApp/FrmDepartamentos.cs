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
    public partial class FrmDepartamentos : Form
    {
        private DepartamentoRepository departamentoRepository;

        private Modo modo = Modo.SinDefinir;
        private Departamento? departamentoSelecionado;
        public FrmDepartamentos()
        {
            InitializeComponent();
            departamentoRepository = new DepartamentoRepository();
        }
        private void FrmDepartamentos_Load(object sender, EventArgs e)
        {
            CargarDepartamentos();
        }

        private void CargarDepartamentos()
        {
            var departamentos = departamentoRepository.Get();

            dataGridViewDepartamentos.DataSource = departamentos;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewDepartamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void mostrarDepartamento(Departamento departamento)
        {
            lbtTituloModo.Visible = true;
            lbtTituloModo.Text = "Detalles del departamento seleccionado";
            lblIdValue.Text = departamento.Id.ToString();
            txtDepartamento.Text = departamento.Nombre;
            txtProvinciaId.Text = departamento.IdProvincia.ToString();
            chkActivo.Checked = departamento.Activo;
            panelDetalles.Visible = true;
            btnGrabar.Visible = false;
            btnCancelar.Visible = false;
            HabilitarCamposDeEdicion(false);
        }
        private void HabilitarCamposDeEdicion(bool habilitar)
        {
            txtDepartamento.Enabled = habilitar;
            txtProvinciaId.Enabled = habilitar;
            chkActivo.Enabled = habilitar;
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            modo = Modo.Alta;
            lbtTituloModo.Visible = true;
            lbtTituloModo.Text = "Crear una nueva provincia";
            panelDetalles.Visible = true;

            lblIdValue.Text = "";
            txtDepartamento.Text = "";
            chkActivo.Checked = true;
            panelDetalles.Visible = true;
            btnGrabar.Visible = true;
            btnCancelar.Visible = true;
            HabilitarCamposDeEdicion(true);
            departamentoSelecionado = null;
            txtDepartamento.Focus();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (departamentoSelecionado != null)
            {
                mostrarDepartamento(departamentoSelecionado);
                lbtTituloModo.Visible = true;
                lbtTituloModo.Text = "Editando un departamento existente";
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



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lbtTituloModo.Visible = false;
            lbtTituloModo.Text = "";
            OcultarDetalles();
            modo = Modo.SinDefinir;

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
        private void GrabarNueva()
        {
            var provinciaIdString = txtProvinciaId.Text;

            if (int.TryParse(provinciaIdString, out var provinciaId))
            {
                var nuevoDepartamento = new Departamento();
                nuevoDepartamento.Nombre = txtDepartamento.Text;
                nuevoDepartamento.IdProvincia = provinciaId;
                nuevoDepartamento.Activo = chkActivo.Checked;

                var idDepartamento = departamentoRepository.Insert(nuevoDepartamento);

                // Si resultado == true
                if (idDepartamento > 0)
                {
                    MessageBox.Show("Departamento creado con éxito");
                    OcultarDetalles();
                    CargarDepartamentos();
                }
                else
                {
                    MessageBox.Show("Error al intentar crear el departamento");
                }
            }
            else
            {
                MessageBox.Show("El valor de Provincia ID debe ser numerico");
            }            
        }
        private void GrabarModificando()
        {
            if (departamentoSelecionado == null)
            {
                return;
            }

            var provinciaIdString = txtProvinciaId.Text; 

            if (int.TryParse(provinciaIdString, out var provinciaId))
            {
                departamentoSelecionado.Nombre = txtDepartamento.Text;
                departamentoSelecionado.IdProvincia = provinciaId;

                departamentoSelecionado.Activo = chkActivo.Checked;

                var resultado = departamentoRepository.Update(departamentoSelecionado);

                // Si resultado == true
                if (resultado)
                {
                    MessageBox.Show("Departamento modificado con éxito");
                    OcultarDetalles();
                    CargarDepartamentos();
                }
                else
                {
                    MessageBox.Show("Error al intentar modificar el departamento");
                }
            } 
            else
            {
                MessageBox.Show("El valor de Provincia ID debe ser numerico");
            }                       
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtProvinciaId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewDepartamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var departamento = dataGridViewDepartamentos.Rows[e.RowIndex].DataBoundItem as Departamento;

                departamentoSelecionado = departamento;
                mostrarDepartamento(departamento);
                modo = Modo.Consulta;
            }
        }
    }
}
