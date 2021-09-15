using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadderGame
{
    class UC4_RepeatTill100
    {
        public const int Ladder = 1;
        public const int Snake = 2;
        public const int winningPosition = 100;
        public static void WinningPosition()
        {


            int position = 0;
            int number;
            // int currentPosition = 0;
            Console.WriteLine("Starting position: " + position);
            while (position <= winningPosition-1 && position >= 0)
            {
                Random randomOption = new Random();
                int options = randomOption.Next(0, 3);
                Console.WriteLine("Option:  " + options);
                switch (options)
                {
                    case Ladder:
                        Console.WriteLine("Option 1: Ladder");
                        number = UC2_RollingDice.DiceNumber();
                        Console.WriteLine("Moves forward by {0}",number);
                        position = position + number;
                        break;
                    case Snake:
                        {
                            Console.WriteLine("Option 2: Snake");
                            number = UC2_RollingDice.DiceNumber();
                          
                            if (position <= number || position == 0)
                            {
                                position = 0;
                                Console.WriteLine("Start Again");
                            }
                            else
                            {
                                position = position - number;
                                Console.WriteLine("Moves backward by {0}",number);
                            }

                        }
                       
                        break;
                    default:
                        Console.WriteLine("Option 0: No Play");
                        position = position + 0;
                        Console.WriteLine("Stays at same position");
                        break;
                }
                Console.WriteLine("Current position: " + position+"\n\n");

                
            }


        }
    }
}
