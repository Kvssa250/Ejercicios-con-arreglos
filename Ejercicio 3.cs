using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            List<int> prime_numbers = new List<int>();
            int cantidad = 0;
            int mayor = 0;
            int z = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Escriba el valor no. {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            foreach (int x in numbers)
            {
                if (x == 2)
                {
                    prime_numbers.Add(x);
                    cantidad++;
                }
                for (int q = 2; q < x; q++)
                {
                    if (x % q == 0)
                    {
                        break;
                    }
                    if (x % q != 0)
                    {
                        prime_numbers.Add(x);
                        cantidad++;
                        break;
                    }
                }
            }
            while (z < cantidad)
            {
                if (mayor < prime_numbers[z])
                {
                    mayor = prime_numbers[z];
                }
                z++;
            }
            for (int y = 0; y < numbers.Length; y++)
            {
                if (mayor == numbers[y])
                {
                    Console.WriteLine($"El numero primo mas grande es: {mayor}, y esta en la posicion no. {y + 1}.");
                }
            }
        }
    }
}