namespace WinFormsApp
{
    partial class FrmProvincias2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitulo = new Label();
            dataGridViewProvincias = new DataGridView();
            btnNuevo = new Button();
            btnEditar = new Button();
            lbtTituloModo = new Label();
            panelDetalles = new Panel();
            txtProvincia = new TextBox();
            chkActivo = new CheckBox();
            lblIdValue = new Label();
            lblActivo = new Label();
            lblProvincia = new Label();
            lblId = new Label();
            btnGrabar = new Button();
            btnCancelar = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProvincias).BeginInit();
            panelDetalles.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(78, 4);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(61, 15);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Provincias";
            // 
            // dataGridViewProvincias
            // 
            dataGridViewProvincias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProvincias.Location = new Point(78, 22);
            dataGridViewProvincias.Name = "dataGridViewProvincias";
            dataGridViewProvincias.ReadOnly = true;
            dataGridViewProvincias.RowTemplate.Height = 25;
            dataGridViewProvincias.Size = new Size(473, 178);
            dataGridViewProvincias.TabIndex = 1;
            dataGridViewProvincias.CellClick += dataGridViewProvincias_CellClick;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(78, 206);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(159, 206);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // lbtTituloModo
            // 
            lbtTituloModo.AutoSize = true;
            lbtTituloModo.Location = new Point(85, 240);
            lbtTituloModo.Name = "lbtTituloModo";
            lbtTituloModo.Size = new Size(17, 15);
            lbtTituloModo.TabIndex = 4;
            lbtTituloModo.Text = "Id";
            lbtTituloModo.Visible = false;
            // 
            // panelDetalles
            // 
            panelDetalles.BorderStyle = BorderStyle.FixedSingle;
            panelDetalles.Controls.Add(txtProvincia);
            panelDetalles.Controls.Add(chkActivo);
            panelDetalles.Controls.Add(lblIdValue);
            panelDetalles.Controls.Add(lblActivo);
            panelDetalles.Controls.Add(lblProvincia);
            panelDetalles.Controls.Add(lblId);
            panelDetalles.Location = new Point(78, 269);
            panelDetalles.Name = "panelDetalles";
            panelDetalles.Size = new Size(280, 103);
            panelDetalles.TabIndex = 5;
            panelDetalles.Visible = false;
            panelDetalles.Paint += panelDetalles_Paint;
            // 
            // txtProvincia
            // 
            txtProvincia.Location = new Point(84, 31);
            txtProvincia.Name = "txtProvincia";
            txtProvincia.Size = new Size(100, 23);
            txtProvincia.TabIndex = 5;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(84, 75);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(15, 14);
            chkActivo.TabIndex = 4;
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // lblIdValue
            // 
            lblIdValue.AutoSize = true;
            lblIdValue.Location = new Point(84, 7);
            lblIdValue.Name = "lblIdValue";
            lblIdValue.Size = new Size(48, 15);
            lblIdValue.TabIndex = 3;
            lblIdValue.Text = "id value";
            lblIdValue.Click += labelIdValue_Click;
            // 
            // lblActivo
            // 
            lblActivo.AutoSize = true;
            lblActivo.Location = new Point(7, 74);
            lblActivo.Name = "lblActivo";
            lblActivo.Size = new Size(41, 15);
            lblActivo.TabIndex = 2;
            lblActivo.Text = "Activo";
            lblActivo.Click += label5_Click;
            // 
            // lblProvincia
            // 
            lblProvincia.AutoSize = true;
            lblProvincia.Location = new Point(5, 39);
            lblProvincia.Name = "lblProvincia";
            lblProvincia.Size = new Size(56, 15);
            lblProvincia.TabIndex = 1;
            lblProvincia.Text = "Provincia";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(7, 7);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(78, 378);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(75, 23);
            btnGrabar.TabIndex = 6;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Visible = false;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(159, 378);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(713, 415);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 8;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmProvincias2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(panelDetalles);
            Controls.Add(lbtTituloModo);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(dataGridViewProvincias);
            Controls.Add(labelTitulo);
            Name = "FrmProvincias2";
            Text = "FmrProvincias2";
            Load += FrmProvincias2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProvincias).EndInit();
            panelDetalles.ResumeLayout(false);
            panelDetalles.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private DataGridView dataGridViewProvincias;
        private Button btnNuevo;
        private Button btnEditar;
        private Label lbtTituloModo;
        private Panel panelDetalles;
        private Label lblActivo;
        private Label lblProvincia;
        private Label lblId;
        private TextBox txtProvincia;
        private CheckBox chkActivo;
        private Label lblIdValue;
        private Button btnGrabar;
        private Button btnCancelar;
        private Button btnCerrar;
    }
}