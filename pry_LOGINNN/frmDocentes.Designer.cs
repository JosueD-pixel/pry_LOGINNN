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
            pcbLogo.Location = new Point(565, 21);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(102, 78);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 33;
            pcbLogo.TabStop = false;
            pcbLogo.Click += pcbLogo_Click;
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
            dgvDocentes.Location = new Point(62, 322);
            dgvDocentes.Name = "dgvDocentes";
            dgvDocentes.RowHeadersWidth = 51;
            dgvDocentes.RowTemplate.Height = 35;
            dgvDocentes.Size = new Size(936, 130);
            dgvDocentes.TabIndex = 21;
            // 
            // pnlDocentes
            // 
            pnlDocentes.BackColor = SystemColors.ActiveCaption;
            pnlDocentes.Controls.Add(txtNombre);
            pnlDocentes.Controls.Add(cmbPuesto);
            pnlDocentes.Controls.Add(txtCorreo);
            pnlDocentes.Controls.Add(txtTelefono);
            pnlDocentes.Controls.Add(txtClave);
            pnlDocentes.Location = new Point(62, 113);
            pnlDocentes.Margin = new Padding(3, 2, 3, 2);
            pnlDocentes.Name = "pnlDocentes";
            pnlDocentes.Size = new Size(615, 168);
            pnlDocentes.TabIndex = 22;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(23, 44);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(269, 29);
            txtNombre.TabIndex = 31;
            // 
            // cmbPuesto
            // 
            cmbPuesto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmbPuesto.FormattingEnabled = true;
            cmbPuesto.Items.AddRange(new object[] { "Profesor", "Coordinador" });
            cmbPuesto.Location = new Point(23, 85);
            cmbPuesto.Margin = new Padding(3, 2, 3, 2);
            cmbPuesto.Name = "cmbPuesto";
            cmbPuesto.Size = new Size(269, 29);
            cmbPuesto.TabIndex = 26;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(297, 44);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo";
            txtCorreo.Size = new Size(269, 29);
            txtCorreo.TabIndex = 30;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(297, 14);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(269, 29);
            txtTelefono.TabIndex = 29;
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtClave.Location = new Point(23, 14);
            txtClave.Margin = new Padding(3, 2, 3, 2);
            txtClave.Name = "txtClave";
            txtClave.PlaceholderText = "Clave";
            txtClave.Size = new Size(269, 29);
            txtClave.TabIndex = 26;
            // 
            // pnlUsuarios
            // 
            pnlUsuarios.BackColor = SystemColors.ActiveCaption;
            pnlUsuarios.Controls.Add(cmbPerfil);
            pnlUsuarios.Controls.Add(txtPassword);
            pnlUsuarios.Controls.Add(txtUsuario);
            pnlUsuarios.Location = new Point(686, 113);
            pnlUsuarios.Margin = new Padding(3, 2, 3, 2);
            pnlUsuarios.Name = "pnlUsuarios";
            pnlUsuarios.Size = new Size(312, 168);
            pnlUsuarios.TabIndex = 23;
            // 
            // cmbPerfil
            // 
            cmbPerfil.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmbPerfil.FormattingEnabled = true;
            cmbPerfil.Items.AddRange(new object[] { "Administrador", "Alumno", "Docente", "Tutor" });
            cmbPerfil.Location = new Point(13, 85);
            cmbPerfil.Margin = new Padding(3, 2, 3, 2);
            cmbPerfil.Name = "cmbPerfil";
            cmbPerfil.Size = new Size(269, 29);
            cmbPerfil.TabIndex = 24;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(13, 44);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(269, 29);
            txtPassword.TabIndex = 25;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(13, 14);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Nombre";
            txtUsuario.Size = new Size(269, 29);
            txtUsuario.TabIndex = 24;
            // 
            // txtClaveDocente
            // 
            txtClaveDocente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtClaveDocente.Location = new Point(730, 292);
            txtClaveDocente.Margin = new Padding(3, 2, 3, 2);
            txtClaveDocente.Name = "txtClaveDocente";
            txtClaveDocente.PlaceholderText = "Buscar Docente";
            txtClaveDocente.Size = new Size(269, 29);
            txtClaveDocente.TabIndex = 31;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(371, 39);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(172, 47);
            lblTitulo.TabIndex = 32;
            lblTitulo.Text = "Docentes";
            // 
            // frmDocentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.bordes;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1050, 490);
            Controls.Add(pcbLogo);
            Controls.Add(lblTitulo);
            Controls.Add(txtClaveDocente);
            Controls.Add(pnlUsuarios);
            Controls.Add(pnlDocentes);
            Controls.Add(dgvDocentes);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
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
    }
}