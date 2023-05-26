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

namespace METRODOS
{
    public partial class confirmar : Form
    {
        public confirmar(Pagar.datos info)
        {
            InitializeComponent();

            lbTotal.Text = Convert.ToString(info.totalpago);
        }

        private void confirmar_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("C:\\MetroDos\\Info.txt");
            string linea = sr.ReadLine();
            string[] info = linea.Split(',');
            //float saldoint = float.Parse(info[5]);
            //float saldo = float.Parse(txtRecarga.Text) + saldoint;
            //info[5] = Convert.ToString(saldo);
            sr.Close();
            if (float.Parse(info[5])< float.Parse(lbTotal.Text))
            {
                MessageBox.Show("Saldo insuficiente");
            }
            else
            {
                float numero = float.Parse(info[5]) - float.Parse(lbTotal.Text);
                StreamWriter sw = new StreamWriter("C:\\MetroDos\\Info.txt");
                sw.WriteLine(info[0] + "," + info[1] + "," + info[2] + "," + info[3] + "," + info[4] + "," + numero);
                sw.Close();

            }


            Pagar pagar = new Pagar();
            pagar.Show();

            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Pagar pagar = new Pagar();
            pagar.Show();
            this.Close();
            
        }
    }
}
