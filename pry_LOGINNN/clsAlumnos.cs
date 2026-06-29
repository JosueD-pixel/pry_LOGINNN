using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace pry_LOGINNN
{
    internal class clsAlumnos
    {



        //Adaptadores y tabla virtuales de la clase

        private MySqlDataAdapter consulta;
        private DataTable tabla;


        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();
            try
            {
                cls_conexion conexionBD = new cls_conexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    //Unimos las 4 tablas mediante INNER JOIN para mostrar descrípciones claras en el Grid
                    string sql = "SELECT A.matricula AS Matricula, + " +
                                 "A.nombreAlumno AS Nombre," +
                                 "A.apellidoP AS 'A. Paterno', + " +
                                 "A.apellidoM AS 'A. Materno'," +
                                 "C.nombreCarrera AS Carrera," +
                                 "T.nombreTutor AS Tutor," +
                                 "U.vchnombreUsuario AS Usuario, " +
                                 "A.direccion, A.telefono, A.correo, A.promedioBachillerato, A.foto, A.idTutor, A.idCarrera, A.idUsuario" +
                                 "FROM tblalumnos A" +
                                 "INNER JOIN tblcarreras C ON A.idCarrera = C.idCarrera" +
                                 "INNER JOIN tbltutores T ON A.idTutor = T.idTutor" +
                                 "INNER JOIN tblusuarios U ON A.idUsuario = U.intidUsuario; ";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }//Liberar la consulta
                }//Liberarla conexion
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion al cargar catalogo de alumnos " + ex.Message);
            }
            return tabla;
        }
        //OBTENCION DE LOS DATOS CARRERAS POR: ANGEL JOSUE :3
        public DataTable ObtenerCarreras()
        {
            tabla = new DataTable();
            try
            {
                cls_conexion conexionBD = new cls_conexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    //valuemember es idcarrera, y el displaymember es nombrecarrera
                    string sql = "SELECT idCarrera, nombreCarrera FROM tblCarreras;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }//Liberar la consulta
                }//Liberarla conexion
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion al obtener el catalogo de carreras " + ex.Message);
            }
            return tabla;
        }

    }
}
