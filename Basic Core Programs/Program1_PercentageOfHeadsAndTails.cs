using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
     class Program1_PercentageOfHeadsAndTails
    {
        public static void PercentageCalculate()
        {
            Console.Write("Enter number of flips:  ");
            int number = Convert.ToInt32(Console.ReadLine());

          

            int heads = 0;
            int tails = 0;

            for(int i =0; i < number; i++)
            {
                Random random = new Random();
                double value = random.NextDouble();
                if (value < 0.5)
                {
                    tails++;
                }
                else
                {
                    heads++;
                }
            }
            Console.WriteLine("Heads:  "+heads);
            Console.WriteLine("Tails:  " + tails);

            float percentageHeads = (heads / number) * 100;
            float percentageTails = (tails / number) * 100;


            Console.WriteLine("Heads Percentage Probability:  " + percentageHeads);
            Console.WriteLine("Tails Percentage Probability:  " + percentageTails);
        }
    }
}