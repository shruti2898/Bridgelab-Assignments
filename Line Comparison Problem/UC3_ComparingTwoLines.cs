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
            float distanceAB = CalculateDistance.Distance();
            Console.WriteLine("Please enter co-ordinates of Line CD: ");
            float distanceCD = CalculateDistance.Distance();

            Console.WriteLine("Length of Line AB is :   " + distanceAB);
            Console.WriteLine("Length of Line CD is :   " + distanceCD);

            int status = distanceAB.CompareTo(distanceCD);

            if (status > 0)
            {
                Console.WriteLine("Length of line AB is greater than length of line CD");
            }
            else if (status < 0)
            {
                Console.WriteLine("Length of line AB is less than length of line CD");
            }
            else
            {
                Console.WriteLine("Length of line AB and llength of line CD are equal");
            }
               
        }


        //Alternate Method
        //if (distanceAB == distanceCD)
        //{
        //    Console.WriteLine("Length of AB and CD are equal. So lines AB and CD are Equal.");
        //}
        //else if( distanceAB > distanceCD)
        //{
        //    Console.WriteLine("Length of AB is greater than CD.");
        //}
        //else
        //{
        //    Console.WriteLine("Length of AB is less than CD.");
        //}
    }
    }

