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
        Profesores profesores = null;
        Divisiones divisiones = null;
        Carreras carreras = null;
        LineasInvestigacion lineasInvestigacion = null;
        Propositos propositos = null;
        TiposProduccion tiposProduccion = null;
        Producciones producciones = null;
        Instituciones instituciones = null;

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
            profesores = new Profesores();
            profesores.TopLevel = false;
            tabProfesores.Controls.Add(profesores);
            profesores.Show();
            // Divisiones
            divisiones = new Divisiones();
            divisiones.TopLevel = false;
            tabDivisiones.Controls.Add(divisiones);
            divisiones.Show();
            // Carreras
            carreras = new Carreras();
            carreras.TopLevel = false;
            tabCarreras.Controls.Add(carreras);
            carreras.Show();
            // Lineas Investigacion
            lineasInvestigacion = new LineasInvestigacion();
            lineasInvestigacion.TopLevel = false;
            tabLineasInvestigacion.Controls.Add(lineasInvestigacion);
            lineasInvestigacion.Show();
            // Propósitos
            propositos = new Propositos();
            propositos.TopLevel = false;
            tabPropositos.Controls.Add(propositos);
            propositos.Show();
            // Instituciones
            instituciones = new Instituciones();
            instituciones.TopLevel = false;
            tabInstituciones.Controls.Add(instituciones);
            instituciones.Show();
            // Tipos de Produccion
            tiposProduccion = new TiposProduccion();
            tiposProduccion.TopLevel = false;
            tabTiposProduccion.Controls.Add(tiposProduccion);
            tiposProduccion.Show();
            // Producciones
            producciones = new Producciones(this.profesor);
            producciones.TopLevel = false;
            tabProducciones.Controls.Add(producciones);
            producciones.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tcPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcPrincipal.SelectedIndex == 0 && profesores != null)
                profesores.cargarCmbDivisiones();
            if (tcPrincipal.SelectedIndex == 2 && carreras != null)
                carreras.cargarCmbDivisiones();
            if(tcPrincipal.SelectedIndex == 7 && producciones != null)
            {
                producciones.cargarInstituciones();
                producciones.cargarLineasInvestigacion();
                producciones.cargarProfesores();
                producciones.cargarPropositos();
                producciones.cargarTiposProduccion();
            }
        }
    }
}
