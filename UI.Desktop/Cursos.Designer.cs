namespace UI.Desktop
{
    partial class Cursos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FontAwesome.Sharp.IconButton btnEditar;
            FontAwesome.Sharp.IconButton btnEliminar;
            FontAwesome.Sharp.IconButton btnNuevo;
            this.panelAdd = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anio_especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAdd
            // 
            this.panelAdd.Location = new System.Drawing.Point(703, 61);
            this.panelAdd.MaximumSize = new System.Drawing.Size(276, 158);
            this.panelAdd.MinimumSize = new System.Drawing.Size(276, 300);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(276, 300);
            this.panelAdd.TabIndex = 15;
            this.panelAdd.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.panelAdd_ControlRemoved);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(871, 478);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(952, 478);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEditar
            // 
            btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnEditar.IconColor = System.Drawing.Color.Black;
            btnEditar.IconSize = 40;
            btnEditar.Location = new System.Drawing.Point(750, 12);
            btnEditar.Name = "btnEditar";
            btnEditar.Rotation = 0D;
            btnEditar.Size = new System.Drawing.Size(40, 40);
            btnEditar.TabIndex = 11;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEliminar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminar.IconColor = System.Drawing.Color.Black;
            btnEliminar.IconSize = 40;
            btnEliminar.Location = new System.Drawing.Point(796, 12);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Rotation = 0D;
            btnEliminar.Size = new System.Drawing.Size(40, 40);
            btnEliminar.TabIndex = 12;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNuevo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnNuevo.IconColor = System.Drawing.Color.Black;
            btnNuevo.IconSize = 40;
            btnNuevo.Location = new System.Drawing.Point(703, 11);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Rotation = 0D;
            btnNuevo.Size = new System.Drawing.Size(41, 41);
            btnNuevo.TabIndex = 10;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvCursos
            // 
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Anio_especialidad,
            this.Comision,
            this.Materia});
            this.dgvCursos.Location = new System.Drawing.Point(12, 12);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.Size = new System.Drawing.Size(645, 400);
            this.dgvCursos.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Anio_especialidad
            // 
            this.Anio_especialidad.DataPropertyName = "AnioCalendario";
            this.Anio_especialidad.HeaderText = "Año Calendario";
            this.Anio_especialidad.Name = "Anio_especialidad";
            this.Anio_especialidad.ReadOnly = true;
            // 
            // Comision
            // 
            this.Comision.DataPropertyName = "Comision";
            this.Comision.HeaderText = "Comision";
            this.Comision.Name = "Comision";
            this.Comision.ReadOnly = true;
            // 
            // Materia
            // 
            this.Materia.DataPropertyName = "Materia";
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 513);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(btnEditar);
            this.Controls.Add(btnEliminar);
            this.Controls.Add(btnNuevo);
            this.Controls.Add(this.dgvCursos);
            this.MinimumSize = new System.Drawing.Size(699, 552);
            this.Name = "Cursos";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.Cursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anio_especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
    }
}