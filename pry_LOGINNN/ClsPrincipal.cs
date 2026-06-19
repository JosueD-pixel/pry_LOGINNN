using System;
using System.Collections.Generic;
using System.Text;

namespace pry_LOGINNN
{
    internal class ClsPrincipal
    {
        private Form misformasabiertos;

        public void AgregarAlcontenedor(Form formulario, Panel panel)
        {
            if (misformasabiertos != null)
            {
                misformasabiertos.Close();
                misformasabiertos.Dispose();
            }
            misformasabiertos = formulario;
            panel.Controls.Clear();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.Sizable;
            formulario.Dock = DockStyle.Fill;
            
            panel.Controls.Add(formulario);
            panel.Tag = formulario;
            formulario.Show();
        }
    
    }
}
