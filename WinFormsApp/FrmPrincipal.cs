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

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void provincias2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FrmProvincias2();
            // Set the Parent Form of the Child window.
            form.MdiParent = this;
            // Display the new form.
            form.Show();

        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var form = new FrmDepartamentos();
            // Set the Parent Form of the Child window.
            form.MdiParent = this;
            // Display the new form.
            form.Show();
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FrmLocalidades();
            // Set the Parent Form of the Child window.
            form.MdiParent = this;
            // Display the new form.
            form.Show();

        }
    }
}