using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    class UC1_LengthOfALine
    {
        public static void LengthOfLine()
        {
            Console.WriteLine("Please enter co-ordinates of Pont A and Point B: ");
            double distance = CalculateDistance.Distance();
            Console.WriteLine("Length of Line AB is :   "+ distance);
        }
    }
}
