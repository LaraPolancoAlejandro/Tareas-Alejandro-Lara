using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BARBERIA
{
    public partial class Form1 : Form
    {
        private int indice = -1;
        private List<clsContacto> contactos = new List<clsContacto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Vaciar_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Servi_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (indice>-1)
            {
                contactos.RemoveAt(indice);
                actualizarVista();
                limpiacampos();
                indice = -1;
            }
            else
            {
                MessageBox.Show("Haz doble click en el elemento que deseas borrar y luego presiona el boton");
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            clsContacto Persona = new clsContacto();
            Persona.Nombre = tbNombre.Text;
            Persona.Telefono = tbTelefono.Text;
            Persona.Servicio = tbServicio.Text;
            Persona.Fecha =  (tbdateTimePicker2.Value);
            Persona.Hora = (tbdateTimePicker1.Value);
            if(indice > -1)
            {
                contactos[indice] = Persona;
                indice = -1;
            }
            else
            {
                contactos.Add(Persona);
            }
           
            actualizarVista();
            limpiacampos();
        }

        private void limpiacampos()
        {
            tbNombre.Text = null;
            tbTelefono.Text = null;
            tbServicio.Text = null;
            
        }

        private void actualizarVista()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = contactos;
            dataGridView1.ClearSelection();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow renglon = dataGridView1.SelectedRows[0];
            indice = dataGridView1.Rows.IndexOf(renglon);
            clsContacto persona = contactos[indice];
            tbNombre.Text = persona.Nombre;
            tbTelefono.Text = persona.Telefono;
            tbServicio.Text = persona.Servicio;
            tbdateTimePicker1.Value = persona.Hora;
            tbdateTimePicker2.Value = persona.Fecha;

        }
    }
}
