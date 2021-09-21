using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace LogicalPrograms
{
    class Program6_StopWatch
    {
        public static void StopwatchCalculation()
        {
            Stopwatch watch = new Stopwatch();

            int max = 10000000;
            Random random = new Random();
            int randomLap = random.Next(0, max);
            for (int i = 0; i < max; i++)
            {
                watch.Start();
                if (i == randomLap)
                {
                    randomLap = random.Next(0, max);
                    watch.Stop();
                    TimeSpan ts = watch.Elapsed;
                    Console.WriteLine("\n\nTime Lap: " + ts);
                }
            }
        }

    }
}

