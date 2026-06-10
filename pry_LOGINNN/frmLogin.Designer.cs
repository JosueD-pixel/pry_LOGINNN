namespace pry_LOGINNN
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            btnAcceder = new Button();
            btnSalir = new Button();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnAcceder
            // 
            btnAcceder.Font = new Font("Segoe UI", 14F);
            btnAcceder.Location = new Point(288, 299);
            btnAcceder.Margin = new Padding(4, 4, 4, 4);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(232, 79);
            btnAcceder.TabIndex = 0;
            btnAcceder.Text = "ACCEDER";
            btnAcceder.UseVisualStyleBackColor = true;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 14F);
            btnSalir.Location = new Point(528, 299);
            btnSalir.Margin = new Padding(4, 4, 4, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(232, 79);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 14F);
            txtUsuario.Location = new Point(288, 129);
            txtUsuario.Margin = new Padding(4, 4, 4, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Nombre de usuario";
            txtUsuario.Size = new Size(472, 45);
            txtUsuario.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14F);
            txtPassword.Location = new Point(288, 194);
            txtPassword.Margin = new Padding(4, 4, 4, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Contraseña de usuario";
            txtPassword.Size = new Size(472, 45);
            txtPassword.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 41);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 220);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(824, 15);
            pictureBox2.Margin = new Padding(4, 4, 4, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(118, 118);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 445);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(btnSalir);
            Controls.Add(btnAcceder);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmLogin";
            Text = "Inicio de sesion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAcceder;
        private Button btnSalir;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
