namespace WinFormsApp
{
    partial class FrmDepartamentos
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
            dataGridViewDepartamentos = new DataGridView();
            btnNuevo = new Button();
            btnEditar = new Button();
            lbtTituloModo = new Label();
            lblId = new Label();
            lblIdValue = new Label();
            panelDetalles = new Panel();
            txtProvinciaId = new TextBox();
            lblProvinciaId = new Label();
            chkActivo = new CheckBox();
            lblActivo = new Label();
            txtDepartamento = new TextBox();
            lblDepartamento = new Label();
            btnGrabar = new Button();
            btnCancelar = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDepartamentos).BeginInit();
            panelDetalles.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(38, 20);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(88, 15);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Departamentos";
            // 
            // dataGridViewDepartamentos
            // 
            dataGridViewDepartamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDepartamentos.Location = new Point(38, 38);
            dataGridViewDepartamentos.Name = "dataGridViewDepartamentos";
            dataGridViewDepartamentos.ReadOnly = true;
            dataGridViewDepartamentos.RowTemplate.Height = 25;
            dataGridViewDepartamentos.Size = new Size(459, 181);
            dataGridViewDepartamentos.TabIndex = 1;
            dataGridViewDepartamentos.CellClick += dataGridViewDepartamentos_CellClick;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(38, 225);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(122, 225);
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
            lbtTituloModo.Location = new Point(38, 264);
            lbtTituloModo.Name = "lbtTituloModo";
            lbtTituloModo.Size = new Size(18, 15);
            lbtTituloModo.TabIndex = 4;
            lbtTituloModo.Text = "ID";
            lbtTituloModo.Visible = false;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(3, 10);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 5;
            lblId.Text = "Id";
            lblId.Click += label3_Click;
            // 
            // lblIdValue
            // 
            lblIdValue.AutoSize = true;
            lblIdValue.Location = new Point(92, 10);
            lblIdValue.Name = "lblIdValue";
            lblIdValue.Size = new Size(48, 15);
            lblIdValue.TabIndex = 6;
            lblIdValue.Text = "id value";
            // 
            // panelDetalles
            // 
            panelDetalles.BorderStyle = BorderStyle.FixedSingle;
            panelDetalles.Controls.Add(txtProvinciaId);
            panelDetalles.Controls.Add(lblProvinciaId);
            panelDetalles.Controls.Add(chkActivo);
            panelDetalles.Controls.Add(lblActivo);
            panelDetalles.Controls.Add(txtDepartamento);
            panelDetalles.Controls.Add(lblDepartamento);
            panelDetalles.Controls.Add(lblId);
            panelDetalles.Controls.Add(lblIdValue);
            panelDetalles.Location = new Point(38, 282);
            panelDetalles.Name = "panelDetalles";
            panelDetalles.Size = new Size(244, 127);
            panelDetalles.TabIndex = 7;
            panelDetalles.Visible = false;
            // 
            // txtProvinciaId
            // 
            txtProvinciaId.Location = new Point(92, 65);
            txtProvinciaId.Name = "txtProvinciaId";
            txtProvinciaId.Size = new Size(100, 23);
            txtProvinciaId.TabIndex = 12;
            // 
            // lblProvinciaId
            // 
            lblProvinciaId.AutoSize = true;
            lblProvinciaId.Location = new Point(3, 68);
            lblProvinciaId.Name = "lblProvinciaId";
            lblProvinciaId.Size = new Size(70, 15);
            lblProvinciaId.TabIndex = 11;
            lblProvinciaId.Text = "Provincia ID";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(92, 95);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(15, 14);
            chkActivo.TabIndex = 10;
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // lblActivo
            // 
            lblActivo.AutoSize = true;
            lblActivo.Location = new Point(6, 94);
            lblActivo.Name = "lblActivo";
            lblActivo.Size = new Size(41, 15);
            lblActivo.TabIndex = 9;
            lblActivo.Text = "Activo";
            // 
            // txtDepartamento
            // 
            txtDepartamento.Location = new Point(92, 38);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(100, 23);
            txtDepartamento.TabIndex = 8;
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Location = new Point(3, 40);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(83, 15);
            lblDepartamento.TabIndex = 7;
            lblDepartamento.Text = "Departamento";
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(38, 415);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(75, 23);
            btnGrabar.TabIndex = 8;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Visible = false;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(122, 415);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrar.Location = new Point(700, 415);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 10;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmDepartamentos
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
            Controls.Add(dataGridViewDepartamentos);
            Controls.Add(labelTitulo);
            Name = "FrmDepartamentos";
            Text = "FrmDepartamentos";
            Load += FrmDepartamentos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDepartamentos).EndInit();
            panelDetalles.ResumeLayout(false);
            panelDetalles.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private DataGridView dataGridViewDepartamentos;
        private Button btnNuevo;
        private Button btnEditar;
        private Label lbtTituloModo;
        private Label lblId;
        private Label lblIdValue;
        private Panel panelDetalles;
        private Label lblDepartamento;
        private Label lblActivo;
        private TextBox txtDepartamento;
        private CheckBox chkActivo;
        private Button btnGrabar;
        private Button btnCancelar;
        private Button btnCerrar;
        private Label lblProvinciaId;
        private TextBox txtProvinciaId;
    }
}