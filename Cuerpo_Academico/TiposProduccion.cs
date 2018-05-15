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
    public partial class TiposProduccion : Form
    {
        private string consulta;
        private Conexion conexion;
        private OdbcDataReader resultado;

        public TiposProduccion()
        {
            conexion = new Conexion();
            InitializeComponent();
            cargarDataGridViewDivisiones();
        }

        #region Functions

        private void cargarDataGridViewDivisiones()
        {
            dgvDivisiones.Rows.Clear();
            consulta = "SELECT * FROM tipo_produccion";
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
                        fila.Cells[1].Value = resultado["descripcion"].ToString();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validator.validateField(new Field(txtNombre.Text, "text")))
            {
                MessageBox.Show("Faltan llenar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            consulta = "INSERT INTO tipo_produccion (descripcion) VALUES('" + txtNombre.Text + "');";
            resultado = conexion.ejecutarComando(consulta);
            if (resultado.RecordsAffected > 0)
            {
                MessageBox.Show("Tipo de producción guardada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Limpiar();
            cargarDataGridViewDivisiones();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!Validator.validateID(txtID.Text))
            {
                MessageBox.Show("El ID debe ser numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            consulta = "SELECT * FROM tipo_produccion WHERE id = " + txtID.Text;
            resultado = conexion.ejecutarComando(consulta);
            if (!resultado.HasRows)
            {
                MessageBox.Show("No se ha encontrado el tipo de producción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            txtNombre.Text = resultado["descripcion"].ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!Validator.validateID(txtID.Text))
            {
                MessageBox.Show("El ID debe ser numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            consulta = "SELECT descripcion FROM tipo_produccion WHERE id = " + txtID.Text;
            resultado = conexion.ejecutarComando(consulta);
            if (!resultado.HasRows)
            {
                MessageBox.Show("No se ha encontrado el tipo de producción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("¿Seguro que deseas eliminar " + resultado["descripcion"].ToString() + "?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                consulta = "DELETE FROM tipo_produccion WHERE id = " + txtID.Text;
                resultado = conexion.ejecutarComando(consulta);
                if (resultado.RecordsAffected > 0)
                {
                    MessageBox.Show("Tipo de producción eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            consulta = "SELECT descripcion FROM tipo_produccion WHERE id = " + txtID.Text;
            resultado = conexion.ejecutarComando(consulta);
            if (!resultado.HasRows)
            {
                MessageBox.Show("No se ha encontrado el tipo de producción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!Validator.validateField(new Field(txtNombre.Text, "text")))
            {
                MessageBox.Show("Se debe agregar una nueva descripción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("¿Seguro que deseas modificar a " + resultado["descripcion"].ToString() + "?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                consulta = "UPDATE tipo_produccion SET descripcion = '" + txtNombre.Text + "' WHERE  id = " + txtID.Text;
                resultado = conexion.ejecutarComando(consulta);
                if (resultado.RecordsAffected > 0)
                {
                    MessageBox.Show("Tipo de producción modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    cargarDataGridViewDivisiones();
                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
