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
            pcbLogin = new PictureBox();
            pcbCandado = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbCandado).BeginInit();
            SuspendLayout();
            // 
            // btnAcceder
            // 
            btnAcceder.Font = new Font("Segoe UI", 14F);
            btnAcceder.Location = new Point(230, 239);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(186, 63);
            btnAcceder.TabIndex = 0;
            btnAcceder.Text = "ACCEDER";
            btnAcceder.UseVisualStyleBackColor = true;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 14F);
            btnSalir.Location = new Point(422, 239);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(186, 63);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(230, 103);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Nombre de usuario";
            txtUsuario.Size = new Size(378, 38);
            txtUsuario.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(230, 155);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Contraseña de usuario";
            txtPassword.Size = new Size(378, 38);
            txtPassword.TabIndex = 3;
            // 
            // pcbLogin
            // 
            pcbLogin.BackColor = Color.Transparent;
            pcbLogin.Image = (Image)resources.GetObject("pcbLogin.Image");
            pcbLogin.Location = new Point(12, 33);
            pcbLogin.Name = "pcbLogin";
            pcbLogin.Size = new Size(189, 176);
            pcbLogin.SizeMode = PictureBoxSizeMode.Zoom;
            pcbLogin.TabIndex = 4;
            pcbLogin.TabStop = false;
            // 
            // pcbCandado
            // 
            pcbCandado.BackColor = Color.Transparent;
            pcbCandado.Image = (Image)resources.GetObject("pcbCandado.Image");
            pcbCandado.Location = new Point(627, 12);
            pcbCandado.Name = "pcbCandado";
            pcbCandado.Size = new Size(126, 129);
            pcbCandado.SizeMode = PictureBoxSizeMode.Zoom;
            pcbCandado.TabIndex = 5;
            pcbCandado.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 356);
            Controls.Add(pcbCandado);
            Controls.Add(pcbLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(btnSalir);
            Controls.Add(btnAcceder);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            Text = "Inicio de sesion";
            ((System.ComponentModel.ISupportInitialize)pcbLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbCandado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAcceder;
        private Button btnSalir;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private PictureBox pcbLogin;
        private PictureBox pcbCandado;
    }
}
