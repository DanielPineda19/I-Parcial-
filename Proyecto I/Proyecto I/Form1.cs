using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_I
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            //Variables: a la  variable le asigno lo que hay en el Text Box y convierto ese valor al tipo de variable que es
            decimal num1 = Convert.ToDecimal(Num1TextBox.Text);
            decimal num2 = Convert.ToDecimal(Num1TextBox.Text);

            //Forma 1: decimal resultado = num1+num2;

            //Forma 2
            decimal resultado = Convert.ToDecimal(Num1TextBox.Text) + Convert.ToDecimal(Num2TextBox.Text);

            //Mostrar salida o resultado al usuario en pantalla
            MessageBox.Show("La suma es: " + resultado);

            //Resultado en pantalla con Text Box y lo convierto a String
            ResultadoTextBox.Text = Convert.ToString(resultado);
        }

       
    }
}
  