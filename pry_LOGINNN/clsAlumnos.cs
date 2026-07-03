using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Text;

namespace pry_LOGINNN
{
    internal class clsAlumnos
    {

        private int matricula;
        private string nombreAlumno;
        private string apellidoP;
        private string apellidoM;
        private string direccion;
        private string telefono;
        private string correo;
        private decimal promedioBachillerato;
        private int idTutor;//Foraneo
        private int idCarrera;//Foraneo
        private int idUsuario;//Foraneo

        private string nombreUsuario;
        private string password;
        private string perfil;

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Password { get => password; set => password = value; }
        public string Perfil { get => perfil; set => perfil = value; }


        //Propiedades   
        public int Matricula { get => matricula; set => matricula = value; }
        public string NombreAlumno { get => nombreAlumno; set => nombreAlumno = value; }
        public string ApellidoP { get => apellidoP; set => apellidoP = value; }
        public string ApellidoM { get => apellidoM; set => apellidoM = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public decimal PromedioBachillerato { get => promedioBachillerato; set => promedioBachillerato = value; }
        public int IdTutor { get => idTutor; set => idTutor = value; }
        public int IdCarrera { get => idCarrera; set => idCarrera = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }


        //Adaptadores y tabla virtuales de la clase

        private MySqlDataAdapter consulta;
        private DataTable tabla;
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
                    string sql = "SELECT A.matricula AS Matricula, " +
                                 "A.nombreAlumno AS Nombre, " +
                                 "A.apellidoP AS 'A. Paterno', " +
                                 "A.apellidoM AS 'A. Materno', " +
                                 "C.nombreCarrera AS Carrera, " +
                                 "T.nombreTutor AS Tutor, " +
                                 "U.vchnombreUsuario AS Usuario, " +
                                 "U.vchpassword, " + 
                                 "U.vchperfil, " +
                                 "A.direccion, A.telefono, A.correo, A.promedioBachillerato, A.idTutor, A.idCarrera, A.idUsuario " +
                                 "FROM tblalumnos A " +
                                 "INNER JOIN tblcarreras C ON A.idCarrera = C.idCarrera " +
                                 "INNER JOIN tbltutores T ON A.idTutor = T.idTutor " +
                                 "INNER JOIN tblusuarios U ON A.idUsuario = U.intidUsuario;";

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
        public DataTable ObtenerTutores()
        {
            tabla = new DataTable();
            try
            {
                cls_conexion conexionBD = new cls_conexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    //valuemember es idtutor, y el displaymember es nombretutor
                    string sql = "SELECT idTutor, nombreTutor FROM tbltutores;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }//Liberar la consulta
                }//Liberarla conexión
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion al obtener el catalogo de tutores" + ex.Message);
            }
            return tabla;
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
        public DataTable Consultar()
        {
            tabla = new DataTable();
            try
            {
                cls_conexion conexionBD = new cls_conexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT A.matricula AS Matricula, " +
                                 "A.nombreAlumno AS Nombre, " +
                                 "A.apellidoP AS 'A. Paterno', " +
                                 "A.apellidoM AS 'A. Materno', " +
                                 "C.nombreCarrera AS Carrera, " +
                                 "T.nombreTutor AS Tutor, " +
                                 "U.vchnombreUsuario AS Usuario, " +
                                 "U.vchpassword, " + // <-- Aqui se agrega el password
                                 "U.vchperfil, " + // <-- Aqui se agrega el perfil
                                 "A.direccion, A.telefono, A.correo, A.promedioBachillerato, A.idTutor, A.idCarrera, A.idUsuario " +
                                 "FROM tblalumnos A " +
                                 "INNER JOIN tblcarreras C ON A.idCarrera = C.idCarrera " +
                                 "INNER JOIN tbltutores T ON A.idTutor = T.idTutor " +
                                 "INNER JOIN tblusuarios U ON A.idUsuario = U.intidUsuario WHERE matricula LIKE @matricula;";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@matricula", "%" + matricula + "%");
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

                                    //Paso B: Insertar el alumno en tblalumnos vinculando el ID de usuario obtenido
                                    string sqlInsAlumno = "INSERT INTO tblalumnos(matricula, idUsuario, nombreAlumno, apellidoP, apellidoM, direccion, telefono, correo, promedioBachillerato, idTutor, idCarrera)" +
                                                          "VALUES(@matricula, @idUsuario, @nombre, @apP, @apM, @dir, @tel, @correo, @prom, @idTutor, @idCarrera);";

                                    using (comando = new MySqlCommand(sqlInsAlumno, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@matricula", matricula);
                                        comando.Parameters.AddWithValue("@idUsuario", nuevoIdUsuario);
                                        comando.Parameters.AddWithValue("@nombre", nombreAlumno);
                                        comando.Parameters.AddWithValue("@apP", apellidoP);
                                        comando.Parameters.AddWithValue("@apM", apellidoM);
                                        comando.Parameters.AddWithValue("@dir", direccion);
                                        comando.Parameters.AddWithValue("@tel", telefono);
                                        comando.Parameters.AddWithValue("@correo", correo);
                                        comando.Parameters.AddWithValue("@prom", promedioBachillerato);
                                        comando.Parameters.AddWithValue("@idTutor", idTutor);
                                        comando.Parameters.AddWithValue("@idCarrera", idCarrera);

                                        comando.ExecuteNonQuery();
                                    }
                                    msg = "El alumno y sus credenciales se guardaron correctamente ";
                                    break;

                                case 1://Actualizar 
                                       //Paso A: Actualizar la tabla usuarios utilizando el ID que recuperamos en el clic del grind
                                    string sqlUpdUser = "UPDATE tblusuarios SET vchnombreusuario = @nomUser, vchperfil = @perfil " +
                                                       "WHERE intidUsuario = @idUsuario;";

                                    using (comando = new MySqlCommand(sqlUpdUser, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@idUsuario", matricula);
                                        comando.Parameters.AddWithValue("@nomUser", nombreUsuario);
                                        comando.Parameters.AddWithValue("@perfil", perfil);

                                        comando.ExecuteNonQuery();
                                    }
                                    //PASO B: Actualizar los datos del expediente en tblalumnos mediante su matricula
                                    string sqlUpdAlumno = "UPDATE tblalumnos SET nombreAlumno = @nombre, apellidoP = @apP, apellidoM= @apM, " +
                                                          "direccion = @dir, telefono = @tel, correo = @correo, promedioBachillerato =@prom, " +
                                                          "idTutor = @idTutor, idCarrera = @idCarrera WHERE matricula = @matricula;";

                                    using (comando = new MySqlCommand(sqlUpdAlumno, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@matricula", matricula);
                                        comando.Parameters.AddWithValue("@nombre", nombreAlumno);
                                        comando.Parameters.AddWithValue("@apP", apellidoP);
                                        comando.Parameters.AddWithValue("@apM", apellidoM);
                                        comando.Parameters.AddWithValue("@dir", direccion);
                                        comando.Parameters.AddWithValue("@tel", telefono);
                                        comando.Parameters.AddWithValue("@correo", correo);
                                        comando.Parameters.AddWithValue("@prom", promedioBachillerato);
                                        comando.Parameters.AddWithValue("@idTutor", idTutor);
                                        comando.Parameters.AddWithValue("@idCarrera", idCarrera);

                                        comando.ExecuteNonQuery();
                                    }

                                    msg = "Los datos del alumno se actualizaron correctamente.";
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
                            string sqlDelAlumno = " DELETE FROM tblalumnos WHERE matricula = @matricula;";
                            using (comando = new MySqlCommand(sqlDelAlumno, conexion, transaccion))
                            {
                                comando.Parameters.AddWithValue("@matricula", matricula);
                                comando.ExecuteNonQuery();
                            }

                            string sqlDelUsuario = " DELETE FROM tblusuarios WHERE intidUsuario = @idUsuario;";
                            using (comando = new MySqlCommand(sqlDelUsuario, conexion, transaccion))
                            {
                                comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                                comando.ExecuteNonQuery();
                            }

                            transaccion.Commit();
                            msg = "El alumno y sus credenciales de usuario han sido eliminados del sistema.";
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


    }
}
