using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class Program3_PrimeNumber
    {
        public static void PrimeNumber()
        {
            Console.Write("Enter a number:   ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool flag = false;

            for(int i=2; i <= num / 2; i++)
            {   
                if (num % i == 0 && num != 2 )
                {
                    flag = true;
                    break;
                }
               
            }
            if (flag)
            {
                Console.WriteLine("\n\n{0} is not a Prime number", num);
            }
             else
            {
                Console.WriteLine("\n\n{0} is a Prime number", num);
            }
        }
    }
}
