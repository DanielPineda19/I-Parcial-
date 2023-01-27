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
            //Variables 
            decimal num1 = Convert.ToDecimal(Num1TextBox.Text);
            decimal num2 = Convert.ToDecimal(Num1TextBox.Text);

            decimal resultado = num1+num2;

            MessageBox.Show("La suma es: " + resultado);

        }
    }
}
