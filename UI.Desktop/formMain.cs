using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            panelSubABM.Visible = false;
            panelSubCalendario.Visible = false;
            panelSubExamenes.Visible = false;
            panelSubNotas.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelSubABM.Visible) panelSubABM.Visible = false;
            if (panelSubCalendario.Visible) panelSubCalendario.Visible = false;
            if (panelSubExamenes.Visible) panelSubExamenes.Visible = false;
            if (panelSubNotas.Visible) panelSubNotas.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }else subMenu.Visible = false;
        }
        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void formMain_Shown(object sender, EventArgs e)
        {
            formLogin appLogin = new formLogin();
            if (appLogin.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }
        }


        private void especialidadesMenuItem_Click(object sender, EventArgs e)
        {
            Especialidades appEspecialidades = new Especialidades();
            appEspecialidades.Show();
        }

        private void usuariosMenuItem1_Click(object sender, EventArgs e)
        {
            Usuarios appUsuarios = new Usuarios();
            appUsuarios.Show();
        }

        private void planesMenuItem_Click(object sender, EventArgs e)
        {
            Planes appPlanes = new Planes();
            appPlanes.Show();
        }

        private void materiasMenuItem_Click(object sender, EventArgs e)
        {
            Materias appMaterias = new Materias();
            appMaterias.Show();
        }

        private void ABM_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubABM);
        }

        private void btnCALENDARIO_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubCalendario);
        }

        private void btnEXAMENES_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubExamenes);
        }

        private void btnNOTAS_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubNotas);
        }
    }
}
