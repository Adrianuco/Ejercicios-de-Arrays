namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Adriano Almanza
                     * 11/09/24
                     * Ejercicio 1
                     * Programa que tira dos dados 36,000 veces y calcula la cantidad de sumas que ocurrieron
                     * Tambien muestra si los resultados son razonables o no
                     */


            //Se establecen las constantes y el objeto rand para los numeros aleatorios
            const int roll = 36000;
            Random rand = new Random();
            int d1, d2, sum;

            //Array para la cantidad de sumas de un numero
            int[] sumasP = new int[11];

            for (int i = 0; i < roll; i++)
            {
                //Bucle donde en cada iteracion se tiran los dados y se incrementa en uno el valor del array asociado a la suma
                d1 = rand.Next(1, 7);
                d2 = rand.Next(1, 7);
                sum = d1 + d2;

                //Case para ir sumando de uno en uno las veces que salio determinada suma
                switch (sum)
                {
                    case 2:
                        {
                            sumasP[0]++;
                            break;
                        }
                    case 3:
                        {
                            sumasP[1]++;
                            break;
                        }
                    case 4:
                        {
                            sumasP[2]++;
                            break;
                        }
                    case 5:
                        {
                            sumasP[3]++;
                            break;
                        }
                    case 6:
                        {
                            sumasP[4]++;
                            break;
                        }
                    case 7:
                        {
                            sumasP[5]++;
                            break;
                        }
                    case 8:
                        {
                            sumasP[6]++;
                            break;
                        }
                    case 9:
                        {
                            sumasP[7]++;
                            break;
                        }
                    case 10:
                        {
                            sumasP[8]++;
                            break;
                        }
                    case 11:
                        {
                            sumasP[9]++;
                            break;
                        }
                    case 12:
                        {
                            sumasP[10]++;
                            break;
                        }

                }
            }

            //Se imprime las sumas posibles
            Console.Write("    Suma           ");
            for (int i = 1; i < 12; i++)
            {
                Console.Write(i + 1 + "     ");

            }

            Console.WriteLine();
            Console.WriteLine();

            //Se imprime la cantidad de veces que ocurrio cada suma
            Console.Write("Numero de Veces    ");
            for (int i = 0; i < 11; i++)
            {
                Console.Write(sumasP[i] + "  ");
            }

            //Esta variable es la estimacion de cuantas veces tendria que salir el 7
            float veces7 = (1.0f / 6.0f) * roll;

            //Este es el margen de error. Su funcion es para comparar la diferencia entre las veces que se espera 7 y las veces que salio
            //En caso de que la diferencia supere el margen, entonces los resultados no son razonables
            float marError = veces7 * 0.05f;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Se ocupa Math.Abs para conseguir el valor absoluto de la diferencia entre las veces que se espera 7 y las veces que salio
            //Se evalua si esta diferencia es menor que el margen de error
            if (Math.Abs(sumasP[5] - veces7) <= marError)
            {
                Console.WriteLine("Los resultados son razonables");
            }
            else
            {
                Console.WriteLine("Los resultados no son razonables");
            }
            Console.ReadKey();


        }
    }
}
