using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace METRODOS
{
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text != null && txtDocumento.Text != null && txtEdad.Text != null && txtContrasena.Text != null && (btnFemenino.Checked != false || btnMaculino.Checked != false))
            {
                escribir(txtNombre.Text, txtDocumento.Text, txtEdad.Text, txtContrasena.Text, btnFemenino.Checked, btnMaculino.Checked);
                Inicio inicio = new Inicio();
                inicio.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Se deben diligenciar todos los campos");
            }
            
        }
        public void escribir(string _Nombre, string _documento, string _edad, string _contrasena, bool _femenino, bool _masculino)
        {
   
            string sexo = "";
            if (_femenino == true)
            {
                sexo = "Femenino";
            }
            else if (_masculino == true)
            {
                sexo = "Masculino";
            }
            string texto = recorrer(_Nombre, _documento, _contrasena, _edad,sexo);
            StreamWriter sw = new StreamWriter("C:\\MetroDos\\Datos.txt");
            sw.WriteLine(texto);
            sw.Close();
        }
       
        public string recorrer(string _Nombre, string _documento, string _edad, string _contrasena,string _sexo)
        {
            StreamReader sr = new StreamReader("C:\\MetroDos\\Datos.txt");
            string linea = sr.ReadLine(), texto = "";
            while (linea != null)
            {
                texto = texto + linea + "\n";
                linea = sr.ReadLine();
            }
            sr.Close();
            texto = texto + _Nombre + "," + _documento + "," + _contrasena + "," + _edad + "," + _sexo +","+ 0;
            return texto;
        }

        private void Registrarse_Load(object sender, EventArgs e)
        {

        }
    }
}
