using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            List<int> three_digits = new List<int>();
            List<int> positions = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Escriba el valor no. {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            foreach (int x in numbers)
            {
                if (x >= 100)
                { 
                    three_digits.Add(x);
                }
            }
            foreach (int z in three_digits)
            {
                for (int y = 0; y < numbers.Length; y++)
                {
                    if ((numbers[y] == z))
                    { 
                        positions.Add(y+1);
                    }
                }
            }
            Console.WriteLine("Los numeros con mas de tres digitos estan en las siguientes posiciones: ");
            foreach (int q in positions)
            {
                Console.WriteLine(q);
            }
        }
    }
}