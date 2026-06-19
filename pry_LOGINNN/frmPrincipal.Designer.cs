namespace pry_LOGINNN
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            pcbMenu = new PictureBox();
            pcbAlumnos = new PictureBox();
            pcbDocentes = new PictureBox();
            pcbCarreras = new PictureBox();
            pcbUsuarios = new PictureBox();
            pcbTitulo = new PictureBox();
            pnlContenedor = new Panel();
            pcbTutores = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbDocentes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbCarreras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbTitulo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbTutores).BeginInit();
            SuspendLayout();
            // 
            // pcbMenu
            // 
            pcbMenu.Image = Properties.Resources.MENu1;
            pcbMenu.Location = new Point(26, 40);
            pcbMenu.Name = "pcbMenu";
            pcbMenu.Size = new Size(336, 895);
            pcbMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbMenu.TabIndex = 0;
            pcbMenu.TabStop = false;
            // 
            // pcbAlumnos
            // 
            pcbAlumnos.Image = Properties.Resources.alumnosBoton;
            pcbAlumnos.Location = new Point(88, 180);
            pcbAlumnos.Name = "pcbAlumnos";
            pcbAlumnos.Size = new Size(205, 97);
            pcbAlumnos.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbAlumnos.TabIndex = 1;
            pcbAlumnos.TabStop = false;
            pcbAlumnos.MouseDown += pcbGenerar_MouseDown;
            pcbAlumnos.MouseUp += pcbGenerar_MouseUp;
            // 
            // pcbDocentes
            // 
            pcbDocentes.Image = Properties.Resources.DocentesBoton;
            pcbDocentes.Location = new Point(88, 309);
            pcbDocentes.Name = "pcbDocentes";
            pcbDocentes.Size = new Size(205, 97);
            pcbDocentes.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbDocentes.TabIndex = 2;
            pcbDocentes.TabStop = false;
            pcbDocentes.MouseDown += pcbGenerar_MouseDown;
            pcbDocentes.MouseUp += pcbGenerar_MouseUp;
            // 
            // pcbCarreras
            // 
            pcbCarreras.Image = (Image)resources.GetObject("pcbCarreras.Image");
            pcbCarreras.Location = new Point(88, 439);
            pcbCarreras.Name = "pcbCarreras";
            pcbCarreras.Size = new Size(205, 97);
            pcbCarreras.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbCarreras.TabIndex = 3;
            pcbCarreras.TabStop = false;
            pcbCarreras.Click += pcbCarreras_Click;
            pcbCarreras.MouseDown += pcbGenerar_MouseDown;
            pcbCarreras.MouseUp += pcbGenerar_MouseUp;
            // 
            // pcbUsuarios
            // 
            pcbUsuarios.Image = Properties.Resources.UsuarioosBoton;
            pcbUsuarios.Location = new Point(88, 586);
            pcbUsuarios.Name = "pcbUsuarios";
            pcbUsuarios.Size = new Size(205, 97);
            pcbUsuarios.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbUsuarios.TabIndex = 4;
            pcbUsuarios.TabStop = false;
            pcbUsuarios.MouseDown += pcbGenerar_MouseDown;
            pcbUsuarios.MouseUp += pcbGenerar_MouseUp;
            // 
            // pcbTitulo
            // 
            pcbTitulo.Image = Properties.Resources.Sistema;
            pcbTitulo.Location = new Point(393, 76);
            pcbTitulo.Name = "pcbTitulo";
            pcbTitulo.Size = new Size(1236, 173);
            pcbTitulo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbTitulo.TabIndex = 5;
            pcbTitulo.TabStop = false;
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = SystemColors.ActiveCaption;
            pnlContenedor.Location = new Point(390, 232);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1241, 701);
            pnlContenedor.TabIndex = 6;
            // 
            // pcbTutores
            // 
            pcbTutores.Image = (Image)resources.GetObject("pcbTutores.Image");
            pcbTutores.Location = new Point(112, 744);
            pcbTutores.Name = "pcbTutores";
            pcbTutores.Size = new Size(205, 97);
            pcbTutores.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbTutores.TabIndex = 7;
            pcbTutores.TabStop = false;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1539, 844);
            Controls.Add(pcbTutores);
            Controls.Add(pnlContenedor);
            Controls.Add(pcbTitulo);
            Controls.Add(pcbUsuarios);
            Controls.Add(pcbCarreras);
            Controls.Add(pcbDocentes);
            Controls.Add(pcbAlumnos);
            Controls.Add(pcbMenu);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pcbMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbAlumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbDocentes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbCarreras).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbTitulo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbTutores).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private PictureBox pcbMenu;
        private PictureBox pcbAlumnos;
        private PictureBox pcbDocentes;
        private PictureBox pcbCarreras;
        private PictureBox pcbUsuarios;
        private PictureBox pcbTitulo;
        private Panel pnlContenedor;
        private PictureBox pcbTutores;
    }
}