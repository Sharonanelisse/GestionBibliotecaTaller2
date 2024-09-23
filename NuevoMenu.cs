using BibliotecaHerecia.Clases;
using BibliotecaHerecia.Libros;
using BibliotecaHerecia.Miembros;
using BibliotecaHerecia.Prestamos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaHerecia
{
    public partial class NuevoMenu : Form
    {
        public NuevoMenu()
        {
            InitializeComponent();
            customizedDesing();
        }

        private void customizedDesing()
        {
            panelAdminLibros.Visible = false;
            panelAdminMiembros.Visible = false;
            panelPrestamo.Visible = false;
        }

        private void hidePanelMenu()
        {
            if (panelAdminLibros.Visible == true)
            { panelAdminMiembros.Visible = false; }
            if (panelAdminMiembros.Visible == true)
            { panelAdminMiembros.Visible = false; }
            if (panelPrestamo.Visible == true)
            { panelPrestamo.Visible = false; }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hidePanelMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void NuevoMenu_Load(object sender, EventArgs e)
        {

        }


        private void btnAdminMiembro_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAdminMiembros);
        }
        private void btnAdminLibros_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAdminLibros);
        }
        private void btnRealizarPrestamo_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPrestamo);
        }


        private void btnVerMiembro_Click(object sender, EventArgs e)
        {
            openChildForm(new VerMiembros());
            Form verMiembrosForm = new VerMiembros();
            //verMiembrosForm.Show();
            hidePanelMenu();
        }
        private void btnNuevoMiembro_Click(object sender, EventArgs e)
        {
            openChildForm(new NuevoMiembro());
            Form NuevoMiembroForm = new NuevoMiembro();
            //NuevoMiembroForm.Show();
            hidePanelMenu();
        }


        private void btnVerLibro_Click(object sender, EventArgs e)
        {
            openChildForm(new VerLibros());
            Form verLibrosForm = new VerLibros();
            //verLibrosForm.Show();
            hidePanelMenu();
        }
        private void btnNuevoLibro_Click(object sender, EventArgs e)
        {
            openChildForm(new NuevoLibro());
            Form NuevoLibroForm = new NuevoLibro();
            //NuevoLibroForm.Show();
            hidePanelMenu();
        }


        private void btnNuevoPrestamo_Click(object sender, EventArgs e)
        {
            openChildForm(new RealizarPrestamo());
            Form realizarPrestamoForm = new RealizarPrestamo();
            //realizarPrestamoForm.Show();
            hidePanelMenu();
        }

        private Form? activeForm = null;

        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.AutoSize = true;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
