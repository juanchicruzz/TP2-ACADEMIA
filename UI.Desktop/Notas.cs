using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class Notas : Form
    {
        
        public Notas()
        {
            InitializeComponent();
            Visibilidad();
        }

        public void Visibilidad()
        {
            txtNota.Visible = false;
            dgvCursos.Visible = false;
            lbCurso.Visible = false;
            lbNota.Visible = false;
            txtNota.Visible = false;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
