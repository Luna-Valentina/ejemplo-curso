using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_AUTO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Iniciando la consola.");
            AUTO auto_uno = new AUTO("Chevrolet", "Onix", 2021, 1.3, 5, 35);
            //Console.WriteLine("El auto número uno es un " + auto_uno.marca + " " + auto_uno.modelo + " del año " + auto_uno.anio + ".");
            AUTO auto_dos = new AUTO("Volkswagen", "Vento", 2022, 1.4, 5, 40);
            //Console.WriteLine("El auto número dos es un " + auto_dos.marca + " " + auto_dos.modelo + " del año " + auto_dos.anio + ".");
            Console.WriteLine(auto_uno.marca + " ¿puedes hacer un viaje de 570 kilómetros ahora mismo?");
            Console.WriteLine(auto_uno.conducir(570));
            Console.WriteLine("¿Y qué tal un viaje de 120 kilómetros?");
            Console.WriteLine(auto_uno.conducir(120));
            Console.WriteLine("¿Qué tal si ahora realizamos un viaje de 150 kilómetros?");
            Console.WriteLine(auto_uno.conducir(150));
            Console.WriteLine("Ahora un último viaje de 20 kilómetros.");
            Console.WriteLine(auto_uno.conducir(20));
            Console.WriteLine("¡Surgió una emergencia! Preciso un viaje de 55 kilómetros.");
            Console.WriteLine(auto_uno.conducir(55));
            Console.WriteLine("Luego de todos los viajes, el tanque tiene " + auto_uno.combustible.ToString("0.00") + " litros.");
            Console.WriteLine("Hora de cargar combustible.");
            Console.WriteLine("Cargando, por favor espere...");
            Console.WriteLine(auto_uno.cargarCombustible(10));
            Console.WriteLine(auto_uno.cargarCombustible(20));
            Console.WriteLine(auto_uno.cargarCombustible(50));


            Console.ReadKey();

        }
    }
}
