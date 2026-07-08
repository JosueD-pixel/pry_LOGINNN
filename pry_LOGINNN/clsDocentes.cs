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



        private string nombreUsuario;
        private string password;
        private string perfil;

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Password { get => password; set => password = value; }
        public string Perfil { get => perfil; set => perfil = value; }
        public string Puesto { get => puesto; set => puesto = value; }



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

        public string GuardarActualizar(int tipoOperacion)
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
                            switch (tipoOperacion)
                            {
                                case 0://Nuevo e insertar
                                    string sqlInsUser = "INSERT INTO tblusuarios(vchnombreUsuario, vchpassword , vchperfil, vhcestado) " +
                                                        "VALUES(@nomUser, MD5(@pass), @perfil, 'Activo'); SELECT LAST_INSERT_ID();";

                                    int nuevoIdUsuario = 0;
                                    using (comando = new MySqlCommand(sqlInsUser, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@nomUser", nombreUsuario);
                                        comando.Parameters.AddWithValue("@pass", password);
                                        comando.Parameters.AddWithValue("@perfil", perfil);
                                        nuevoIdUsuario = Convert.ToInt32(comando.ExecuteScalar());
                                    }

                                    //Paso B: Insertar el docente en tbldocentes vinculando el ID de usuario obtenido
                                    string sqlInsDocente = "INSERT INTO tbldocentes(claveDocente, idUsuario, nombreDocente, puesto, telefono, correo)" +
                                                          "VALUES(@claveDocente, @idUsuario, @nombre, @puesto, @tel, @correo);";

                                    using (comando = new MySqlCommand(sqlInsDocente, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@claveDocente", clave);
                                        comando.Parameters.AddWithValue("@idUsuario", nuevoIdUsuario);
                                        comando.Parameters.AddWithValue("@nombre", nombreDocente);
                                        comando.Parameters.AddWithValue("@puesto", puesto);
                                        comando.Parameters.AddWithValue("@tel", telefono);
                                        comando.Parameters.AddWithValue("@correo", correo);

                                        comando.ExecuteNonQuery();
                                    }
                                    msg = "El docente y sus credenciales se guardaron correctamente ";
                                    break;

                                case 1://Actualizar 
                                       //Paso A: Actualizar la tabla usuarios utilizando el ID que recuperamos en el clic del grind
                                    string sqlUpdUser = "UPDATE tblusuarios SET vchnombreusuario = @nomUser, vchperfil = @perfil " +
                                                        "WHERE intidUsuario = @idUsuario;";

                                    using (comando = new MySqlCommand(sqlUpdUser, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@idUsuario", clave);
                                        comando.Parameters.AddWithValue("@nomUser", nombreUsuario);
                                        comando.Parameters.AddWithValue("@perfil", perfil);

                                        comando.ExecuteNonQuery();
                                    }
                                    //PASO B: Actualizar los datos del expediente en tbldocentes mediante su matricula
                                    string sqlUpdDocente = "UPDATE tbldocentes SET nombreDocente = @nombre, " +
                                                           "puesto = @puesto, telefono = @tel, correo = @correo " +
                                                           "WHERE claveDocente = @claveDocente;";

                                    using (comando = new MySqlCommand(sqlUpdDocente, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@claveDocente", clave);
                                        comando.Parameters.AddWithValue("@nombre", nombreDocente);
                                        comando.Parameters.AddWithValue("@puesto", puesto);
                                        comando.Parameters.AddWithValue("@tel", telefono);
                                        comando.Parameters.AddWithValue("@correo", correo);

                                        comando.ExecuteNonQuery();
                                    }

                                    msg = "Los datos del docente se actualizaron correctamente.";
                                    break;
                            }
                            //Si todo se ejecuto sin errores en el switch, confirmamos cambios en la BD
                            transaccion.Commit();
                        }
                        catch (Exception ex)
                        {
                            //Si algo fallo (en el usuario o el alumno), deshacemos todo para evitar inconsistencias
                            transaccion.Rollback();
                            throw new Exception("Error en la operacion. Se cancelaron los cambios: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexion: " + ex.Message);
            }
            return msg;
        }


    }
}
