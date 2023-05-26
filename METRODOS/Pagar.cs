using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace METRODOS
{
    public partial class Pagar : Form
    {
        public Pagar()
        {
            InitializeComponent();
            llamarInfo();

        }

        public struct datos
        {
            public float totalpago;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {


            Perfil perfil = new Perfil();
            perfil.Show();
            this.Close();

        }


        private void Pagar_Load(object sender, EventArgs e)
        {

        }
        public void llamarInfo()
        {
            StreamReader sr = new StreamReader("C:\\MetroDos\\Info.txt");
            string linea = sr.ReadLine();
            string[] info = linea.Split(',');
            lbSaldo.Text = info[5];
            sr.Close();
        }

        private void clTransportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int indice = clTransportes.SelectedIndex;

            //if(indice != -1) 
            //{
            //    lbCosto.Text = "500";
            //}

            //if (clTransportes.GetItemChecked(0) == true)
            //{
            //    float costo = float.Parse(lbCosto.Text);
            //    costo += 1;
            //    lbCosto.Text = Convert.ToString(costo);

            //}
            //else if(clTransportes.GetItemChecked(0) == false)
            //{
            //    float costo = float.Parse(lbCosto.Text);
            //    costo -= 1;
            //    lbCosto.Text = Convert.ToString(costo);
            //}
            //if (clTransportes.GetItemChecked(1) == true)
            //{
            //    float costo = float.Parse(lbCosto.Text);
            //    costo += 100;
            //    lbCosto.Text = Convert.ToString(costo);
            //}
            //if (clTransportes.GetItemChecked(2) == true)
            //{
            //    float costo = float.Parse(lbCosto.Text);
            //    costo += 10000;
            //    lbCosto.Text = Convert.ToString(costo);
            //}

           
           
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            float total = 0;

            if (clTransportes.GetItemChecked(0) == true)
            {
                total = total + 2300;
                //float costo = float.Parse(lbCosto.Text);
                //costo += 1;
                //lbCosto.Text = Convert.ToString(costo);
            }
            if (clTransportes.GetItemChecked(1) == true)
            {
                total = total + 1800;
                //float costo = float.Parse(lbCosto.Text);
                //costo += 1;
                //lbCosto.Text = Convert.ToString(costo);
            }
            if (clTransportes.GetItemChecked(2) == true)
            {
                total = total + 2000;
                //float costo = float.Parse(lbCosto.Text);
                //costo += 1;
                //lbCosto.Text = Convert.ToString(costo);
            }
            if (clTransportes.GetItemChecked(3) == true)
            {
                total = total + 10000;
                //float costo = float.Parse(lbCosto.Text);
                //costo += 1;
                //lbCosto.Text = Convert.ToString(costo);
            }
            if (clTransportes.GetItemChecked(4) == true)
            {
                total = total + 20000;
                //float costo = float.Parse(lbCosto.Text);
                //costo += 1;
                //lbCosto.Text = Convert.ToString(costo);
            }
            if (clTransportes.GetItemChecked(5) == true)
            {
                total = total + 1800;
                //float costo = float.Parse(lbCosto.Text);
                //costo += 1;
                //lbCosto.Text = Convert.ToString(costo);
            }
            



            datos info;
            info.totalpago = total;

            confirmar obj = new confirmar(info);
            obj.Show();
            this.Close();
            llamarInfo();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
