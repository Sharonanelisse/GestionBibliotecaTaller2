namespace BibliotecaHerecia
{
    partial class NuevoMenu
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
            panelSideMenu = new Panel();
            panelPrestamo = new Panel();
            btnNuevoPrestamo = new Button();
            btnRealizarPrestamo = new Button();
            panelAdminLibros = new Panel();
            btnVerLibro = new Button();
            btnNuevoLibro = new Button();
            btnAdminLibros = new Button();
            panelAdminMiembros = new Panel();
            btnVerMiembro = new Button();
            btnNuevoMiembro = new Button();
            btnAdminMiembro = new Button();
            PanelLogo = new Panel();
            panelChildForm = new Panel();
            panelSideMenu.SuspendLayout();
            panelPrestamo.SuspendLayout();
            panelAdminLibros.SuspendLayout();
            panelAdminMiembros.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = Color.Black;
            panelSideMenu.Controls.Add(panelPrestamo);
            panelSideMenu.Controls.Add(btnRealizarPrestamo);
            panelSideMenu.Controls.Add(panelAdminLibros);
            panelSideMenu.Controls.Add(btnAdminLibros);
            panelSideMenu.Controls.Add(panelAdminMiembros);
            panelSideMenu.Controls.Add(btnAdminMiembro);
            panelSideMenu.Controls.Add(PanelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Margin = new Padding(2);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(180, 372);
            panelSideMenu.TabIndex = 0;
            // 
            // panelPrestamo
            // 
            panelPrestamo.BackColor = Color.FromArgb(35, 32, 39);
            panelPrestamo.Controls.Add(btnNuevoPrestamo);
            panelPrestamo.Dock = DockStyle.Top;
            panelPrestamo.Location = new Point(0, 271);
            panelPrestamo.Margin = new Padding(2);
            panelPrestamo.Name = "panelPrestamo";
            panelPrestamo.Size = new Size(180, 30);
            panelPrestamo.TabIndex = 6;
            // 
            // btnNuevoPrestamo
            // 
            btnNuevoPrestamo.Dock = DockStyle.Top;
            btnNuevoPrestamo.FlatAppearance.BorderSize = 0;
            btnNuevoPrestamo.FlatStyle = FlatStyle.Flat;
            btnNuevoPrestamo.ForeColor = Color.LightGray;
            btnNuevoPrestamo.Location = new Point(0, 0);
            btnNuevoPrestamo.Margin = new Padding(2);
            btnNuevoPrestamo.Name = "btnNuevoPrestamo";
            btnNuevoPrestamo.Padding = new Padding(20, 0, 0, 0);
            btnNuevoPrestamo.RightToLeft = RightToLeft.No;
            btnNuevoPrestamo.Size = new Size(180, 20);
            btnNuevoPrestamo.TabIndex = 0;
            btnNuevoPrestamo.Text = "Realizar Prestamo";
            btnNuevoPrestamo.TextAlign = ContentAlignment.MiddleLeft;
            btnNuevoPrestamo.UseVisualStyleBackColor = true;
            btnNuevoPrestamo.Click += btnNuevoPrestamo_Click;
            // 
            // btnRealizarPrestamo
            // 
            btnRealizarPrestamo.Dock = DockStyle.Top;
            btnRealizarPrestamo.FlatAppearance.BorderSize = 0;
            btnRealizarPrestamo.FlatStyle = FlatStyle.Flat;
            btnRealizarPrestamo.ForeColor = Color.Gainsboro;
            btnRealizarPrestamo.Location = new Point(0, 249);
            btnRealizarPrestamo.Margin = new Padding(2);
            btnRealizarPrestamo.Name = "btnRealizarPrestamo";
            btnRealizarPrestamo.Padding = new Padding(6, 0, 0, 0);
            btnRealizarPrestamo.Size = new Size(180, 22);
            btnRealizarPrestamo.TabIndex = 5;
            btnRealizarPrestamo.Text = "Préstamo";
            btnRealizarPrestamo.TextAlign = ContentAlignment.MiddleLeft;
            btnRealizarPrestamo.UseVisualStyleBackColor = true;
            btnRealizarPrestamo.Click += btnRealizarPrestamo_Click;
            // 
            // panelAdminLibros
            // 
            panelAdminLibros.BackColor = Color.FromArgb(35, 32, 39);
            panelAdminLibros.Controls.Add(btnVerLibro);
            panelAdminLibros.Controls.Add(btnNuevoLibro);
            panelAdminLibros.Dock = DockStyle.Top;
            panelAdminLibros.Location = new Point(0, 195);
            panelAdminLibros.Margin = new Padding(2);
            panelAdminLibros.Name = "panelAdminLibros";
            panelAdminLibros.Size = new Size(180, 54);
            panelAdminLibros.TabIndex = 4;
            // 
            // btnVerLibro
            // 
            btnVerLibro.Dock = DockStyle.Top;
            btnVerLibro.FlatAppearance.BorderSize = 0;
            btnVerLibro.FlatStyle = FlatStyle.Flat;
            btnVerLibro.ForeColor = Color.LightGray;
            btnVerLibro.Location = new Point(0, 20);
            btnVerLibro.Margin = new Padding(2);
            btnVerLibro.Name = "btnVerLibro";
            btnVerLibro.Padding = new Padding(20, 0, 0, 0);
            btnVerLibro.RightToLeft = RightToLeft.No;
            btnVerLibro.Size = new Size(180, 20);
            btnVerLibro.TabIndex = 2;
            btnVerLibro.Text = "Ver Libro";
            btnVerLibro.TextAlign = ContentAlignment.MiddleLeft;
            btnVerLibro.UseVisualStyleBackColor = true;
            btnVerLibro.Click += btnVerLibro_Click;
            // 
            // btnNuevoLibro
            // 
            btnNuevoLibro.Dock = DockStyle.Top;
            btnNuevoLibro.FlatAppearance.BorderSize = 0;
            btnNuevoLibro.FlatStyle = FlatStyle.Flat;
            btnNuevoLibro.ForeColor = Color.LightGray;
            btnNuevoLibro.Location = new Point(0, 0);
            btnNuevoLibro.Margin = new Padding(2);
            btnNuevoLibro.Name = "btnNuevoLibro";
            btnNuevoLibro.Padding = new Padding(20, 0, 0, 0);
            btnNuevoLibro.RightToLeft = RightToLeft.No;
            btnNuevoLibro.Size = new Size(180, 20);
            btnNuevoLibro.TabIndex = 1;
            btnNuevoLibro.Text = "Nuevo Libro";
            btnNuevoLibro.TextAlign = ContentAlignment.MiddleLeft;
            btnNuevoLibro.UseVisualStyleBackColor = true;
            btnNuevoLibro.Click += btnNuevoLibro_Click;
            // 
            // btnAdminLibros
            // 
            btnAdminLibros.Dock = DockStyle.Top;
            btnAdminLibros.FlatAppearance.BorderSize = 0;
            btnAdminLibros.FlatStyle = FlatStyle.Flat;
            btnAdminLibros.ForeColor = Color.Gainsboro;
            btnAdminLibros.Location = new Point(0, 173);
            btnAdminLibros.Margin = new Padding(2);
            btnAdminLibros.Name = "btnAdminLibros";
            btnAdminLibros.Padding = new Padding(6, 0, 0, 0);
            btnAdminLibros.Size = new Size(180, 22);
            btnAdminLibros.TabIndex = 3;
            btnAdminLibros.Text = "Administración de Libros";
            btnAdminLibros.TextAlign = ContentAlignment.MiddleLeft;
            btnAdminLibros.UseVisualStyleBackColor = true;
            btnAdminLibros.Click += btnAdminLibros_Click;
            // 
            // panelAdminMiembros
            // 
            panelAdminMiembros.BackColor = Color.FromArgb(35, 32, 39);
            panelAdminMiembros.Controls.Add(btnVerMiembro);
            panelAdminMiembros.Controls.Add(btnNuevoMiembro);
            panelAdminMiembros.Dock = DockStyle.Top;
            panelAdminMiembros.Location = new Point(0, 117);
            panelAdminMiembros.Margin = new Padding(2);
            panelAdminMiembros.Name = "panelAdminMiembros";
            panelAdminMiembros.Size = new Size(180, 56);
            panelAdminMiembros.TabIndex = 2;
            // 
            // btnVerMiembro
            // 
            btnVerMiembro.Dock = DockStyle.Top;
            btnVerMiembro.FlatAppearance.BorderSize = 0;
            btnVerMiembro.FlatStyle = FlatStyle.Flat;
            btnVerMiembro.ForeColor = Color.LightGray;
            btnVerMiembro.Location = new Point(0, 20);
            btnVerMiembro.Margin = new Padding(2);
            btnVerMiembro.Name = "btnVerMiembro";
            btnVerMiembro.Padding = new Padding(20, 0, 0, 0);
            btnVerMiembro.RightToLeft = RightToLeft.No;
            btnVerMiembro.Size = new Size(180, 20);
            btnVerMiembro.TabIndex = 2;
            btnVerMiembro.Text = "Ver Miembro";
            btnVerMiembro.TextAlign = ContentAlignment.MiddleLeft;
            btnVerMiembro.UseVisualStyleBackColor = true;
            btnVerMiembro.Click += btnVerMiembro_Click;
            // 
            // btnNuevoMiembro
            // 
            btnNuevoMiembro.Dock = DockStyle.Top;
            btnNuevoMiembro.FlatAppearance.BorderSize = 0;
            btnNuevoMiembro.FlatStyle = FlatStyle.Flat;
            btnNuevoMiembro.ForeColor = Color.LightGray;
            btnNuevoMiembro.Location = new Point(0, 0);
            btnNuevoMiembro.Margin = new Padding(2);
            btnNuevoMiembro.Name = "btnNuevoMiembro";
            btnNuevoMiembro.Padding = new Padding(20, 0, 0, 0);
            btnNuevoMiembro.RightToLeft = RightToLeft.No;
            btnNuevoMiembro.Size = new Size(180, 20);
            btnNuevoMiembro.TabIndex = 1;
            btnNuevoMiembro.Text = "Nuevo Miembro";
            btnNuevoMiembro.TextAlign = ContentAlignment.MiddleLeft;
            btnNuevoMiembro.UseVisualStyleBackColor = true;
            btnNuevoMiembro.Click += btnNuevoMiembro_Click;
            // 
            // btnAdminMiembro
            // 
            btnAdminMiembro.Dock = DockStyle.Top;
            btnAdminMiembro.FlatAppearance.BorderSize = 0;
            btnAdminMiembro.FlatStyle = FlatStyle.Flat;
            btnAdminMiembro.ForeColor = Color.Gainsboro;
            btnAdminMiembro.Location = new Point(0, 95);
            btnAdminMiembro.Margin = new Padding(2);
            btnAdminMiembro.Name = "btnAdminMiembro";
            btnAdminMiembro.Padding = new Padding(6, 0, 0, 0);
            btnAdminMiembro.Size = new Size(180, 22);
            btnAdminMiembro.TabIndex = 1;
            btnAdminMiembro.Text = "Administración de Miembros";
            btnAdminMiembro.TextAlign = ContentAlignment.MiddleLeft;
            btnAdminMiembro.UseVisualStyleBackColor = true;
            btnAdminMiembro.Click += btnAdminMiembro_Click;
            // 
            // PanelLogo
            // 
            PanelLogo.BackColor = SystemColors.ButtonHighlight;
            PanelLogo.BackgroundImage = Properties.Resources.Logotipo;
            PanelLogo.BackgroundImageLayout = ImageLayout.Stretch;
            PanelLogo.Dock = DockStyle.Top;
            PanelLogo.Location = new Point(0, 0);
            PanelLogo.Margin = new Padding(2);
            PanelLogo.Name = "PanelLogo";
            PanelLogo.Size = new Size(180, 95);
            PanelLogo.TabIndex = 0;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.White;
            panelChildForm.BackgroundImage = Properties.Resources.libros;
            panelChildForm.BackgroundImageLayout = ImageLayout.Zoom;
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(180, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(598, 372);
            panelChildForm.TabIndex = 1;
            // 
            // NuevoMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 372);
            Controls.Add(panelChildForm);
            Controls.Add(panelSideMenu);
            Margin = new Padding(2);
            Name = "NuevoMenu";
            Text = "Menu Principal";
            Load += NuevoMenu_Load;
            panelSideMenu.ResumeLayout(false);
            panelPrestamo.ResumeLayout(false);
            panelAdminLibros.ResumeLayout(false);
            panelAdminMiembros.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Button btnAdminMiembro;
        private Panel panelAdminMiembros;
        private Button btnVerMiembro;
        private Button btnNuevoMiembro;
        private Panel panelPrestamo;
        private Button btnNuevoPrestamo;
        private Button btnRealizarPrestamo;
        private Panel panelAdminLibros;
        private Button btnVerLibro;
        private Button btnNuevoLibro;
        private Button btnAdminLibros;
        private Panel panelChildForm;
        private Panel PanelLogo;
    }
}