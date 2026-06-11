using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace pry_LOGINNN
{
    internal class cls_conexion
    {
        private string host = "189.240.192.140";
        private string bd = "bdescuela3d";
        private string usuario = "terceroD";
        private string password = "tercero@D";
        private string puerto = "3306";

        private string cadenaConexion => $"server= {host};database={bd};user={usuario};password={password};port={puerto}";

        //Método Abrir conexcion
        public MySqlConnection AbrirConexion()
        {
            var conexion = new MySqlConnection(cadenaConexion);
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar conectarse a la base de datos"+ ex.Message, ex);
            }

        }

        //Método cerrar conexcion
        public void CerrarConexion(MySqlConnection conexion)
        {
            try
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                    conexion.Dispose();
                }
            }

            catch (Exception ex)
            {
                throw new Exception("Error al cerrar la conexion con la base de datos" + (ex.Message, ex));
            }

        }
    }
}
