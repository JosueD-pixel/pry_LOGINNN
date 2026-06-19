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
        private string nombreCarrera;
        //Usamos un adaptador 
        private MySqlDataAdapter consulta;
        //usamos una tabla temporal
        private DataTable tabla;

        //Propiedad para el atributo nombreCarrera
        public string NombreCarrera { get => nombreCarrera; set => nombreCarrera = value; }

        //Metodo para cargar datos en el DataGrid
        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();
            try
            {
                cls_conexion conexionBD = new cls_conexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "select idCarrera AS Clave, nombreCarrera AS Carrera, descripcion AS Descripcion  from tblCarreras;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }//Liberar la consulta
                }//Liberarla conexion
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion " + ex.Message);
            }
            return tabla;


        }
    }
}
