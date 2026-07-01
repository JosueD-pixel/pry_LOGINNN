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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            pcbLogo.Location = new Point(594, 22);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(102, 66);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 26;
            pcbLogo.TabStop = false;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtNombre.Location = new Point(17, 42);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(264, 29);
            txtNombre.TabIndex = 0;
            // 
            // txtMatricula
            // 
            txtMatricula.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtMatricula.Location = new Point(17, 12);
            txtMatricula.Margin = new Padding(3, 2, 3, 2);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PlaceholderText = "Matricula";
            txtMatricula.Size = new Size(264, 29);
            txtMatricula.TabIndex = 2;
            // 
            // txtAPaterno
            // 
            txtAPaterno.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtAPaterno.Location = new Point(17, 72);
            txtAPaterno.Margin = new Padding(3, 2, 3, 2);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.PlaceholderText = "Apellido Paterno";
            txtAPaterno.Size = new Size(264, 29);
            txtAPaterno.TabIndex = 3;
            // 
            // txtPromedioBarchiller
            // 
            txtPromedioBarchiller.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtPromedioBarchiller.Location = new Point(312, 72);
            txtPromedioBarchiller.Margin = new Padding(3, 2, 3, 2);
            txtPromedioBarchiller.Name = "txtPromedioBarchiller";
            txtPromedioBarchiller.PlaceholderText = "Promedio ";
            txtPromedioBarchiller.Size = new Size(264, 29);
            txtPromedioBarchiller.TabIndex = 4;
            // 
            // txtAMaterno
            // 
            txtAMaterno.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtAMaterno.Location = new Point(17, 102);
            txtAMaterno.Margin = new Padding(3, 2, 3, 2);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.PlaceholderText = "Apellido Materno";
            txtAMaterno.Size = new Size(264, 29);
            txtAMaterno.TabIndex = 5;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtDireccion.Location = new Point(17, 132);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Direccion ";
            txtDireccion.Size = new Size(264, 29);
            txtDireccion.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtTelefono.Location = new Point(312, 12);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(264, 29);
            txtTelefono.TabIndex = 7;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtCorreo.Location = new Point(312, 42);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo";
            txtCorreo.Size = new Size(264, 29);
            txtCorreo.TabIndex = 8;
            // 
            // cmbTutores
            // 
            cmbTutores.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmbTutores.FormattingEnabled = true;
            cmbTutores.Location = new Point(312, 100);
            cmbTutores.Margin = new Padding(3, 2, 3, 2);
            cmbTutores.Name = "cmbTutores";
            cmbTutores.Size = new Size(266, 29);
            cmbTutores.TabIndex = 9;
            // 
            // cmbCarreras
            // 
            cmbCarreras.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmbCarreras.FormattingEnabled = true;
            cmbCarreras.Location = new Point(312, 130);
            cmbCarreras.Margin = new Padding(3, 2, 3, 2);
            cmbCarreras.Name = "cmbCarreras";
            cmbCarreras.Size = new Size(266, 29);
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
            pnlAlumnos.Location = new Point(85, 94);
            pnlAlumnos.Margin = new Padding(3, 2, 3, 2);
            pnlAlumnos.Name = "pnlAlumnos";
            pnlAlumnos.Size = new Size(615, 168);
            pnlAlumnos.TabIndex = 11;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtUsuario.Location = new Point(17, 12);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = " Nombre";
            txtUsuario.Size = new Size(264, 29);
            txtUsuario.TabIndex = 13;
            // 
            // txtPasword
            // 
            txtPasword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtPasword.Location = new Point(17, 42);
            txtPasword.Margin = new Padding(3, 2, 3, 2);
            txtPasword.Name = "txtPasword";
            txtPasword.PasswordChar = '*';
            txtPasword.PlaceholderText = "Contraseña";
            txtPasword.Size = new Size(264, 29);
            txtPasword.TabIndex = 12;
            // 
            // pnlUsuarios
            // 
            pnlUsuarios.BackColor = SystemColors.ControlDarkDark;
            pnlUsuarios.Controls.Add(cmbPerfil);
            pnlUsuarios.Controls.Add(txtUsuario);
            pnlUsuarios.Controls.Add(txtPasword);
            pnlUsuarios.Location = new Point(705, 94);
            pnlUsuarios.Margin = new Padding(3, 2, 3, 2);
            pnlUsuarios.Name = "pnlUsuarios";
            pnlUsuarios.Size = new Size(312, 168);
            pnlUsuarios.TabIndex = 15;
            // 
            // cmbPerfil
            // 
            cmbPerfil.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmbPerfil.FormattingEnabled = true;
            cmbPerfil.Items.AddRange(new object[] { "Administrador", "Alumno", "Docente", "Tutor" });
            cmbPerfil.Location = new Point(17, 102);
            cmbPerfil.Margin = new Padding(3, 2, 3, 2);
            cmbPerfil.Name = "cmbPerfil";
            cmbPerfil.Size = new Size(266, 29);
            cmbPerfil.TabIndex = 11;
            // 
            // Alumno
            // 
            Alumno.AutoSize = true;
            Alumno.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Alumno.Location = new Point(88, 68);
            Alumno.Name = "Alumno";
            Alumno.Size = new Size(83, 25);
            Alumno.TabIndex = 16;
            Alumno.Text = "Alumno";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(705, 68);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 17;
            label1.Text = "Usuarios";
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_06_17_183955;
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Location = new Point(563, 267);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(118, 64);
            btnEliminar.TabIndex = 21;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_06_17_184226;
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(434, 267);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(123, 64);
            btnGuardar.TabIndex = 19;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_06_17_1831001;
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Location = new Point(319, 267);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(109, 64);
            btnNuevo.TabIndex = 18;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtMatriculaAlumno
            // 
            txtMatriculaAlumno.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMatriculaAlumno.Location = new Point(874, 303);
            txtMatriculaAlumno.Name = "txtMatriculaAlumno";
            txtMatriculaAlumno.PlaceholderText = "Buscar Alumno";
            txtMatriculaAlumno.Size = new Size(148, 32);
            txtMatriculaAlumno.TabIndex = 22;
            txtMatriculaAlumno.TextChanged += txtMatriculaAlumno_TextChanged;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Bisque;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvAlumnos.DefaultCellStyle = dataGridViewCellStyle4;
            dgvAlumnos.EnableHeadersVisualStyles = false;
            dgvAlumnos.Location = new Point(86, 334);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.RowHeadersWidth = 51;
            dgvAlumnos.RowTemplate.Height = 35;
            dgvAlumnos.Size = new Size(936, 130);
            dgvAlumnos.TabIndex = 20;
            dgvAlumnos.SelectionChanged += dgvAlumnos_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(430, -3);
            label2.Name = "label2";
            label2.Size = new Size(0, 37);
            label2.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(514, 238);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 24;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(406, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(165, 47);
            lblTitulo.TabIndex = 25;
            lblTitulo.Text = "Alumnos";
            // 
            // frmAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1050, 499);
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
            Margin = new Padding(3, 2, 3, 2);
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