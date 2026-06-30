using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pry_LOGINNN
{
    public partial class frmAlumnos : Form
    {
        clsAlumnos alumnos;
        public frmAlumnos()
        {
            InitializeComponent();
            CargarGrid();
            CargarCombos();
        }

        public void CargarGrid()
        {
            alumnos = new clsAlumnos();
            dgvAlumnos.DataSource = null;
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvAlumnos.DataSource = alumnos.CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
                }//Liberarla conexion
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion al obtener el catalogo de tutores" + ex.Message);
            }
            return tabla;
        }


    }
}
