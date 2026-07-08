using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace pry_LOGINNN
{
    internal class clsDocentes
    {
        private int clave;
        private string nombreDocente;
        private string telefono;
        private string correo;
        private string puesto;
        private int idUsuario;//Foraneo

        public int Clave { get => clave; set => clave = value; }
        public string NombreDocente { get => nombreDocente; set => nombreDocente = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }

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
                    string sql = "SELECT A.claveDocente AS Clave, " +
                                 "A.nombreDocente AS Nombre, " +
                                 "A.puesto AS Puesto, " +
                                 "U.vchnombreUsuario AS Usuario, " +
                                 "U.vchpassword, " +
                                 "U.vchperfil, " +
                                 "A.idUsuario, " +
                                 "A.telefono AS Telefono, " +
                                 "A.correo AS Correo " +
                                 "FROM tbldocentes A " +
                                 "INNER JOIN tblusuarios U ON A.idUsuario = U.intidUsuario;";

                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }//Liberar la consulta
                }//Liberarla conexion
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion al cargar catalogo de docentes " + ex.Message);
            }
            return tabla;
        }

    }
}
