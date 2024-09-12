using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Adriano Almanza
             * 09/09/24
             * Programa de arreglos bidimensionales y suma columnas y filas
             */
            int[,] table = new int[3, 3];
            int[] sumFila = new int[3];
            int[] sumCol = new int[3];
            Console.WriteLine("Programa de Arreglos Bidimensionales");

            //Leer los datos de la matriz y sumar las filas
            for(int i = 0;  i < table.GetLength(0); i++)
            {
                for(int j = 0 ; j < table.GetLength(1); j++)
                {
                    Console.Write("Digite un numero: ");
                    table[i, j] = int.Parse(Console.ReadLine());
                    sumFila[i] += table[i, j];
                }
            }
            Console.Clear();

            //Sumar las columnas
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    sumCol[i] += table[j, i];
                }
                Console.WriteLine();
            } 
            
            //Imprimir la matriz
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write(table[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Imprimir las sumas de filas y columnas
            for (int i = 0; i < sumFila.Length; i++)
            {
                Console.WriteLine("La suma de la fila " + (i+1) + " es: " + sumFila[i]);
            }           
            for (int i = 0; i < sumCol.Length; i++)
            {
                Console.WriteLine("La suma de la columna " + (i + 1) + " es: " + sumCol[i]);
            }

            Console.ReadKey();
        }
    }
}
