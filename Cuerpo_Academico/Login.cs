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
    public partial class Login : Form
    {
        Conexion conexion = new Conexion();
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(txtCorreo.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Por favor primero llena los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string consulta = "SELECT * FROM profesor WHERE correo = '" + txtCorreo.Text + "' AND password = md5('" + txtPassword.Text + "');";
            OdbcDataReader resultado = conexion.ejecutarComando(consulta);
            if (resultado.HasRows)
            {
                MessageBox.Show("Bienvenido", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //conexion.cerrarConexion();
                Profesor profesor = new Profesor(resultado);
                Inicio inicio = new Inicio(this, profesor);
                this.Hide();
                inicio.Show();
            }
            else
            {
                MessageBox.Show("Datos incorrectos, intenta de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conexion.cerrarConexion();
            }
        }
    }
}
