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

namespace Cuerpo_Academico
{
    public partial class Buscador : Form
    {
        public string consulta;
        private Conexion conexion;
        private OdbcDataReader resultado;
        public Buscador()
        {
            conexion = new Conexion();
            InitializeComponent();
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
            cargarComboBox(conexion.ejecutarComando(consulta), cmbTipo, "descripcion");
        }

        private void cargarAnios()
        {
            consulta = "SELECT anio FROM produccion GROUP BY anio";
            resultado = conexion.ejecutarComando(consulta);
            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    cmbAnio.Items.Add(resultado["anio"].ToString());
                }
            }
        }

        public void cargarProfesores()
        {
            cmbIntegrantes.Items.Clear();
            consulta = "SELECT id, nombre, apellido_paterno, apellido_materno, tipo_usuario, id_division, correo FROM profesor";
            resultado = conexion.ejecutarComando(consulta);
            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    Profesor prof = new Profesor(resultado["id"].ToString(), resultado["nombre"].ToString(), resultado["apellido_paterno"].ToString(),
                        resultado["apellido_materno"].ToString(), resultado["tipo_usuario"].ToString(), resultado["id_division"].ToString(), resultado["correo"].ToString());
                    cmbIntegrantes.Items.Add(prof);
                }
            }
        }

        public void cargarLineasInvestigacion()
        {
            consulta = "SELECT * FROM linea_investigacion";
            cargarComboBox(conexion.ejecutarComando(consulta), cmbLineaInvestigacion, "descripcion");
        }

        #endregion

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(cmbAnio.SelectedItem == null && cmbIntegrantes.SelectedItem == null && cmbLineaInvestigacion.SelectedItem == null  && cmbTipo.SelectedItem == null)
            {
                MessageBox.Show("Ingresa al menos un valor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cmbIntegrantes.SelectedItem != null)
                consulta = "SELECT produccion.numero_registro, produccion.titulo, produccion.anio, produccion.fecha_publicacion AS fecha_publicacion, " +
                    "tipo_produccion.descripcion AS tipo_produccion, linea_investigacion.descripcion AS linea_investigacion, " +
                    "proposito.descripcion AS proposito, institucion.nombre As institucion, produccion.cuenta_curriculum " +
                    "FROM produccion, tipo_produccion, linea_investigacion, proposito, institucion, profesor_elabora_produccion, profesor, profesor_colabora_produccion " +
                    "WHERE produccion.id_tipo_produccion = tipo_produccion.id AND produccion.id_linea_investigacion = linea_investigacion.id " +
                    "AND produccion.id_proposito = proposito.id AND produccion.id_institucion_avaladora = institucion.id " +
                    "AND produccion.numero_registro = profesor_elabora_produccion.id_produccion " +
                    "AND (profesor.id = profesor_elabora_produccion.id_profesor OR profesor.id = profesor_colabora_produccion.id_profesor) " +
                    "AND profesor.id = " + (cmbIntegrantes.SelectedItem as Profesor).getID() + " ";
            else
                consulta = "SELECT produccion.numero_registro, produccion.titulo, produccion.anio, produccion.fecha_publicacion AS fecha_publicacion, tipo_produccion.descripcion AS tipo_produccion, linea_investigacion.descripcion AS linea_investigacion, proposito.descripcion AS proposito, institucion.nombre As institucion, produccion.cuenta_curriculum " +
                     "FROM produccion, tipo_produccion, linea_investigacion, proposito, institucion " +
                     "WHERE produccion.id_tipo_produccion = tipo_produccion.id " +
                     "AND produccion.id_linea_investigacion = linea_investigacion.id " +
                     "AND produccion.id_proposito = proposito.id " +
                     "AND produccion.id_institucion_avaladora = institucion.id ";
            if (cmbAnio.SelectedItem != null)
                consulta += "AND produccion.anio = '" + cmbAnio.SelectedItem.ToString() + "' ";
            if(cmbLineaInvestigacion.SelectedItem != null)
                consulta += "AND linea_investigacion.id = " + (cmbLineaInvestigacion.SelectedItem as ComboBoxItem).Value + " ";
            if (cmbTipo.SelectedItem != null)
                consulta += "AND tipo_produccion.id = " + (cmbTipo.SelectedItem as ComboBoxItem).Value + " ";
            if (cmbIntegrantes.SelectedItem != null)
                consulta += "GROUP BY produccion.numero_registro ";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Buscador_Load(object sender, EventArgs e)
        {
            cargarAnios();
            cargarLineasInvestigacion();
            cargarProfesores();
            cargarTiposProduccion();
        }
    }
}
