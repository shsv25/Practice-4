// 16 варіант
using System;

namespace Poject4.ex4
{
    internal class Program
    {
            static void Main()
            {
                Console.Write("Введiть натуральне число: ");
                int num = int.Parse(Console.ReadLine());

                Console.Write("Розклад числа {0} на простi множники: ", num);
                PrintPrimeFactors(num); // виклик методу розкладу числа на прості множники

                Console.WriteLine();
            }

            static void PrintPrimeFactors(int num)
            {
                for (int i = 2; i <= num; i++)
                {
                    int count = 0;
                    while (num % i == 0)
                    {
                        count++;
                        num /= i;
                    }
                    for (int j = 0; j < count; j++)
                    {
                        Console.Write("{0} ", i);
                    }
                }
            }
        }
    }

