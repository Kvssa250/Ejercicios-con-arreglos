using System;
using System.Data;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int mayor = 0;
            int x = 0;
            for (int i = 0; i < numbers.Length; i++)
            { 
                Console.WriteLine($"Escriba el valor no. {i+1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (i > 0)
                {
                    while (numbers[i - 1] == numbers[i])
                    {
                        Console.WriteLine($"{numbers[i - 1]} ya esta en la lista, escriba otro numero: ");
                        numbers[i] = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                    }
                }
            }
            while (x < numbers.Length) 
            {
                if (mayor < numbers[x])
                {
                    mayor = numbers[x];
                }
                x++;
            }
            for (int z = 0; z < numbers.Length; z++)
            {
                if (mayor == numbers[z])
                {
                    Console.WriteLine($"El numero mas grande es: {mayor}, y esta en la posicion no. {z+1}.");
                }
            }
        }
    }
}