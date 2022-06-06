using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica_dental
{
    public partial class Formulario : Form
    {
        
        public Formulario()
        {
            InitializeComponent();
        }

        private void titulo_Click(object sender, EventArgs e)
        {

        }

        private void Formulario_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BTacceder_Click(object sender, EventArgs e)
        {
            string usuario = TBusuario.Text;
            string contraseña = TBcontraseña.Text;

            if (usuario == "" && contraseña == "")
            {
                MessageBox.Show("Debe rellenar los campos");

            }

            if (usuario == "Admin" && contraseña == "Admin") 
            {
                MessageBox.Show("Bienvenido, presione ''OK'' para continuar");
                
                Form2 ventana = new Form2();
                ventana.Visible = true;
                this.Visible = false;
                
            }

            else
            {
                MessageBox.Show("El usuario y contraseña por defecto son Admin");
            }
        }
    }
}
