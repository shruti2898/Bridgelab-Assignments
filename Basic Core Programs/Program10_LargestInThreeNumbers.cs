using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class Program10_LargestInThreeNumbers
    {
        public static void LargestNumber()
        {
            Console.WriteLine("Enter three numbers:  ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            //Using Ternary Operator
            int largest = (a > b) ? (a > c ? a : c) : (b > c ? b : c);

            Console.WriteLine("Largest number is {0}", largest);

        }
    }
}
