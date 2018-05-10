using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Cuerpo_Academico
{
    public class Profesor
    {
        private int id;
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private int tipoUsuario;
        private int idDivision;
        private string correo;
         
        public Profesor(OdbcDataReader reader)
        {
            this.id = Convert.ToInt32(reader["id"].ToString());
            this.nombre = reader["nombre"].ToString();
            this.apellidoPaterno = reader["apellido_paterno"].ToString();
            this.apellidoMaterno = reader["apellido_materno"].ToString();
            this.tipoUsuario = Convert.ToInt32(reader["tipo_usuario"].ToString());
            this.idDivision = Convert.ToInt32(reader["id_division"].ToString());
            this.correo = reader["correo"].ToString();
        }

        public int getID() { return id; }
        
        public string getNombre() { return nombre; }

        public string getApellidoPaterno() { return apellidoPaterno; }

        public string getApellidoMaterno() { return apellidoMaterno; }

        public string getNombreCompleto() { return nombre + " " + apellidoPaterno + " " + apellidoMaterno; }

        public int getTipoUsuario() { return tipoUsuario; }

        public int getIdDivision() { return idDivision; }

        public string getCorreo() { return correo; }
    }
}
