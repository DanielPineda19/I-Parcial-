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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        //Variable global
        decimal sumaTotal=0;

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            //Variables: a la  variable le asigno lo que hay en el Text Box y convierto ese valor al tipo de variable que es
            decimal num1 = Convert.ToDecimal(Num1TextBox.Text);
            decimal num2 = Convert.ToDecimal(Num2TextBox.Text);

            //Forma 1: decimal resultado = num1+num2;

            //Forma 2:
            //decimal resultado = Convert.ToDecimal(Num1TextBox.Text) + Convert.ToDecimal(Num2TextBox.Text);

            //Mostrar salida o resultado al usuario en pantalla
            //MessageBox.Show("La suma es: " + resultado);

            //Resultado en pantalla con Text Box y lo convierto a String
            //ResultadoTextBox.Text = Convert.ToString(resultado);

            //Llamado de procedimiento suma1
            //suma1(num1, num2);

            //Llamado de función suma2
            sumaTotal= suma2(num1, num2);

            MessageBox.Show("La suma es: " + sumaTotal, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //Procedimiento 
        private void suma1 (decimal num1, decimal num2)
        {
            sumaTotal = num1 + num2;
        } 

        //Función
        private decimal suma2 (decimal num1, decimal num2)
        { 
            return num1 + num2; 
        }



       
    }
}
  