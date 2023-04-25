// 1 варіант
// Вивести на екран всі цілі числа від 𝑎 до 𝑏, кратні деякому числу c.

using System;

namespace Project4.ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть початкове значення a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введiть кiнцеве значення b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Введiть задане число c: ");
            int c = int.Parse(Console.ReadLine());

            PrintMultiples(a, b, c); // виклик методу для виведення кратних чисел
        }

        static void PrintMultiples(int a, int b, int c)
        {
            for (int i = a; i <= b; i++)
            {
                if (i % c == 0) // перевірка на кратність
                {
                    Console.WriteLine(i);

                }
            }
        }
    }
}
