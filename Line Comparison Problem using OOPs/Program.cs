using System;

namespace LineComparisonUsingOOPS
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creating object
            //UC1_DistanceOfALine LineAB = new UC1_DistanceOfALine(4,5,6,7);
            //Console.WriteLine(LineAB.lengthOfLine());

            //UC2_LineEquality lines1 = new UC2_LineEquality(1, 2, 3, 4, 5, 6, 7, 8);
            //Console.WriteLine(lines1.CheckLineEquality());

            //UC3_LineComparison lines2 = new UC3_LineComparison(1, 2, 3, 4, 5, 6, 7, 8);
            //Console.WriteLine(lines2.LineComparison());

            // UC4_LineComparisonUsingOOPs lines3 = new UC4_LineComparisonUsingOOPs(1, 2, 3, 4, 5, 6, 7, 8);
            // Console.WriteLine(lines3.DisplayResult());


            Console.WriteLine("Line Comparison\n");
            Console.WriteLine("1. Calculate distance of a line \n2. Check Equality of two lines \n3. Comapare two lines \n4. Compare two lines uisng OOPs\n");
            Console.Write("Select an option: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n");
            switch (n)
            {
                case 1:

                    UC1_DistanceOfALine LineAB = new UC1_DistanceOfALine(4, 5, 6, 7);
                    Console.WriteLine(LineAB.lengthOfLine());
                    break;
                case 2:
                    UC2_LineEquality lines1 = new UC2_LineEquality(19, 24, 3, 41, 5, 64, 7, 18);
                    Console.WriteLine(lines1.CheckLineEquality());
                    break;
                case 3:
                    UC3_LineComparison lines2 = new UC3_LineComparison(1, 22, 30, 4, 52, 16, 7, 8);
                    Console.WriteLine(lines2.LineComparison());
                    break;
                case 4:
                    UC4_LineComparisonUsingOOPs lines3 = new UC4_LineComparisonUsingOOPs(17, 12, 3, 14, 5, 13, 7, 28);
                    Console.WriteLine(lines3.DisplayResult());
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

            Console.ReadKey();
        }
    }
} 
