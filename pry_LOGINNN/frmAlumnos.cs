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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                //Determinamos el tipo de operacion 
                int tipoOperacion = idMatricula == 0 ? 0 : 1;

                alumnos = new clsAlumnos();
                // 1. Llenamos las propiedades del bloque Alumno
                alumnos.Matricula = int.Parse(txtMatricula.Text);
                alumnos.NombreAlumno = txtNombre.Text;
                alumnos.ApellidoP = txtAPaterno.Text;
                alumnos.ApellidoM = txtAMaterno.Text;
                alumnos.Direccion = txtDireccion.Text;
                alumnos.Telefono = txtTelefono.Text;
                alumnos.Correo = txtCorreo.Text;
                alumnos.PromedioBachillerato = decimal.Parse(txtPromedioBarchiller.Text);
                alumnos.IdCarrera = Convert.ToInt32(cmbCarreras.SelectedValue);
                alumnos.IdTutor = Convert.ToInt32(cmbTutores.SelectedValue);

                // 2. Llenamos las propiedades del bloque Usuario
                alumnos.IdUsuario = idUsuario; //Sera 0 si es nuevo, o el ID real si es update
                alumnos.NombreUsuario = txtUsuario.Text;
                alumnos.Password = txtPasword.Text;
                alumnos.Perfil = cmbPerfil.Text;

                string msg = "";

                //Si es una modificacion (tipoOperacion = 1 ), pedimos confirmacion como en carreras
                if (tipoOperacion == 1)
                {
                    var resp = MessageBox.Show("¿Confirmar que deseas actualizar los datos de este alumno?", "ALERTA ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resp == DialogResult.Yes)
                    {
                        msg = alumnos.GuardarActualizar(tipoOperacion);
                        MessageBox.Show(msg, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    msg = alumnos.GuardarActualizar(tipoOperacion);
                    MessageBox.Show(msg, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                CargarGrid(); //Refrescamos la tabla del formulario para ver los cambios
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron guardar los datos: " + ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show($"¿Estas completamente seguro de eliminar permanentemente al alumno con Matricula: {idMatricula}?\nEsta accion borrara tambien su cuenta de usuario.",
                                "¡ADVERTENCIA!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    alumnos = new clsAlumnos();
                    alumnos.Matricula = idMatricula;
                    alumnos.IdUsuario = idUsuario;

                    string resultado = alumnos.Eliminar();

                    MessageBox.Show(resultado, "Registro Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error al intentar eliminar el registro: " + ex.Message,
                                    "Error Operacional", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
