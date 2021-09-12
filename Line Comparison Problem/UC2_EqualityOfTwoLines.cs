using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    class UC2_EqualityOfTwoLines
    {
        public static void EqualityOfTwoLines()
        {
            Console.WriteLine("Please enter co-ordinates of Line AB: ");
            double distanceAB = CalculateDistance.Distance();
            Console.WriteLine("Please enter co-ordinates of Line CD: ");
            double distanceCD = CalculateDistance.Distance();

            Console.WriteLine("Length of Line AB is :   " + distanceAB);
            Console.WriteLine("Length of Line CD is :   " + distanceCD);

            if(distanceAB == distanceCD)
            {
                Console.WriteLine("Length of AB and CD are equal. So lines AB and CD are Equal.");
            }
            else
            {
                Console.WriteLine("Length of AB and CD are not equal. So lines AB and CD are not Equal.");
            }
        }
    }
}
