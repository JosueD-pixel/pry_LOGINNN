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
        private string descripcion;
        private int idCarrera;//este atributo es para referencia de update y delete 
        //Usamos un adaptador 
        private MySqlDataAdapter consulta;
        //usamos un command para actualizar o insertar 
        private MySqlCommand comando; 
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

        public DataTable Consultar()
        {
            tabla = new DataTable();
            try
            {
                cls_conexion conexionBD = new cls_conexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT idCarrera AS Clave, nombreCarrera AS Carrera, descripcion AS Descripcion FROM tblCarreras WHERE nombreCarrera LIKE @carrera;";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@carrera", "%" + nombreCarrera + "%");
                        using (consulta = new MySqlDataAdapter(consultar))
                        {
                            consulta.Fill(tabla);
                        }//Liberar el adaptador
                    }//Liberar la consulta
                }//Liberar la conexion
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion de la base de datos " + ex.Message);
            }
            return tabla;
        }


        public string Eliminar()
        {
            string msg = "";
            try
            {
                cls_conexion conexionBD = new cls_conexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "DELETE FROM tblcarreras C WHERE C.idCarrera = @idCarrera;";
                    using (comando = new MySqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@idCarrera", idCarrera);
                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            msg = "Datos eliminados correctamente";
                        }
                        else
                        {
                            msg = "Los datos no se pudieron eliminar";
                        }
                    }//liberar las conexiones
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
            return msg;
        }


    }
}
