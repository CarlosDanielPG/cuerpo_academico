using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Cuerpo_Academico
{
    class Conexion
    {
        private OdbcConnection conexion;
        private OdbcCommand comando;
        private OdbcDataReader resultado;

        public Conexion()
        {
            conexion = new OdbcConnection("Driver={MySQL ODBC 8.0 Unicode Driver};" + "Server=localhost;" + "Port=3306; Database=cuerpo_academico;" + "User=root; Password=; option=3;");
        }

        public OdbcDataReader ejecutarComando(string consulta)
        {
            if (!isOpen())
                conexion.Open();
            try
            {
                comando = new OdbcCommand(consulta, conexion);
                resultado = comando.ExecuteReader();
                return resultado;
            } catch(OdbcException ex)
            {
                return null;
            }
        }

        public void cerrarConexion()
        {
            conexion.Close();
        }

        public bool isOpen()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
                return true;
            return false;
        }
    }
}
