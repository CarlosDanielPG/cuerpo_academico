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
    public partial class Curriculum : Form
    {
        private string consulta;
        private Conexion conexion;
        private OdbcDataReader resultado;
        private string id;
        public Curriculum(string id)
        {
            this.id = id;
            conexion = new Conexion();
            InitializeComponent();
        }

        private void Curriculum_Load(object sender, EventArgs e)
        {
            consulta = "SELECT * FROM produccion LEFT JOIN profesor_colabora_produccion ON(produccion.numero_registro = profesor_colabora_produccion.id_produccion) LEFT JOIN profesor_elabora_produccion ON(produccion.numero_registro = profesor_elabora_produccion.id_produccion) LEFT JOIN profesor ON (profesor.id = profesor_colabora_produccion.id_profesor OR profesor.id = profesor_elabora_produccion.id_profesor) WHERE profesor.id = " + id + " AND produccion.cuenta_curriculum = 1 GROUP BY produccion.titulo";
            resultado = conexion.ejecutarComando(consulta);
            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dgvCurriculum);
                    fila.Cells[0].Value = resultado["numero_registro"].ToString();
                    fila.Cells[1].Value = resultado["titulo"].ToString();
                    fila.Cells[2].Value = resultado["anio"].ToString();
                    fila.Cells[3].Value = resultado["fecha_publicacion"].ToString();
                    dgvCurriculum.Rows.Add(fila);
                }
            }
            else
            {
                MessageBox.Show("No se encuentra al profesor o no tiene producciones que cuenten en curriculum", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
