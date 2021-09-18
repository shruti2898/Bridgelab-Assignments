using System;
using System.Collections.Generic;
using System.Text;


namespace LogicalPrograms
{
    class Program6_StopWatch
    {
        public static void StopwatchCalculation()
       {         
            Console.Write("StopWatch running..........\n\n");
           
            int max = 86400000;
            String time = "00:00:00:0000";
            String[] timeArray = time.Split(":");
            int hours = Convert.ToInt32(timeArray[0]);
            int minutes = Convert.ToInt32(timeArray[1]);
            int seconds = Convert.ToInt32(timeArray[2]);
            int milliseconds = Convert.ToInt32(timeArray[3]);

            int randomStop = new Random().Next(0, max);           
            for (int i = 0; i < max; i++)
            {
                if (randomStop == i)
                {   
                    milliseconds = randomStop % 999;
                    timeArray[3] = milliseconds.ToString();
                    randomStop = randomStop / 999;
                    seconds = randomStop % 59;
                    timeArray[2] = seconds.ToString();
                    randomStop = randomStop / 59;
                    minutes = randomStop % 59;
                    timeArray[1] = minutes.ToString();
                    randomStop = randomStop / 59;
                    hours = randomStop % 23;
                    timeArray[0] = hours.ToString();
                }
            }
            Console.Write("StopWatch stopped..........\n\n");
            Console.WriteLine("Time: " + string.Join(":", timeArray));
        }
    }
}
