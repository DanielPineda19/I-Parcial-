using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace POO
{
    //OJO --> ESTA CLASE ES EL MOLDE DEL OBJETO
    //OJO --> HAY PARAMETROS LOS CUALES ALIMENTAN A LOS ATRIBUTOS

    public class Coche
    {
        //ATRIBUTOS
        private string marca;
        private string modelo;
        private decimal precio;



        //PROPIEDADES

        //Propiedad para la Marca
        public string Marca
        {
            get { return marca; } //El metodo get sirve para obtener, entonces con Get obtengo, retorno el valor que tiene el atributo, en este caso marca.

            set { marca = value; } //El set es para mandarle información, es decir, le paso una marca en este caso al atributo "marca", le establezco el valor. 
        }

        public string Modelo { get => modelo; set => modelo = value; }
         
        //Cuando utilizo esta forma para las propiedades, me ahorro de declarar el atriibuto, internamente crea el atributo necesario
        public decimal Precio { get; set; }
        public int Kilometros { get; set; } 



        //CONSTRUCTORES
        public Coche() { } //Constructor Vacio

        public Coche(string _marca, string _modelo, decimal _precio) //Constructor con parametros
        { 
            //A la propiedad le paso el valor (el parametro)
            //El parametro (_marca) le asigna el valor a la propiedad "Marca", luego el vuelve a la propiedad y como esta asignando utiliza el metodo Set, el cual seria el atributo "marca" y le asigna el valor a la propiedad (el valor seria el del constructor (_marca)
            Marca = _marca;
            Modelo = _modelo;                               
        }



        //METODOS
        public string DevolverDatosBasicos()
        {
            return "Marca: " + Marca + " Modelo: " + Modelo + " Precio " + Precio;
        }

         


    }
}
