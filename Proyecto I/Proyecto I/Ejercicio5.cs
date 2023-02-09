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
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        //OJO --> siempre que haya un await va haber un Async
        private async void CalcularButton_Click(object sender, EventArgs e)
        {
            decimal Num1 = Convert.ToDecimal (N1TextBox.Text);
            decimal Num2 = Convert.ToDecimal (N2TextBox.Text);

            //En esta variable almaceno o llamo a la Funcion Asincrona
            //Siempre que llame una función asyncrona utilizo el ASYNC y el AWAIT
            decimal Suma = await SumaAsync (Num1, Num2);

            MessageBox.Show("La suma es: " + Suma);
        }


        //Tranformo un Método Normal a un Método Asincrono
        private async Task <decimal> SumaAsync (decimal Num1, decimal Num2)
        {
            //Aqui utilizo una expresión landan, dentro del esta expresión realizo la operación que se va guardar en la variable Suma
            //OJO --> Siempre utilizo el Await y el async
            
            decimal suma = await Task.Run(() =>
            {
                //Retorna esta operación y se guarda en la variable Suma
                return Num1 + Num2;
            });

            //Retorno la tarea asincrona con el valor decimal
            return suma;
        } 
    }
}
