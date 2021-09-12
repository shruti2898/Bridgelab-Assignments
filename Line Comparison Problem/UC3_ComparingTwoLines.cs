using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    class UC3_ComparingTwoLines
    {
        public static void ComparingTwoLines()
        {
            Console.WriteLine("Please enter co-ordinates of Line AB: ");
            double distanceAB = CalculateDistance.Distance();
            Console.WriteLine("Please enter co-ordinates of Line CD: ");
            double distanceCD = CalculateDistance.Distance();

            Console.WriteLine("Length of Line AB is :   " + distanceAB);
            Console.WriteLine("Length of Line CD is :   " + distanceCD);

            if (distanceAB == distanceCD)
            {
                Console.WriteLine("Length of AB and CD are equal. So lines AB and CD are Equal.");
            }
            else if( distanceAB > distanceCD)
            {
                Console.WriteLine("Length of AB is greater than CD.");
            }
            else
            {
                Console.WriteLine("Length of AB is less than CD.");
            }
        }
    }
}
