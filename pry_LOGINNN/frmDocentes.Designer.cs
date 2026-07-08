namespace pry_LOGINNN
{
    partial class frmDocentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocentes));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvDocentes = new DataGridView();
            pnlDocentes = new Panel();
            txtNombre = new TextBox();
            cmbPuesto = new ComboBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtClave = new TextBox();
            pnlUsuarios = new Panel();
            cmbPerfil = new ComboBox();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            txtClaveDocente = new TextBox();
            lblTitulo = new Label();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            pcbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).BeginInit();
            pnlDocentes.SuspendLayout();
            pnlUsuarios.SuspendLayout();
            SuspendLayout();
            // 
            // pcbLogo
            // 
            pcbLogo.Image = (Image)resources.GetObject("pcbLogo.Image");
            pcbLogo.Location = new Point(790, 35);
            pcbLogo.Margin = new Padding(4, 5, 4, 5);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(146, 118);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 33;
            pcbLogo.TabStop = false;
            // 
            // dgvDocentes
            // 
            dgvDocentes.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Bisque;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDocentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDocentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDocentes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDocentes.EnableHeadersVisualStyles = false;
            dgvDocentes.Location = new Point(89, 551);
            dgvDocentes.Margin = new Padding(4, 5, 4, 5);
            dgvDocentes.Name = "dgvDocentes";
            dgvDocentes.RowHeadersWidth = 51;
            dgvDocentes.RowTemplate.Height = 35;
            dgvDocentes.Size = new Size(1338, 216);
            dgvDocentes.TabIndex = 21;
            dgvDocentes.SelectionChanged += dgvDocentes_SelectionChanged;
            // 
            // pnlDocentes
            // 
            pnlDocentes.BackColor = SystemColors.ActiveCaption;
            pnlDocentes.Controls.Add(txtNombre);
            pnlDocentes.Controls.Add(cmbPuesto);
            pnlDocentes.Controls.Add(txtCorreo);
            pnlDocentes.Controls.Add(txtTelefono);
            pnlDocentes.Controls.Add(txtClave);
            pnlDocentes.Location = new Point(89, 161);
            pnlDocentes.Margin = new Padding(4, 4, 4, 4);
            pnlDocentes.Name = "pnlDocentes";
            pnlDocentes.Size = new Size(879, 265);
            pnlDocentes.TabIndex = 22;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(32, 74);
            txtNombre.Margin = new Padding(4, 4, 4, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(383, 39);
            txtNombre.TabIndex = 31;
            // 
            // cmbPuesto
            // 
            cmbPuesto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmbPuesto.FormattingEnabled = true;
            cmbPuesto.Items.AddRange(new object[] { "Profesor", "Coordinador" });
            cmbPuesto.Location = new Point(32, 141);
            cmbPuesto.Margin = new Padding(4, 4, 4, 4);
            cmbPuesto.Name = "cmbPuesto";
            cmbPuesto.Size = new Size(383, 40);
            cmbPuesto.TabIndex = 26;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(424, 74);
            txtCorreo.Margin = new Padding(4, 4, 4, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo";
            txtCorreo.Size = new Size(383, 39);
            txtCorreo.TabIndex = 30;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(424, 24);
            txtTelefono.Margin = new Padding(4, 4, 4, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(383, 39);
            txtTelefono.TabIndex = 29;
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtClave.Location = new Point(32, 24);
            txtClave.Margin = new Padding(4, 4, 4, 4);
            txtClave.Name = "txtClave";
            txtClave.PlaceholderText = "Clave";
            txtClave.Size = new Size(383, 39);
            txtClave.TabIndex = 26;
            // 
            // pnlUsuarios
            // 
            pnlUsuarios.BackColor = SystemColors.ActiveCaption;
            pnlUsuarios.Controls.Add(cmbPerfil);
            pnlUsuarios.Controls.Add(txtPassword);
            pnlUsuarios.Controls.Add(txtUsuario);
            pnlUsuarios.Location = new Point(980, 161);
            pnlUsuarios.Margin = new Padding(4, 4, 4, 4);
            pnlUsuarios.Name = "pnlUsuarios";
            pnlUsuarios.Size = new Size(446, 265);
            pnlUsuarios.TabIndex = 23;
            // 
            // cmbPerfil
            // 
            cmbPerfil.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmbPerfil.FormattingEnabled = true;
            cmbPerfil.Items.AddRange(new object[] { "Administrador", "Alumno", "Docente", "Tutor" });
            cmbPerfil.Location = new Point(19, 141);
            cmbPerfil.Margin = new Padding(4, 4, 4, 4);
            cmbPerfil.Name = "cmbPerfil";
            cmbPerfil.Size = new Size(383, 40);
            cmbPerfil.TabIndex = 24;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(19, 74);
            txtPassword.Margin = new Padding(4, 4, 4, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(383, 39);
            txtPassword.TabIndex = 25;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(19, 24);
            txtUsuario.Margin = new Padding(4, 4, 4, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Nombre";
            txtUsuario.Size = new Size(383, 39);
            txtUsuario.TabIndex = 24;
            // 
            // txtClaveDocente
            // 
            txtClaveDocente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtClaveDocente.Location = new Point(1042, 486);
            txtClaveDocente.Margin = new Padding(4, 4, 4, 4);
            txtClaveDocente.Name = "txtClaveDocente";
            txtClaveDocente.PlaceholderText = "Buscar Docente";
            txtClaveDocente.Size = new Size(383, 39);
            txtClaveDocente.TabIndex = 31;
            txtClaveDocente.TextChanged += txtClaveDocente_TextChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(512, 52);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(255, 70);
            lblTitulo.TabIndex = 32;
            lblTitulo.Text = "Docentes";
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_06_17_1831001;
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Location = new Point(456, 435);
            btnNuevo.Margin = new Padding(4, 5, 4, 5);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(156, 106);
            btnNuevo.TabIndex = 26;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_06_17_184226;
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(620, 435);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(176, 106);
            btnGuardar.TabIndex = 34;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_06_17_183955;
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Location = new Point(804, 435);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(169, 106);
            btnEliminar.TabIndex = 35;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmDocentes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.bordes;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1500, 816);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(pcbLogo);
            Controls.Add(lblTitulo);
            Controls.Add(txtClaveDocente);
            Controls.Add(pnlUsuarios);
            Controls.Add(pnlDocentes);
            Controls.Add(dgvDocentes);
            DoubleBuffered = true;
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmDocentes";
            Text = "frmDocentes";
            
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).EndInit();
            pnlDocentes.ResumeLayout(false);
            pnlDocentes.PerformLayout();
            pnlUsuarios.ResumeLayout(false);
            pnlUsuarios.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDocentes;
        private Panel pnlDocentes;
        private Panel pnlUsuarios;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private ComboBox cmbPerfil;
        private TextBox txtTelefono;
        private TextBox textBox4;
        private TextBox txtClave;
        private TextBox txtCorreo;
        private ComboBox cmbPuesto;
        private TextBox txtClaveDocente;
        private TextBox txtNombre;
        private Label lblTitulo;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEliminar;
    }
}