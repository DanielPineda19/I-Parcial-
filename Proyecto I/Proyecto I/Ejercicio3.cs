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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            string cadena = CadenaTextBox.Text;

            LongitudTextBox.Text = cadena.Length.ToString();

            PrimerCaracterTextBox.Text = cadena.Substring(0, 1);
            UltimoCaracterTextBox.Text = cadena.Substring(cadena.Length - 1, 1);

            MayusculaTextBox.Text = cadena.ToUpper();
            MinusculaTextBox.Text = cadena.ToLower();

            //ReemplazoTextBox.Text = cadena.Replace("A", "E");

            //En este ejemplo puedo aplicarle funciones a funciones y el aspecto de reemplazar las mayusculas y minusculas
            ReemplazoTextBox.Text = cadena.ToUpper().Replace("A", "E").ToLower();
        }
    }
        
}
