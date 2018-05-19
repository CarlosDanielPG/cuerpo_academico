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
        private Profesor profesor;
        Profesores profesores = null;
        Divisiones divisiones = null;
        Carreras carreras = null;
        LineasInvestigacion lineasInvestigacion = null;
        Propositos propositos = null;
        TiposProduccion tiposProduccion = null;
        Producciones producciones = null;
        Instituciones instituciones = null;
        ProduccionesPropias produccionesPropias = null;

        public Inicio(Login login, Profesor profesor)
        {
            this.login = login;
            this.profesor = profesor;
            InitializeComponent();
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.Close();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            if(profesor.getTipoUsuario() == 3 || profesor.getTipoUsuario() == 4)
            {
                tcPrincipal.TabPages.Remove(tabProfesores);
                tcPrincipal.TabPages.Remove(tabDivisiones);
                tcPrincipal.TabPages.Remove(tabCarreras);
                tcPrincipal.TabPages.Remove(tabLineasInvestigacion);
                tcPrincipal.TabPages.Remove(tabProfesores);
                tcPrincipal.TabPages.Remove(tabPropositos);
                tcPrincipal.TabPages.Remove(tabInstituciones);
                tcPrincipal.TabPages.Remove(tabTiposProduccion);
                if (profesor.getTipoUsuario() == 4)
                    tcPrincipal.TabPages.Remove(tabProducciones);
            }
            sLblUsuario.Text += " " + profesor.getNombreCompleto();
            // Profesores
            if (tabProfesores != null)
            {
                profesores = new Profesores();
                profesores.TopLevel = false;
                tabProfesores.Controls.Add(profesores);
                profesores.Show();
            }
            // Divisiones
            if (tabDivisiones != null)
            {
                divisiones = new Divisiones();
                divisiones.TopLevel = false;
                tabDivisiones.Controls.Add(divisiones);
                divisiones.Show();
            }
            // Carreras
            if (tabCarreras != null)
            {
                carreras = new Carreras();
                carreras.TopLevel = false;
                tabCarreras.Controls.Add(carreras);
                carreras.Show();
            }
            // Lineas Investigacion
            if (tabLineasInvestigacion != null)
            {
                lineasInvestigacion = new LineasInvestigacion();
                lineasInvestigacion.TopLevel = false;
                tabLineasInvestigacion.Controls.Add(lineasInvestigacion);
                lineasInvestigacion.Show();
            }
            // Propósitos
            if (tabPropositos != null)
            {
                propositos = new Propositos();
                propositos.TopLevel = false;
                tabPropositos.Controls.Add(propositos);
                propositos.Show();
            }
            // Instituciones
            if (tabInstituciones != null)
            {
                instituciones = new Instituciones();
                instituciones.TopLevel = false;
                tabInstituciones.Controls.Add(instituciones);
                instituciones.Show();
            }
            // Tipos de Produccion
            if (tabTiposProduccion != null)
            {
                tiposProduccion = new TiposProduccion();
                tiposProduccion.TopLevel = false;
                tabTiposProduccion.Controls.Add(tiposProduccion);
                tiposProduccion.Show();
            }
            // Producciones
            if (tabProducciones != null)
            {
                producciones = new Producciones(this.profesor);
                producciones.TopLevel = false;
                tabProducciones.Controls.Add(producciones);
                producciones.Show();
            }
            produccionesPropias = new ProduccionesPropias(this.profesor);
            produccionesPropias.TopLevel = false;
            tabProduccionesPropias.Controls.Add(produccionesPropias);
            produccionesPropias.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                Close();
        }

        private void tcPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcPrincipal.SelectedTab == tabDivisiones && profesores != null)
                profesores.cargarCmbDivisiones();
            if(tcPrincipal.SelectedTab == tabCarreras && carreras != null)
                carreras.cargarCmbDivisiones();
            if(tcPrincipal.SelectedTab == tabProducciones && producciones != null)
            {
                producciones.cargarInstituciones();
                producciones.cargarLineasInvestigacion();
                producciones.cargarProfesores();
                producciones.cargarPropositos();
                producciones.cargarTiposProduccion();
            }
            if(tcPrincipal.SelectedTab == tabProduccionesPropias && produccionesPropias != null)
            {
                produccionesPropias.cargarDataGridProducciones();
                produccionesPropias.cargarDataGridProduccionesElabora();
            }
        }
    }
}
