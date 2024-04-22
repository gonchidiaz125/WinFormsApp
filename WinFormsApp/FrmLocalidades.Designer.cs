namespace WinFormsApp
{
    partial class FrmLocalidades
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
            lblTitulo = new Label();
            dataGridViewLocalidades = new DataGridView();
            btnNuevo = new Button();
            btnEditar = new Button();
            lbtTituloModo = new Label();
            panelDetalles = new Panel();
            chkActivo = new CheckBox();
            lblActivo = new Label();
            lblDepartamentoId = new Label();
            txtDepartamentoId = new TextBox();
            txtLocalidad = new TextBox();
            lblLocalidad = new Label();
            lblIdValue = new Label();
            lblId = new Label();
            btnGrabar = new Button();
            btnCancelar = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLocalidades).BeginInit();
            panelDetalles.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(28, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(69, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Localidades";
            // 
            // dataGridViewLocalidades
            // 
            dataGridViewLocalidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLocalidades.Location = new Point(28, 27);
            dataGridViewLocalidades.MultiSelect = false;
            dataGridViewLocalidades.Name = "dataGridViewLocalidades";
            dataGridViewLocalidades.ReadOnly = true;
            dataGridViewLocalidades.RowTemplate.Height = 25;
            dataGridViewLocalidades.Size = new Size(436, 167);
            dataGridViewLocalidades.TabIndex = 1;
            dataGridViewLocalidades.CellClick += dataGridViewLocalidades_CellClick;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(28, 200);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(109, 200);
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
            lbtTituloModo.Location = new Point(28, 233);
            lbtTituloModo.Name = "lbtTituloModo";
            lbtTituloModo.Size = new Size(18, 15);
            lbtTituloModo.TabIndex = 4;
            lbtTituloModo.Text = "ID";
            lbtTituloModo.Visible = false;
            // 
            // panelDetalles
            // 
            panelDetalles.BorderStyle = BorderStyle.FixedSingle;
            panelDetalles.Controls.Add(chkActivo);
            panelDetalles.Controls.Add(lblActivo);
            panelDetalles.Controls.Add(lblDepartamentoId);
            panelDetalles.Controls.Add(txtDepartamentoId);
            panelDetalles.Controls.Add(txtLocalidad);
            panelDetalles.Controls.Add(lblLocalidad);
            panelDetalles.Controls.Add(lblIdValue);
            panelDetalles.Controls.Add(lblId);
            panelDetalles.Location = new Point(30, 251);
            panelDetalles.Name = "panelDetalles";
            panelDetalles.Size = new Size(283, 146);
            panelDetalles.TabIndex = 5;
            panelDetalles.Visible = false;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(114, 105);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(15, 14);
            chkActivo.TabIndex = 7;
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // lblActivo
            // 
            lblActivo.AutoSize = true;
            lblActivo.Location = new Point(6, 109);
            lblActivo.Name = "lblActivo";
            lblActivo.Size = new Size(41, 15);
            lblActivo.TabIndex = 6;
            lblActivo.Text = "Activo";
            // 
            // lblDepartamentoId
            // 
            lblDepartamentoId.AutoSize = true;
            lblDepartamentoId.Location = new Point(3, 77);
            lblDepartamentoId.Name = "lblDepartamentoId";
            lblDepartamentoId.Size = new Size(96, 15);
            lblDepartamentoId.TabIndex = 5;
            lblDepartamentoId.Text = "Departamento Id";
            // 
            // txtDepartamentoId
            // 
            txtDepartamentoId.Location = new Point(114, 69);
            txtDepartamentoId.Name = "txtDepartamentoId";
            txtDepartamentoId.Size = new Size(100, 23);
            txtDepartamentoId.TabIndex = 4;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(114, 35);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(100, 23);
            txtLocalidad.TabIndex = 3;
            // 
            // lblLocalidad
            // 
            lblLocalidad.AutoSize = true;
            lblLocalidad.Location = new Point(3, 43);
            lblLocalidad.Name = "lblLocalidad";
            lblLocalidad.Size = new Size(58, 15);
            lblLocalidad.TabIndex = 2;
            lblLocalidad.Text = "Localidad";
            // 
            // lblIdValue
            // 
            lblIdValue.AutoSize = true;
            lblIdValue.Location = new Point(114, 11);
            lblIdValue.Name = "lblIdValue";
            lblIdValue.Size = new Size(48, 15);
            lblIdValue.TabIndex = 1;
            lblIdValue.Text = "id value";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(3, 11);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(30, 403);
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
            btnCancelar.Location = new Point(111, 403);
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
            // FrmLocalidades
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
            Controls.Add(dataGridViewLocalidades);
            Controls.Add(lblTitulo);
            Name = "FrmLocalidades";
            Text = "ABMLocalidades";
            Load += FrmLocalidades_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLocalidades).EndInit();
            panelDetalles.ResumeLayout(false);
            panelDetalles.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private DataGridView dataGridViewLocalidades;
        private Button btnNuevo;
        private Button btnEditar;
        private Label lbtTituloModo;
        private Panel panelDetalles;
        private Label lblLocalidad;
        private Label lblIdValue;
        private Label lblId;
        private Button btnGrabar;
        private Button btnCancelar;
        private Button btnCerrar;
        private CheckBox chkActivo;
        private Label lblActivo;
        private Label lblDepartamentoId;
        private TextBox txtDepartamentoId;
        private TextBox txtLocalidad;
    }
}