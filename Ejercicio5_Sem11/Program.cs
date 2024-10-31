//N00458733

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_Sem11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] caracteres = { 'a', 'e', 'i', 'o', 'u' };
            char caracter;

            EscribirElementosDelArreglo(caracteres);
            Console.Write("Ingrese el caracter que desea buscar: ");
            while (!char.TryParse(Console.ReadLine(), out caracter))
            {
                Console.WriteLine("Recuerde que debe ingresar un caracter.");
                Console.Write("Ingrese el caracter que quiera buscar: ");
            }

            ModificarElElementoDelArreglo(caracter, ref caracteres);
            EscribirElementosDelArreglo(caracteres);
            Console.ReadKey();
        }

        static void EscribirElementosDelArreglo(char[] arreglo)
        {
            Console.Write("Los caracteres son: ");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write($"{arreglo[i]} ");
            }
            Console.WriteLine();
        }

        static void ModificarElElementoDelArreglo(char caracterBuscado, ref char[] caracteres)
        {
            int contador = 0, contador2 = 0;
            for (int i = 0; i < caracteres.Length; i++)
            {
                contador++;
                if (caracterBuscado == caracteres[i])
                {
                    Console.Write("Ingrese el nuevo valor que se le va a asignar al caracter: ");
                    while (!char.TryParse(Console.ReadLine(), out caracteres[i]))
                    {
                        Console.WriteLine("Recuerde que debe ingresar un caracter.");
                        Console.Write("Ingrese el nuevo valor que se le va a asignar al caracter: ");
                    }
                    contador2++;
                }
            }
            if (contador2 == 0)
            {
                Console.WriteLine("No se ha encontrado el caracter buscado");
            }
        }
    }
}

