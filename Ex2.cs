// 12 варіант
// Створити додаток з допомогою якого можна для ряду, члени якого обчислюються по формулі,
// підрахувати суму членів ряду з точністю до 0,000001 і суму перших 10 членів ряду.

using System;

namespace Project4.ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Введення кількості членів ряду
            Console.Write("Введiть кiлькiсть членiв ряду: ");
            int n = int.Parse(Console.ReadLine());

            // Обчислення та виведення суми членів ряду
            double sum = CalculateSum(n);
            Console.WriteLine("Сума членiв ряду: {0}", Math.Round(sum, 6));

            // Обчислення та виведення суми перших 10 членів ряду
            double sumFirstTen = CalculateSumFirstTen();
            Console.WriteLine("Сума перших 10 членiв ряду: {0}", Math.Round(sumFirstTen, 6));

            Console.ReadKey();
        }

        // Метод для обчислення суми членів ряду
        static double CalculateSum(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                double a = Math.Pow(-1, i) * (1 / Math.Pow(i, 2) + Math.Pow(2, i));
                sum += a;
            }
            return sum;
        }

        // Метод для обчислення суми перших 10 членів ряду
        static double CalculateSumFirstTen()
        {
            double sumFirstTen = 0;
            for (int i = 1; i <= 10; i++)
            {
                double a = Math.Pow(-1, i) * (1 / Math.Pow(i, 2) + Math.Pow(2, i));
                sumFirstTen += a;
            }
            return sumFirstTen;
        }
    }
}
