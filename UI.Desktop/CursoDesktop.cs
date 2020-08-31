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
using UI.Desktop;
using FastMember;

namespace UI.Desktop
{
    public partial class CursoDesktop : ApplicationForm
    {
        public Curso cursoActual;
        public CursoDesktop()
        {
            InitializeComponent();
        }
        public CursoDesktop(ModoForm modo) : this()
        {
            Modo = modo;
            this.btnAceptar.Text = "Guardar";
        }
        public CursoDesktop(int ID,ModoForm modo) : this()
        {
            Modo = modo;
            CursoLogic c = new CursoLogic();
            cursoActual = c.GetOne(ID);
            MapearDeDatos();
            switch (Modo)
            {

                case ModoForm.Alta:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Modificacion:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    break;
                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    break;

            }
        }
        public virtual void MapearDeDatos()
        {
            //Seguir
        }
        public virtual void Eliminar()
        {
            CursoLogic c = new CursoLogic();
            c.Delete(cursoActual.ID);
        }
        public virtual void GuardarCambios()
        {
            CursoLogic c= new CursoLogic();
            MapearADatos();
            c.Save(cursoActual);
        }
        public void Notificar(string titulo, string mensaje, MessageBoxButtons
botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }
        public void Notificar(string mensaje, MessageBoxButtons botones,
        MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (Modo)
            {
                case ModoForm.Alta:
                case ModoForm.Modificacion:
                    if (Validar())
                    {
                        GuardarCambios();
                        Close();
                    };
                    break;
                case ModoForm.Baja:
                    Eliminar();
                    Close();
                    break;
                case ModoForm.Consulta:
                    Close();
                    break;

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
