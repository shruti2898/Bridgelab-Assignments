using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class Program3_PowerOfTwo
    { 
        public static void PowerOfTwo()
        {
            Console.Write("Please enter value of Power N:  ");
            int n = Convert.ToInt32(Console.ReadLine());
            int baseNumber = 2;
            
            for(int i= 1; i<=n; i++)
            {
                if (n < 31) 
                {
                    Console.WriteLine("2^{0}   : {1} ", i, (int)Math.Pow(baseNumber, i));
                }
                else
                {
                    Console.WriteLine("Int overflow. Please enter value below 31");
                }
               
            }
        }
    }
}
