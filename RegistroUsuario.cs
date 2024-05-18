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
namespace Registro
{
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTLimpiar_Click(object sender, EventArgs e)
        {
            TBNombre.Clear();
            TBPass.Clear();
            
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            
            try
            {
                TextWriter RegistrarUsuario = new StreamWriter(@"C:\Users\Lab1-18\source\repos\Registro\bin\Debug\" + TBNombre.Text + ".txt", true);
                RegistrarUsuario.WriteLine(TBPass.Text);
                RegistrarUsuario.Close();

                MessageBox.Show("Registro Exitoso");
            }

            catch (Exception x) 
            {
                MessageBox.Show("Hubo un error" + x, "Error");
                //Introducir Parametros Correctos
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRMInicio VentanaInicio = new FRMInicio();
            VentanaInicio.Show();
        }

        private void TBNombre_TextChanged(object sender, EventArgs e)
        {
            //FDGUFDHUIFRHUIFD


            if (System.Text.RegularExpressions.Regex.IsMatch(TBPass.Text, "^ [0-9]")) {
                TBPass.Text = "";
            }
            
        }

        private void TBPass_TextChanged(object sender, EventArgs e)
        {
            TBPass.PasswordChar = '⬤';
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextWriter RegistrarUsuario = new StreamWriter(@"C:\Users\Lab1-18\source\repos\Registro\bin\Debug\" + TBNombre.Text + ".txt", true);
            RegistrarUsuario.WriteLine(TBPass.Text);
            RegistrarUsuario.Close();

            MessageBox.Show("Registro Exitoso");
        }
    }
}

