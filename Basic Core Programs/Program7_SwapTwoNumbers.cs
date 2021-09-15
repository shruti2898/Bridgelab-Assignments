using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class Program7_SwapTwoNumbers
    {
        public static void SwapNumbers()
        {   
            // inputs
            Console.Write("Enter first number:  ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number:  ");
            int b = Convert.ToInt32(Console.ReadLine());
          

            Console.WriteLine("\n\n\nNumbers before swapping -   ");
            Console.WriteLine("First number :   "+a);
            Console.WriteLine("Second number :   " + b);

            // using a temporary variable
            //int temp;
            //temp = a;
            //a = b;
            //b = temp;

            //Console.WriteLine("\n\n\nNumbers after swapping -   ");
            //Console.WriteLine("First number :   " + a);
            //Console.WriteLine("Second number :   " + b);


            // without using third variable
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("\n\n\nNumbers after swapping -   ");
            Console.WriteLine("First number :   " + a);
            Console.WriteLine("Second number :   " + b);


           

            
        }
    }
}
