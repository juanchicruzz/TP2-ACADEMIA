﻿using System;
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
        private void homeButton_Click(object sender, EventArgs e) 
        {
            if (activeForm != null)
                activeForm.Close();
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
            openChildForm(appEspecialidades);
        }

        private void usuariosMenuItem1_Click(object sender, EventArgs e)
        {
            Usuarios appUsuarios = new Usuarios();
            //appUsuarios.Show();
            this.openChildForm(appUsuarios);
        }

        private void planesMenuItem_Click(object sender, EventArgs e)
        {
            Planes appPlanes = new Planes();
            this.openChildForm(appPlanes);
        }

        private void materiasMenuItem_Click(object sender, EventArgs e)
        {
            Materias appMaterias = new Materias();
            openChildForm(appMaterias);
        }
        private void btnComisiones_Click(object sender, EventArgs e)
        {
            Comisiones appComisiones = new Comisiones();
            openChildForm(appComisiones);
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            Cursos appComisiones = new Cursos();
            openChildForm(appComisiones);
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
            Notas notas = new Notas();
            this.openChildForm(notas);
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMainForms.Controls.Add(childForm);
            panelMainForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAdminPersonas_Click(object sender, EventArgs e)
        {
            Personas appPersonas = new Personas();
            this.openChildForm(appPersonas);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlumnoInscripciones inscripciones = new AlumnoInscripciones();
            this.openChildForm(inscripciones);
        }
    }
}
