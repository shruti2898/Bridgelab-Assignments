using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    class CalculateDistance
    {
        public static float Distance()
        {
            Console.Write("Co-ordinates of Start Point: ");
            int x1, y1;
            string line1 = Console.ReadLine();
            string[] numbers1 = line1.Split(',');
            x1 = int.Parse(numbers1[0]);
            y1 = int.Parse(numbers1[1]);
            Console.Write("Co-ordinates of End Point: ");
            int x2, y2;
            string line2 = Console.ReadLine();
            string[] numbers2 = line2.Split(',');
            x2 = int.Parse(numbers2[0]);
            y2 = int.Parse(numbers2[1]);

            float distance = (float) Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            return distance;
        }
    }
}
