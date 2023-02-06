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
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            //Declaro una variable del tipo DateTime 
            DateTime fecha = DateTimePicker.Value;

            DiaTextBox.Text = fecha.Day.ToString();
            MesTextBox.Text = fecha.Month.ToString();
            AnioTextBox.Text = fecha.Year.ToString();
            SemanaTextBox.Text = fecha.DayOfWeek.ToString();

            //Me muestra el mes en letras al utilizar Formateadoadores
            MesTextBox.Text = fecha.ToString("MMMM");
            SemanaTextBox.Text = fecha.ToString("dddd");



            //Variable que contiene los dias ingresados
            int NDias = Convert.ToInt32(DiasTextBox.Text);

            //Variable que contiene la fecha actual
            DateTime fechaActual = DateTime.Now;

            //Calcula la fecha proxima de consulta con la fecha actual del sistemas y los dias de la proxima consulta
            CitasTextBox.Text = fechaActual.AddDays(NDias).ToShortDateString();



            int DiasResta = Convert.ToInt32 (DiasRestaTextBox.Text);

            //Es la resta de los dias a la fecha introducida por el usuario
            NuevaFechaTextBox.Text = fecha.AddDays(-DiasResta).ToLongDateString();


            //Imprime lo que retorna la función que calcula la edad
            MessageBox.Show("La edad del usuario es: " + RetornarEdad(fecha));

        }

        
        private int RetornarEdad (DateTime fecha)
        {
            //En la variable guardo la fecha actual del sistema
            DateTime FechaActual = DateTime.Now;

            int edad = 0;

            
            if (fecha >= FechaActual)
            {
                //Si la fecha de nacimiento es mayor a la fecha actual retorna 0
                return 0;
            }
            else
            {
                //Sino, se calcula de forma normal
                edad = FechaActual.Year - fecha.Year;

                if (fecha.Month > FechaActual.Month)
                {
                    //si el mes de nacimiento del usuario es mayor al actual le resto -1 para tener su edad exacta
                    edad = edad - 1;
                }

                return edad;
            }


        }
    }
}
