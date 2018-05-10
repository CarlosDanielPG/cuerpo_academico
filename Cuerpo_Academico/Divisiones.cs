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
    public partial class Divisiones : Form
    {
        private string consulta;
        private Conexion conexion;
        private OdbcDataReader resultado;

        public Divisiones()
        {
            conexion = new Conexion();
            InitializeComponent();
            cargarDataGridViewDivisiones();
        }

        #region Functions

        private void cargarDataGridViewDivisiones()
        {
            dgvDivisiones.Rows.Clear();
            consulta = "SELECT * FROM division";
            try
            {
                resultado = conexion.ejecutarComando(consulta);
                if (resultado.HasRows)
                {
                    while (resultado.Read())
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dgvDivisiones);
                        fila.Cells[0].Value = resultado["id"].ToString();
                        fila.Cells[1].Value = resultado["nombre"].ToString();
                        dgvDivisiones.Rows.Add(fila);
                    }
                }
            }
            catch (OdbcException ex)
            {

            }
        }
        
        private void Limpiar()
        {
            txtNombre.Clear();
        }

        private bool validarCampos()
        {
            if (txtNombre.Text == "")
                return false;
            return true;
        }
        #endregion

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtID.Text == "")
            {
                MessageBox.Show("Ingresa el ID a buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            consulta = "SELECT * FROM division WHERE id = " + txtID.Text;
            resultado = conexion.ejecutarComando(consulta);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validarCampos())
            {
                MessageBox.Show("Faltan llenar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            consulta = "INSERT INTO division (nombre) VALUES('" + txtNombre.Text + "');";
            resultado = conexion.ejecutarComando(consulta);
            if (resultado.RecordsAffected > 0)
            {
                MessageBox.Show("División guardada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Limpiar();
            cargarDataGridViewDivisiones();
        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
