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
    public partial class Carreras : Form
    {
        private string consulta;
        private Conexion conexion;
        private OdbcDataReader resultado;

        public Carreras()
        {
            conexion = new Conexion();
            InitializeComponent();
        }

        private void Carreras_Load(object sender, EventArgs e)
        {
            cargarDataGridViewCarreras();
            cargarTabCarreras();
        }

        #region FUNCTIONS

        private void cargarDataGridViewCarreras()
        {
            dgvCarreras.Rows.Clear();
            consulta = "SELECT carrera.id AS id, carrera.nombre AS nombre, division.nombre AS division, nivel_carrera.nombre AS nivel FROM carrera, division, nivel_carrera WHERE carrera.id_division = division.id AND carrera.id_nivel = nivel_carrera.id";        
            try
            {
                resultado = conexion.ejecutarComando(consulta);
                if (resultado.HasRows)
                {
                    while (resultado.Read())
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dgvCarreras);
                        fila.Cells[0].Value = resultado["id"].ToString();
                        fila.Cells[1].Value = resultado["nombre"].ToString();
                        fila.Cells[2].Value = resultado["division"].ToString();
                        fila.Cells[3].Value = resultado["nivel"].ToString();
                        dgvCarreras.Rows.Add(fila);
                    }
                }
            }
            catch (OdbcException)
            {

            }
        }

        private void cargarComboBox(OdbcDataReader resultado, ComboBox comboBox)
        {
            comboBox.Items.Clear();
            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    ComboBoxItem item = new ComboBoxItem(resultado["id"].ToString(), resultado["nombre"].ToString());
                    comboBox.Items.Add(item);
                }
            }
        }

        private void cargarTabCarreras()
        {
            consulta = "SELECT * FROM nivel_carrera";
            cargarComboBox(conexion.ejecutarComando(consulta), cmbNivel);

            consulta = "SELECT * FROM division";
            cargarComboBox(conexion.ejecutarComando(consulta), cmbDivisiones);
        }

        public void cargarCmbDivisiones()
        {
            consulta = "SELECT * FROM division";
            cargarComboBox(conexion.ejecutarComando(consulta), cmbDivisiones);
        }

        private void LimpiarCarrera()
        {
            txtNombre.Clear();
        }

        private bool validarCampos()
        {
            if (txtNombre.Text == "" || cmbNivel.SelectedItem == null || cmbDivisiones.SelectedItem == null)
                return false;
            return true;
        }

        #endregion

        #region BUTTONS

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<ComboBox> comboBoxes = new List<ComboBox>();

            comboBoxes.Add(cmbDivisiones);
            comboBoxes.Add(cmbNivel);

            if(txtNombre.Text == "" || !Validator.validateComboBoxes(comboBoxes))
            {
                MessageBox.Show("Faltan llenar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            consulta = "INSERT INTO carrera (nombre, id_nivel, id_division) VALUES('" + txtNombre.Text + "', " + (cmbNivel.SelectedItem as ComboBoxItem).Value.ToString() + ", " + (cmbDivisiones.SelectedItem as ComboBoxItem).Value.ToString() + ");";
            try
            {
                resultado = conexion.ejecutarComando(consulta);

                if (resultado.RecordsAffected > 0)
                {
                    MessageBox.Show("Carrera guardada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                cargarDataGridViewCarreras();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Ya existe una carrera con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            consulta = "SELECT * FROM carrera WHERE id = " + txtID.Text;

            resultado = conexion.ejecutarComando(consulta);

            if (!resultado.HasRows)
            {
                MessageBox.Show("No se ha encontrado la carrera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            txtNombre.Text = resultado["nombre"].ToString();

            int index = 0;

            foreach (var item in cmbDivisiones.Items)
            {
                if ((item as ComboBoxItem).Value == resultado["id_division"].ToString())
                    cmbDivisiones.SelectedIndex = index;
                index++;
            }

            index = 0;

            foreach (var item in cmbNivel.Items)
            {
                if ((item as ComboBoxItem).Value == resultado["id_nivel"].ToString())
                    cmbNivel.SelectedIndex = index;
                index++;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCarrera();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!Validator.validateID(txtID.Text))
            {
                MessageBox.Show("El ID debe ser numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            consulta = "SELECT nombre FROM carrera WHERE id = " + txtID.Text;

            resultado = conexion.ejecutarComando(consulta);

            if (!resultado.HasRows)
            {
                MessageBox.Show("No se ha encontrado la carrera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("¿Seguro que deseas eliminar a " + resultado["nombre"].ToString() + "?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                consulta = "DELETE FROM carrera WHERE id = " + txtID.Text;
                try
                {
                    resultado = conexion.ejecutarComando(consulta);

                    if (resultado.RecordsAffected > 0)
                    {
                        MessageBox.Show("Carrera eliminada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarCarrera();

                        cargarDataGridViewCarreras();
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

            if(!validarCampos())
            {
                MessageBox.Show("Faltan llenar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            consulta = "SELECT nombre FROM carrera WHERE id = " + txtID.Text;

            resultado = conexion.ejecutarComando(consulta);

            if (!resultado.HasRows)
            {
                MessageBox.Show("No se ha encontrado la carrera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }            

            if (MessageBox.Show("¿Seguro que deseas modificar a " + resultado["nombre"].ToString() + "?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                consulta = "UPDATE carrera SET nombre = '" + txtNombre.Text + "', id_nivel = " + (cmbNivel.SelectedItem as ComboBoxItem).Value.ToString() + ", id_division = " + (cmbDivisiones.SelectedItem as ComboBoxItem).Value.ToString() + " WHERE  id = " + txtID.Text;
                resultado = conexion.ejecutarComando(consulta);
                try
                {
                    if (resultado.RecordsAffected > 0)
                    {
                        MessageBox.Show("Carrera modificada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCarrera();
                        cargarDataGridViewCarreras();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Ya existe una carrera con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        #endregion
    }
}
