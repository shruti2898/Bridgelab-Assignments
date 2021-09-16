using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class Program5_PrimeFactorsOfANumber
    {
        public static void PrimeFactors()
        {
            Console.Write("Enter a number:  ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\nPrime Factors of {0} are:", number);
            while (number % 2 == 0)
            {
                Console.Write(2 + " ");
                number = number/2;
            }
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
               
                while (number % i == 0)
                {
                    Console.Write(i + " ");
                    number = number / i;
                }
            }

            if (number > 2)
                Console.Write(number);
        }
    }
}
