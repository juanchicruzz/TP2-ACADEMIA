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

        private void listaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios appUsuarios = new Usuarios();
            appUsuarios.Show();
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Especialidades appEspecialidades = new Especialidades();
            appEspecialidades.Show();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Usuarios appUsuarios = new Usuarios();
            appUsuarios.Show();
        }

        private void planesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Planes appPlanes = new Planes();
            appPlanes.Show();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materias appMaterias = new Materias();
            appMaterias.Show();
        }
    }
}
