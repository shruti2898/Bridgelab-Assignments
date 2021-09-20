using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisonUsingOOPS
{
   public class UC4_LineComparisonUsingOOPs
    {
        int x1, y1, x2, y2, p1, q1, p2, q2;

        // Constructor Declaration of Class
        public UC4_LineComparisonUsingOOPs(int x1, int y1, int x2, int y2, int p1, int q1, int p2, int q2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.p1 = p1;
            this.q1 = q1;
            this.p2 = p2;
            this.q2 = q2;
        }

        public float DistanceCalculate(int a1, int b1, int a2, int b2)
        {
            return (float)Math.Sqrt((Math.Pow(a1 - a2, 2) + Math.Pow(b1 - b2, 2)));
        }

        public string DisplayResult() 
        {
            float distanceAB = DistanceCalculate(x1, y1, x2, y2);
            float distanceCD = DistanceCalculate(p1, q1, p2, q2);

            Console.WriteLine("Co - ordinates of Line AB are" + "(" + x1 + ", " + y1 + ") and(" + x2 + ", " + y2 + "). \nLength of line AB is:  " + distanceAB);
            Console.WriteLine("\n\nCo - ordinates of Line CD are" + "(" + p1 + ", " + q1 + ") and(" + p2 + ", " + q2 + "). \nLength of line CD is:  " + distanceCD);


            if (distanceAB == distanceCD)
            {
                return ("Length of AB and CD are equal. So lines AB and CD are Equal.");
            }
            else if (distanceAB > distanceCD)
            {
                return ("Length of AB is greater than CD.");
            }
            else
            {
                return ("Length of AB is less than CD.");
            }
        }

    }



}

