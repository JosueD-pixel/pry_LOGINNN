namespace pry_LOGINNN
{
    partial class frmCarrera
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
            lblTitulo = new Label();
            pmlAgrupaControles = new Panel();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            dvgCarrera = new DataGridView();
            txtDescipcion = new TextBox();
            pcbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            pmlAgrupaControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgCarrera).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(315, 81);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(92, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Carreras";
            // 
            // pcbLogo
            // 
            pcbLogo.Image = Properties.Resources.Carrera;
            pcbLogo.Location = new Point(458, 63);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(88, 48);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 1;
            pcbLogo.TabStop = false;
            // 
            // pmlAgrupaControles
            // 
            pmlAgrupaControles.Controls.Add(btnEliminar);
            pmlAgrupaControles.Controls.Add(btnGuardar);
            pmlAgrupaControles.Controls.Add(btnNuevo);
            pmlAgrupaControles.Controls.Add(txtDescripcion);
            pmlAgrupaControles.Controls.Add(txtNombre);
            pmlAgrupaControles.Location = new Point(172, 114);
            pmlAgrupaControles.Name = "pmlAgrupaControles";
            pmlAgrupaControles.Size = new Size(459, 142);
            pmlAgrupaControles.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(36, 14);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Escribir el nombre de la carrera";
            txtNombre.Size = new Size(401, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(36, 53);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Escribir una descripcion de la carrera";
            txtDescripcion.Size = new Size(401, 23);
            txtDescripcion.TabIndex = 1;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_06_17_1831001;
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Location = new Point(36, 82);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(76, 43);
            btnNuevo.TabIndex = 2;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_06_17_184226;
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(197, 82);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(76, 43);
            btnGuardar.TabIndex = 3;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_06_17_183955;
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Location = new Point(361, 82);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(76, 43);
            btnEliminar.TabIndex = 4;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dvgCarrera
            // 
            dvgCarrera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgCarrera.Location = new Point(172, 291);
            dvgCarrera.Name = "dvgCarrera";
            dvgCarrera.Size = new Size(459, 100);
            dvgCarrera.TabIndex = 3;
            // 
            // txtDescipcion
            // 
            txtDescipcion.Location = new Point(531, 262);
            txtDescipcion.Name = "txtDescipcion";
            txtDescipcion.PlaceholderText = "Buscar carrera";
            txtDescipcion.Size = new Size(100, 23);
            txtDescipcion.TabIndex = 4;
            // 
            // frmCarrera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_06_17_174633;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDescipcion);
            Controls.Add(dvgCarrera);
            Controls.Add(pmlAgrupaControles);
            Controls.Add(pcbLogo);
            Controls.Add(lblTitulo);
            DoubleBuffered = true;
            Name = "frmCarrera";
            Text = "/";
            Load += frmCarrera_Load;
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            pmlAgrupaControles.ResumeLayout(false);
            pmlAgrupaControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgCarrera).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private PictureBox pcbLogo;
        private Panel pmlAgrupaControles;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnNuevo;
        private DataGridView dvgCarrera;
        private TextBox txtDescipcion;
    }
}