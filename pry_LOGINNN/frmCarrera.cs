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
            dgvCarreras.DataSource = carreras;
            dgvCarreras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCarreras.DataSource = carreras.CargarDataGrid;

        }
    }
}
