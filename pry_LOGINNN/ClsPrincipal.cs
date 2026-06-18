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
            if(misformasabiertos != null)
            {
                misformasabiertos.Close();
                misformasabiertos.Dispose(); 
            }
            misformasabiertos = formulario;
            panel.Controls.Clear();

            //VAS NATHAN 
        }
    
    }
}
