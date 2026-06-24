namespace pry_LOGINNN
{
    partial class frmTutores
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
            lblTutor = new Label();
            pcbTutor = new PictureBox();
            panel1 = new Panel();
            dgvTutores = new DataGridView();
            txtNombre = new TextBox();
            txtParentesco = new TextBox();
            txtDireccion = new TextBox();
            txtNombreTutor = new TextBox();
            txtCorreo = new TextBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            txtTelefono = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pcbTutor).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTutores).BeginInit();
            SuspendLayout();
            // 
            // lblTutor
            // 
            lblTutor.AutoSize = true;
            lblTutor.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTutor.Location = new Point(434, 34);
            lblTutor.Name = "lblTutor";
            lblTutor.Size = new Size(192, 62);
            lblTutor.TabIndex = 0;
            lblTutor.Text = "Tutores";
            // 
            // pcbTutor
            // 
            pcbTutor.Image = Properties.Resources.tutor;
            pcbTutor.Location = new Point(624, 20);
            pcbTutor.Name = "pcbTutor";
            pcbTutor.Size = new Size(107, 76);
            pcbTutor.SizeMode = PictureBoxSizeMode.Zoom;
            pcbTutor.TabIndex = 1;
            pcbTutor.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnNuevo);
            panel1.Controls.Add(txtNombreTutor);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(txtDireccion);
            panel1.Controls.Add(txtParentesco);
            panel1.Controls.Add(txtNombre);
            panel1.Location = new Point(220, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 286);
            panel1.TabIndex = 2;
            // 
            // dgvTutores
            // 
            dgvTutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTutores.Location = new Point(160, 394);
            dgvTutores.Name = "dgvTutores";
            dgvTutores.RowHeadersWidth = 51;
            dgvTutores.Size = new Size(897, 230);
            dgvTutores.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(134, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Escribir el nombre del tutor";
            txtNombre.Size = new Size(537, 31);
            txtNombre.TabIndex = 0;
            // 
            // txtParentesco
            // 
            txtParentesco.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtParentesco.Location = new Point(134, 41);
            txtParentesco.Name = "txtParentesco";
            txtParentesco.PlaceholderText = "Escribir un parentesco del tutor";
            txtParentesco.Size = new Size(537, 31);
            txtParentesco.TabIndex = 1;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDireccion.Location = new Point(134, 78);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Escribir una direccion del tutor";
            txtDireccion.Size = new Size(537, 31);
            txtDireccion.TabIndex = 2;
            // 
            // txtNombreTutor
            // 
            txtNombreTutor.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreTutor.Location = new Point(554, 238);
            txtNombreTutor.Name = "txtNombreTutor";
            txtNombreTutor.PlaceholderText = "Buscar tutor";
            txtNombreTutor.Size = new Size(208, 32);
            txtNombreTutor.TabIndex = 3;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(134, 152);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Escribir un correo del tutor";
            txtCorreo.Size = new Size(537, 31);
            txtCorreo.TabIndex = 4;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = Properties.Resources.btnNuevo;
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.ForeColor = SystemColors.ControlLight;
            btnNuevo.Location = new Point(72, 197);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(125, 86);
            btnNuevo.TabIndex = 3;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = Properties.Resources.btnGuardar;
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.ForeColor = SystemColors.Control;
            btnGuardar.Location = new Point(214, 197);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(125, 86);
            btnGuardar.TabIndex = 5;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = Properties.Resources.btnEliminar;
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Location = new Point(364, 197);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(125, 86);
            btnEliminar.TabIndex = 6;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(134, 115);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Escribir un telefono del tutor";
            txtTelefono.Size = new Size(537, 31);
            txtTelefono.TabIndex = 7;
            // 
            // frmTutores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Imagen1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1200, 654);
            Controls.Add(dgvTutores);
            Controls.Add(panel1);
            Controls.Add(pcbTutor);
            Controls.Add(lblTutor);
            DoubleBuffered = true;
            Name = "frmTutores";
            Text = "frmTutores";
            ((System.ComponentModel.ISupportInitialize)pcbTutor).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTutores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTutor;
        private PictureBox pcbTutor;
        private Panel panel1;
        private DataGridView dgvTutores;
        private TextBox txtNombre;
        private TextBox txtNombreTutor;
        private TextBox txtDireccion;
        private TextBox txtParentesco;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnNuevo;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
    }
}