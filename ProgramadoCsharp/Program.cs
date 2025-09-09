using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramadoCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mostrar un mensaje
            Console.WriteLine("Fundamentos de Algoritmos - 6414");
            Console.WriteLine("Bienvenido a C#");
            //--Definir variables--
            int a, b, suma;

            //--Entrada de Datos--
            //Solicitando datos
            Console.WriteLine("Ingrese el primer numero");
            //Guardar los datos
            a= Convert.ToInt32(Console.ReadLine());
            //Solicitando datos
            Console.WriteLine("Ingrese el segundo numero");
            //Guardar los datos
            b = Convert.ToInt32(Console.ReadLine());

            //--Proceso--
            suma = a + b;

            //--Salida Datos--
            Console.WriteLine("La suma es: "+suma);
            Console.WriteLine($"La suma de {a} + {b} = {suma}");

            Console.WriteLine("--Algoritmos con Estructura Condicional --");

            Console.WriteLine("Ingrese su edad: "); //pidiendo msj usuario
            var edad = int.Parse(Console.ReadLine()); //guardando dato
            //Condicion
            if (edad >= 18)
            {
                Console.WriteLine("Accedes al Cine");

            }

            int aa = 6, bb = 7 ;

            if (aa > bb)
            {
                int temp;
                temp = aa;
                aa = bb;
                bb = temp;
                Console.WriteLine($"Los valores intercambiados son a={aa}, b={bb}");
            }
            else {
                Console.WriteLine("aa es menor que bb");
            }

            //Vincular ejercicio usando metodo
            //E1Secuencial EJ1 = new E1Secuencial();
            //EJ1.areatriangulo();

            //Pasuar para mostrar Resultados
            Console.ReadKey();
        }
    }
}
