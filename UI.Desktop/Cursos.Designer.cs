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
            this.dgvComisones = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anio_especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComisones)).BeginInit();
            this.SuspendLayout();
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
            btnEditar.Location = new System.Drawing.Point(571, 418);
            btnEditar.Name = "btnEditar";
            btnEditar.Rotation = 0D;
            btnEditar.Size = new System.Drawing.Size(40, 40);
            btnEditar.TabIndex = 11;
            btnEditar.UseVisualStyleBackColor = true;
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
            btnEliminar.Location = new System.Drawing.Point(617, 418);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Rotation = 0D;
            btnEliminar.Size = new System.Drawing.Size(40, 40);
            btnEliminar.TabIndex = 12;
            btnEliminar.UseVisualStyleBackColor = true;
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
            btnNuevo.Location = new System.Drawing.Point(524, 417);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Rotation = 0D;
            btnNuevo.Size = new System.Drawing.Size(41, 41);
            btnNuevo.TabIndex = 10;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvComisones
            // 
            this.dgvComisones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComisones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion,
            this.Anio_especialidad,
            this.Comision,
            this.Materia,
            this.Plan});
            this.dgvComisones.Location = new System.Drawing.Point(12, 12);
            this.dgvComisones.Name = "dgvComisones";
            this.dgvComisones.Size = new System.Drawing.Size(645, 400);
            this.dgvComisones.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
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
            // Plan
            // 
            this.Plan.DataPropertyName = "Plan";
            this.Plan.HeaderText = "Plan";
            this.Plan.Name = "Plan";
            this.Plan.ReadOnly = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(515, 478);
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
            this.btnSalir.Location = new System.Drawing.Point(596, 478);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 513);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(btnEditar);
            this.Controls.Add(btnEliminar);
            this.Controls.Add(btnNuevo);
            this.Controls.Add(this.dgvComisones);
            this.MinimumSize = new System.Drawing.Size(699, 552);
            this.Name = "Cursos";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.Cursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComisones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComisones;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anio_especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plan;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
    }
}