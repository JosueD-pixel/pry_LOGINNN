using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pry_LOGINNN
{
    public partial class frmDocentes : Form
    {
        clsDocentes docentes;
        int idclave;
        int idUsuario;

        public frmDocentes()
        {
            InitializeComponent();
            CargarGrid();

        }

        public void CargarGrid()
        {
            docentes = new clsDocentes();
            dgvDocentes.DataSource = null;
            dgvDocentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvDocentes.DataSource = docentes.CargarDataGrid();
                dgvDocentes.Columns["Usuario"].Visible = false;
                dgvDocentes.Columns["vchpassword"].Visible = false;
                dgvDocentes.Columns["vchperfil"].Visible = false;
                dgvDocentes.Columns["correo"].Visible = true;
                dgvDocentes.Columns["telefono"].Visible = true;
                dgvDocentes.Columns["idUsuario"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtClaveDocente_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveDocente.Text))
            {
                CargarGrid();
                return;
            }
            docentes = new clsDocentes();
            dgvDocentes.DataSource = null;
            dgvDocentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                docentes.Clave = int.Parse(txtClaveDocente.Text);
                dgvDocentes.DataSource = docentes.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show($"¿Estas completamente seguro de eliminar permanentemente al docente con Clave: {idclave}?\nEsta accion borrara tambien su cuenta de usuario.",
                        "¡ADVERTENCIA!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    docentes = new clsDocentes();
                    docentes.Clave = idclave;
                    docentes.IdUsuario = idUsuario;

                    string resultado = docentes.Eliminar();

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
