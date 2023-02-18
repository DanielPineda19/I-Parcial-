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
    public partial class Ejercicio7 : Form
    {
        public Ejercicio7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Limpiar el ListBox cuando vuelva a ejecutar
            listBox1.Items.Clear();


            //Matriz (Declaración e inicialización de la matriz
            int[,] Matriz1 = new int[3, 3] 
            { 
                {3, 6, 3}, 
                {9, 6, 4}, 
                {1, 8, 7} 
            };

            //Instacio un objeto de la clase Random, para crear valores aleatorios en la matriz
            Random random = new Random();

            //Genera un tamaño aleatorio de las filas y columnas para la matriz
            int valorfila = random.Next(1, 10);
            int valorcolumna = random.Next(1, 10);

            //Tamaño aleatorio de la matriz
            int[,] Matriz2 = new int[valorfila, valorcolumna];



            //Ciclo para dar valores a la matriz
            for (int filas = 0; filas < Matriz2.GetLength(0); filas++) //Ciclo para las filas de la matriz
            {
                for (int columnas = 0; columnas < Matriz2.GetLength(1); columnas++) //Ciclo para las columnas de la matriz
                {
                    //Llena la matriz de valores aleatorios
                    Matriz2[filas, columnas] = random.Next(1, 10);
                }
            }



            //Ciclo para mostrar valores a la matriz
            for (int filas = 0; filas < Matriz2.GetLength(0); filas++) //Ciclo para las filas de la matriz
            {
                for (int columnas = 0; columnas < Matriz2.GetLength(1); columnas++) //Ciclo para las columnas de la matriz
                {
                    //Muestro un string que me dice el valor que esta en ese indice
                    listBox1.Items.Add("La posición [" + filas + "," + columnas + "] = " + Matriz2[filas, columnas]);
                }
            }

            //Mostrar el tamaño de la matriz
            textBox1.Text= Matriz2.GetLength(0).ToString() + "x" + Matriz2.GetLength(1).ToString();
        }
    }
}
