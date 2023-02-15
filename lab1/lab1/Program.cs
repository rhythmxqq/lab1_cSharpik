using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число иттераций: ");
            int length = Convert.ToInt16(Console.ReadLine());
            double sum = 0;
            if (length<0)
            {
                Console.WriteLine("Введите другое число иттераций: ");
            }
            Console.WriteLine();
            for (int i = 1; i <= length; i++)
            {
                if (i == 1)
                {
                    sum = 1 - x;
                    Console.WriteLine("Сумма иттерации № " + i + "= " + sum);
                }
                else
                {
                    sum += (Math.Pow(-1,i)* Math.Pow(x, i)) / (getFactorial(i));
                   Console.WriteLine("Сумма иттерации № " + i + "= " + sum);
                }
            }
        }

        private static double getFactorial(int i)
        {
            int fact = 1;
            for (int f = 1; f <= i; f++)
            {
                fact *= f;
            }
            return fact;
        }
    }

  
}
