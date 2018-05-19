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
    public partial class Propositos : Form
    {
        private string consulta;
        private Conexion conexion;
        private OdbcDataReader resultado;

        public Propositos()
        {
            conexion = new Conexion();
            InitializeComponent();
            cargarDataGridViewPropositos();
        }

        private void Limpiar()
        {
            txtDescripcion.Clear();
        }

        private void cargarDataGridViewPropositos()
        {
            dgvPropositos.Rows.Clear();
            consulta = "SELECT * FROM proposito";
            try
            {
                resultado = conexion.ejecutarComando(consulta);

                if (resultado.HasRows)
                {
                    while (resultado.Read())
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dgvPropositos);
                        fila.Cells[0].Value = resultado["id"].ToString();
                        fila.Cells[1].Value = resultado["descripcion"].ToString();
                        dgvPropositos.Rows.Add(fila);
                    }
                }
            }
            catch (OdbcException)
            {

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validator.validateField(new Field(txtDescripcion.Text, "text")))
            {
                MessageBox.Show("Inserte una descripcion válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            consulta = "INSERT INTO proposito (descripcion) VALUES('" + txtDescripcion.Text + "');";

            resultado = conexion.ejecutarComando(consulta);
            try
            {
            if (resultado.RecordsAffected > 0)
            {
                MessageBox.Show("Proposito guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Limpiar();

            cargarDataGridViewPropositos();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Ya existe un propósito con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            consulta = "SELECT * FROM proposito WHERE id = " + txtID.Text;

            resultado = conexion.ejecutarComando(consulta);

            if (!resultado.HasRows)
            {
                MessageBox.Show("No se ha encontrado el proposito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            txtDescripcion.Text = resultado["descripcion"].ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!Validator.validateID(txtID.Text))
            {
                MessageBox.Show("El ID debe ser numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            consulta = "SELECT descripcion FROM proposito WHERE id = " + txtID.Text;

            resultado = conexion.ejecutarComando(consulta);

            if (!resultado.HasRows)
            {
                MessageBox.Show("No se ha encontrado el proposito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("¿Seguro que deseas eliminar a " + resultado["descripcion"].ToString() + "?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                consulta = "DELETE FROM proposito WHERE id = " + txtID.Text;
                try
                {
                    resultado = conexion.ejecutarComando(consulta);

                    if (resultado.RecordsAffected > 0)
                    {
                        MessageBox.Show("Proposito eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpiar();

                        cargarDataGridViewPropositos();
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

            consulta = "SELECT descripcion FROM proposito WHERE id = " + txtID.Text;

            resultado = conexion.ejecutarComando(consulta);

            if (!resultado.HasRows)
            {
                MessageBox.Show("No se ha encontrado el proposito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!Validator.validateField(new Field(txtDescripcion.Text, "text")))
            {
                MessageBox.Show("Se debe agregar una nueva descripcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("¿Seguro que deseas modificar a " + resultado["descripcion"].ToString() + "?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                consulta = "UPDATE proposito SET descripcion = '" + txtDescripcion.Text + "' WHERE  id = " + txtID.Text;

                resultado = conexion.ejecutarComando(consulta);
                try
                {
                    if (resultado.RecordsAffected > 0)
                    {
                        MessageBox.Show("Proposito modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpiar();

                        cargarDataGridViewPropositos();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Ya existe un propósito con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
