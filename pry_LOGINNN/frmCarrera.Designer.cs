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
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            dvgCarrera = new DataGridView();
            txtDescipcion = new TextBox();
            pcbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            pmlAgrupaControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgCarrera).BeginInit();
            SuspendLayout();
            // 
            // pcbLogo
            // 
            pcbLogo.Image = Properties.Resources.Carrera;
            pcbLogo.Location = new Point(674, 84);
            pcbLogo.Margin = new Padding(3, 4, 3, 4);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(101, 64);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 1;
            pcbLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(518, 94);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(124, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Carreras";
            // 
            // pmlAgrupaControles
            // 
            pmlAgrupaControles.Controls.Add(btnEliminar);
            pmlAgrupaControles.Controls.Add(btnGuardar);
            pmlAgrupaControles.Controls.Add(btnNuevo);
            pmlAgrupaControles.Controls.Add(txtDescripcion);
            pmlAgrupaControles.Controls.Add(txtNombre);
            pmlAgrupaControles.Location = new Point(213, 156);
            pmlAgrupaControles.Margin = new Padding(3, 4, 3, 4);
            pmlAgrupaControles.Name = "pmlAgrupaControles";
            pmlAgrupaControles.Size = new Size(841, 189);
            pmlAgrupaControles.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_06_17_183955;
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Location = new Point(590, 109);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(87, 57);
            btnEliminar.TabIndex = 4;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_06_17_184226;
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(383, 109);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(87, 57);
            btnGuardar.TabIndex = 3;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_06_17_1831001;
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Location = new Point(248, 109);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(87, 57);
            btnNuevo.TabIndex = 2;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(41, 71);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Escribir una descripcion de la carrera";
            txtDescripcion.Size = new Size(733, 27);
            txtDescripcion.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(41, 19);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Escribir el nombre de la carrera";
            txtNombre.Size = new Size(733, 27);
            txtNombre.TabIndex = 0;
            // 
            // dvgCarrera
            // 
            dvgCarrera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgCarrera.Location = new Point(181, 388);
            dvgCarrera.Margin = new Padding(3, 4, 3, 4);
            dvgCarrera.Name = "dvgCarrera";
            dvgCarrera.RowHeadersWidth = 51;
            dvgCarrera.Size = new Size(897, 161);
            dvgCarrera.TabIndex = 3;
            // 
            // txtDescipcion
            // 
            txtDescipcion.Location = new Point(964, 353);
            txtDescipcion.Margin = new Padding(3, 4, 3, 4);
            txtDescipcion.Name = "txtDescipcion";
            txtDescipcion.PlaceholderText = "Buscar carrera";
            txtDescipcion.Size = new Size(114, 27);
            txtDescipcion.TabIndex = 4;
            // 
            // frmCarrera
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_06_17_174633;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1223, 654);
            Controls.Add(txtDescipcion);
            Controls.Add(dvgCarrera);
            Controls.Add(pmlAgrupaControles);
            Controls.Add(pcbLogo);
            Controls.Add(lblTitulo);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
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