using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class Program2_PerfectNumber
    {
        public static void PerfectNumber()
        {
            int sum = 0;
            int divisors;

            Console.Write("Enter a number:   ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\nDivisors of {0}:   ",num);
            for (int i=1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    Console.Write(i+" ");
                    sum = sum + i;

                }
            }
            Console.WriteLine("\n\nSum of divisors:  " + sum);

            if (sum == num)
            {
                Console.WriteLine("\n\n{0} is a Perfect number", num);
            }
            else
            {
                Console.WriteLine("\n\n{0} is not a Perfect number", num);
            }
           
        }
    }
}
