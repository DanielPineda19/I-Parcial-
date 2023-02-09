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
    public partial class Ejercicio6 : Form
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void ArreglosButton_Click(object sender, EventArgs e)
        {
            //VECTORES

            //Declaración de vectores de tipo Int
            int[] vector = new int[5];

            //Asignando valores a las posiciones del vector (de la posición 0 y 4, ya que hay 5) 
            vector[0] = 10;
            vector[1] = 20;
            vector[2] = 30;
            vector[3] = 40;
            vector[4] = 50;

            //Asignando valores directamente al vector donde lo declare 
            int[] vector2 = new int[5] {10, 20, 30, 40, 50};

            //Asignando valores directamente al vector donde lo declare, pero no le defino la longitud o tamaño
            int[] vector3 = new int[] { 10, 20, 30, 40, 50 };

            //Asingo directamente valores
            int[] vector4 = { 10, 20, 30, 40, 50 };



            //Vector de Tipo String
            string[] vector5 = { "ANA", "MARIA", "LUCAS", "KIM", "SAM" };

            //Este ciclo sirve para mostrar en el ListBox cada uno de los valores que estan el vector
            //Por cada ieracion va ir mostrando cada uno de los valores del vector
            for (int i = 0; i < vector5.Length; i++)
            {
                ArreglosListBox.Items.Add(vector5[i]); //La variable "i" es la posicion desde la cual va empezar a mostrar los valores y se va actualizando su valor en cada iteración
            }

            //Utilizo un ciclo Foreach
            foreach (string item in vector5)
            {
                //Aqui hago lo mismo pero con un Combo Box
                comboBox1.Items.Add(item);
            }

        }
    }
}
