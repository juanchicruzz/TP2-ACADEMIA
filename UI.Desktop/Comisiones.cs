﻿using Business.Entities;
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
    public partial class Comisiones : ApplicationForm
    {
        private Form activeForm = null;
        public Comisiones()
        {
            InitializeComponent();
        }
        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvComisones.SelectedRows.Count > 0)
            {
                int ID = Convert.ToInt32(this.dgvComisones.SelectedRows[0].Cells["ID"].Value);
                ComisionDesktop formComision = new ComisionDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                formComision.ShowDialog();
                this.Listar();
            }
        }
        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvComisones.SelectedRows.Count > 0)
            {
                int ID = Convert.ToInt32(this.dgvComisones.SelectedRows[0].Cells["ID"].Value);
                ComisionDesktop formComision = new ComisionDesktop(ID, ApplicationForm.ModoForm.Baja);
                formComision.ShowDialog();
                this.Listar();
            }
        }
        public void Listar()
        {
            ComisionLogic cl = new ComisionLogic();
            PlanLogic pl = new PlanLogic();
            try
            {
                List<Plan> planes = pl.GetAll();
                List<Comision> comisiones = cl.GetAll();
                var query = from c in comisiones
                            join p in planes
                            on c.IDPlan equals p.ID
                            select new
                            {
                                ID = c.ID,
                                Descripcion = c.Descripcion,
                                anio_especialidad = c.AnioEspecialidad,
                                plan = p.Descripcion
                            };
                dgvComisones.DataSource = query.ToList();
            
            }catch(Exception Ex)
            {
                Exception ExcepcionManejada =
               new Exception("Error al recuperar lista de Comisiones", Ex);
                MessageBox.Show("Error al recuperar lista de Comisiones", "Comision", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ExcepcionManejada;
            }
        }

        private void Comisiones_Load(object sender, EventArgs e)
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

        private void panelAdd_ControlRemoved(object sender, ControlEventArgs e)
        {
            Listar();
        }

        private void tsbNuevo_Click_1(object sender, EventArgs e)
        {
            ComisionDesktop formComision = new ComisionDesktop(ApplicationForm.ModoForm.Alta);
            formComision.ShowDialog();
            this.Listar();
        }
    }
}
