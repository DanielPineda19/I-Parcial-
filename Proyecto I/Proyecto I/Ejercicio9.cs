using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POO;

namespace Proyecto_I
{
    public partial class Ejercicio9 : Form
    {
        public Ejercicio9()
        {
            InitializeComponent();
        }


        //Objeto en ambito global 
        Coche miCoche = null;

        //Declaro una lista de objetos de la clase Coche
        List <Coche> listacoches = new List <Coche>();


        private void EjecutarPOOButton_Click(object sender, EventArgs e)
        {
            //INSTANCIAR OBJETO DE LA CLASE "COCHE"
            //Coche miCoche = new Coche();
            //Coche miCCoche2 = new Coche("Toyota", "22R");



            //VARIABLES
            //En variables almaceno lo que ingresa el usuario
            string marca = MarcaTextBox.Text;
            string modelo = ModeloTextBox.Text;
            decimal precio = Convert.ToDecimal(PrecioTextBox.Text);

            //Operador ternario, es como tener un IF
            // ? --> significa entonces, le asigno el valor que sigue
            // : --> es el SINO
            // 0 --> el valor que le aigno si se cumple la primera condicion
            int km = KMTextBox.Text == string.Empty ? 0 : Convert.ToInt32(KMTextBox.Text);



            //Instacio mi objeto de la Clase Coche
            //Instancio mi objeto con constructor vacio
            miCoche = new Coche();   

            //Aqui a las propiedades del objeto le paso los valores que ingreso el usuario en los TextBox que estan en las variables
            //Asigno a la propiedad un valor
            //Aqui utlizo el metodo Set de la propiedad
            miCoche.Marca = marca;
            miCoche.Modelo = modelo;
            miCoche.Precio = precio;
            miCoche.Kilometros = km;



            //MOSTRAR DATOS DEL OBJETO
            //Aqui extraigo lo que tiene la propiedad
            //Obtengo un valor de la propiedad
            //Aqui utilizo el Metodo Get de la propiedad
            //MessageBox.Show("Objeto Coche --> Marca: " + miCoche.Marca + " Modelo: " + miCoche.Modelo);



            //LLAMADO A LA LISTA
            listacoches.Add(miCoche);

            //limpio el data para luego asignarle la lista
            CochesDataGridView.DataSource = null;

            //AL DATAGRID VIEW LE PASO MI "LISTACOCOCHES"
            CochesDataGridView.DataSource = listacoches;

            //Llamado a procedimiento limpia controles
            LimpiarControles();

            //Me devuelve a la casilla instantaneamente, ayuda al usuario para agregar rapido los datos
            MarcaTextBox.Focus();
        }

        //Procedimiento para limpiar controles
        private void LimpiarControles ()
        {
            MarcaTextBox.Clear();
            ModeloTextBox.Text=string.Empty;
            PrecioTextBox.Text = "";
            KMTextBox.Clear();
        }

        private void Ejercicio9_Load(object sender, EventArgs e)
        {
            MarcaTextBox.Focus();
        }
    }
}
