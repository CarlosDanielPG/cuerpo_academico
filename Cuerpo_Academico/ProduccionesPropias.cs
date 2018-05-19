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

namespace Cuerpo_Academico
{
    public partial class ProduccionesPropias : Form
    {
        private string consulta;
        private Conexion conexion;
        private OdbcDataReader resultado;
        Profesor profesor;
        public ProduccionesPropias(Profesor profesor)
        {
            this.profesor = profesor;
            conexion = new Conexion();
            InitializeComponent();
        }

        public void cargarDataGridProducciones()
        {
            dgvProducciones.Rows.Clear();
            consulta = "SELECT produccion.numero_registro, produccion.titulo, produccion.anio, produccion.fecha_publicacion AS fecha_publicacion, " +
                   "tipo_produccion.descripcion AS tipo_produccion, linea_investigacion.descripcion AS linea_investigacion, " +
                   "proposito.descripcion AS proposito, institucion.nombre As institucion, produccion.cuenta_curriculum " +
                   "FROM produccion, tipo_produccion, linea_investigacion, proposito, institucion, profesor_colabora_produccion, profesor " +
                   "WHERE produccion.id_tipo_produccion = tipo_produccion.id AND produccion.id_linea_investigacion = linea_investigacion.id " +
                   "AND produccion.id_proposito = proposito.id AND produccion.id_institucion_avaladora = institucion.id " +
                   "AND produccion.numero_registro = profesor_colabora_produccion.id_produccion " +
                   "AND profesor.id = profesor_colabora_produccion.id_profesor " +
                   "AND profesor.id = " + profesor.getID();
            resultado = conexion.ejecutarComando(consulta);
            if (resultado.HasRows)
            {
                dgvProducciones.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                while (resultado.Read())
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dgvProducciones);
                    fila.Cells[0].Value = resultado["numero_registro"].ToString();
                    fila.Cells[1].Value = resultado["titulo"].ToString();
                    fila.Cells[2].Value = resultado["anio"].ToString();
                    fila.Cells[3].Value = resultado["fecha_publicacion"].ToString().Substring(0, 10);
                    fila.Cells[4].Value = resultado["tipo_produccion"].ToString();
                    fila.Cells[5].Value = resultado["linea_investigacion"].ToString();
                    fila.Cells[6].Value = resultado["proposito"].ToString();
                    fila.Cells[7].Value = resultado["institucion"].ToString();
                    if (resultado["cuenta_curriculum"].ToString() == "1")
                        fila.Cells[8].Value = "Si";
                    else
                        fila.Cells[8].Value = "No";
                    dgvProducciones.Rows.Add(fila);
                }
            }
        }

        public void cargarDataGridProduccionesElabora()
        {
            dgvElaborando.Rows.Clear();
            consulta = "SELECT produccion.numero_registro, produccion.titulo, produccion.anio, produccion.fecha_publicacion AS fecha_publicacion, " +
                   "tipo_produccion.descripcion AS tipo_produccion, linea_investigacion.descripcion AS linea_investigacion, " +
                   "proposito.descripcion AS proposito, institucion.nombre As institucion, produccion.cuenta_curriculum " +
                   "FROM produccion, tipo_produccion, linea_investigacion, proposito, institucion, profesor_elabora_produccion, profesor " +
                   "WHERE produccion.id_tipo_produccion = tipo_produccion.id AND produccion.id_linea_investigacion = linea_investigacion.id " +
                   "AND produccion.id_proposito = proposito.id AND produccion.id_institucion_avaladora = institucion.id " +
                   "AND produccion.numero_registro = profesor_elabora_produccion.id_produccion " +
                   "AND profesor.id = profesor_elabora_produccion.id_profesor " +
                   "AND profesor.id = " + profesor.getID();
            resultado = conexion.ejecutarComando(consulta);
            if (resultado.HasRows)
            {
                dgvElaborando.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                while (resultado.Read())
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dgvElaborando);
                    fila.Cells[0].Value = resultado["numero_registro"].ToString();
                    fila.Cells[1].Value = resultado["titulo"].ToString();
                    fila.Cells[2].Value = resultado["anio"].ToString();
                    fila.Cells[3].Value = resultado["fecha_publicacion"].ToString().Substring(0, 10);
                    fila.Cells[4].Value = resultado["tipo_produccion"].ToString();
                    fila.Cells[5].Value = resultado["linea_investigacion"].ToString();
                    fila.Cells[6].Value = resultado["proposito"].ToString();
                    fila.Cells[7].Value = resultado["institucion"].ToString();
                    if (resultado["cuenta_curriculum"].ToString() == "1")
                        fila.Cells[8].Value = "Si";
                    else
                        fila.Cells[8].Value = "No";
                    dgvElaborando.Rows.Add(fila);
                }
            }
        }

        private void ProduccionesPropias_Load(object sender, EventArgs e)
        {
            cargarDataGridProducciones();
            cargarDataGridProduccionesElabora();
        }

        private void btnCurriculum_Click(object sender, EventArgs e)
        {
            Curriculum curriculum = new Curriculum(profesor.getID().ToString());
            curriculum.ShowDialog();
        }
    }
}
