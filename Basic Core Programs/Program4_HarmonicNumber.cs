using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class Program4_HarmonicNumber
    {
        public static void HarmonicNumber()
        {
            int n;
            double sum = 0.0;

            

            Console.Write("Enter the number of terms :   ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

          
            for (int i = 1; i <= n; i++)
            {
                Console.Write("1/{0} + ", i); 
                sum += 1 / (float)i;
            }
            Console.WriteLine("\n\nSum of Harmonic Series upto {0} terms : {1} \n", n, sum);
        }
    }
}
