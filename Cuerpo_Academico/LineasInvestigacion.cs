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
    public partial class LineasInvestigacion : Form
    {
        private string consulta;
        private Conexion conexion;
        private OdbcDataReader resultado;

        public LineasInvestigacion()
        {
            conexion = new Conexion();
            InitializeComponent();
            cargarDataGridViewDivisiones();
        }

        #region Functions

        private void cargarDataGridViewDivisiones()
        {
            dgvDivisiones.Rows.Clear();
            consulta = "SELECT * FROM linea_investigacion";
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
            if (!Validator.validateID(txtID.Text))
            {
                MessageBox.Show("El ID debe ser numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            consulta = "SELECT * FROM linea_investigacion WHERE id = " + txtID.Text;
            resultado = conexion.ejecutarComando(consulta);
            if (!resultado.HasRows)
            {
                MessageBox.Show("No se ha encontrado la linea de investigacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            txtNombre.Text = resultado["nombre"].ToString();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!Validator.validateID(txtID.Text))
            {
                MessageBox.Show("El ID debe ser numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            consulta = "SELECT nombre FROM linea_investigacion WHERE id = " + txtID.Text;
            resultado = conexion.ejecutarComando(consulta);
            if (!resultado.HasRows)
            {
                MessageBox.Show("No se ha encontrado la linea de investigación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("¿Seguro que deseas eliminar a " + resultado["nombre"].ToString() + "?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                consulta = "DELETE FROM linea_investigacion WHERE id = " + txtID.Text;
                resultado = conexion.ejecutarComando(consulta);
                if (resultado.RecordsAffected > 0)
                {
                    MessageBox.Show("Linea de investigación eliminada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    cargarDataGridViewDivisiones();
                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!Validator.validateID(txtID.Text))
            {
                MessageBox.Show("El ID debe ser numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            consulta = "SELECT nombre FROM linea_division WHERE id = " + txtID.Text;
            resultado = conexion.ejecutarComando(consulta);
            if (!resultado.HasRows)
            {
                MessageBox.Show("No se ha encontrado la linea de investigación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!Validator.validateField(new Field(txtNombre.Text, "text")))
            {
                MessageBox.Show("Se debe agregar un nuevo nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("¿Seguro que deseas modificar a " + resultado["nombre"].ToString() + "?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                consulta = "UPDATE linea_investigacion SET nombre = '" + txtNombre.Text + "' WHERE  id = " + txtID.Text;
                resultado = conexion.ejecutarComando(consulta);
                if (resultado.RecordsAffected > 0)
                {
                    MessageBox.Show("Linea de investigación modificada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    cargarDataGridViewDivisiones();
                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (!Validator.validateField(new Field(txtNombre.Text, "text")))
            {
                MessageBox.Show("Faltan llenar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            consulta = "INSERT INTO linea_investigacion (nombre) VALUES('" + txtNombre.Text + "');";
            resultado = conexion.ejecutarComando(consulta);
            if (resultado.RecordsAffected > 0)
            {
                MessageBox.Show("Linea de investigación guardada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Limpiar();
            cargarDataGridViewDivisiones();
        }
    }
}
