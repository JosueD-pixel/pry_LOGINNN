using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace pry_LOGINNN
{
    internal class clsTutores
    {
        private string nombreTutor;
        private string parentesco;
        private string direccion;
        private string telefono;
        private string correo;

        private int idTutor;//este atributo es para referencia de update y delete 
        //Usamos un adaptador 
        private MySqlDataAdapter consulta;
        //usamos un command para actualizar o insertar 
        private MySqlCommand comando;
        //usamos una tabla temporal
        private DataTable tabla;

        //Propiedad para los atributos

        public string NombreTutor { get => nombreTutor; set => nombreTutor = value; }
        public int IdTutor { get => idTutor; set => idTutor = value; }
        public string Parentesco { get => parentesco; set => parentesco = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }

        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();
            try
            {
                cls_conexion conexionBD = new cls_conexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "select idTutor AS Clave, nombreTutor AS Tutor, parentesco AS Parentesco, direccion AS Direccion, telefono AS Telefono, correo AS Correo  from tbltutores;";
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
