using Business.Entities;
using Business.Logic;
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
    public partial class Cursos : ApplicationForm
    {

        public Cursos()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            CursoLogic cl = new CursoLogic();
            ComisionLogic Coml = new ComisionLogic();
            MateriaLogic ml = new MateriaLogic();
            try
            {
                List<Curso> cursos = cl.GetAll();
                List<Comision> comisiones = Coml.GetAll();
                List<Materia> materias = ml.GetAll();
                var query = from c in cursos
                            join cm in comisiones
                            on c.IDComision equals cm.ID
                            join ma in materias
                            on c.IDMateria equals ma.ID
                            select new
                            {
                                ID = c.ID,
                                Descripcion = c.Descripcion,
                                Cupo = c.Cupo,
                                AnioCalendario = c.AnioCalendario,
                                Comision = cm.Descripcion,
                                Materia = ma.Descripcion
                            };
                dgvComisones.DataSource = query.ToList();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
               new Exception("Error al recuperar lista de Cursos", Ex);
                MessageBox.Show("Error al recuperar lista de Cursos", "Cursos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ExcepcionManejada;
            }

        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

    }
}
