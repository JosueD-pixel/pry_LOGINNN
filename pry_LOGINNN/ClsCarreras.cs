using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;
using System.Text;

namespace pry_LOGINNN
{
    internal class ClsCarreras
    {
        //Usamos un adaptador 
        private MySqlDataAdapter consulta;
        //usamos una tabla temporal
        private DataTable tabla;

        //Metodo para cargar datos en el DataGrid
        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();

            cls_conexion conexionBD = new cls_conexion();
            var conexion = conexionBD.AbrirConexion();
            string sql = "select idCarrera AS Clave, nombreCarrera AS Carrera, descripcion AS Descripcion  from tblCarreras;";
            consulta = new MySqlDataAdapter(sql, conexion);
            consulta.Fill(tabla);
            return tabla;
        }

    }
}
