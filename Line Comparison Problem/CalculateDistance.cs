using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    class CalculateDistance
    {
        public static double Distance()
        {

            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            double distance = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            return distance;
        }
    }
}
