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
            float distanceAB = CalculateDistance.Distance();
            Console.WriteLine("Please enter co-ordinates of Line CD: ");
            float distanceCD = CalculateDistance.Distance();

            Console.WriteLine("Length of Line AB is :   " + distanceAB);
            Console.WriteLine("Length of Line CD is :   " + distanceCD);


            String lineAB = distanceAB.ToString();
            String lineCD = distanceCD.ToString();

            if (lineAB.Equals(lineCD))
            {
                Console.WriteLine("Length of AB and CD are equal. So lines AB and CD are Equal.");
            }
            else
            {
                Console.WriteLine("Length of AB and CD are not equal. So lines AB and CD are not Equal.");
            }




            //Alternate method: 
            //if(distanceAB == distanceCD)
            //{
            //    Console.WriteLine("Length of AB and CD are equal. So lines AB and CD are Equal.");
            //}
            //else
            //{
            //    Console.WriteLine("Length of AB and CD are not equal. So lines AB and CD are not Equal.");
            //}
        }
    }
}
