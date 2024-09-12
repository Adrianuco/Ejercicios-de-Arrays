using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Adriano Almanza
             * 09/09/24
             * Programa de arreglos unidimensionales que suman los numeros pares e impares
             */
            const int TAM = 10;
            int[] numbers = new int[TAM];
            int par = 0, imp = 0;

            Console.WriteLine("Digite los numeros: ");
            Console.WriteLine();

            for(int i = 0; i < TAM; i++)
            {
                Console.Write("Ingresa numero: ");
                numbers[i] = int.Parse(Console.ReadLine());
                if (numbers[i] % 2 == 0)
                {
                    par += numbers[i];
                }
                else
                {
                    imp += numbers[i];
                }
            }
            Console.Clear();
            Console.WriteLine("Datos del Arreglo");
            for(int i =0; i < numbers.Length;i++)
            {
                Console.Write(numbers[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("La suma de los numeros pares es " + par);
            Console.WriteLine("La suma de los numeros impares es " + imp);
            Console.ReadKey();  
        }
    }
}
