using System;

namespace homeWorkSumNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int number;
            int numberMin = -100;
            int numberMax = 100;
            int multipleNumberMin = 3;
            int multipleNumberMax = 5;

            Random rand = new Random();
            number = rand.Next(numberMin,numberMax);

            Console.WriteLine(number);

            for (int i = number; i <= numberMax; i++)
            { 
            if (i > 0 && (i % multipleNumberMin == 0 || i % multipleNumberMax == 0))
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
