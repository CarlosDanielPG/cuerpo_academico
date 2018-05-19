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
    public partial class Instituciones : Form
    {
        private string consulta;
        private Conexion conexion;
        private OdbcDataReader resultado;

        public Instituciones()
        {
            conexion = new Conexion();
            InitializeComponent();
            cargarDataGridView();
        }

        #region Functions

        private void cargarDataGridView()
        {
            dgvInstituciones.Rows.Clear();
            consulta = "SELECT * FROM institucion";
            try
            {
                resultado = conexion.ejecutarComando(consulta);
                if (resultado.HasRows)
                {
                    while (resultado.Read())
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dgvInstituciones);
                        fila.Cells[0].Value = resultado["id"].ToString();
                        fila.Cells[1].Value = resultado["nombre"].ToString();
                        dgvInstituciones.Rows.Add(fila);
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
            consulta = "INSERT INTO institucion (nombre) VALUES('" + txtNombre.Text + "');";
            resultado = conexion.ejecutarComando(consulta);
            try
            {
                if (resultado.RecordsAffected > 0)
                {
                    MessageBox.Show("Institución guardada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Limpiar();
                cargarDataGridView();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Ya existe una institución con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!Validator.validateID(txtID.Text))
            {
                MessageBox.Show("El ID debe ser numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            consulta = "SELECT * FROM institucion WHERE id = " + txtID.Text;
            resultado = conexion.ejecutarComando(consulta);
            if (!resultado.HasRows)
            {
                MessageBox.Show("No se ha encontrado la institución", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            consulta = "SELECT nombre FROM institucion WHERE id = " + txtID.Text;
            resultado = conexion.ejecutarComando(consulta);
            if (!resultado.HasRows)
            {
                MessageBox.Show("No se ha encontrado la institución", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("¿Seguro que deseas eliminar " + resultado["nombre"].ToString() + "?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                consulta = "DELETE FROM institucion WHERE id = " + txtID.Text;
                try
                {

                    resultado = conexion.ejecutarComando(consulta);
                    if (resultado.RecordsAffected > 0)
                    {
                        MessageBox.Show("Institución eliminada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        cargarDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("No es posible eliminar, tiene registros relacionados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
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
            consulta = "SELECT nombre FROM institucion WHERE id = " + txtID.Text;
            resultado = conexion.ejecutarComando(consulta);
            if (!resultado.HasRows)
            {
                MessageBox.Show("No se ha encontrado la institución", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!Validator.validateField(new Field(txtNombre.Text, "text")))
            {
                MessageBox.Show("Se debe agregar un nuevo nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("¿Seguro que deseas modificar a " + resultado["nombre"].ToString() + "?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                consulta = "UPDATE institucion SET nombre = '" + txtNombre.Text + "' WHERE  id = " + txtID.Text;
                resultado = conexion.ejecutarComando(consulta);
                try
                {
                    if (resultado.RecordsAffected > 0)
                    {
                        MessageBox.Show("Institución modificada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        cargarDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Ya existe una institución con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
