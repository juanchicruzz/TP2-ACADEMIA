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
        private Form _activeForm = null;

        public Cursos()
        {
            InitializeComponent();
        }

        public void openChildForm(Form childForm)
        {
            if (_activeForm != null)
                _activeForm.Close();
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelAdd.Controls.Add(childForm);
            panelAdd.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
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
                                AnioCalendario = c.AnioCalendario,
                                Comision = cm.Descripcion,
                                Materia = ma.Descripcion,
                                Cupo = c.Cupo
                            };
                dgvCursos.DataSource = query.ToList();
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CursoDesktop formCurso = new CursoDesktop(ApplicationForm.ModoForm.Alta);
            openChildForm(formCurso);
            this.Listar();
        }

        private void panelAdd_ControlRemoved(object sender, ControlEventArgs e)
        {
            Listar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        { 
                if (this.dgvCursos.SelectedRows.Count > 0)
                {
                    int ID = Convert.ToInt32(this.dgvCursos.SelectedRows[0].Cells["ID"].Value);
                    CursoDesktop formCurso = new CursoDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                    openChildForm(formCurso);
                    this.Listar();
                }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvCursos.SelectedRows.Count > 0)
            {
                int ID = Convert.ToInt32(this.dgvCursos.SelectedRows[0].Cells["ID"].Value);
                CursoDesktop formCurso = new CursoDesktop(ID, ApplicationForm.ModoForm.Baja);
                openChildForm(formCurso);
                this.Listar();
            }
        }
    }
}
