namespace METRODOS
{
    partial class Registrarse
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMaculino = new System.Windows.Forms.RadioButton();
            this.btnFemenino = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRARSE";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(181, 153);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(290, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(562, 153);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(56, 22);
            this.txtEdad.TabIndex = 2;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(181, 220);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(151, 22);
            this.txtDocumento.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre Completo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Documento de Identidad";
            // 
            // btnMaculino
            // 
            this.btnMaculino.AutoSize = true;
            this.btnMaculino.Location = new System.Drawing.Point(390, 222);
            this.btnMaculino.Name = "btnMaculino";
            this.btnMaculino.Size = new System.Drawing.Size(39, 20);
            this.btnMaculino.TabIndex = 7;
            this.btnMaculino.TabStop = true;
            this.btnMaculino.Text = "M";
            this.btnMaculino.UseVisualStyleBackColor = true;
            // 
            // btnFemenino
            // 
            this.btnFemenino.AutoSize = true;
            this.btnFemenino.Location = new System.Drawing.Point(435, 222);
            this.btnFemenino.Name = "btnFemenino";
            this.btnFemenino.Size = new System.Drawing.Size(36, 20);
            this.btnFemenino.TabIndex = 8;
            this.btnFemenino.TabStop = true;
            this.btnFemenino.Text = "F";
            this.btnFemenino.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Genero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(559, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(562, 222);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(139, 22);
            this.txtContrasena.TabIndex = 11;
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(335, 297);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(155, 50);
            this.btnRegistrarse.TabIndex = 12;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(345, 397);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(136, 28);
            this.btnIngresar.TabIndex = 13;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // Registrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFemenino);
            this.Controls.Add(this.btnMaculino);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Registrarse";
            this.Text = "Registrarse";
            this.Load += new System.EventHandler(this.Registrarse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton btnMaculino;
        private System.Windows.Forms.RadioButton btnFemenino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Button btnIngresar;
    }
}