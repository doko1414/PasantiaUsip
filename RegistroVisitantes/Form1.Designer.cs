namespace RegistroVisitantes
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.login = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtContraseñaLogin = new System.Windows.Forms.TextBox();
            this.txtNombreUsuarioLogin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RegistroAdmin = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RegistroPers = new System.Windows.Forms.TabPage();
            this.enviar = new System.Windows.Forms.Button();
            this.btnGenerarInforme = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.richTextBoxMotivo = new System.Windows.Forms.RichTextBox();
            this.textContacto = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.RegistroAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.RegistroPers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.login);
            this.tabControl1.Controls.Add(this.RegistroAdmin);
            this.tabControl1.Controls.Add(this.RegistroPers);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.Info;
            this.login.Controls.Add(this.pictureBox2);
            this.login.Controls.Add(this.txtContraseñaLogin);
            this.login.Controls.Add(this.txtNombreUsuarioLogin);
            this.login.Controls.Add(this.label7);
            this.login.Controls.Add(this.label6);
            this.login.Controls.Add(this.button2);
            this.login.Controls.Add(this.button1);
            this.login.Location = new System.Drawing.Point(4, 25);
            this.login.Name = "login";
            this.login.Padding = new System.Windows.Forms.Padding(3);
            this.login.Size = new System.Drawing.Size(792, 421);
            this.login.TabIndex = 0;
            this.login.Text = "Login";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RegistroVisitantes.Properties.Resources._6681204;
            this.pictureBox2.Location = new System.Drawing.Point(347, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // txtContraseñaLogin
            // 
            this.txtContraseñaLogin.Location = new System.Drawing.Point(347, 248);
            this.txtContraseñaLogin.Name = "txtContraseñaLogin";
            this.txtContraseñaLogin.Size = new System.Drawing.Size(219, 22);
            this.txtContraseñaLogin.TabIndex = 12;
            // 
            // txtNombreUsuarioLogin
            // 
            this.txtNombreUsuarioLogin.Location = new System.Drawing.Point(347, 199);
            this.txtNombreUsuarioLogin.Name = "txtNombreUsuarioLogin";
            this.txtNombreUsuarioLogin.Size = new System.Drawing.Size(219, 22);
            this.txtNombreUsuarioLogin.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "CONTRASEÑA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "USUARIO:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(347, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "REGISTRARSE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(347, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "INICIAR SESION";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistroAdmin
            // 
            this.RegistroAdmin.BackColor = System.Drawing.SystemColors.Info;
            this.RegistroAdmin.Controls.Add(this.txtCorreo);
            this.RegistroAdmin.Controls.Add(this.label1);
            this.RegistroAdmin.Controls.Add(this.pictureBox1);
            this.RegistroAdmin.Controls.Add(this.txtCelular);
            this.RegistroAdmin.Controls.Add(this.label12);
            this.RegistroAdmin.Controls.Add(this.button3);
            this.RegistroAdmin.Controls.Add(this.txtContraseña);
            this.RegistroAdmin.Controls.Add(this.txtNombreUsuario);
            this.RegistroAdmin.Controls.Add(this.label10);
            this.RegistroAdmin.Controls.Add(this.label11);
            this.RegistroAdmin.Controls.Add(this.txtApellido);
            this.RegistroAdmin.Controls.Add(this.txtNombre);
            this.RegistroAdmin.Controls.Add(this.label8);
            this.RegistroAdmin.Controls.Add(this.label9);
            this.RegistroAdmin.Location = new System.Drawing.Point(4, 25);
            this.RegistroAdmin.Name = "RegistroAdmin";
            this.RegistroAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.RegistroAdmin.Size = new System.Drawing.Size(792, 421);
            this.RegistroAdmin.TabIndex = 1;
            this.RegistroAdmin.Text = "RegistroAdmin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::RegistroVisitantes.Properties.Resources._366733258_612975617657553_3996130933657315606_n_fotor_bg_remover_20230905104824;
            this.pictureBox1.Location = new System.Drawing.Point(15, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 339);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(574, 124);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(204, 22);
            this.txtCelular.TabIndex = 80;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(412, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 16);
            this.label12.TabIndex = 79;
            this.label12.Text = "CELULAR:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(574, 368);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 23);
            this.button3.TabIndex = 78;
            this.button3.Text = "TERMINAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(574, 227);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(204, 22);
            this.txtContraseña.TabIndex = 77;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(574, 171);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(204, 22);
            this.txtNombreUsuario.TabIndex = 76;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(412, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 16);
            this.label10.TabIndex = 75;
            this.label10.Text = "CONTRASEÑA:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(412, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 16);
            this.label11.TabIndex = 74;
            this.label11.Text = "NOMBRE USUARIO:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(574, 72);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(204, 22);
            this.txtApellido.TabIndex = 73;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(574, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(204, 22);
            this.txtNombre.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(412, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 71;
            this.label8.Text = "APELLIDOS:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(412, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 70;
            this.label9.Text = "NOMBRE:";
            // 
            // RegistroPers
            // 
            this.RegistroPers.BackColor = System.Drawing.SystemColors.Info;
            this.RegistroPers.Controls.Add(this.enviar);
            this.RegistroPers.Controls.Add(this.btnGenerarInforme);
            this.RegistroPers.Controls.Add(this.btnGuardar);
            this.RegistroPers.Controls.Add(this.richTextBoxMotivo);
            this.RegistroPers.Controls.Add(this.textContacto);
            this.RegistroPers.Controls.Add(this.textApellido);
            this.RegistroPers.Controls.Add(this.textNombre);
            this.RegistroPers.Controls.Add(this.label5);
            this.RegistroPers.Controls.Add(this.label4);
            this.RegistroPers.Controls.Add(this.label3);
            this.RegistroPers.Controls.Add(this.label2);
            this.RegistroPers.Location = new System.Drawing.Point(4, 25);
            this.RegistroPers.Name = "RegistroPers";
            this.RegistroPers.Padding = new System.Windows.Forms.Padding(3);
            this.RegistroPers.Size = new System.Drawing.Size(792, 421);
            this.RegistroPers.TabIndex = 2;
            this.RegistroPers.Text = "RegistroPers";
            // 
            // enviar
            // 
            this.enviar.Location = new System.Drawing.Point(557, 347);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(126, 23);
            this.enviar.TabIndex = 73;
            this.enviar.Text = "Enviar Informe";
            this.enviar.UseVisualStyleBackColor = true;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // btnGenerarInforme
            // 
            this.btnGenerarInforme.Location = new System.Drawing.Point(387, 347);
            this.btnGenerarInforme.Name = "btnGenerarInforme";
            this.btnGenerarInforme.Size = new System.Drawing.Size(126, 23);
            this.btnGenerarInforme.TabIndex = 72;
            this.btnGenerarInforme.Text = "Generar Informe";
            this.btnGenerarInforme.UseVisualStyleBackColor = true;
            this.btnGenerarInforme.Click += new System.EventHandler(this.btnGenerarInforme_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(222, 348);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 23);
            this.btnGuardar.TabIndex = 71;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // richTextBoxMotivo
            // 
            this.richTextBoxMotivo.Location = new System.Drawing.Point(222, 200);
            this.richTextBoxMotivo.Name = "richTextBoxMotivo";
            this.richTextBoxMotivo.Size = new System.Drawing.Size(461, 96);
            this.richTextBoxMotivo.TabIndex = 70;
            this.richTextBoxMotivo.Text = "";
            // 
            // textContacto
            // 
            this.textContacto.Location = new System.Drawing.Point(222, 144);
            this.textContacto.Name = "textContacto";
            this.textContacto.Size = new System.Drawing.Size(204, 22);
            this.textContacto.TabIndex = 69;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(222, 99);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(204, 22);
            this.textApellido.TabIndex = 68;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(222, 49);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(204, 22);
            this.textNombre.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 66;
            this.label5.Text = "MOTIVO: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 65;
            this.label4.Text = "CONTACTO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 64;
            this.label3.Text = "APELLIDOS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 63;
            this.label2.Text = "NOMBRE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 82;
            this.label1.Text = "CORREO GMAIL:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(574, 275);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(204, 22);
            this.txtCorreo.TabIndex = 83;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.login.ResumeLayout(false);
            this.login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.RegistroAdmin.ResumeLayout(false);
            this.RegistroAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.RegistroPers.ResumeLayout(false);
            this.RegistroPers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage login;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtContraseñaLogin;
        private System.Windows.Forms.TextBox txtNombreUsuarioLogin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage RegistroAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage RegistroPers;
        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.Button btnGenerarInforme;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.RichTextBox richTextBoxMotivo;
        private System.Windows.Forms.TextBox textContacto;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label1;
    }
}

