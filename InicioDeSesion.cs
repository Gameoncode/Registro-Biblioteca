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
    public partial class InicioDeSesion : Form
    {
        public InicioDeSesion()
        {
            InitializeComponent();
        }

        private void BTIniciarSesion_Click(object sender, EventArgs e)
        {

            try
            {
                TextReader Inicio = new StreamReader(TBNombre.Text + ".txt");

                if (Inicio.ReadLine() == TBPass.Text)
                {
                    MessageBox.Show("Se inicio sesion");
                }

                else
                {
                    MessageBox.Show("No se pudo iniciar sesion");
                }
            }

            catch (Exception z)
            {
                MessageBox.Show("Hubo un error" + z, "Error");
            }
        }
    }
}
