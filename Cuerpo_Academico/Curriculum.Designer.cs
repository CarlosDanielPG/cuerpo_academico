namespace Cuerpo_Academico
{
    partial class Curriculum
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
            this.dgvCurriculum = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.numero_registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_publicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurriculum)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCurriculum
            // 
            this.dgvCurriculum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurriculum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero_registro,
            this.titulo,
            this.anio,
            this.fecha_publicacion});
            this.dgvCurriculum.Location = new System.Drawing.Point(12, 12);
            this.dgvCurriculum.Name = "dgvCurriculum";
            this.dgvCurriculum.Size = new System.Drawing.Size(443, 206);
            this.dgvCurriculum.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(361, 226);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(94, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // numero_registro
            // 
            this.numero_registro.HeaderText = "Numero Registro";
            this.numero_registro.Name = "numero_registro";
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
            // 
            // fecha_publicacion
            // 
            this.fecha_publicacion.HeaderText = "Fecha publicacion";
            this.fecha_publicacion.Name = "fecha_publicacion";
            // 
            // Curriculum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 261);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvCurriculum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Curriculum";
            this.Text = "Curriculum";
            this.Load += new System.EventHandler(this.Curriculum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurriculum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCurriculum;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_publicacion;
    }
}