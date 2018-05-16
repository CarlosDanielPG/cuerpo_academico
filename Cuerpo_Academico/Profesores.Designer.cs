namespace Cuerpo_Academico
{
    partial class Profesores
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
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.gbGradosDisponibles = new System.Windows.Forms.GroupBox();
            this.cmbGrados = new System.Windows.Forms.ComboBox();
            this.btnEliminarGrado = new System.Windows.Forms.Button();
            this.btnAgregarGrado = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvProfesores = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.division = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.listGrados = new System.Windows.Forms.ListBox();
            this.lblDivision = new System.Windows.Forms.Label();
            this.cmbDivision = new System.Windows.Forms.ComboBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lblApellidoM = new System.Windows.Forms.Label();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.lblApellidoP = new System.Windows.Forms.Label();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCurriculum = new System.Windows.Forms.Button();
            this.gbBusqueda.SuspendLayout();
            this.gbGradosDisponibles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.btnCurriculum);
            this.gbBusqueda.Controls.Add(this.lblID);
            this.gbBusqueda.Controls.Add(this.txtID);
            this.gbBusqueda.Controls.Add(this.btnBuscar);
            this.gbBusqueda.Controls.Add(this.btnEliminar);
            this.gbBusqueda.Controls.Add(this.btnModificar);
            this.gbBusqueda.Location = new System.Drawing.Point(637, 23);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(157, 197);
            this.gbBusqueda.TabIndex = 48;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Busqueda";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(13, 18);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 28;
            this.lblID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(16, 40);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(129, 20);
            this.txtID.TabIndex = 28;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(16, 71);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(129, 23);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(16, 101);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(129, 23);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(16, 133);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(129, 23);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(156, 111);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(64, 13);
            this.lblPassword.TabIndex = 47;
            this.lblPassword.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(159, 127);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(129, 20);
            this.txtPassword.TabIndex = 46;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // gbGradosDisponibles
            // 
            this.gbGradosDisponibles.Controls.Add(this.cmbGrados);
            this.gbGradosDisponibles.Controls.Add(this.btnEliminarGrado);
            this.gbGradosDisponibles.Controls.Add(this.btnAgregarGrado);
            this.gbGradosDisponibles.Location = new System.Drawing.Point(294, 137);
            this.gbGradosDisponibles.Name = "gbGradosDisponibles";
            this.gbGradosDisponibles.Size = new System.Drawing.Size(254, 83);
            this.gbGradosDisponibles.TabIndex = 45;
            this.gbGradosDisponibles.TabStop = false;
            this.gbGradosDisponibles.Text = "Grados Disponibles";
            // 
            // cmbGrados
            // 
            this.cmbGrados.FormattingEnabled = true;
            this.cmbGrados.Location = new System.Drawing.Point(36, 19);
            this.cmbGrados.Name = "cmbGrados";
            this.cmbGrados.Size = new System.Drawing.Size(173, 21);
            this.cmbGrados.TabIndex = 21;
            // 
            // btnEliminarGrado
            // 
            this.btnEliminarGrado.Location = new System.Drawing.Point(120, 46);
            this.btnEliminarGrado.Name = "btnEliminarGrado";
            this.btnEliminarGrado.Size = new System.Drawing.Size(99, 23);
            this.btnEliminarGrado.TabIndex = 23;
            this.btnEliminarGrado.Text = "Eliminar Grado";
            this.btnEliminarGrado.UseVisualStyleBackColor = true;
            this.btnEliminarGrado.Click += new System.EventHandler(this.btnEliminarGrado_Click);
            // 
            // btnAgregarGrado
            // 
            this.btnAgregarGrado.Location = new System.Drawing.Point(21, 46);
            this.btnAgregarGrado.Name = "btnAgregarGrado";
            this.btnAgregarGrado.Size = new System.Drawing.Size(93, 23);
            this.btnAgregarGrado.TabIndex = 22;
            this.btnAgregarGrado.Text = "Agregar Grado";
            this.btnAgregarGrado.UseVisualStyleBackColor = true;
            this.btnAgregarGrado.Click += new System.EventHandler(this.btnAgregarGrado_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(300, 78);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(121, 23);
            this.btnLimpiar.TabIndex = 44;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(300, 36);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(121, 23);
            this.btnGuardar.TabIndex = 43;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvProfesores
            // 
            this.dgvProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nombre,
            this.apellido_paterno,
            this.apellido_materno,
            this.tipo_usuario,
            this.division,
            this.correo});
            this.dgvProfesores.Location = new System.Drawing.Point(21, 226);
            this.dgvProfesores.Name = "dgvProfesores";
            this.dgvProfesores.Size = new System.Drawing.Size(773, 150);
            this.dgvProfesores.TabIndex = 42;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // apellido_paterno
            // 
            this.apellido_paterno.HeaderText = "Apellido Paterno";
            this.apellido_paterno.Name = "apellido_paterno";
            // 
            // apellido_materno
            // 
            this.apellido_materno.HeaderText = "Apellido Materno";
            this.apellido_materno.Name = "apellido_materno";
            // 
            // tipo_usuario
            // 
            this.tipo_usuario.HeaderText = "Tipo Usuario";
            this.tipo_usuario.Name = "tipo_usuario";
            // 
            // division
            // 
            this.division.HeaderText = "Division";
            this.division.Name = "division";
            // 
            // correo
            // 
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            this.correo.Width = 180;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Grados:";
            // 
            // listGrados
            // 
            this.listGrados.FormattingEnabled = true;
            this.listGrados.Location = new System.Drawing.Point(159, 166);
            this.listGrados.Name = "listGrados";
            this.listGrados.Size = new System.Drawing.Size(129, 56);
            this.listGrados.TabIndex = 40;
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(156, 64);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(47, 13);
            this.lblDivision.TabIndex = 39;
            this.lblDivision.Text = "Division:";
            // 
            // cmbDivision
            // 
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new System.Drawing.Point(159, 80);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.Size = new System.Drawing.Size(121, 21);
            this.cmbDivision.TabIndex = 38;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(18, 160);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(41, 13);
            this.lblCorreo.TabIndex = 37;
            this.lblCorreo.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(21, 176);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(129, 20);
            this.txtCorreo.TabIndex = 36;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Location = new System.Drawing.Point(156, 23);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(85, 13);
            this.lblTipoUsuario.TabIndex = 35;
            this.lblTipoUsuario.Text = "Tipo de Usuario:";
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Location = new System.Drawing.Point(159, 39);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoUsuario.TabIndex = 34;
            // 
            // lblApellidoM
            // 
            this.lblApellidoM.AutoSize = true;
            this.lblApellidoM.Location = new System.Drawing.Point(18, 111);
            this.lblApellidoM.Name = "lblApellidoM";
            this.lblApellidoM.Size = new System.Drawing.Size(89, 13);
            this.lblApellidoM.TabIndex = 33;
            this.lblApellidoM.Text = "Apellido Materno:";
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Location = new System.Drawing.Point(21, 127);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(129, 20);
            this.txtApellidoM.TabIndex = 32;
            // 
            // lblApellidoP
            // 
            this.lblApellidoP.AutoSize = true;
            this.lblApellidoP.Location = new System.Drawing.Point(18, 65);
            this.lblApellidoP.Name = "lblApellidoP";
            this.lblApellidoP.Size = new System.Drawing.Size(87, 13);
            this.lblApellidoP.TabIndex = 31;
            this.lblApellidoP.Text = "Apellido Paterno:";
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Location = new System.Drawing.Point(21, 81);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(129, 20);
            this.txtApellidoP.TabIndex = 30;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(18, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 29;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(21, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(129, 20);
            this.txtNombre.TabIndex = 28;
            // 
            // btnCurriculum
            // 
            this.btnCurriculum.Location = new System.Drawing.Point(16, 162);
            this.btnCurriculum.Name = "btnCurriculum";
            this.btnCurriculum.Size = new System.Drawing.Size(129, 23);
            this.btnCurriculum.TabIndex = 29;
            this.btnCurriculum.Text = "Mostrar Curriculum";
            this.btnCurriculum.UseVisualStyleBackColor = true;
            this.btnCurriculum.Click += new System.EventHandler(this.btnCurriculum_Click);
            // 
            // Profesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(813, 399);
            this.Controls.Add(this.gbBusqueda);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.gbGradosDisponibles);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvProfesores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listGrados);
            this.Controls.Add(this.lblDivision);
            this.Controls.Add(this.cmbDivision);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.cmbTipoUsuario);
            this.Controls.Add(this.lblApellidoM);
            this.Controls.Add(this.txtApellidoM);
            this.Controls.Add(this.lblApellidoP);
            this.Controls.Add(this.txtApellidoP);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profesores";
            this.Text = "Profesores";
            this.Load += new System.EventHandler(this.Profesores_Load);
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            this.gbGradosDisponibles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox gbGradosDisponibles;
        private System.Windows.Forms.ComboBox cmbGrados;
        private System.Windows.Forms.Button btnEliminarGrado;
        private System.Windows.Forms.Button btnAgregarGrado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvProfesores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_materno;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn division;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listGrados;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.ComboBox cmbDivision;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.Label lblApellidoM;
        private System.Windows.Forms.TextBox txtApellidoM;
        private System.Windows.Forms.Label lblApellidoP;
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnCurriculum;
    }
}