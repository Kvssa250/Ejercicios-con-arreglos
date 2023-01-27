using System;
using System.Diagnostics.CodeAnalysis;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int sum = 0;
            int cantidad = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Escriba el valor no. {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            foreach (int x in numbers)
            {
                sum = sum + x;
                cantidad++;
            }
            float average = sum / cantidad;
            Console.WriteLine($"El promedio de los numeros de la lista es: {average}");
        }
    }
}