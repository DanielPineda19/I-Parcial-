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
    public partial class Ejercicio8 : Form
    {
        public Ejercicio8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RecorrerDeUnoEnUno (1, 100);
        }

        private void RecorrerDeUnoEnUno (int NInicial, int NFinal)
        {
            //le asigna el valor inicial al list box
            listBox1.Items.Add(NInicial);

            //el if es para que valla desde el valor inicial hasta el final
            //se va repetir mientras el valor inicial sea menor al final, cuando no sea menor, ya no entra al if y termina el proceso recursivo, ya que 100 no es menor a 100
            if (NInicial < NFinal)
            {
                //Aqui empieza el proceso recursivo, le aumento 1, ya que cuando se llama vuelve al inicio de la funcion y el valor seria 2 ahora, y asi sucesivamente
                RecorrerDeUnoEnUno (NInicial+1, NFinal);
            }


        }
    }
}
