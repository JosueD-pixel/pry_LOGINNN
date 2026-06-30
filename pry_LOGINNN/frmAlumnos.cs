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




    }
}
