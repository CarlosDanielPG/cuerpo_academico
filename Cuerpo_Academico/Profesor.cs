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

        public Profesor(string id, string nombre, string apellidoPaterno, string apellidoMaterno, string tipoUsuario, string idDivision, string correo)
        {
            this.id = Convert.ToInt32(id);
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.tipoUsuario = Convert.ToInt32(tipoUsuario);
            this.idDivision = Convert.ToInt32(idDivision);
            this.correo = correo;
        }

        public int getID() { return id; }
        
        public string getNombre() { return nombre; }

        public string getApellidoPaterno() { return apellidoPaterno; }

        public string getApellidoMaterno() { return apellidoMaterno; }

        public string getNombreCompleto() { return nombre + " " + apellidoPaterno + " " + apellidoMaterno; }

        public int getTipoUsuario() { return tipoUsuario; }

        public int getIdDivision() { return idDivision; }

        public string getCorreo() { return correo; }

        public override string ToString()
        {
            return this.nombre + " " + this.apellidoPaterno + " " + this.apellidoMaterno;
        }
    }
}
