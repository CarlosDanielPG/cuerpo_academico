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
    public partial class Inicio : Form
    {
        private Login login;
        private string consulta;
        private Conexion conexion;
        private OdbcDataReader resultado;
        private Profesor profesor;

        public Inicio(Login login, Profesor profesor)
        {
            this.login = login;
            this.profesor = profesor;
            this.conexion = new Conexion();
            InitializeComponent();
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.Close();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            //tcPrincipal.TabPages.Remove(tabCarreras);
            sLblUsuario.Text += " " + profesor.getNombreCompleto();
            // Profesores
            Profesores profesores = new Profesores();
            profesores.TopLevel = false;
            tabProfesores.Controls.Add(profesores);
            profesores.Show();
            // Divisiones
            Divisiones divisiones = new Divisiones();
            divisiones.TopLevel = false;
            tabDivisiones.Controls.Add(divisiones);
            divisiones.Show();
            // Carreras
            Carreras carreras = new Carreras();
            carreras.TopLevel = false;
            tabCarreras.Controls.Add(carreras);
            carreras.Show();
            // Lineas Investigacion
            LineasInvestigacion lineasInvestigacion = new LineasInvestigacion();
            lineasInvestigacion.TopLevel = false;
            tabLineasInvestigacion.Controls.Add(lineasInvestigacion);
            lineasInvestigacion.Show();
            // Propósitos
            Propositos propositos = new Propositos();
            propositos.TopLevel = false;
            tabPropositos.Controls.Add(propositos);
            propositos.Show();
            // Tipos de Produccion
            TiposProduccion tiposProduccion = new TiposProduccion();
            tiposProduccion.TopLevel = false;
            tabTiposProduccion.Controls.Add(tiposProduccion);
            tiposProduccion.Show();
            // Producciones
            Producciones producciones = new Producciones();
            producciones.TopLevel = false;
            tabProducciones.Controls.Add(producciones);
            producciones.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
