using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pry_LOGINNN
{
    public partial class frmPrincipal : Form
    {
        ClsPrincipal principal;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void pcbGenerar_MouseDown(object mipicture, MouseEventArgs e)
        {
            PictureBox pcb = (PictureBox)mipicture;
            pcb.Location = new Point(pcb.Location.X + 3, pcb.Location.Y + 3);
        }

        private void pcbGenerar_MouseUp(object mipicture, MouseEventArgs e)
        {
            PictureBox pcb = (PictureBox)mipicture;
            pcb.Location = new Point(pcb.Location.X - 3, pcb.Location.Y - 3);

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            pcbAlumnos.Parent = pcbMenu;
            pcbDocentes.Parent = pcbMenu;
            pcbCarreras.Parent = pcbMenu;
            pcbUsuarios.Parent = pcbMenu;
            pcbTutores.Parent = pcbMenu;

            pcbAlumnos.BackColor = Color.Transparent;
            pcbDocentes.BackColor = Color.Transparent;
            pcbCarreras.BackColor = Color.Transparent;
            pcbUsuarios.BackColor = Color.Transparent;

            pcbCarreras.Enabled = clsLogin.EsAdministrador;
            pcbDocentes.Enabled = clsLogin.EsAdministrador;
            pcbUsuarios.Enabled = clsLogin.EsAdministrador;

            pcbAlumnos.Enabled = clsLogin.EsAdministrador || clsLogin.EsDocente;

        }

        private void pcbCarreras_Click(object sender, EventArgs e)
        {
            principal = new ClsPrincipal();
            principal.AgregarAlcontenedor(new frmCarrera(), pnlContenedor);
        }

        private void pcbTutores_Click(object sender, EventArgs e)
        {
            principal = new ClsPrincipal();
            principal.AgregarAlcontenedor(new frmTutores(), pnlContenedor);
        }
    }
}
