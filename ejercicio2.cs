using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosPreParcial
{
    class ejercicio2
    {
        public static void Main(string[] args)
        {
            Persona persona = new Persona();
            Persona persona1 = new Persona("Miguel",18);
            Persona persona2 = new Persona("Michael",20,"40693716");


            

            persona.MostrarInformacion();
            persona1.MostrarInformacion();
            persona2.MostrarInformacion();



        }

        class Persona
        {
            public string nombre;
            private int edad;
            public string DNI;

            
            public Persona() 
            {
                
            }
            public Persona(string nombre, int edad)
            {
                this.nombre = nombre;
                this.edad = edad;
            }
            public Persona(string nombre, int edad, string DNI)
            {
                this.nombre = nombre;
                this.edad = edad;
                this.DNI = DNI;
            
            }


            public void MostrarInformacion()
            {
                Console.WriteLine($"nombre: {nombre} edad: {edad} DNI: {DNI}");

            }




        }
    }
}


/*
 2) Crear la clase Persona con los siguientes atributos:
nombre
private edad
DNI
Método:
MostrarInformación() que imprima por consola los tres atributos.
Crear 3 constructores:

Uno vacío.
Uno que reciba por parametro el nombre y la edad.
Uno que reciba el nombre, la edad y el DNI.

En el Main:
Crear tres objetos de Persona usando los distintos constructores y mostrar los valores de sus
propiedades con el método MostrarInformación().

 
 */