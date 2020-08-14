namespace UI.Desktop
{
    partial class Usuarios
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
            FontAwesome.Sharp.IconButton btnNuevo;
            FontAwesome.Sharp.IconButton btnEditar;
            FontAwesome.Sharp.IconButton btnEliminar;
            this.tcUsuarios = new System.Windows.Forms.ToolStripContainer();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilitado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            this.tcUsuarios.ContentPanel.SuspendLayout();
            this.tcUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
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
            btnNuevo.Location = new System.Drawing.Point(659, 12);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Rotation = 0D;
            btnNuevo.Size = new System.Drawing.Size(41, 41);
            btnNuevo.TabIndex = 4;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
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
            btnEditar.Location = new System.Drawing.Point(706, 13);
            btnEditar.Name = "btnEditar";
            btnEditar.Rotation = 0D;
            btnEditar.Size = new System.Drawing.Size(40, 40);
            btnEditar.TabIndex = 5;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += new System.EventHandler(this.tsbEditar_Click);
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
            btnEliminar.Location = new System.Drawing.Point(752, 13);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Rotation = 0D;
            btnEliminar.Size = new System.Drawing.Size(40, 40);
            btnEliminar.TabIndex = 6;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // tcUsuarios
            // 
            // 
            // tcUsuarios.ContentPanel
            // 
            this.tcUsuarios.ContentPanel.Controls.Add(btnEditar);
            this.tcUsuarios.ContentPanel.Controls.Add(btnEliminar);
            this.tcUsuarios.ContentPanel.Controls.Add(btnNuevo);
            this.tcUsuarios.ContentPanel.Controls.Add(this.btnActualizar);
            this.tcUsuarios.ContentPanel.Controls.Add(this.btnSalir);
            this.tcUsuarios.ContentPanel.Controls.Add(this.dgvUsuarios);
            this.tcUsuarios.ContentPanel.Size = new System.Drawing.Size(1038, 627);
            this.tcUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tcUsuarios.Name = "tcUsuarios";
            this.tcUsuarios.Size = new System.Drawing.Size(1038, 627);
            this.tcUsuarios.TabIndex = 0;
            this.tcUsuarios.Text = "toolStripContainer1";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(879, 592);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(960, 592);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.apellido,
            this.usuario,
            this.email,
            this.habilitado});
            this.dgvUsuarios.DataBindings.Add(new System.Windows.Forms.Binding("AutoGenerateColumns", global::UI.Desktop.Properties.Settings.Default, "False", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 12);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(641, 529);
            this.dgvUsuarios.TabIndex = 1;
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "Nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "Apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "NombreUsuario";
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // habilitado
            // 
            this.habilitado.DataPropertyName = "Habilitado";
            this.habilitado.HeaderText = "Habilitado";
            this.habilitado.Name = "habilitado";
            this.habilitado.ReadOnly = true;
            this.habilitado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.habilitado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1038, 627);
            this.Controls.Add(this.tcUsuarios);
            this.MinimumSize = new System.Drawing.Size(818, 666);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.tcUsuarios.ContentPanel.ResumeLayout(false);
            this.tcUsuarios.ResumeLayout(false);
            this.tcUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcUsuarios;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn habilitado;
    }
}