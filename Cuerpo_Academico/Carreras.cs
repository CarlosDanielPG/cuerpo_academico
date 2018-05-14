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

        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<ComboBox> comboBoxes = new List<ComboBox>();
            comboBoxes.Add(cmbDivisiones);
            comboBoxes.Add(cmbNivel);
            if(!Validator.v)
            consulta = "INSERT INTO carrera (nombre, id_nivel, id_division) VALUES('" + txtNombre.Text + "', " + (cmbNivel.SelectedItem as ComboBoxItem).Value.ToString() + ", " + (cmbDivisiones.SelectedItem as ComboBoxItem).Value.ToString() + ");";
            resultado = conexion.ejecutarComando(consulta);
            if (resultado.RecordsAffected > 0)
            {
                MessageBox.Show("Carrera guardada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            cargarDataGridViewCarreras();
        }
    }
}
