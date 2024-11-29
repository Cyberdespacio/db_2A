using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Timers;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//int numOculto = 33;
            int numOculto = arrojaRandom();

            int intentos = 1;

            Console.WriteLine("Ingrese un Número Entero entre 1 & 100");
            int numIngresado = Convert.ToInt32(Console.ReadLine());

            while (numIngresado != numOculto)
            {
                if (numIngresado < numOculto)
                {
                    Console.WriteLine("\t(!) El Número Oculto es MAYOR al que ingresó.");
                }
                else
                {
                    Console.WriteLine("\t(!) El Número Oculto es MENOR al que ingresó.");
                }

                Console.WriteLine("\nVuelva a intentarlo: ingrese un Número Entero entre 1 & 100");
                numIngresado = Convert.ToInt32(Console.ReadLine());

                intentos++;
            } Console.WriteLine("\t\t\t¡¡¡FELICITACIONES!!! El Número Oculto era {0}\n" +
                "\t\t\tUsted ha descubierto el Número Oculto en {1} intentos.", numOculto, intentos);
        }

        static int arrojaRandom()
        {
            Random numeroAzar = new Random();
            return numeroAzar.Next(101);
        }

            Console.WriteLine("Ingrese 2 Números: el 1° será el porcentaje del 2° número\n");

            Console.WriteLine("Ingrese el 1° Número:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el 2° Número:");
            int num2 = int.Parse(Console.ReadLine());

            double porcentaje = (num1*num2) / 100; //Regla de 3

            Console.WriteLine($"\nEl {num1}% de {num2} es: {porcentaje}.");
            */


            Console.WriteLine("¿Cuántos números va a introducir?");
            int totalnums = int.Parse(Console.ReadLine());

            int[] nums = new int[totalnums];

            for (int i = 0; i < totalnums; i++)
            {
                Console.WriteLine($"Introduzca el {i + 1}° número");
                nums[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < totalnums - 1; i++)
            {
                for (int j = 0; j < totalnums - i - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nLos números ordenados de menor a mayor son:");
            for (int i = 0; i < totalnums; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}