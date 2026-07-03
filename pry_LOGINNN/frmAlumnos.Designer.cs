namespace pry_LOGINNN
{
    partial class frmAlumnos
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
            PictureBox pcbLogo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlumnos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtNombre = new TextBox();
            txtMatricula = new TextBox();
            txtAPaterno = new TextBox();
            txtPromedioBarchiller = new TextBox();
            txtAMaterno = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            cmbTutores = new ComboBox();
            cmbCarreras = new ComboBox();
            pnlAlumnos = new Panel();
            txtUsuario = new TextBox();
            txtPasword = new TextBox();
            pnlUsuarios = new Panel();
            cmbPerfil = new ComboBox();
            Alumno = new Label();
            label1 = new Label();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            txtMatriculaAlumno = new TextBox();
            dgvAlumnos = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            lblTitulo = new Label();
            pcbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            pnlAlumnos.SuspendLayout();
            pnlUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // pcbLogo
            // 
            pcbLogo.Image = (Image)resources.GetObject("pcbLogo.Image");
            pcbLogo.Location = new Point(849, 37);
            pcbLogo.Margin = new Padding(4, 5, 4, 5);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(146, 110);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 26;
            pcbLogo.TabStop = false;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtNombre.Location = new Point(24, 70);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(375, 39);
            txtNombre.TabIndex = 0;
            // 
            // txtMatricula
            // 
            txtMatricula.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtMatricula.Location = new Point(24, 20);
            txtMatricula.Margin = new Padding(4, 3, 4, 3);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PlaceholderText = "Matricula";
            txtMatricula.Size = new Size(375, 39);
            txtMatricula.TabIndex = 2;
            // 
            // txtAPaterno
            // 
            txtAPaterno.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtAPaterno.Location = new Point(24, 120);
            txtAPaterno.Margin = new Padding(4, 3, 4, 3);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.PlaceholderText = "Apellido Paterno";
            txtAPaterno.Size = new Size(375, 39);
            txtAPaterno.TabIndex = 3;
            // 
            // txtPromedioBarchiller
            // 
            txtPromedioBarchiller.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtPromedioBarchiller.Location = new Point(446, 120);
            txtPromedioBarchiller.Margin = new Padding(4, 3, 4, 3);
            txtPromedioBarchiller.Name = "txtPromedioBarchiller";
            txtPromedioBarchiller.PlaceholderText = "Promedio ";
            txtPromedioBarchiller.Size = new Size(375, 39);
            txtPromedioBarchiller.TabIndex = 4;
            // 
            // txtAMaterno
            // 
            txtAMaterno.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtAMaterno.Location = new Point(24, 170);
            txtAMaterno.Margin = new Padding(4, 3, 4, 3);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.PlaceholderText = "Apellido Materno";
            txtAMaterno.Size = new Size(375, 39);
            txtAMaterno.TabIndex = 5;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtDireccion.Location = new Point(24, 220);
            txtDireccion.Margin = new Padding(4, 3, 4, 3);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Direccion ";
            txtDireccion.Size = new Size(375, 39);
            txtDireccion.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtTelefono.Location = new Point(446, 20);
            txtTelefono.Margin = new Padding(4, 3, 4, 3);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(375, 39);
            txtTelefono.TabIndex = 7;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtCorreo.Location = new Point(446, 70);
            txtCorreo.Margin = new Padding(4, 3, 4, 3);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo";
            txtCorreo.Size = new Size(375, 39);
            txtCorreo.TabIndex = 8;
            // 
            // cmbTutores
            // 
            cmbTutores.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmbTutores.FormattingEnabled = true;
            cmbTutores.Location = new Point(446, 167);
            cmbTutores.Margin = new Padding(4, 3, 4, 3);
            cmbTutores.Name = "cmbTutores";
            cmbTutores.Size = new Size(378, 40);
            cmbTutores.TabIndex = 9;
            // 
            // cmbCarreras
            // 
            cmbCarreras.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmbCarreras.FormattingEnabled = true;
            cmbCarreras.Location = new Point(446, 217);
            cmbCarreras.Margin = new Padding(4, 3, 4, 3);
            cmbCarreras.Name = "cmbCarreras";
            cmbCarreras.Size = new Size(378, 40);
            cmbCarreras.TabIndex = 10;
            // 
            // pnlAlumnos
            // 
            pnlAlumnos.BackColor = SystemColors.ControlDarkDark;
            pnlAlumnos.Controls.Add(txtMatricula);
            pnlAlumnos.Controls.Add(cmbCarreras);
            pnlAlumnos.Controls.Add(txtNombre);
            pnlAlumnos.Controls.Add(cmbTutores);
            pnlAlumnos.Controls.Add(txtAPaterno);
            pnlAlumnos.Controls.Add(txtCorreo);
            pnlAlumnos.Controls.Add(txtPromedioBarchiller);
            pnlAlumnos.Controls.Add(txtTelefono);
            pnlAlumnos.Controls.Add(txtAMaterno);
            pnlAlumnos.Controls.Add(txtDireccion);
            pnlAlumnos.Location = new Point(121, 157);
            pnlAlumnos.Margin = new Padding(4, 3, 4, 3);
            pnlAlumnos.Name = "pnlAlumnos";
            pnlAlumnos.Size = new Size(879, 280);
            pnlAlumnos.TabIndex = 11;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtUsuario.Location = new Point(24, 20);
            txtUsuario.Margin = new Padding(4, 3, 4, 3);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = " Nombre";
            txtUsuario.Size = new Size(375, 39);
            txtUsuario.TabIndex = 13;
            // 
            // txtPasword
            // 
            txtPasword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtPasword.Location = new Point(24, 70);
            txtPasword.Margin = new Padding(4, 3, 4, 3);
            txtPasword.Name = "txtPasword";
            txtPasword.PasswordChar = '*';
            txtPasword.PlaceholderText = "Contraseña";
            txtPasword.Size = new Size(375, 39);
            txtPasword.TabIndex = 12;
            // 
            // pnlUsuarios
            // 
            pnlUsuarios.BackColor = SystemColors.ControlDarkDark;
            pnlUsuarios.Controls.Add(cmbPerfil);
            pnlUsuarios.Controls.Add(txtUsuario);
            pnlUsuarios.Controls.Add(txtPasword);
            pnlUsuarios.Location = new Point(1007, 157);
            pnlUsuarios.Margin = new Padding(4, 3, 4, 3);
            pnlUsuarios.Name = "pnlUsuarios";
            pnlUsuarios.Size = new Size(446, 280);
            pnlUsuarios.TabIndex = 15;
            // 
            // cmbPerfil
            // 
            cmbPerfil.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmbPerfil.FormattingEnabled = true;
            cmbPerfil.Items.AddRange(new object[] { "Administrador", "Alumno", "Docente", "Tutor" });
            cmbPerfil.Location = new Point(24, 170);
            cmbPerfil.Margin = new Padding(4, 3, 4, 3);
            cmbPerfil.Name = "cmbPerfil";
            cmbPerfil.Size = new Size(378, 40);
            cmbPerfil.TabIndex = 11;
            // 
            // Alumno
            // 
            Alumno.AutoSize = true;
            Alumno.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Alumno.Location = new Point(126, 113);
            Alumno.Margin = new Padding(4, 0, 4, 0);
            Alumno.Name = "Alumno";
            Alumno.Size = new Size(122, 38);
            Alumno.TabIndex = 16;
            Alumno.Text = "Alumno";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1007, 113);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 38);
            label1.TabIndex = 17;
            label1.Text = "Usuarios";
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_06_17_183955;
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Location = new Point(804, 445);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(169, 107);
            btnEliminar.TabIndex = 21;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_06_17_184226;
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(620, 445);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(176, 107);
            btnGuardar.TabIndex = 19;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_06_17_1831001;
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Location = new Point(456, 445);
            btnNuevo.Margin = new Padding(4, 5, 4, 5);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(156, 107);
            btnNuevo.TabIndex = 18;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtMatriculaAlumno
            // 
            txtMatriculaAlumno.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMatriculaAlumno.Location = new Point(1249, 505);
            txtMatriculaAlumno.Margin = new Padding(4, 5, 4, 5);
            txtMatriculaAlumno.Name = "txtMatriculaAlumno";
            txtMatriculaAlumno.PlaceholderText = "Buscar Alumno";
            txtMatriculaAlumno.Size = new Size(210, 44);
            txtMatriculaAlumno.TabIndex = 22;
            txtMatriculaAlumno.TextChanged += txtMatriculaAlumno_TextChanged;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Bisque;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAlumnos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAlumnos.EnableHeadersVisualStyles = false;
            dgvAlumnos.Location = new Point(123, 557);
            dgvAlumnos.Margin = new Padding(4, 5, 4, 5);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.RowHeadersWidth = 51;
            dgvAlumnos.RowTemplate.Height = 35;
            dgvAlumnos.Size = new Size(1337, 217);
            dgvAlumnos.TabIndex = 20;
            dgvAlumnos.SelectionChanged += dgvAlumnos_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(614, -5);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 54);
            label2.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(734, 397);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 38);
            label3.TabIndex = 24;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(580, 38);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(247, 70);
            lblTitulo.TabIndex = 25;
            lblTitulo.Text = "Alumnos";
            // 
            // frmAlumnos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1500, 832);
            Controls.Add(pcbLogo);
            Controls.Add(lblTitulo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(txtMatriculaAlumno);
            Controls.Add(dgvAlumnos);
            Controls.Add(label1);
            Controls.Add(Alumno);
            Controls.Add(pnlUsuarios);
            Controls.Add(pnlAlumnos);
            DoubleBuffered = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmAlumnos";
            Text = "frmAlumnos";
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            pnlAlumnos.ResumeLayout(false);
            pnlAlumnos.PerformLayout();
            pnlUsuarios.ResumeLayout(false);
            pnlUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtMatricula;
        private TextBox txtAPaterno;
        private TextBox txtPromedioBarchiller;
        private TextBox txtAMaterno;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private ComboBox cmbTutores;
        private ComboBox cmbCarreras;
        private Panel pnlAlumnos;
        private TextBox txtUsuario;
        private TextBox txtPasword;
        private TextBox txtPerfil;
        private Panel pnlUsuarios;
        private Label Alumno;
        private Label label1;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnNuevo;
        private TextBox txtMatriculaAlumno;
        private DataGridView dgvAlumnos;
        private Label label2;
        private Label label3;
        private Label lblTitulo;
        private ComboBox cmbPerfil;
    }
}