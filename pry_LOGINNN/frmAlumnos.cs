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
        int idMatricula;
        int idUsuario;

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
                dgvAlumnos.Columns["Usuario"].Visible = false;
                dgvAlumnos.Columns["vchpassword"].Visible = false;
                dgvAlumnos.Columns["vchperfil"].Visible = false;
                dgvAlumnos.Columns["direccion"].Visible = false;
                dgvAlumnos.Columns["correo"].Visible = false;
                dgvAlumnos.Columns["telefono"].Visible = false;
                dgvAlumnos.Columns["promedioBachillerato"].Visible = false;
                dgvAlumnos.Columns["idTutor"].Visible = false;
                dgvAlumnos.Columns["idCarrera"].Visible = false;
                dgvAlumnos.Columns["idUsuario"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
                filaCarrera["nombreCarrera"] = "-- Selecciona una Carrera --";
                dtCarreras.Rows.InsertAt(filaCarrera, 0);

                //Enlazamos los datos al ComboBox visual

                cmbCarreras.DataSource = dtCarreras;
                cmbCarreras.DisplayMember = "nombreCarrera"; //El texto visible
                cmbCarreras.ValueMember = "idCarrera"; //La llave primaria real
                cmbCarreras.SelectedIndex = 0; //Forzar a que muestre el placeholder

                DataTable dtTutores = alumnos.ObtenerTutores();

                //Creamos la fila del placeholder para la carrera
                DataRow filaTutores = dtTutores.NewRow();
                filaTutores["idTutor"] = 0;
                filaTutores["nombreTutor"] = "-- Selecciona una Tutor --";
                dtTutores.Rows.InsertAt(filaTutores, 0);

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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            idMatricula = 0;
            idUsuario = 0;
            alumnos.LimpiarPanel(pnlAlumnos);
            alumnos.LimpiarPanel(pnlUsuarios);
            txtMatricula.Focus();

        }

        private void txtMatriculaAlumno_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatriculaAlumno.Text))
            {
                CargarGrid();
                return;
            }
            alumnos = new clsAlumnos();
            dgvAlumnos.DataSource = null;
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                alumnos.Matricula = int.Parse(txtMatriculaAlumno.Text);
                dgvAlumnos.DataSource = alumnos.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                //esto es para saber si es nuevo o vamos a actualizar
                idMatricula = int.Parse(dgvAlumnos.CurrentRow.Cells["Matricula"].Value.ToString());
                idUsuario = int.Parse(dgvAlumnos.CurrentRow.Cells["idUsuario"].Value.ToString());

                //Esto es para la tabla alumnos
                txtMatricula.Text = idMatricula.ToString();
                txtNombre.Text = dgvAlumnos.CurrentRow.Cells["Nombre"].Value.ToString();
                txtAPaterno.Text = dgvAlumnos.CurrentRow.Cells["A. Paterno"].Value.ToString();
                txtAMaterno.Text = dgvAlumnos.CurrentRow.Cells["A. Materno"].Value.ToString();
                txtDireccion.Text = dgvAlumnos.CurrentRow.Cells["direccion"].Value.ToString();
                txtTelefono.Text = dgvAlumnos.CurrentRow.Cells["telefono"].Value.ToString();
                txtCorreo.Text = dgvAlumnos.CurrentRow.Cells["correo"].Value.ToString();
                txtPromedioBarchiller.Text = dgvAlumnos.CurrentRow.Cells["promedioBachillerato"].Value.ToString();

                //Eesto es para la tabla usuarios

                txtUsuario.Text = dgvAlumnos.CurrentRow.Cells["Usuario"].Value.ToString();
                txtPasword.Text = dgvAlumnos.CurrentRow.Cells["vchpassword"].Value.ToString();
                cmbPerfil.Text = dgvAlumnos.CurrentRow.Cells["vchperfil"].Value.ToString();

                cmbCarreras.SelectedValue = int.Parse(dgvAlumnos.CurrentRow.Cells["idCarrera"].Value.ToString());
                cmbTutores.SelectedValue = int.Parse(dgvAlumnos.CurrentRow.Cells["idTutor"].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mapear los datos seleccionados " + ex.Message);
            }

        }
    }
}
