using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Globalization;
using Microsoft.VisualBasic;

namespace Cuerpo_Academico
{
    public partial class Producciones : Form
    {
        private string consulta;
        private Conexion conexion;
        private OdbcDataReader resultado;
        private Profesor profesor;
        private List<ComboBox> comboBoxes = null;
        private List<ListBox> listBoxes = null;
        private int cuenta_curriculum = 0;
        private string consultaGeneral = "SELECT produccion.numero_registro, produccion.titulo, produccion.anio, produccion.fecha_publicacion AS fecha_publicacion, tipo_produccion.descripcion AS tipo_produccion, linea_investigacion.descripcion AS linea_investigacion, proposito.descripcion AS proposito, institucion.nombre As institucion, produccion.cuenta_curriculum FROM produccion, tipo_produccion, linea_investigacion, proposito, institucion WHERE produccion.id_tipo_produccion = tipo_produccion.id AND produccion.id_linea_investigacion = linea_investigacion.id AND produccion.id_proposito = proposito.id AND produccion.id_institucion_avaladora = institucion.id";
        public Producciones(Profesor profesor)
        {
            this.profesor = profesor;
            conexion = new Conexion();
            InitializeComponent();
            comboBoxes = new List<ComboBox>();
            listBoxes = new List<ListBox>();
        }

