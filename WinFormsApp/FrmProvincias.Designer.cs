namespace WinFormsApp
{
	partial class FrmProvincias
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
            btnCerrar = new Button();
            lblTitulo = new Label();
            dataGridViewProvincias = new DataGridView();
            btnNuevo = new Button();
            btnGrabar = new Button();
            btnCancelar = new Button();
            lblId = new Label();
            txtProvincia = new TextBox();
            lblProvincia = new Label();
            lblActivo = new Label();
            chkActivo = new CheckBox();
            lblIdValue = new Label();
            btnEditar = new Button();
            lbtTituloModo = new Label();
            panelDetalles = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProvincias).BeginInit();
            panelDetalles.SuspendLayout();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrar.Location = new Point(713, 511);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(37, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(61, 15);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Provincias";
            // 
            // dataGridViewProvincias
            // 
            dataGridViewProvincias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProvincias.Location = new Point(37, 70);
            dataGridViewProvincias.MultiSelect = false;
            dataGridViewProvincias.Name = "dataGridViewProvincias";
            dataGridViewProvincias.ReadOnly = true;
            dataGridViewProvincias.RowTemplate.Height = 25;
            dataGridViewProvincias.Size = new Size(567, 227);
            dataGridViewProvincias.TabIndex = 2;
            dataGridViewProvincias.CellClick += dataGridViewProvincias_CellClick;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(37, 303);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(41, 504);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(75, 23);
            btnGrabar.TabIndex = 4;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Visible = false;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(129, 504);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(22, 12);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 6;
            lblId.Text = "ID";
            // 
            // txtProvincia
            // 
            txtProvincia.Location = new Point(84, 40);
            txtProvincia.Name = "txtProvincia";
            txtProvincia.Size = new Size(203, 23);
            txtProvincia.TabIndex = 7;
            // 
            // lblProvincia
            // 
            lblProvincia.AutoSize = true;
            lblProvincia.Location = new Point(22, 43);
            lblProvincia.Name = "lblProvincia";
            lblProvincia.Size = new Size(56, 15);
            lblProvincia.TabIndex = 8;
            lblProvincia.Text = "Provincia";
            // 
            // lblActivo
            // 
            lblActivo.AutoSize = true;
            lblActivo.Location = new Point(22, 77);
            lblActivo.Name = "lblActivo";
            lblActivo.Size = new Size(41, 15);
            lblActivo.TabIndex = 9;
            lblActivo.Text = "Activo";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(84, 76);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(15, 14);
            chkActivo.TabIndex = 10;
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // lblIdValue
            // 
            lblIdValue.AutoSize = true;
            lblIdValue.Location = new Point(84, 12);
            lblIdValue.Name = "lblIdValue";
            lblIdValue.Size = new Size(48, 15);
            lblIdValue.TabIndex = 11;
            lblIdValue.Text = "id value";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(129, 303);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // lbtTituloModo
            // 
            lbtTituloModo.AutoSize = true;
            lbtTituloModo.Location = new Point(44, 341);
            lbtTituloModo.Name = "lbtTituloModo";
            lbtTituloModo.Size = new Size(18, 15);
            lbtTituloModo.TabIndex = 13;
            lbtTituloModo.Text = "ID";
            lbtTituloModo.Visible = false;
            // 
            // panelDetalles
            // 
            panelDetalles.BorderStyle = BorderStyle.FixedSingle;
            panelDetalles.Controls.Add(txtProvincia);
            panelDetalles.Controls.Add(lblId);
            panelDetalles.Controls.Add(lblProvincia);
            panelDetalles.Controls.Add(lblIdValue);
            panelDetalles.Controls.Add(lblActivo);
            panelDetalles.Controls.Add(chkActivo);
            panelDetalles.Location = new Point(37, 368);
            panelDetalles.Name = "panelDetalles";
            panelDetalles.Size = new Size(312, 120);
            panelDetalles.TabIndex = 14;
            panelDetalles.Visible = false;
            // 
            // FrmProvincias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 546);
            Controls.Add(panelDetalles);
            Controls.Add(lbtTituloModo);
            Controls.Add(btnEditar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(btnNuevo);
            Controls.Add(dataGridViewProvincias);
            Controls.Add(lblTitulo);
            Controls.Add(btnCerrar);
            Name = "FrmProvincias";
            Text = "ABM de Provincias";
            Load += FrmProvincias_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProvincias).EndInit();
            panelDetalles.ResumeLayout(false);
            panelDetalles.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrar;
		private Label lblTitulo;
		private DataGridView dataGridViewProvincias;
		private Button btnNuevo;
		private Button btnGrabar;
		private Button btnCancelar;
		private Label lblId;
		private TextBox txtProvincia;
		private Label lblProvincia;
		private Label lblActivo;
		private CheckBox chkActivo;
		private Label lblIdValue;
		private Button btnEditar;
		private Label lbtTituloModo;
		private Panel panelDetalles;
	}
}