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
    public partial class Planes : Form
    {
        public Planes()
        {
            InitializeComponent();
        }

        public void Listar()
        {
            PlanLogic pl = new PlanLogic();
            EspecialidadLogic el = new EspecialidadLogic();
            try
            {
                List<Plan> planes = pl.GetAll();
                List<Especialidad> especialidades = el.GetAll();
                var query = 
                        from p in planes
                        join e in especialidades
                        on p.IDEspecialidad equals e.ID
                        select new 
                        { 
                            ID = p.ID, 
                            Descripcion = p.Descripcion, 
                            Especialidad = e.Descripcion 
                        };
                dgvPlan.DataSource = query.ToList();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de Planes", Ex);
                MessageBox.Show("Error al recuperar lista de Planes", "Planes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ExcepcionManejada;
            }
        }

        private void Planes_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            PlanDesktop formPlan = new PlanDesktop(ApplicationForm.ModoForm.Alta);
            formPlan.ShowDialog();
            this.Listar();
        }
        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvPlan.SelectedRows.Count > 0)
            {
                int ID = Convert.ToInt32(this.dgvPlan.SelectedRows[0].Cells["ID"].Value);
                PlanDesktop formPlan = new PlanDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                formPlan.ShowDialog();
                this.Listar();
            }
        }
        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvPlan.SelectedRows.Count > 0)
            {
                int ID = Convert.ToInt32(this.dgvPlan.SelectedRows[0].Cells["ID"].Value);
                PlanDesktop formPlan = new PlanDesktop(ID, ApplicationForm.ModoForm.Baja);
                formPlan.ShowDialog();
                this.Listar();
            }
        }
    }
}
