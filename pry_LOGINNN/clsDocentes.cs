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
        private MySqlDataAdapter consulta;
        private MySqlCommand comando;

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
        public DataTable Consultar()
        {
            tabla = new DataTable();
            try
            {
                cls_conexion conexionBD = new cls_conexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT A.claveDocente AS Clave, " +
                                 "A.nombreDocente AS Nombre, " +
                                 "A.puesto AS Puesto, " +
                                 "U.vchnombreUsuario AS Usuario, " +
                                 "A.telefono AS Telefono, " +
                                 "A.correo AS Correo, " +
                                 "U.vchpassword, " + // <-- Aqui se agrega el password
                                 "U.vchperfil, " + // <-- Aqui se agrega el perfil
                                 "A.idUsuario " +
                                 "FROM tbldocentes A " +
                                 "INNER JOIN tblusuarios U ON A.idUsuario = U.intidUsuario WHERE claveDocente LIKE @claveDocente;";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@claveDocente", "%" + clave + "%");
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
            cls_conexion conexionBD = new cls_conexion();

            try
            {
                using (var conexion = conexionBD.AbrirConexion())
                {
                    using (var transaccion = conexion.BeginTransaction())
                    {
                        try
                        {
                            string sqlDelDocente = " DELETE FROM tbldocentes WHERE claveDocente = @claveDocente;";
                            using (comando = new MySqlCommand(sqlDelDocente, conexion, transaccion))
                            {
                                comando.Parameters.AddWithValue("@claveDocente", clave);
                                comando.ExecuteNonQuery();
                            }

                            string sqlDelUsuario = " DELETE FROM tblusuarios WHERE intidUsuario = @idUsuario;";
                            using (comando = new MySqlCommand(sqlDelUsuario, conexion, transaccion))
                            {
                                comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                                comando.ExecuteNonQuery();
                            }

                            transaccion.Commit();
                            msg = "El docente y sus credenciales de usuario han sido eliminados del sistema.";
                        }
                        catch (Exception ex)
                        {
                            //Si algo falla, deshacemos la operacion para no dejar datos huerfanos
                            transaccion.Rollback();
                            throw new Exception("No se pudo completar la eliminacion. Cambios revertidos: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexion al eliminar: " + ex.Message);
            }

            return msg;
        }
        public void LimpiarPanel(Panel panelDestino)
        {
            foreach (Control control in panelDestino.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0;
                }

            }
        }

    }
}
