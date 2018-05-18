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
    public partial class Profesores : Form
    {
        private string consulta;
        private Conexion conexion;
        private OdbcDataReader resultado;
        
        public Profesores()
        {
            conexion = new Conexion();
            InitializeComponent();
        }

        private void Profesores_Load(object sender, EventArgs e)
        {
            cargarTabProfesores();
            createListFields();
        }

        #region Functions

        private void cargarTabProfesores()
        {
            consulta = "SELECT * FROM tipo_usuario";
            cargarComboBox(conexion.ejecutarComando(consulta), cmbTipoUsuario);

            consulta = "SELECT * FROM division";
            cargarComboBox(conexion.ejecutarComando(consulta), cmbDivision);

            consulta = "SELECT * FROM grado";
            cargarComboBox(conexion.ejecutarComando(consulta), cmbGrados);

            cargarDataGridViewProfesores();
        }

        public void cargarCmbDivisiones()
        {
            consulta = "SELECT * FROM division";
            cargarComboBox(conexion.ejecutarComando(consulta), cmbDivision);
        }

        private void cargarDataGridViewProfesores()
        {
            dgvProfesores.Rows.Clear();
            consulta = "SELECT profesor.id AS id, profesor.nombre, profesor.apellido_paterno, profesor.apellido_materno, tipo_usuario.nombre AS tipo_usuario, division.nombre AS division, profesor.correo FROM profesor, tipo_usuario, division WHERE profesor.tipo_usuario = tipo_usuario.id AND profesor.id_division = division.id";
            try
            {
                resultado = conexion.ejecutarComando(consulta);
                if (resultado.HasRows)
                {
                    while (resultado.Read())
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dgvProfesores);
                        fila.Cells[0].Value = resultado["id"].ToString();
                        fila.Cells[1].Value = resultado["nombre"].ToString();
                        fila.Cells[2].Value = resultado["apellido_paterno"].ToString();
                        fila.Cells[3].Value = resultado["apellido_materno"].ToString();
                        fila.Cells[4].Value = resultado["tipo_usuario"].ToString();
                        fila.Cells[5].Value = resultado["division"].ToString();
                        fila.Cells[6].Value = resultado["correo"].ToString();
                        dgvProfesores.Rows.Add(fila);
                    }
                }
            }
            catch (OdbcException ex)
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

        private void LimpiarProfesor()
        {
            txtNombre.Clear();
            txtApellidoP.Clear();
            txtApellidoM.Clear();
            txtCorreo.Clear();
            listGrados.Items.Clear();
            txtPassword.Clear();
        }

        private bool validarID()
        {
            if (txtID.Text == "")
                return false;
            int i;
            if(int.TryParse(txtID.Text, out i))
                return true;
            return false;
        }

        private List<Field> createListFields()
        {
            List<Field> listFields = new List<Field>();
            Field name = new Field(txtNombre.Text, "text");
            listFields.Add(name);
            Field fatherSurname = new Field(txtApellidoP.Text, "text");
            listFields.Add(fatherSurname);
            Field motherSurname = new Field(txtApellidoM.Text, "text");
            listFields.Add(motherSurname);
            Field email = new Field(txtCorreo.Text, "email");
            listFields.Add(email);
            Field password = new Field(txtPassword.Text, "password");
            listFields.Add(password);
            return listFields;
        }

        #endregion

        #region Buttons

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarProfesor();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<ComboBox> comboBoxes = new List<ComboBox>();
            List<ListBox> listBoxes = new List<ListBox>();
            comboBoxes.Add(cmbTipoUsuario);
            comboBoxes.Add(cmbDivision);
            listBoxes.Add(listGrados);
            if (!Validator.validateFields(createListFields()) || !Validator.validateComboBoxes(comboBoxes) || !Validator.validateListBoxes(listBoxes))
            {
                MessageBox.Show("Faltan llenar campos\n1. Toma en cuenta que la contraseña tiene que ser mayor a 6 caracteres\n2. El correo debe ser váilido\n3. Debes seleccionar tanto el tipo de usuario como la division\n4. Agregar uno o más grados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            consulta = "INSERT INTO profesor (nombre, apellido_paterno, apellido_materno, tipo_usuario, id_division, correo, password) VALUES ('" +
                txtNombre.Text + "', '" + txtApellidoP.Text + "', '" + txtApellidoM.Text + "', " + (cmbTipoUsuario.SelectedItem as ComboBoxItem).Value.ToString() +
                ", " + (cmbDivision.SelectedItem as ComboBoxItem).Value.ToString() + ", '" + txtCorreo.Text + "', md5('" + txtPassword.Text + "'));";
            resultado = conexion.ejecutarComando(consulta);
            if (resultado.RecordsAffected == 0)
            {
                MessageBox.Show("Error al guardar, consulta al administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            foreach (var item in listGrados.Items)
            {
                consulta = "INSERT INTO profesor_grado (id_profesor, id_grado) VALUES( (SELECT max(id) FROM profesor), " +
                    (item as ComboBoxItem).Value.ToString() + ");";
                resultado = conexion.ejecutarComando(consulta);
            }

            MessageBox.Show("Profesor guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarProfesor();
            cargarDataGridViewProfesores();
        }

        private void btnAgregarGrado_Click(object sender, EventArgs e)
        {
            if (cmbGrados.SelectedItem != null)
            {
                if (listGrados.Items.Contains(cmbGrados.SelectedItem))
                {
                    MessageBox.Show("Grado ya en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                listGrados.Items.Add(cmbGrados.SelectedItem);
            }
        }

        private void btnEliminarGrado_Click(object sender, EventArgs e)
        {
            if (listGrados.SelectedItem != null)
            {
                listGrados.Items.Remove(listGrados.SelectedItem);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!Validator.validateID(txtID.Text))
            {
                MessageBox.Show("Ingresa el ID a buscar y numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            consulta = "SELECT nombre, apellido_paterno, apellido_materno, tipo_usuario, id_division, correo FROM profesor WHERE id = " + txtID.Text;
            resultado = conexion.ejecutarComando(consulta);
            if (!resultado.HasRows)
            {
                MessageBox.Show("No se ha encontrado al profesor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            listGrados.Items.Clear();
            txtNombre.Text = resultado["nombre"].ToString();
            txtApellidoP.Text = resultado["apellido_paterno"].ToString();
            txtApellidoM.Text = resultado["apellido_materno"].ToString();
            txtCorreo.Text = resultado["correo"].ToString();
            int index = 0;
            foreach (var item in cmbTipoUsuario.Items)
            {
                if ((item as ComboBoxItem).Value == resultado["tipo_usuario"].ToString())
                    cmbTipoUsuario.SelectedIndex = index;
                index++;
            }
            index = 0;
            foreach (var item in cmbDivision.Items)
            {
                if ((item as ComboBoxItem).Value == resultado["id_division"].ToString())
                    cmbDivision.SelectedIndex = index;
                index++;
            }
            consulta = "SELECT * FROM profesor_grado WHERE id_profesor = " + txtID.Text;
            resultado = conexion.ejecutarComando(consulta);
            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    foreach (var item in cmbGrados.Items)
                    {
                        string id = resultado["id_grado"].ToString();
                        if ((item as ComboBoxItem).Value == id)
                        {
                            listGrados.Items.Add(item);
                            break;
                        }
                    }
                }
            }
        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!Validator.validateID(txtID.Text))
            {
                MessageBox.Show("El ID debe ser numérico y no estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            consulta = "SELECT nombre, apellido_paterno, apellido_materno FROM profesor WHERE id = " + txtID.Text;
            resultado = conexion.ejecutarComando(consulta);
            if (!resultado.HasRows)
            {
                MessageBox.Show("No se ha encontrado al profesor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show("¿Seguro que deseas eliminar a " + resultado["nombre"].ToString() + " " + resultado["apellido_paterno"].ToString() + " " + resultado["apellido_materno"].ToString() + "?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                consulta = "DELETE FROM profesor WHERE id = " + txtID.Text;
                try
                {
                    resultado = conexion.ejecutarComando(consulta);
                    if (resultado.RecordsAffected > 0)
                    {
                        MessageBox.Show("Profesor eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarProfesor();
                        cargarDataGridViewProfesores();
                    }
                    else
                        MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            if(!Validator.validateID(txtID.Text))
            {
                MessageBox.Show("Ingresa el ID a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!Validator.validateFields(createListFields()))
            {
                MessageBox.Show("Faltan llenar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            consulta = "SELECT nombre FROM profesor WHERE id = " + txtID.Text;
            resultado = conexion.ejecutarComando(consulta);
            if (!resultado.HasRows)
            {
                MessageBox.Show("No se encuentra el profesor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            consulta = "UPDATE profesor SET nombre = '" + txtNombre.Text + "', apellido_paterno = '" + txtApellidoP.Text + "', apellido_materno = '" +
                txtApellidoM.Text + "', tipo_usuario = " + (cmbTipoUsuario.SelectedItem as ComboBoxItem).Value.ToString() + ", id_division = " +
                (cmbDivision.SelectedItem as ComboBoxItem).Value.ToString() + ", correo = '" + txtCorreo.Text + "'";
            if (txtPassword.Text != "")
                consulta += ", password = md5('" + txtPassword.Text + "')";
            consulta += " WHERE id = " + txtID.Text;
            resultado = conexion.ejecutarComando(consulta);
            if (resultado.RecordsAffected > 0)
            {
                consulta = "DELETE FROM profesor_grado WHERE id_profesor = " + txtID.Text;
                resultado = conexion.ejecutarComando(consulta);
                if (resultado.RecordsAffected > 0)
                {
                    foreach (var item in listGrados.Items)
                    {
                        consulta = "INSERT INTO profesor_grado (id_profesor, id_grado) VALUES( " + txtID.Text + ", " +
                            (item as ComboBoxItem).Value.ToString() + ");";
                        resultado = conexion.ejecutarComando(consulta);
                    }
                }
                MessageBox.Show("Profesor guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDataGridViewProfesores();
            }
        }


        #endregion

        private void btnCurriculum_Click(object sender, EventArgs e)
        {
            if (!Validator.validateID(txtID.Text))
            {
                MessageBox.Show("El ID debe ser numérico y no estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Curriculum curriculum = new Curriculum(txtID.Text);
            curriculum.ShowDialog();
        }
    }
}
