using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pry_LOGINNN
{
    public partial class frmCarrera : Form
    {
        ClsCarreras carreras;
        public frmCarrera()
        {
            InitializeComponent();

            carreras = new ClsCarreras();
            dgvCarreras.DataSource = null;
            dgvCarreras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvCarreras.DataSource = carreras.CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNombreCarrera_TextChanged(object sender, EventArgs e)
        {
            carreras = new ClsCarreras();
            dgvCarreras.DataSource = null;
            dgvCarreras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                carreras.NombreCarrera = txtNombreCarrera.Text;
                dgvCarreras.DataSource = carreras.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                int tipoOperacion = idCarrera == 0 ? 0 : 1;
                carreras.IdCarrera = idCarrera;
                carreras.NombreCarrera = txtNombre.Text;
                carreras.Descripcion = txtDescripcion.Text;
                string msg = "";
                if (tipoOperacion != 0)
                {
                    var resp = MessageBox.Show("Confirmar que desea eliminar el dato seleccionado", "ALERTA!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resp == DialogResult.Yes)
                    {
                        msg = carreras.GuardarActualizar(tipoOperacion);
                        MessageBox.Show(msg);
                    }
                }
                else
                {
                    msg = carreras.GuardarActualizar(tipoOperacion);
                    MessageBox.Show(msg);
                }
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            idCarrera = 0;
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtNombre.Focus();

        }
    }

}
