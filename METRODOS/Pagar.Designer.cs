namespace METRODOS
{
    partial class Pagar
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
            this.clTransportes = new System.Windows.Forms.CheckedListBox();
            this.lbSaldo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lbCosto = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAGAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "SALDO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(609, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tarifas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // clTransportes
            // 
            this.clTransportes.CheckOnClick = true;
            this.clTransportes.FormattingEnabled = true;
            this.clTransportes.Items.AddRange(new object[] {
            "Metro",
            "Metroplus",
            "Metrocable",
            "Metrofly",
            "Metrovip",
            "Tranvía"});
            this.clTransportes.Location = new System.Drawing.Point(331, 204);
            this.clTransportes.Name = "clTransportes";
            this.clTransportes.Size = new System.Drawing.Size(134, 123);
            this.clTransportes.TabIndex = 4;
            this.clTransportes.SelectedIndexChanged += new System.EventHandler(this.clTransportes_SelectedIndexChanged);
            // 
            // lbSaldo
            // 
            this.lbSaldo.AutoSize = true;
            this.lbSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaldo.Location = new System.Drawing.Point(133, 204);
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(0, 25);
            this.lbSaldo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(326, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "TRANSPORTE";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(12, 401);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(146, 37);
            this.btnRegresar.TabIndex = 7;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lbCosto
            // 
            this.lbCosto.AutoSize = true;
            this.lbCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCosto.Location = new System.Drawing.Point(583, 200);
            this.lbCosto.Name = "lbCosto";
            this.lbCosto.Size = new System.Drawing.Size(123, 25);
            this.lbCosto.TabIndex = 8;
            this.lbCosto.Text = "Metro - 2300";
            this.lbCosto.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(642, 401);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(146, 37);
            this.btnPagar.TabIndex = 9;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(563, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Meproplus - 1800";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(569, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Metrovip - 20000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(569, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Metrofly - 10000";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(563, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Metrocable - 2000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(579, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tranvia 1800";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // Pagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.lbCosto);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbSaldo);
            this.Controls.Add(this.clTransportes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pagar";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Pagar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox clTransportes;
        private System.Windows.Forms.Label lbSaldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lbCosto;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
    }
}