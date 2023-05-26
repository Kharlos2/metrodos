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
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("C:\\MetroDos\\Info.txt");
            string linea = sr.ReadLine();
            string[] info = linea.Split(',');
            lbNombre.Text = info[0];
            lbEdad.Text = info[2];
            lbGenero.Text = info[4];
            lbDocumento.Text = info[1];
            lbSaldo.Text = info[5];
            sr.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            Recargar recargar = new Recargar();
            recargar.Show();
            this.Close();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            Pagar pagar = new Pagar();
            pagar.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            guardarDatos();
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }
        public void guardarDatos()
        {
            List<string[]> usuarios = new List<string[]>();
            StreamReader sr = new StreamReader("C:\\MetroDos\\Datos.txt");
            while (sr.Peek() != -1)
            {
                string linea = sr.ReadLine();
                string[] line_sep = linea.Split(',');
                usuarios.Add(line_sep);
            }
            sr.Close();
            borrar();
            
            foreach (var user in usuarios)
            {
                try { 
                    if (lbDocumento.Text == user[1])
                    {
                        user[5] = lbSaldo.Text;
                    }
                    escribir(user[0], user[1],user[2],user[3],user[4],user[5]);
                }
                catch (Exception)
                {
                    MessageBox.Show(";)");
                }
            }
        }
        public void escribir(string _Nombre, string _documento, string _edad, string _contrasena, string _sexo, string saldo)
        {
            

            string texto = recorrer(_Nombre, _documento, _contrasena, _edad, _sexo, saldo);
            StreamWriter sw = new StreamWriter("C:\\MetroDos\\Datos.txt");
            sw.WriteLine(texto);
            sw.Close();
        }

        public string recorrer(string _Nombre, string _documento, string _edad, string _contrasena, string _sexo, string saldo)
        {
            StreamReader sr = new StreamReader("C:\\MetroDos\\Datos.txt");
            string linea = sr.ReadLine(), texto = "";
            while (linea != null)
            {
               if (linea != "" && linea != null) 
                { 
                    texto = texto + linea + "\n";
                }

                linea = sr.ReadLine();
            }
            sr.Close();
            texto = texto + _Nombre + "," + _documento + "," + _contrasena + "," + _edad + "," + _sexo + "," + saldo;
            return texto;
        }
        public void borrar()
        {
            StreamWriter sw = new StreamWriter("C:\\MetroDos\\Datos.txt");
            sw.WriteLine("");
            sw.Close();
        }
        private void Perfil_Load(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
