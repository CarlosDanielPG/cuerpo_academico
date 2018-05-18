namespace Cuerpo_Academico
{
    partial class Producciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbTipoProduccion = new System.Windows.Forms.ComboBox();
            this.lblTipoProduccion = new System.Windows.Forms.Label();
            this.listElaboradores = new System.Windows.Forms.ListBox();
            this.cmbProfesores = new System.Windows.Forms.ComboBox();
            this.gbProfesores = new System.Windows.Forms.GroupBox();
            this.btnColaboradores = new System.Windows.Forms.Button();
            this.btnElaboradores = new System.Windows.Forms.Button();
            this.listColaboradores = new System.Windows.Forms.ListBox();
            this.cmbAnios = new System.Windows.Forms.ComboBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblInstitucion = new System.Windows.Forms.Label();
            this.cmbInstituciones = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.chkCurriculum = new System.Windows.Forms.CheckBox();
            this.dgvProducciones = new System.Windows.Forms.DataGridView();
            this.numero_registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_publicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_produccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linea_investigacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proposito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.institucion_avaladora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curriculum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbBuscador = new System.Windows.Forms.GroupBox();
            this.btnBuscarTodo = new System.Windows.Forms.Button();
            this.dbFiltrar = new System.Windows.Forms.RadioButton();
            this.rbMostrarTodo = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbParametro = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblProposito = new System.Windows.Forms.Label();
            this.cmbProposito = new System.Windows.Forms.ComboBox();
            this.lblLineaInvestigacion = new System.Windows.Forms.Label();
            this.cmbLineaInvestigacion = new System.Windows.Forms.ComboBox();
            this.gbElaboradores = new System.Windows.Forms.GroupBox();
            this.btnEliminarElaborador = new System.Windows.Forms.Button();
            this.gbColaboradores = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbOperaciones = new System.Windows.Forms.GroupBox();
            this.btnBuscarID = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.gbProfesores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducciones)).BeginInit();
            this.gbBuscador.SuspendLayout();
            this.gbElaboradores.SuspendLayout();
            this.gbColaboradores.SuspendLayout();
            this.gbOperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(26, 20);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(169, 20);
            this.txtTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(23, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(36, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Titulo:";
            // 
            // cmbTipoProduccion
            // 
            this.cmbTipoProduccion.FormattingEnabled = true;
            this.cmbTipoProduccion.Location = new System.Drawing.Point(26, 59);
            this.cmbTipoProduccion.Name = "cmbTipoProduccion";
            this.cmbTipoProduccion.Size = new System.Drawing.Size(169, 21);
            this.cmbTipoProduccion.TabIndex = 2;
            // 
            // lblTipoProduccion
            // 
            this.lblTipoProduccion.AutoSize = true;
            this.lblTipoProduccion.Location = new System.Drawing.Point(24, 43);
            this.lblTipoProduccion.Name = "lblTipoProduccion";
            this.lblTipoProduccion.Size = new System.Drawing.Size(88, 13);
            this.lblTipoProduccion.TabIndex = 3;
            this.lblTipoProduccion.Text = "Tipo Produccion:";
            // 
            // listElaboradores
            // 
            this.listElaboradores.FormattingEnabled = true;
            this.listElaboradores.Location = new System.Drawing.Point(6, 19);
            this.listElaboradores.Name = "listElaboradores";
            this.listElaboradores.Size = new System.Drawing.Size(168, 56);
            this.listElaboradores.TabIndex = 4;
            // 
            // cmbProfesores
            // 
            this.cmbProfesores.FormattingEnabled = true;
            this.cmbProfesores.Location = new System.Drawing.Point(6, 19);
            this.cmbProfesores.Name = "cmbProfesores";
            this.cmbProfesores.Size = new System.Drawing.Size(168, 21);
            this.cmbProfesores.TabIndex = 6;
            // 
            // gbProfesores
            // 
            this.gbProfesores.Controls.Add(this.btnColaboradores);
            this.gbProfesores.Controls.Add(this.btnElaboradores);
            this.gbProfesores.Controls.Add(this.cmbProfesores);
            this.gbProfesores.Location = new System.Drawing.Point(244, 127);
            this.gbProfesores.Name = "gbProfesores";
            this.gbProfesores.Size = new System.Drawing.Size(534, 53);
            this.gbProfesores.TabIndex = 7;
            this.gbProfesores.TabStop = false;
            this.gbProfesores.Text = "Profesores";
            // 
            // btnColaboradores
            // 
            this.btnColaboradores.Location = new System.Drawing.Point(356, 18);
            this.btnColaboradores.Name = "btnColaboradores";
            this.btnColaboradores.Size = new System.Drawing.Size(168, 22);
            this.btnColaboradores.TabIndex = 8;
            this.btnColaboradores.Text = "Agregar a Colaboradores";
            this.btnColaboradores.UseVisualStyleBackColor = true;
            this.btnColaboradores.Click += new System.EventHandler(this.btnColaboradores_Click);
            // 
            // btnElaboradores
            // 
            this.btnElaboradores.Location = new System.Drawing.Point(180, 18);
            this.btnElaboradores.Name = "btnElaboradores";
            this.btnElaboradores.Size = new System.Drawing.Size(168, 22);
            this.btnElaboradores.TabIndex = 7;
            this.btnElaboradores.Text = "Agregar a Elaboradores";
            this.btnElaboradores.UseVisualStyleBackColor = true;
            this.btnElaboradores.Click += new System.EventHandler(this.btnElaboradores_Click);
            // 
            // listColaboradores
            // 
            this.listColaboradores.FormattingEnabled = true;
            this.listColaboradores.Location = new System.Drawing.Point(6, 19);
            this.listColaboradores.Name = "listColaboradores";
            this.listColaboradores.Size = new System.Drawing.Size(176, 56);
            this.listColaboradores.TabIndex = 8;
            // 
            // cmbAnios
            // 
            this.cmbAnios.FormattingEnabled = true;
            this.cmbAnios.Location = new System.Drawing.Point(587, 20);
            this.cmbAnios.Name = "cmbAnios";
            this.cmbAnios.Size = new System.Drawing.Size(121, 21);
            this.cmbAnios.TabIndex = 10;
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(584, 4);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(29, 13);
            this.lblAnio.TabIndex = 11;
            this.lblAnio.Text = "Año:";
            // 
            // lblInstitucion
            // 
            this.lblInstitucion.AutoSize = true;
            this.lblInstitucion.Location = new System.Drawing.Point(584, 44);
            this.lblInstitucion.Name = "lblInstitucion";
            this.lblInstitucion.Size = new System.Drawing.Size(108, 13);
            this.lblInstitucion.TabIndex = 13;
            this.lblInstitucion.Text = "Institucion avaladora:";
            // 
            // cmbInstituciones
            // 
            this.cmbInstituciones.FormattingEnabled = true;
            this.cmbInstituciones.Location = new System.Drawing.Point(587, 60);
            this.cmbInstituciones.Name = "cmbInstituciones";
            this.cmbInstituciones.Size = new System.Drawing.Size(181, 21);
            this.cmbInstituciones.TabIndex = 12;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(27, 137);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 14;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(24, 121);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(97, 13);
            this.lblFecha.TabIndex = 15;
            this.lblFecha.Text = "Fecha publicación:";
            // 
            // chkCurriculum
            // 
            this.chkCurriculum.AutoSize = true;
            this.chkCurriculum.Location = new System.Drawing.Point(30, 163);
            this.chkCurriculum.Name = "chkCurriculum";
            this.chkCurriculum.Size = new System.Drawing.Size(173, 17);
            this.chkCurriculum.TabIndex = 16;
            this.chkCurriculum.Text = "¿Considerada para Curriculum?";
            this.chkCurriculum.UseVisualStyleBackColor = true;
            // 
            // dgvProducciones
            // 
            this.dgvProducciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero_registro,
            this.titulo,
            this.anio,
            this.fecha_publicacion,
            this.tipo_produccion,
            this.linea_investigacion,
            this.proposito,
            this.institucion_avaladora,
            this.curriculum});
            this.dgvProducciones.Location = new System.Drawing.Point(26, 260);
            this.dgvProducciones.Name = "dgvProducciones";
            this.dgvProducciones.Size = new System.Drawing.Size(752, 134);
            this.dgvProducciones.TabIndex = 17;
            // 
            // numero_registro
            // 
            this.numero_registro.HeaderText = "Numero Registro";
            this.numero_registro.Name = "numero_registro";
            this.numero_registro.Width = 50;
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Titulo";
            this.titulo.Name = "titulo";
            // 
            // anio
            // 
            this.anio.HeaderText = "Año";
            this.anio.Name = "anio";
            this.anio.Width = 40;
            // 
            // fecha_publicacion
            // 
            dataGridViewCellStyle2.Format = "dd-MM-yyyy";
            this.fecha_publicacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.fecha_publicacion.HeaderText = "Fecha Publicacion";
            this.fecha_publicacion.Name = "fecha_publicacion";
            this.fecha_publicacion.Width = 80;
            // 
            // tipo_produccion
            // 
            this.tipo_produccion.HeaderText = "Tipo Produccion";
            this.tipo_produccion.Name = "tipo_produccion";
            // 
            // linea_investigacion
            // 
            this.linea_investigacion.HeaderText = "Linea Investigacion";
            this.linea_investigacion.Name = "linea_investigacion";
            // 
            // proposito
            // 
            this.proposito.HeaderText = "Proposito";
            this.proposito.Name = "proposito";
            // 
            // institucion_avaladora
            // 
            this.institucion_avaladora.HeaderText = "Institucion Avaladora";
            this.institucion_avaladora.Name = "institucion_avaladora";
            // 
            // curriculum
            // 
            this.curriculum.HeaderText = "Cuenta curriculum";
            this.curriculum.Name = "curriculum";
            // 
            // gbBuscador
            // 
            this.gbBuscador.Controls.Add(this.btnBuscarTodo);
            this.gbBuscador.Controls.Add(this.dbFiltrar);
            this.gbBuscador.Controls.Add(this.rbMostrarTodo);
            this.gbBuscador.Controls.Add(this.btnBuscar);
            this.gbBuscador.Controls.Add(this.cmbParametro);
            this.gbBuscador.Controls.Add(this.txtBuscar);
            this.gbBuscador.Location = new System.Drawing.Point(30, 183);
            this.gbBuscador.Name = "gbBuscador";
            this.gbBuscador.Size = new System.Drawing.Size(384, 71);
            this.gbBuscador.TabIndex = 18;
            this.gbBuscador.TabStop = false;
            this.gbBuscador.Text = "Buscador";
            // 
            // btnBuscarTodo
            // 
            this.btnBuscarTodo.Enabled = false;
            this.btnBuscarTodo.Location = new System.Drawing.Point(175, 42);
            this.btnBuscarTodo.Name = "btnBuscarTodo";
            this.btnBuscarTodo.Size = new System.Drawing.Size(194, 23);
            this.btnBuscarTodo.TabIndex = 5;
            this.btnBuscarTodo.Text = "Buscar Por todos los parametros";
            this.btnBuscarTodo.UseVisualStyleBackColor = true;
            this.btnBuscarTodo.Click += new System.EventHandler(this.btnBuscarTodo_Click);
            // 
            // dbFiltrar
            // 
            this.dbFiltrar.AutoSize = true;
            this.dbFiltrar.Location = new System.Drawing.Point(105, 48);
            this.dbFiltrar.Name = "dbFiltrar";
            this.dbFiltrar.Size = new System.Drawing.Size(50, 17);
            this.dbFiltrar.TabIndex = 4;
            this.dbFiltrar.TabStop = true;
            this.dbFiltrar.Text = "Filtrar";
            this.dbFiltrar.UseVisualStyleBackColor = true;
            this.dbFiltrar.CheckedChanged += new System.EventHandler(this.dbFiltrar_CheckedChanged);
            // 
            // rbMostrarTodo
            // 
            this.rbMostrarTodo.AutoSize = true;
            this.rbMostrarTodo.Location = new System.Drawing.Point(6, 48);
            this.rbMostrarTodo.Name = "rbMostrarTodo";
            this.rbMostrarTodo.Size = new System.Drawing.Size(93, 17);
            this.rbMostrarTodo.TabIndex = 3;
            this.rbMostrarTodo.TabStop = true;
            this.rbMostrarTodo.Text = "Mostrar Todos";
            this.rbMostrarTodo.UseVisualStyleBackColor = true;
            this.rbMostrarTodo.CheckedChanged += new System.EventHandler(this.rbMostrarTodo_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Location = new System.Drawing.Point(278, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbParametro
            // 
            this.cmbParametro.Enabled = false;
            this.cmbParametro.FormattingEnabled = true;
            this.cmbParametro.Location = new System.Drawing.Point(151, 17);
            this.cmbParametro.Name = "cmbParametro";
            this.cmbParametro.Size = new System.Drawing.Size(121, 21);
            this.cmbParametro.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Enabled = false;
            this.txtBuscar.Location = new System.Drawing.Point(6, 17);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(139, 20);
            this.txtBuscar.TabIndex = 0;
            // 
            // lblProposito
            // 
            this.lblProposito.AutoSize = true;
            this.lblProposito.Location = new System.Drawing.Point(24, 84);
            this.lblProposito.Name = "lblProposito";
            this.lblProposito.Size = new System.Drawing.Size(54, 13);
            this.lblProposito.TabIndex = 19;
            this.lblProposito.Text = "Propósito:";
            // 
            // cmbProposito
            // 
            this.cmbProposito.FormattingEnabled = true;
            this.cmbProposito.Location = new System.Drawing.Point(26, 100);
            this.cmbProposito.Name = "cmbProposito";
            this.cmbProposito.Size = new System.Drawing.Size(169, 21);
            this.cmbProposito.TabIndex = 20;
            // 
            // lblLineaInvestigacion
            // 
            this.lblLineaInvestigacion.AutoSize = true;
            this.lblLineaInvestigacion.Location = new System.Drawing.Point(584, 84);
            this.lblLineaInvestigacion.Name = "lblLineaInvestigacion";
            this.lblLineaInvestigacion.Size = new System.Drawing.Size(117, 13);
            this.lblLineaInvestigacion.TabIndex = 22;
            this.lblLineaInvestigacion.Text = "Linea de Investigacion:";
            // 
            // cmbLineaInvestigacion
            // 
            this.cmbLineaInvestigacion.FormattingEnabled = true;
            this.cmbLineaInvestigacion.Location = new System.Drawing.Point(587, 100);
            this.cmbLineaInvestigacion.Name = "cmbLineaInvestigacion";
            this.cmbLineaInvestigacion.Size = new System.Drawing.Size(181, 21);
            this.cmbLineaInvestigacion.TabIndex = 21;
            // 
            // gbElaboradores
            // 
            this.gbElaboradores.Controls.Add(this.btnEliminarElaborador);
            this.gbElaboradores.Controls.Add(this.listElaboradores);
            this.gbElaboradores.Location = new System.Drawing.Point(199, 4);
            this.gbElaboradores.Name = "gbElaboradores";
            this.gbElaboradores.Size = new System.Drawing.Size(182, 117);
            this.gbElaboradores.TabIndex = 23;
            this.gbElaboradores.TabStop = false;
            this.gbElaboradores.Text = "Elaboradores (Ya estás incluido):";
            // 
            // btnEliminarElaborador
            // 
            this.btnEliminarElaborador.Location = new System.Drawing.Point(6, 81);
            this.btnEliminarElaborador.Name = "btnEliminarElaborador";
            this.btnEliminarElaborador.Size = new System.Drawing.Size(168, 23);
            this.btnEliminarElaborador.TabIndex = 5;
            this.btnEliminarElaborador.Text = "Eliminar Elaborador";
            this.btnEliminarElaborador.UseVisualStyleBackColor = true;
            this.btnEliminarElaborador.Click += new System.EventHandler(this.btnEliminarElaborador_Click);
            // 
            // gbColaboradores
            // 
            this.gbColaboradores.Controls.Add(this.button1);
            this.gbColaboradores.Controls.Add(this.listColaboradores);
            this.gbColaboradores.Location = new System.Drawing.Point(387, 4);
            this.gbColaboradores.Name = "gbColaboradores";
            this.gbColaboradores.Size = new System.Drawing.Size(190, 117);
            this.gbColaboradores.TabIndex = 24;
            this.gbColaboradores.TabStop = false;
            this.gbColaboradores.Text = "Colaboradores";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Eliminar Colaborador";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(131, 15);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(102, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(131, 42);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(102, 23);
            this.btnModificar.TabIndex = 25;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(239, 42);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 23);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gbOperaciones
            // 
            this.gbOperaciones.Controls.Add(this.btnBuscarID);
            this.gbOperaciones.Controls.Add(this.lblID);
            this.gbOperaciones.Controls.Add(this.txtID);
            this.gbOperaciones.Controls.Add(this.btnEliminar);
            this.gbOperaciones.Controls.Add(this.btnGuardar);
            this.gbOperaciones.Controls.Add(this.btnModificar);
            this.gbOperaciones.Location = new System.Drawing.Point(420, 183);
            this.gbOperaciones.Name = "gbOperaciones";
            this.gbOperaciones.Size = new System.Drawing.Size(358, 71);
            this.gbOperaciones.TabIndex = 27;
            this.gbOperaciones.TabStop = false;
            this.gbOperaciones.Text = "Operaciones";
            // 
            // btnBuscarID
            // 
            this.btnBuscarID.Location = new System.Drawing.Point(239, 15);
            this.btnBuscarID.Name = "btnBuscarID";
            this.btnBuscarID.Size = new System.Drawing.Size(109, 23);
            this.btnBuscarID.TabIndex = 29;
            this.btnBuscarID.Text = "Buscar";
            this.btnBuscarID.UseVisualStyleBackColor = true;
            this.btnBuscarID.Click += new System.EventHandler(this.btnBuscarID_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(84, 13);
            this.lblID.TabIndex = 28;
            this.lblID.Text = "Numero registro:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(9, 36);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 27;
            // 
            // Producciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(813, 399);
            this.Controls.Add(this.gbOperaciones);
            this.Controls.Add(this.gbColaboradores);
            this.Controls.Add(this.gbElaboradores);
            this.Controls.Add(this.lblLineaInvestigacion);
            this.Controls.Add(this.cmbLineaInvestigacion);
            this.Controls.Add(this.cmbProposito);
            this.Controls.Add(this.lblProposito);
            this.Controls.Add(this.gbBuscador);
            this.Controls.Add(this.dgvProducciones);
            this.Controls.Add(this.chkCurriculum);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblInstitucion);
            this.Controls.Add(this.cmbInstituciones);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.cmbAnios);
            this.Controls.Add(this.gbProfesores);
            this.Controls.Add(this.lblTipoProduccion);
            this.Controls.Add(this.cmbTipoProduccion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Producciones";
            this.Text = "Producciones";
            this.Load += new System.EventHandler(this.Producciones_Load);
            this.gbProfesores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducciones)).EndInit();
            this.gbBuscador.ResumeLayout(false);
            this.gbBuscador.PerformLayout();
            this.gbElaboradores.ResumeLayout(false);
            this.gbColaboradores.ResumeLayout(false);
            this.gbOperaciones.ResumeLayout(false);
            this.gbOperaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbTipoProduccion;
        private System.Windows.Forms.Label lblTipoProduccion;
        private System.Windows.Forms.ListBox listElaboradores;
        private System.Windows.Forms.ComboBox cmbProfesores;
        private System.Windows.Forms.GroupBox gbProfesores;
        private System.Windows.Forms.Button btnColaboradores;
        private System.Windows.Forms.Button btnElaboradores;
        private System.Windows.Forms.ListBox listColaboradores;
        private System.Windows.Forms.ComboBox cmbAnios;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblInstitucion;
        private System.Windows.Forms.ComboBox cmbInstituciones;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.CheckBox chkCurriculum;
        private System.Windows.Forms.DataGridView dgvProducciones;
        private System.Windows.Forms.GroupBox gbBuscador;
        private System.Windows.Forms.RadioButton dbFiltrar;
        private System.Windows.Forms.RadioButton rbMostrarTodo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbParametro;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblProposito;
        private System.Windows.Forms.ComboBox cmbProposito;
        private System.Windows.Forms.Label lblLineaInvestigacion;
        private System.Windows.Forms.ComboBox cmbLineaInvestigacion;
        private System.Windows.Forms.GroupBox gbElaboradores;
        private System.Windows.Forms.Button btnEliminarElaborador;
        private System.Windows.Forms.GroupBox gbColaboradores;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_publicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_produccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn linea_investigacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn proposito;
        private System.Windows.Forms.DataGridViewTextBoxColumn institucion_avaladora;
        private System.Windows.Forms.DataGridViewTextBoxColumn curriculum;
        private System.Windows.Forms.Button btnBuscarTodo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbOperaciones;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnBuscarID;
    }
}