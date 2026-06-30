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
        public void CargarCombos()
        {
            alumnos = new clsAlumnos();

            try
            {
                DataTable dtCarreras = alumnos.ObtenerCarreras();

                //Creamos la fila del placeholder para la carrera
                DataRow filaCarrera = dtCarreras.NewRow();
                filaCarrera["idCarrera"] = 0;
                filaCarrera["nombreCarrera"] = "-- Selecciona una Carrera";
                dtCarreras.Rows.InsertAt(filaCarrera, 0);

                //Enlazamos los datos al ComboBox visual

                cmbCarreras.DataSource = dtCarreras;
                cmbCarreras.DisplayMember = "nombreCarrera"; //El texto visible
                cmbCarreras.ValueMember = "idCarrera"; //La llave primaria real
                cmbCarreras.SelectedIndex = 0; //Forzar a que muestre el placeholder

                DataTable dtTutores = alumnos.ObtenerCarreras();

                //Creamos la fila del placeholder para la carrera
                DataRow filaTutores = dtTutores.NewRow();
                filaTutores["idTutor"] = 0;
                filaTutores["nombreTutor"] = "-- Selecciona una Tutor";
                dtTutores.Rows.InsertAt(filaCarrera, 0);

                //Enlazamos los datos al ComboBox visual

                cmbTutores.DataSource = dtTutores;
                cmbTutores.DisplayMember = "nombreTutor"; //El texto visible
                cmbTutores.ValueMember = "idTutor"; //La llave primaria real
                cmbTutores.SelectedIndex = 0; //Forzar a que muestre el placeholder
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al rellenar los catalogos en los menus desplegados" + ex.Message);
            }
        }


    }
}
