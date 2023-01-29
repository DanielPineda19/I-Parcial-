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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            //Sentencia If por si el usuario no ingresa el primer número
            if (Num1TextBox.Text == "")
            {
                ErrorProvider1.SetError(Num1TextBox, "Ingrese un número");
                return;
            }

            //Sentencia If por si el usuario no ingresa el segundo número
            if (Num2TextBox.Text == "")
            {
                ErrorProvider1.SetError(Num2TextBox, "Ingrese un número");
                return;
            }

            //Sentencia If por si el usuario no selecciona ninguna de las opciones
            if (OperacionesComboBox.Text == "")
            {
                ErrorProvider1.SetError(OperacionesComboBox, "Seleccione una opción");
                return;
            }
            ErrorProvider1.Clear();

            decimal Num1 = Convert.ToDecimal(Num1TextBox.Text);
            decimal Num2 = Convert.ToDecimal(Num2TextBox.Text);
            decimal Resultado=0;

            Resultado = Ejecutar(Num1, Num2);
            //Otra Forma: Ejecutar(Convert.ToDecimal(Num1TextBox.Text), Convert.ToDecimal(Num2TextBox.Text);

            //MessageBox.Show("El resultado es: " + Resultado, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Muestra el resultado en un Label y lo convierte de decimal a un String
            ResultadoLabel.Text = Convert.ToString(Resultado);
        }


        private decimal Ejecutar(decimal n1, decimal n2)
        {
            //La variable operacion va almacenar la opción que seleccionamos en el ComboBox
            String operacion = OperacionesComboBox.Text;

            decimal resultado = 0;

            //Sentencia If para determinar la operación que se va realizar segun la opcion elegida en el ComboBox
            if (operacion == "Suma")
                resultado = n1 + n2;
            else
                if (operacion == "Resta")
                resultado = n1 - n2;
            else
                if (operacion == "Multiplicación")
                resultado = n1 * n2;
            else
                if (operacion == "División")
                resultado = n1 / n2;

            return resultado; 
        }
    }
}
