using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosPreParcial
{
    class ejercicio3
    {

        public static void Main(string[] args)
        {

            Jugador j1 = new Jugador("miguel",3,49,"delantero");
            Jugador j2 = new Jugador("michael", 20, 56,"defensor");

            Tecnico t1 = new Tecnico("jaco", 1, 15, "?");
            Tecnico t2 = new Tecnico("jaquita", 22, 66, "??");


            j1.MostrarInformacion();
            j1.SumarAntiguedad(3,"pq pinto");
            j1.MostrarInformacion();

            t1.MostrarInformacion();
            t1.SumarAntiguedad(5);
            t1.MostrarInformacion();

        }


        class Integrante
        {
            public string nombre;
            public int edad;
            public int antiguedad;


            public Integrante(string nombre, int antiguedad, int edad)
            {
                this.nombre = nombre;
                this.antiguedad = antiguedad;
                this.edad = edad;
            }

            public void SumarAntiguedad(int cantidad)
            {
                if (cantidad > antiguedad)
                {
                    antiguedad++;
                }
            }

            public void SumarAntiguedad(int cantidad, string motivo)
            {
                antiguedad++;
                Console.Write("Motivo:  ");
                Console.WriteLine(motivo);
            }

            public virtual void MostrarInformacion()
            {
                Console.WriteLine($" Nombre: {nombre}, Antiguedad: {antiguedad}, Edad: {edad}");
            }

        }

        class Jugador : Integrante
        {
            public string posicion;



            public Jugador(string nombre, int antiguedad, int edad, string posicion): base(nombre, antiguedad, edad)
            {
                this.posicion = posicion;
            }

            public override void MostrarInformacion()
            {
                Console.WriteLine($" Nombre: {nombre}, Antiguedad: {antiguedad}, Edad: {edad}, Posicion {posicion}");

            }

        }

        class Tecnico : Integrante
        {
            public string especialidad;

            public Tecnico(string nombre, int antiguedad, int edad, string especialidad) : base(nombre, antiguedad, edad)
            {
                this.especialidad = especialidad;
            }

            public override void MostrarInformacion()
            {
                Console.WriteLine($" Nombre: {nombre}, Antiguedad: {antiguedad}, Edad: {edad}, Especialidad: {especialidad}");

            }
        }
    }
}



/*
 3) Crear la clase Integrante que posea nombre, edad, antigüedad y un único método constructor que
almacene los datos de las variables nombradas.

Crear dos clases hijas:

Jugador. 
Tecnico. 

Jugador debe tener posicion.

Tecnico debe tener especialidad.

Crear el método sumarAntiguedad(int cantidad) que incremente el valor de la antigüedad siempre
que el valor por parametro sea superior al existente.


Crear el método sumarAntiguedad(int cantidad, string motivo) para los casos en los que se
incremente la antigüedad con un mótivo especifico. El motivo solamente debe imprimirse en
pantalla.


Instanciar en el Main al menos dos objetos de la clase Jugador y dos objetos de la clase Tecnico,
ejecutar los métodos descriptos para cada tipo de Integrante y mostrar la información final por
pantalla con un método de MostrarInformación().
 
 */