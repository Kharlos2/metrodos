namespace METRODOS
{
    partial class Recargar
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRecarga = new System.Windows.Forms.TextBox();
            this.lbSaldo = new System.Windows.Forms.Label();
            this.btnRecargarRecargar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "RECARGAR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saldo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(542, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtRecarga
            // 
            this.txtRecarga.Location = new System.Drawing.Point(547, 203);
            this.txtRecarga.Name = "txtRecarga";
            this.txtRecarga.Size = new System.Drawing.Size(100, 22);
            this.txtRecarga.TabIndex = 3;
            this.txtRecarga.TextChanged += new System.EventHandler(this.txtRecarga_TextChanged);
            // 
            // lbSaldo
            // 
            this.lbSaldo.AutoSize = true;
            this.lbSaldo.Location = new System.Drawing.Point(208, 206);
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(0, 16);
            this.lbSaldo.TabIndex = 4;
            // 
            // btnRecargarRecargar
            // 
            this.btnRecargarRecargar.Location = new System.Drawing.Point(547, 236);
            this.btnRecargarRecargar.Name = "btnRecargarRecargar";
            this.btnRecargarRecargar.Size = new System.Drawing.Size(100, 23);
            this.btnRecargarRecargar.TabIndex = 5;
            this.btnRecargarRecargar.Text = "RECARGAR";
            this.btnRecargarRecargar.UseVisualStyleBackColor = true;
            this.btnRecargarRecargar.Click += new System.EventHandler(this.btnRecargarRecargar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(12, 399);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(132, 39);
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Recargar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnRecargarRecargar);
            this.Controls.Add(this.lbSaldo);
            this.Controls.Add(this.txtRecarga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Recargar";
            this.Text = "Recargar";
            this.Load += new System.EventHandler(this.Recargar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRecarga;
        private System.Windows.Forms.Label lbSaldo;
        private System.Windows.Forms.Button btnRecargarRecargar;
        private System.Windows.Forms.Button btnRegresar;
    }
}