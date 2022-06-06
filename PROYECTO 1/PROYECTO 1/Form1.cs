using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_1
{
    public partial class Form1 : Form
    {
        Sueldo myNomina = new Sueldo();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CALCULAR_Click(object sender, EventArgs e)
        {
            
            myNomina.sueldoBruto = Convert.ToDecimal(SueldoBrutoTB.Text);

            AFPTB.Text = myNomina.aFp(myNomina.sueldoBruto).ToString();
            IRSTB.Text = myNomina.IRs(myNomina.sueldoBruto).ToString();
            SFSTB.Text = myNomina.SfS(myNomina.sueldoBruto).ToString();

            SueldoNetoTB.Text= myNomina.sueldoneto(myNomina.sueldoBruto, myNomina.AFP, myNomina.IRS, myNomina.SFS).ToString();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            SueldoNetoTB.Clear();
            SueldoBrutoTB.Clear();
            AFPTB.Clear();
            SFSTB.Clear();
            IRSTB.Clear();
        }

        private void AFPTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
