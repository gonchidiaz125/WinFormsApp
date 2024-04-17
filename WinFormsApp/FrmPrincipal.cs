namespace WinFormsApp
{
	public partial class FrmPrincipal : Form
	{
		public FrmPrincipal()
		{
			InitializeComponent();
		}

		private void salirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		/// <summary>
		/// Abre el formulario de Provincias
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void provinciasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = new FrmProvincias();
			// Set the Parent Form of the Child window.
			form.MdiParent = this;
			// Display the new form.
			form.Show();
		}
	}
}