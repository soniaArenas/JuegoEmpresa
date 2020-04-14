namespace ProyectoRPG
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.grbRegistro = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.lklPolitica = new System.Windows.Forms.LinkLabel();
            this.chbPolitica = new System.Windows.Forms.CheckBox();
            this.txtPreguntaSecreta = new System.Windows.Forms.TextBox();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtPass2Registro = new System.Windows.Forms.TextBox();
            this.txtPassRegistro = new System.Windows.Forms.TextBox();
            this.txtUsuRegistro = new System.Windows.Forms.TextBox();
            this.lblPass2Registro = new System.Windows.Forms.Label();
            this.lblPassRegistro = new System.Windows.Forms.Label();
            this.lblUsuRegistro = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbRegistro
            // 
            this.grbRegistro.BackColor = System.Drawing.Color.PaleTurquoise;
            this.grbRegistro.Controls.Add(this.btnCancelar);
            this.grbRegistro.Controls.Add(this.btnRegistro);
            this.grbRegistro.Controls.Add(this.lklPolitica);
            this.grbRegistro.Controls.Add(this.chbPolitica);
            this.grbRegistro.Controls.Add(this.txtPreguntaSecreta);
            this.grbRegistro.Controls.Add(this.lblPregunta);
            this.grbRegistro.Controls.Add(this.txtCiudad);
            this.grbRegistro.Controls.Add(this.lblCiudad);
            this.grbRegistro.Controls.Add(this.lblEdad);
            this.grbRegistro.Controls.Add(this.txtEdad);
            this.grbRegistro.Controls.Add(this.txtMail);
            this.grbRegistro.Controls.Add(this.lblMail);
            this.grbRegistro.Controls.Add(this.txtPass2Registro);
            this.grbRegistro.Controls.Add(this.txtPassRegistro);
            this.grbRegistro.Controls.Add(this.txtUsuRegistro);
            this.grbRegistro.Controls.Add(this.lblPass2Registro);
            this.grbRegistro.Controls.Add(this.lblPassRegistro);
            this.grbRegistro.Controls.Add(this.lblUsuRegistro);
            this.grbRegistro.Location = new System.Drawing.Point(76, 24);
            this.grbRegistro.Name = "grbRegistro";
            this.grbRegistro.Size = new System.Drawing.Size(647, 397);
            this.grbRegistro.TabIndex = 6;
            this.grbRegistro.TabStop = false;
            this.grbRegistro.Text = "Registro";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(356, 317);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(127, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Enabled = false;
            this.btnRegistro.Location = new System.Drawing.Point(194, 317);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(134, 23);
            this.btnRegistro.TabIndex = 16;
            this.btnRegistro.Text = "Registrar";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.BtnRegistro_Click);
            // 
            // lklPolitica
            // 
            this.lklPolitica.AutoSize = true;
            this.lklPolitica.Location = new System.Drawing.Point(332, 286);
            this.lklPolitica.Name = "lklPolitica";
            this.lklPolitica.Size = new System.Drawing.Size(112, 13);
            this.lklPolitica.TabIndex = 15;
            this.lklPolitica.TabStop = true;
            this.lklPolitica.Text = " política de privacidad";
            this.lklPolitica.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LklPolitica_LinkClicked);
            // 
            // chbPolitica
            // 
            this.chbPolitica.AutoSize = true;
            this.chbPolitica.Location = new System.Drawing.Point(269, 286);
            this.chbPolitica.Name = "chbPolitica";
            this.chbPolitica.Size = new System.Drawing.Size(71, 17);
            this.chbPolitica.TabIndex = 14;
            this.chbPolitica.Text = "Acepto la";
            this.chbPolitica.UseVisualStyleBackColor = true;
            this.chbPolitica.CheckedChanged += new System.EventHandler(this.ChbPolitica_CheckedChanged);
            // 
            // txtPreguntaSecreta
            // 
            this.txtPreguntaSecreta.Location = new System.Drawing.Point(252, 189);
            this.txtPreguntaSecreta.Name = "txtPreguntaSecreta";
            this.txtPreguntaSecreta.Size = new System.Drawing.Size(147, 20);
            this.txtPreguntaSecreta.TabIndex = 13;
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(40, 180);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(206, 26);
            this.lblPregunta.TabIndex = 12;
            this.lblPregunta.Text = "Pregunta secreta\r\n     Nombre de tu madre. padre o mascota:";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(120, 77);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(100, 20);
            this.txtCiudad.TabIndex = 11;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(40, 81);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(43, 13);
            this.lblCiudad.TabIndex = 10;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(353, 84);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 9;
            this.lblEdad.Text = "Edad:";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(409, 78);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 8;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(409, 41);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 7;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(358, 44);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(35, 13);
            this.lblMail.TabIndex = 6;
            this.lblMail.Text = "Email:";
            // 
            // txtPass2Registro
            // 
            this.txtPass2Registro.Location = new System.Drawing.Point(409, 113);
            this.txtPass2Registro.Name = "txtPass2Registro";
            this.txtPass2Registro.Size = new System.Drawing.Size(100, 20);
            this.txtPass2Registro.TabIndex = 5;
            // 
            // txtPassRegistro
            // 
            this.txtPassRegistro.Location = new System.Drawing.Point(120, 113);
            this.txtPassRegistro.Name = "txtPassRegistro";
            this.txtPassRegistro.Size = new System.Drawing.Size(100, 20);
            this.txtPassRegistro.TabIndex = 4;
            // 
            // txtUsuRegistro
            // 
            this.txtUsuRegistro.Location = new System.Drawing.Point(120, 45);
            this.txtUsuRegistro.Name = "txtUsuRegistro";
            this.txtUsuRegistro.Size = new System.Drawing.Size(100, 20);
            this.txtUsuRegistro.TabIndex = 3;
            // 
            // lblPass2Registro
            // 
            this.lblPass2Registro.AutoSize = true;
            this.lblPass2Registro.Location = new System.Drawing.Point(291, 117);
            this.lblPass2Registro.Name = "lblPass2Registro";
            this.lblPass2Registro.Size = new System.Drawing.Size(108, 13);
            this.lblPass2Registro.TabIndex = 2;
            this.lblPass2Registro.Text = "Repita la contraseña:";
            // 
            // lblPassRegistro
            // 
            this.lblPassRegistro.AutoSize = true;
            this.lblPassRegistro.Location = new System.Drawing.Point(19, 113);
            this.lblPassRegistro.Name = "lblPassRegistro";
            this.lblPassRegistro.Size = new System.Drawing.Size(64, 13);
            this.lblPassRegistro.TabIndex = 1;
            this.lblPassRegistro.Text = "Contraseña:";
            // 
            // lblUsuRegistro
            // 
            this.lblUsuRegistro.AutoSize = true;
            this.lblUsuRegistro.Location = new System.Drawing.Point(37, 48);
            this.lblUsuRegistro.Name = "lblUsuRegistro";
            this.lblUsuRegistro.Size = new System.Drawing.Size(46, 13);
            this.lblUsuRegistro.TabIndex = 0;
            this.lblUsuRegistro.Text = "Usuario:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbRegistro);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grbRegistro.ResumeLayout(false);
            this.grbRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbRegistro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.LinkLabel lklPolitica;
        private System.Windows.Forms.CheckBox chbPolitica;
        private System.Windows.Forms.TextBox txtPreguntaSecreta;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtPass2Registro;
        private System.Windows.Forms.TextBox txtPassRegistro;
        private System.Windows.Forms.TextBox txtUsuRegistro;
        private System.Windows.Forms.Label lblPass2Registro;
        private System.Windows.Forms.Label lblPassRegistro;
        private System.Windows.Forms.Label lblUsuRegistro;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}