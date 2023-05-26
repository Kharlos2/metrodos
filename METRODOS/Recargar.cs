using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace METRODOS
{
    public partial class Recargar : Form
    {
        public Recargar()
        {
            InitializeComponent();
            llamarInfo();
             
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
   
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil();
            perfil.Show();
            this.Close();
        }

        private void btnRecargarRecargar_Click(object sender, EventArgs e)
        {

            validacion();
            llamarInfo();

        }
        public void llamarInfo()
        {
            StreamReader sr = new StreamReader("C:\\MetroDos\\Info.txt");
            string linea = sr.ReadLine();
            string[] info = linea.Split(',');
            lbSaldo.Text = info[5];
            sr.Close();
        }

        public void validacion()
        {
            try { 

                if(float.Parse(txtRecarga.Text) > 0)
                {
                    StreamReader sr = new StreamReader("C:\\MetroDos\\Info.txt");
                    string linea = sr.ReadLine();
                    string[] info = linea.Split(',');
                    sr.Close();
                    float numero = float.Parse(lbSaldo.Text) + float.Parse(txtRecarga.Text);


                    StreamWriter sw = new StreamWriter("C:\\MetroDos\\Info.txt");
                    sw.WriteLine(info[0] + "," + info[1] + "," + info[2] + "," + info[3] + "," + info[4] + "," + numero);
                    sw.Close();
                    txtRecarga.Clear();
                }
                else
                {
                        MessageBox.Show("Ingresar una cantidad valida");
                        txtRecarga.Clear();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Valor invalido, ingresar solo numeros porfavor.");
                txtRecarga.Clear();
            }
            
        }

        private void txtRecarga_TextChanged(object sender, EventArgs e)
        {
        }

        private void Recargar_Load(object sender, EventArgs e)
        {

        }
    }
}
