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
    public partial class Form2 : Form
    {
        private int indice = -1;
        private List<ClsPacientes> pacientes = new List<ClsPacientes>();
        ClsPacientes paciente = new ClsPacientes();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void BTsalir_Click(object sender, EventArgs e)
        {
            
            Environment.Exit(0);
        }
        
        private void BTagregar_Click(object sender, EventArgs e)
        {
            

            paciente.Nombre = TBnombre.Text;
            paciente.Apellido = TBapellido.Text;
            paciente.Telefono = TBtelefono.Text;
            paciente.Fecha = DP.Value;
            paciente.Hora = TP.Value;

            
           
                if (indice > -1)
                {
                    pacientes[indice] = paciente;
                    indice = -1;
                }
                else
                {
                    pacientes.Add(paciente);
                }
            actualizarVista();
            limpiacampos();
        }
        private void limpiacampos()
        {
            TBnombre.Text = null;
            TBtelefono.Text = null;
            TBapellido.Text = null;

        }

        private void actualizarVista()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = pacientes;
            dataGridView1.ClearSelection();
        }

        private void BTborrar_Click(object sender, EventArgs e)
        {
            if (indice > -1)
            {
                pacientes.RemoveAt(indice);
                actualizarVista();
                limpiacampos();
                indice = -1;
            }
            else
            {
                MessageBox.Show("Haz doble click en el elemento que deseas borrar y luego presiona el boton");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow renglon = dataGridView1.SelectedRows[0];
            indice = dataGridView1.Rows.IndexOf(renglon);
            ClsPacientes paciente = pacientes[indice];
            TBnombre.Text = paciente.Nombre;
            TBtelefono.Text = paciente.Telefono;
            TBapellido.Text = paciente.Apellido;
            TP.Value = paciente.Hora;
            DP.Value = paciente.Fecha;
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow renglon = dataGridView1.SelectedRows[0];
            indice = dataGridView1.Rows.IndexOf(renglon);
            ClsPacientes paciente = pacientes[indice];
            TBnombre.Text = paciente.Nombre;
            TBtelefono.Text = paciente.Telefono;
            TBapellido.Text = paciente.Apellido;
            TP.Value = paciente.Hora;
            DP.Value = paciente.Fecha;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow renglon = dataGridView1.SelectedRows[0];
            indice = dataGridView1.Rows.IndexOf(renglon);
            ClsPacientes paciente = pacientes[indice];
            TBnombre.Text = paciente.Nombre;
            TBtelefono.Text = paciente.Telefono;
            TBapellido.Text = paciente.Apellido;
            TP.Value = paciente.Hora;
            DP.Value = paciente.Fecha;
        }

        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            DataGridViewRow renglon = dataGridView1.SelectedRows[0];
            indice = dataGridView1.Rows.IndexOf(renglon);
            ClsPacientes paciente = pacientes[indice];
            TBnombre.Text = paciente.Nombre;
            TBtelefono.Text = paciente.Telefono;
            TBapellido.Text = paciente.Apellido;
            TP.Value = paciente.Hora;
            DP.Value = paciente.Fecha;
        }
    }
}
