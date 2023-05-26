using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace METRODOS
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        public void button3_Click(object sender, EventArgs e)
        {
            List<string[]> usuarios = new List<string[]>();
            StreamReader sr = new StreamReader("C:\\MetroDos\\Datos.txt");
            //string texto = "";
            while(sr.Peek() != -1)
            {
                string linea = sr.ReadLine();
                string[] line_sep = linea.Split(',');
                usuarios.Add(line_sep);
            }
            bool bandera = false;
            foreach (var user in usuarios)
            {
                

                if (txtNombre.Text == user[0] && txtContrasena.Text == user[3])
                {
                    StreamWriter sw = new StreamWriter("C:\\MetroDos\\Info.txt");
                    sw.WriteLine(user[0]+ "," + user[1] + "," + user[2] + "," + user[3] + "," + user[4] + "," + user[5]);
                    sw.Close();

                    Perfil perfil = new Perfil();
                    perfil.Show();
                    this.Hide();
                    bandera = true;

                }
                
            }
            if (bandera == false)
            {
                MessageBox.Show("Usuario o contraseña invalidos");
                txtContrasena.Text = " ";
                txtNombre.Text = " ";
            }
            sr.Close();
        }
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Registrarse registrarse = new Registrarse();
            registrarse.Show();
            this.Hide();
        }

        
    }
}
