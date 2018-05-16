namespace Cuerpo_Academico
{
    partial class Buscador
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
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblIntegrante = new System.Windows.Forms.Label();
            this.lblLineaInvestigacion = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbLineaInvestigacion = new System.Windows.Forms.ComboBox();
            this.cmbIntegrantes = new System.Windows.Forms.ComboBox();
            this.cmbAnio = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(9, 9);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(164, 9);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(29, 13);
            this.lblAnio.TabIndex = 3;
            this.lblAnio.Text = "Año:";
            // 
            // lblIntegrante
            // 
            this.lblIntegrante.AutoSize = true;
            this.lblIntegrante.Location = new System.Drawing.Point(9, 58);
            this.lblIntegrante.Name = "lblIntegrante";
            this.lblIntegrante.Size = new System.Drawing.Size(58, 13);
            this.lblIntegrante.TabIndex = 5;
            this.lblIntegrante.Text = "Integrante:";
            // 
            // lblLineaInvestigacion
            // 
            this.lblLineaInvestigacion.AutoSize = true;
            this.lblLineaInvestigacion.Location = new System.Drawing.Point(9, 107);
            this.lblLineaInvestigacion.Name = "lblLineaInvestigacion";
            this.lblLineaInvestigacion.Size = new System.Drawing.Size(117, 13);
            this.lblLineaInvestigacion.TabIndex = 7;
            this.lblLineaInvestigacion.Text = "Linea de Investigacion:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(167, 180);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 23);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 180);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(12, 27);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(140, 21);
            this.cmbTipo.TabIndex = 10;
            // 
            // cmbLineaInvestigacion
            // 
            this.cmbLineaInvestigacion.FormattingEnabled = true;
            this.cmbLineaInvestigacion.Location = new System.Drawing.Point(12, 123);
            this.cmbLineaInvestigacion.Name = "cmbLineaInvestigacion";
            this.cmbLineaInvestigacion.Size = new System.Drawing.Size(140, 21);
            this.cmbLineaInvestigacion.TabIndex = 11;
            // 
            // cmbIntegrantes
            // 
            this.cmbIntegrantes.FormattingEnabled = true;
            this.cmbIntegrantes.Location = new System.Drawing.Point(12, 74);
            this.cmbIntegrantes.Name = "cmbIntegrantes";
            this.cmbIntegrantes.Size = new System.Drawing.Size(255, 21);
            this.cmbIntegrantes.TabIndex = 12;
            // 
            // cmbAnio
            // 
            this.cmbAnio.FormattingEnabled = true;
            this.cmbAnio.Location = new System.Drawing.Point(167, 27);
            this.cmbAnio.Name = "cmbAnio";
            this.cmbAnio.Size = new System.Drawing.Size(100, 21);
            this.cmbAnio.TabIndex = 13;
            // 
            // Buscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 215);
            this.Controls.Add(this.cmbAnio);
            this.Controls.Add(this.cmbIntegrantes);
            this.Controls.Add(this.cmbLineaInvestigacion);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblLineaInvestigacion);
            this.Controls.Add(this.lblIntegrante);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.lblTipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Buscador";
            this.Text = "Buscador";
            this.Load += new System.EventHandler(this.Buscador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblIntegrante;
        private System.Windows.Forms.Label lblLineaInvestigacion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbLineaInvestigacion;
        private System.Windows.Forms.ComboBox cmbIntegrantes;
        private System.Windows.Forms.ComboBox cmbAnio;
    }
}