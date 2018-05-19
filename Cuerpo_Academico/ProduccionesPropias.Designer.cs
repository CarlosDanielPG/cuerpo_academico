namespace Cuerpo_Academico
{
    partial class ProduccionesPropias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lblColaborando = new System.Windows.Forms.Label();
            this.dgvElaborando = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblElaborando = new System.Windows.Forms.Label();
            this.btnCurriculum = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElaborando)).BeginInit();
            this.SuspendLayout();
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
            this.dgvProducciones.Location = new System.Drawing.Point(15, 40);
            this.dgvProducciones.Name = "dgvProducciones";
            this.dgvProducciones.Size = new System.Drawing.Size(775, 156);
            this.dgvProducciones.TabIndex = 18;
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
            dataGridViewCellStyle1.Format = "dd-MM-yyyy";
            this.fecha_publicacion.DefaultCellStyle = dataGridViewCellStyle1;
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
            // lblColaborando
            // 
            this.lblColaborando.AutoSize = true;
            this.lblColaborando.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColaborando.Location = new System.Drawing.Point(12, 19);
            this.lblColaborando.Name = "lblColaborando";
            this.lblColaborando.Size = new System.Drawing.Size(421, 18);
            this.lblColaborando.TabIndex = 19;
            this.lblColaborando.Text = "Estas son las producciones donde estás colaborando:";
            // 
            // dgvElaborando
            // 
            this.dgvElaborando.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElaborando.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvElaborando.Location = new System.Drawing.Point(15, 231);
            this.dgvElaborando.Name = "dgvElaborando";
            this.dgvElaborando.Size = new System.Drawing.Size(775, 156);
            this.dgvElaborando.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Numero Registro";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Año";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 40;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle2.Format = "dd-MM-yyyy";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn4.HeaderText = "Fecha Publicacion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Tipo Produccion";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Linea Investigacion";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Proposito";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Institucion Avaladora";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Cuenta curriculum";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // lblElaborando
            // 
            this.lblElaborando.AutoSize = true;
            this.lblElaborando.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElaborando.Location = new System.Drawing.Point(12, 210);
            this.lblElaborando.Name = "lblElaborando";
            this.lblElaborando.Size = new System.Drawing.Size(399, 18);
            this.lblElaborando.TabIndex = 21;
            this.lblElaborando.Text = "Estas son las producciones donde eres elaborador:";
            // 
            // btnCurriculum
            // 
            this.btnCurriculum.Location = new System.Drawing.Point(631, 11);
            this.btnCurriculum.Name = "btnCurriculum";
            this.btnCurriculum.Size = new System.Drawing.Size(159, 23);
            this.btnCurriculum.TabIndex = 22;
            this.btnCurriculum.Text = "Ve aquí tu curriculum";
            this.btnCurriculum.UseVisualStyleBackColor = true;
            this.btnCurriculum.Click += new System.EventHandler(this.btnCurriculum_Click);
            // 
            // ProduccionesPropias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(813, 399);
            this.Controls.Add(this.btnCurriculum);
            this.Controls.Add(this.lblElaborando);
            this.Controls.Add(this.dgvElaborando);
            this.Controls.Add(this.lblColaborando);
            this.Controls.Add(this.dgvProducciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProduccionesPropias";
            this.Text = "ProduccionesPropias";
            this.Load += new System.EventHandler(this.ProduccionesPropias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElaborando)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_publicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_produccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn linea_investigacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn proposito;
        private System.Windows.Forms.DataGridViewTextBoxColumn institucion_avaladora;
        private System.Windows.Forms.DataGridViewTextBoxColumn curriculum;
        private System.Windows.Forms.Label lblColaborando;
        private System.Windows.Forms.DataGridView dgvElaborando;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label lblElaborando;
        private System.Windows.Forms.Button btnCurriculum;
    }
}