using Datos;
using Datos.Entities;


namespace WinFormsApp
{

	public enum Modo
	{
		Alta,
		Edicion,
		Consulta,
		SinDefinir
	}

	public partial class FrmProvincias : Form
	{
		private ProvinciaRepository provinciaRepository;

		private Modo modo = Modo.SinDefinir;
		private Provincia? provinciaSeleccionada;

		public FrmProvincias()
		{
			InitializeComponent();
			provinciaRepository = new ProvinciaRepository();
		}

		/// <summary>
		/// Se ejecuta ni bien se abre/carga el formulario
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FrmProvincias_Load(object sender, EventArgs e)
		{
			CargarProvincias();
		}

		/// <summary>
		/// Muestra la lista de provincias en la grilla
		/// </summary>
		private void CargarProvincias()
		{
			var provincias = provinciaRepository.Get();


			dataGridViewProvincias.DataSource = provincias;
		}

		/// <summary>
		/// Cierra el formulario
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnCerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// Cuando se hace click en una celda de la grilla, se muestran los detalles de la provincia correspondiente a la fila
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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

		/// <summary>
		/// Mostrar el planel de detalle con los datos de una provincia (con campos no editables)
		/// </summary>
		/// <param name="provincia"></param>
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

		/// <summary>
		/// Permite habilitar/deshabilitar los campos de edición
		/// </summary>
		/// <param name="habilitar"></param>
		private void HabilitarCamposDeEdicion(bool habilitar)
		{
			txtProvincia.Enabled = habilitar;
			chkActivo.Enabled = habilitar;
		}

		/// <summary>
		/// Edita la provincia seleccionada
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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

		/// <summary>
		/// Oculota el panel de detalle y los botones grabar y cerrar
		/// </summary>
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

		/// <summary>
		/// Graba una provincia pre-existente (update)
		/// </summary>
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

		/// <summary>
		/// /// Graba una provincia nueva en la BD (insert)
		/// </summary>
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

		/// <summary>
		/// Cancela la edición/creación de una provincia ocultando el panel
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnCancelar_Click(object sender, EventArgs e)
		{
			lbtTituloModo.Visible = false;
			lbtTituloModo.Text = "";
			OcultarDetalles();
			modo = Modo.SinDefinir;
		}

		/// <summary>
		/// Inicia el modo "Alta" para habilitar los controles para poder crear una nueva provincia
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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
	}
}
