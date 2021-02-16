namespace AGEVI
{
    partial class frmSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSesion));
            this.lblInicioSesion = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnOlvide = new System.Windows.Forms.Button();
            this.rdbRobot = new System.Windows.Forms.RadioButton();
            this.pbrLoad = new System.Windows.Forms.ProgressBar();
            this.tmrLoad = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblInicioSesion
            // 
            this.lblInicioSesion.AutoSize = true;
            this.lblInicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicioSesion.Image = ((System.Drawing.Image)(resources.GetObject("lblInicioSesion.Image")));
            this.lblInicioSesion.Location = new System.Drawing.Point(40, 27);
            this.lblInicioSesion.Name = "lblInicioSesion";
            this.lblInicioSesion.Size = new System.Drawing.Size(231, 24);
            this.lblInicioSesion.TabIndex = 0;
            this.lblInicioSesion.Text = "Porfavor ingrese sus datos";
            this.lblInicioSesion.Click += new System.EventHandler(this.btnOlvide_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Image = ((System.Drawing.Image)(resources.GetObject("lblUsuario.Image")));
            this.lblUsuario.Location = new System.Drawing.Point(40, 81);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(133, 20);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario o Correo:";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.Image = ((System.Drawing.Image)(resources.GetObject("lblContrasena.Image")));
            this.lblContrasena.Location = new System.Drawing.Point(40, 130);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(96, 20);
            this.lblContrasena.TabIndex = 2;
            this.lblContrasena.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(179, 83);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(274, 26);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(179, 132);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(274, 26);
            this.txtContraseña.TabIndex = 4;
            // 
            // btnAceptar
            // 
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAceptar.Location = new System.Drawing.Point(383, 191);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnOlvide
            // 
            this.btnOlvide.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnOlvide.Location = new System.Drawing.Point(12, 191);
            this.btnOlvide.Name = "btnOlvide";
            this.btnOlvide.Size = new System.Drawing.Size(188, 23);
            this.btnOlvide.TabIndex = 6;
            this.btnOlvide.Text = "Olvidé mi contraseña";
            this.btnOlvide.UseVisualStyleBackColor = true;
            this.btnOlvide.Click += new System.EventHandler(this.btnOlvide_Click);
            // 
            // rdbRobot
            // 
            this.rdbRobot.AutoSize = true;
            this.rdbRobot.Location = new System.Drawing.Point(206, 194);
            this.rdbRobot.Name = "rdbRobot";
            this.rdbRobot.Size = new System.Drawing.Size(105, 17);
            this.rdbRobot.TabIndex = 7;
            this.rdbRobot.TabStop = true;
            this.rdbRobot.Text = "No soy un Robot";
            this.rdbRobot.UseVisualStyleBackColor = true;
            this.rdbRobot.CheckedChanged += new System.EventHandler(this.rdbRobot_CheckedChanged);
            // 
            // pbrLoad
            // 
            this.pbrLoad.Location = new System.Drawing.Point(12, 232);
            this.pbrLoad.Name = "pbrLoad";
            this.pbrLoad.Size = new System.Drawing.Size(446, 23);
            this.pbrLoad.TabIndex = 8;
            // 
            // tmrLoad
            // 
            this.tmrLoad.Enabled = true;
            this.tmrLoad.Tick += new System.EventHandler(this.tmrLoad_Tick);
            // 
            // frmSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(470, 267);
            this.Controls.Add(this.pbrLoad);
            this.Controls.Add(this.rdbRobot);
            this.Controls.Add(this.btnOlvide);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblInicioSesion);
            this.Name = "frmSesion";
            this.Text = "Sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInicioSesion;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnOlvide;
        private System.Windows.Forms.RadioButton rdbRobot;
        private System.Windows.Forms.ProgressBar pbrLoad;
        private System.Windows.Forms.Timer tmrLoad;
    }
}

