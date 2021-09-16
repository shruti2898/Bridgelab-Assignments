using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class Program1_FibonacciSeries
    {
        public static void FibonacciSeries()
        {
            int firstTerm = 0;
            int secondTerm = 1;
            Console.Write("Enter number of terms in Fibonacci Series:   ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write(firstTerm);

            for(int i=1; i<=num; i++)
            {
                Console.Write(" + "+secondTerm);
                int temp;

                temp = firstTerm;
                firstTerm = secondTerm;
                secondTerm = temp + secondTerm;
                
            }
        }
    }
}