        #region Functions
        private void cargarComboBox(OdbcDataReader resultado, ComboBox comboBox, string nombreAtributo)
        {
            comboBox.Items.Clear();
            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    ComboBoxItem item = new ComboBoxItem(resultado["id"].ToString(), resultado[nombreAtributo].ToString());
                    comboBox.Items.Add(item);
                }
            }
        }

        public void cargarTiposProduccion()
        {
            consulta = "SELECT * FROM tipo_produccion";
            cargarComboBox(conexion.ejecutarComando(consulta), cmbTipoProduccion, "descripcion");
        }

        public void cargarPropositos()
        {
            consulta = "SELECT * FROM proposito";
            cargarComboBox(conexion.ejecutarComando(consulta), cmbProposito, "descripcion");
        }

        public void cargarInstituciones()
        {
            consulta = "SELECT * FROM institucion";
            cargarComboBox(conexion.ejecutarComando(consulta), cmbInstituciones, "nombre");
        }

        public void cargarLineasInvestigacion()
        {
            consulta = "SELECT * FROM linea_investigacion";
            cargarComboBox(conexion.ejecutarComando(consulta), cmbLineaInvestigacion, "descripcion");
        }

        public void cargarProfesores()
        {
            cmbProfesores.Items.Clear();
            consulta = "SELECT id, nombre, apellido_paterno, apellido_materno, tipo_usuario, id_division, correo FROM profesor";
            resultado = conexion.ejecutarComando(consulta);
            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    Profesor prof = new Profesor(resultado["id"].ToString(), resultado["nombre"].ToString(), resultado["apellido_paterno"].ToString(),
                        resultado["apellido_materno"].ToString(), resultado["tipo_usuario"].ToString(), resultado["id_division"].ToString(), resultado["correo"].ToString());
                    cmbProfesores.Items.Add(prof);
                }
            }
        }

        private void cargarAnios()
        {
            for(int i = 2000; i < 2020; i++)
            {
                cmbAnios.Items.Add(i);
            }
        }

        private void limpiarCampos()
        {
            txtTitulo.Clear();
            listElaboradores.Items.Clear();
            listColaboradores.Items.Clear();
        }

        private void cargarDataGridProducciones(string consultaCarga)
        {
            dgvProducciones.Rows.Clear();
            resultado = conexion.ejecutarComando(consultaCarga);
            if (resultado.HasRows)
            {
                dgvProducciones.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                while (resultado.Read())
                {
                    DateTime date;
                    if(!DateTime.TryParseExact(resultado["fecha_publicacion"].ToString(), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                    {
                        date = DateTime.UtcNow.Date;
                    }
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dgvProducciones);
                    fila.Cells[0].Value = resultado["numero_registro"].ToString();
                    fila.Cells[1].Value = resultado["titulo"].ToString();
                    fila.Cells[2].Value = resultado["anio"].ToString();
                    //fila.Cells[3].Value = date.ToString("dd-MM-yyyy");
                    fila.Cells[3].Value = resultado["fecha_publicacion"].ToString();
                    fila.Cells[3].Value = resultado["fecha_publicacion"].ToString();
                    fila.Cells[4].Value = resultado["tipo_produccion"].ToString();
                    fila.Cells[5].Value = resultado["linea_investigacion"].ToString();
                    fila.Cells[6].Value = resultado["proposito"].ToString();
                    fila.Cells[7].Value = resultado["institucion"].ToString();
                    if(resultado["cuenta_curriculum"].ToString() == "1")
                        fila.Cells[8].Value = "Si";
                    else
                        fila.Cells[8].Value = "No";
                    dgvProducciones.Rows.Add(fila);
                }
            }
        }
        
        #endregion

        private void Producciones_Load(object sender, EventArgs e)
        {
            dtpFecha.MinDate = DateTime.Today;
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "yyyy-MM-dd";
            dgvProducciones.Columns["fecha_publicacion"].DefaultCellStyle.Format = "dd/MM/yyyy";
            cargarTiposProduccion();
            cargarPropositos();
            cargarInstituciones();
            cargarLineasInvestigacion();
            cargarProfesores();
            cargarAnios();
            comboBoxes.Add(cmbAnios);
            comboBoxes.Add(cmbInstituciones);
            comboBoxes.Add(cmbLineaInvestigacion);
            comboBoxes.Add(cmbProposito);
            comboBoxes.Add(cmbTipoProduccion);
            //listBoxes.Add(listElaboradores);
            listBoxes.Add(listColaboradores);
            cargarDataGridProducciones(consultaGeneral);
            ComboBoxItem tipo = new ComboBoxItem("tipo_produccion.descripcion", "Tipo produccion");
            cmbParametro.Items.Add(tipo);
            ComboBoxItem anio = new ComboBoxItem("produccion.anio", "Año");
            cmbParametro.Items.Add(anio);
            ComboBoxItem integrante = new ComboBoxItem("profesor_elabora_produccion", "Integrante o Elaborador");
            cmbParametro.Items.Add(integrante);
            ComboBoxItem linea_investigacion = new ComboBoxItem("linea_investigacion.descripcion", "Linea Investigacion");
            cmbParametro.Items.Add(linea_investigacion);
            rbMostrarTodo.Checked = true;
        }

        private void btnElaboradores_Click(object sender, EventArgs e)
        {
            if(cmbProfesores.SelectedItem == null)
            {
                MessageBox.Show("No has seleccionado ningun profesor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if((cmbProfesores.SelectedItem as Profesor).getID() == profesor.getID())
            {
                MessageBox.Show("No es necesario que te incluyas, ya estás incluido al realizar la produccion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (listElaboradores.Items.Contains(cmbProfesores.SelectedItem))
            {
                MessageBox.Show("Ya está incluido ese profesor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            listElaboradores.Items.Add(cmbProfesores.SelectedItem);
        }

        private void btnEliminarElaborador_Click(object sender, EventArgs e)
        {
            if(listElaboradores.SelectedItem == null)
            {
                MessageBox.Show("No has seleccionado ningun profesor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            listElaboradores.Items.RemoveAt(listElaboradores.SelectedIndex);
        }

        private void btnColaboradores_Click(object sender, EventArgs e)
        {
            if (cmbProfesores.SelectedItem == null)
            {
                MessageBox.Show("No has seleccionado ningun profesor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (listColaboradores.Items.Contains(cmbProfesores.SelectedItem))
            {
                MessageBox.Show("Ya está incluido ese profesor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            listColaboradores.Items.Add(cmbProfesores.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listColaboradores.SelectedItem == null)
            {
                MessageBox.Show("No has seleccionado ningun profesor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            listColaboradores.Items.RemoveAt(listColaboradores.SelectedIndex);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validator.validateComboBoxes(comboBoxes))
            {
                MessageBox.Show("Selecciona un valor para todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Validator.validateListBoxes(listBoxes))
            {
                MessageBox.Show("Agrega por lo menos un colaborador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!Validator.validateField(new Field(txtTitulo.Text, "text")))
            {
                MessageBox.Show("Agrega un título", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (chkCurriculum.CheckState == CheckState.Checked)
                cuenta_curriculum = 1;
            consulta = "INSERT INTO produccion (titulo, anio, fecha_publicacion, id_tipo_produccion, id_linea_investigacion, id_proposito, id_institucion_avaladora, cuenta_curriculum) VALUES('" +
                txtTitulo.Text + "', '" + cmbAnios.SelectedItem.ToString() + "', '" + dtpFecha.Value.Date.ToString("yyyy-MM-dd") + "', " +
                (cmbTipoProduccion.SelectedItem as ComboBoxItem).Value + ", " + (cmbLineaInvestigacion.SelectedItem as ComboBoxItem).Value + ", " +
                (cmbProposito.SelectedItem as ComboBoxItem).Value + ", " + (cmbInstituciones.SelectedItem as ComboBoxItem).Value + ", " + cuenta_curriculum + ")";
            resultado = conexion.ejecutarComando(consulta);
            if(resultado.RecordsAffected == 0)
            {
                MessageBox.Show("Error al guardar, consulta al administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            consulta = "INSERT INTO profesor_elabora_produccion (id_profesor, id_produccion) VALUES (" + profesor.getID() + ", (SELECT max(numero_registro) FROM produccion))";
            foreach (var item in listElaboradores.Items)
                consulta += ", (" + (item as Profesor).getID() + ", (SELECT max(numero_registro) FROM produccion))";
            resultado = conexion.ejecutarComando(consulta);
            consulta = "INSERT INTO profesor_colabora_produccion (id_profesor, id_produccion) VALUES";
            foreach (var item in listColaboradores.Items)
                consulta += "(" + (item as Profesor).getID() + ", (SELECT max(numero_registro) FROM produccion)),";
            consulta = consulta.Substring(0, consulta.Length - 1);
            resultado = conexion.ejecutarComando(consulta);
            MessageBox.Show("Produccion guardada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiarCampos();
            cargarDataGridProducciones(consultaGeneral);
        }

        private void dbFiltrar_CheckedChanged(object sender, EventArgs e)
        {
            if (dbFiltrar.Checked)
            {
                txtBuscar.Enabled = true;
                cmbParametro.Enabled = true;
                btnBuscar.Enabled = true;
                btnBuscarTodo.Enabled = true;
            }
        }

        private void rbMostrarTodo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMostrarTodo.Checked)
            {
                txtBuscar.Enabled = false;
                cmbParametro.Enabled = false;
                btnBuscar.Enabled = false;
                btnBuscarTodo.Enabled = false;
                cargarDataGridProducciones(consultaGeneral);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(cmbParametro.SelectedItem == null)
            {
                MessageBox.Show("Primero selecciona el parámetro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(txtBuscar.Text == "")
            {
                MessageBox.Show("Escribe el valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cmbParametro.SelectedItem.ToString() != "Integrante o Elaborador")
            {
                consulta = "SELECT produccion.numero_registro, produccion.titulo, produccion.anio, produccion.fecha_publicacion AS fecha_publicacion, tipo_produccion.descripcion AS tipo_produccion, linea_investigacion.descripcion AS linea_investigacion, proposito.descripcion AS proposito, institucion.nombre As institucion, produccion.cuenta_curriculum " +
                    "FROM produccion, tipo_produccion, linea_investigacion, proposito, institucion " +
                    "WHERE produccion.id_tipo_produccion = tipo_produccion.id " +
                    "AND produccion.id_linea_investigacion = linea_investigacion.id " +
                    "AND produccion.id_proposito = proposito.id " +
                    "AND produccion.id_institucion_avaladora = institucion.id " +
                    "AND " + (cmbParametro.SelectedItem as ComboBoxItem).Value + " = '" + txtBuscar.Text + "'";
            }
            else
            {
                consulta = "SELECT produccion.numero_registro, produccion.titulo, produccion.anio, produccion.fecha_publicacion AS fecha_publicacion, " +
                    "tipo_produccion.descripcion AS tipo_produccion, linea_investigacion.descripcion AS linea_investigacion, " +
                    "proposito.descripcion AS proposito, institucion.nombre As institucion, produccion.cuenta_curriculum " +
                    "FROM produccion, tipo_produccion, linea_investigacion, proposito, institucion, profesor_elabora_produccion, profesor " +
                    "WHERE produccion.id_tipo_produccion = tipo_produccion.id AND produccion.id_linea_investigacion = linea_investigacion.id " +
                    "AND produccion.id_proposito = proposito.id AND produccion.id_institucion_avaladora = institucion.id " +
                    "AND produccion.numero_registro = profesor_elabora_produccion.id_produccion " +
                    "AND profesor.id = profesor_elabora_produccion.id_profesor " +
                    "AND (SELECT CONCAT(profesor.nombre, ' ', profesor.apellido_paterno, ' ', profesor.apellido_materno)) LIKE '%" + txtBuscar.Text + "%'";
            }
            cargarDataGridProducciones(consulta);
        }

        private void btnBuscarTodo_Click(object sender, EventArgs e)
        {
            Buscador buscador = new Buscador();
            var result = buscador.ShowDialog();
            if(result == DialogResult.OK)
                cargarDataGridProducciones(buscador.consulta);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
