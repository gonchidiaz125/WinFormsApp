namespace WinFormsApp
{
	partial class FrmPrincipal
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			menuStrip1 = new MenuStrip();
			archivosToolStripMenuItem = new ToolStripMenuItem();
			provinciasToolStripMenuItem = new ToolStripMenuItem();
			departamentosToolStripMenuItem = new ToolStripMenuItem();
			localidadesToolStripMenuItem = new ToolStripMenuItem();
			toolStripMenuItem2 = new ToolStripSeparator();
			salirToolStripMenuItem = new ToolStripMenuItem();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { archivosToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1083, 24);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// archivosToolStripMenuItem
			// 
			archivosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { provinciasToolStripMenuItem, departamentosToolStripMenuItem, localidadesToolStripMenuItem, toolStripMenuItem2, salirToolStripMenuItem });
			archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
			archivosToolStripMenuItem.Size = new Size(65, 20);
			archivosToolStripMenuItem.Text = "Archivos";
			// 
			// provinciasToolStripMenuItem
			// 
			provinciasToolStripMenuItem.Name = "provinciasToolStripMenuItem";
			provinciasToolStripMenuItem.Size = new Size(155, 22);
			provinciasToolStripMenuItem.Text = "Provincias";
			provinciasToolStripMenuItem.Click += provinciasToolStripMenuItem_Click;
			// 
			// departamentosToolStripMenuItem
			// 
			departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
			departamentosToolStripMenuItem.Size = new Size(155, 22);
			departamentosToolStripMenuItem.Text = "Departamentos";
			// 
			// localidadesToolStripMenuItem
			// 
			localidadesToolStripMenuItem.Name = "localidadesToolStripMenuItem";
			localidadesToolStripMenuItem.Size = new Size(155, 22);
			localidadesToolStripMenuItem.Text = "Localidades";
			// 
			// toolStripMenuItem2
			// 
			toolStripMenuItem2.Name = "toolStripMenuItem2";
			toolStripMenuItem2.Size = new Size(152, 6);
			// 
			// salirToolStripMenuItem
			// 
			salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			salirToolStripMenuItem.Size = new Size(155, 22);
			salirToolStripMenuItem.Text = "Salir";
			salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
			// 
			// FrmPrincipal
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1083, 612);
			Controls.Add(menuStrip1);
			IsMdiContainer = true;
			MainMenuStrip = menuStrip1;
			Name = "FrmPrincipal";
			Text = "Aplicación de Demostración WinForms";
			WindowState = FormWindowState.Maximized;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem archivosToolStripMenuItem;
		private ToolStripMenuItem provinciasToolStripMenuItem;
		private ToolStripMenuItem departamentosToolStripMenuItem;
		private ToolStripMenuItem localidadesToolStripMenuItem;
		private ToolStripMenuItem salirToolStripMenuItem;
		private ToolStripSeparator toolStripMenuItem2;
	}
}