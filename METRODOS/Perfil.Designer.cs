namespace METRODOS
{
    partial class Perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil));
            this.label1 = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbEdad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbGenero = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbDocumento = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbSaldo = new System.Windows.Forms.Label();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.METRO = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(219, 53);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(0, 16);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Location = new System.Drawing.Point(219, 103);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(0, 16);
            this.lbEdad.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Genero";
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Location = new System.Drawing.Point(219, 166);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(0, 16);
            this.lbGenero.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(124, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "D.I";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbDocumento
            // 
            this.lbDocumento.AutoSize = true;
            this.lbDocumento.Location = new System.Drawing.Point(219, 224);
            this.lbDocumento.Name = "lbDocumento";
            this.lbDocumento.Size = new System.Drawing.Size(0, 16);
            this.lbDocumento.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(124, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Saldo";
            // 
            // lbSaldo
            // 
            this.lbSaldo.AutoSize = true;
            this.lbSaldo.Location = new System.Drawing.Point(219, 292);
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(0, 16);
            this.lbSaldo.TabIndex = 9;
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(601, 330);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(166, 27);
            this.btnRecargar.TabIndex = 10;
            this.btnRecargar.Text = "RECARGAR";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(601, 363);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(166, 27);
            this.btnPagar.TabIndex = 11;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(601, 396);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(166, 27);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // METRO
            // 
            this.METRO.AutoSize = true;
            this.METRO.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.METRO.Location = new System.Drawing.Point(608, 35);
            this.METRO.Name = "METRO";
            this.METRO.Size = new System.Drawing.Size(143, 41);
            this.METRO.TabIndex = 13;
            this.METRO.Text = "METRO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(608, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 41);
            this.label11.TabIndex = 14;
            this.label11.Text = "DOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(601, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.METRO);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.lbSaldo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbDocumento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbGenero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbEdad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.label1);
            this.Name = "Perfil";
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.Perfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbDocumento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbSaldo;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label METRO;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}