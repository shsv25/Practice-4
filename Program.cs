// 12 варіант
using System;

namespace Project4.ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double productOfNegativeY, productOfPositiveY;
            int countNegativeY, countPositiveY;

            CalculateProductsAndCounts(out productOfNegativeY, out productOfPositiveY, out countNegativeY, out countPositiveY);

            Console.WriteLine("\n" + "Product of y < -3: {0:F3}", productOfNegativeY);
            Console.WriteLine("Count of y < -3: {0}", countNegativeY);
            Console.WriteLine("Product of y > 0.4: {0:F3}", productOfPositiveY);
            Console.WriteLine("Count of y > 0.4: {0}", countPositiveY);

            Console.ReadKey();
        }

        static double CalculateY(double x)
        {
            return Math.Sin(Math.Abs(x / 2 / 1)) + 9.1 * Math.Cos(x - 1);
        }

        static void CalculateProductsAndCounts(out double productOfNegativeY, out double productOfPositiveY, out int countNegativeY, out int countPositiveY)
        {
            double x, y;
            productOfNegativeY = 1;
            productOfPositiveY = 1;
            countNegativeY = 0;
            countPositiveY = 0;

            Console.WriteLine(" x |    y   ");
            Console.WriteLine("---+--------");

            for (x = 0; x <= 12; x += 1.2)
            {
                y = CalculateY(x);
                Console.WriteLine("{0,2:F1}|{1,8:F3}", x, y);

                if (y < -3)
                {
                    productOfNegativeY *= y;
                    countNegativeY++;
                }
                else if (y > 0.4)
                {
                    productOfPositiveY *= y;
                    countPositiveY++;
                }
            }
        }
    }
}
    






