using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaS3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Algoritmos con Estructuras Secuenciales--");
            Console.WriteLine("Ejercicio 1");
            /*
             Calcular el costo de un viaje a una ciudad si el precio por km es s/2. Una persona ha viajado durante 5 horas un total de 244 km.
            Estimae el monto que debe pagar por el viaje.
             */

            int precio_km = 2, km_viaje=244;
            var monto_pagar = precio_km * km_viaje;

            Console.WriteLine($"El costo por viajar {km_viaje} km es {monto_pagar} ");

            Console.WriteLine("--Algoritmos con Estructura Condicional--");
            Console.WriteLine("ingrese su edad: ");
            var edad= int.Parse(Console.ReadLine());
            if (edad >= 18)
                Console.WriteLine("ingresas al cine");

            Console.ReadKey();

        }
    }
}
