using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadderGame
{
    class UC3_PlayerOptions
    {   //constant for options
        public const int Ladder = 1;    // option = 1 for ladder ( moves forward)
        public const int Snake = 2;     // option = 2 for snake (moves backward)

                                        // option = 0 for no play ( stays at same position )
        public static void PlayerMoves()
        {
            //variables
            int position = 0;

            int number;

            int currentPosition = 0;
            Console.WriteLine("Start Game:  ");
            Console.WriteLine("Current Position:  {0}\n\n",currentPosition);

            Random random = new Random();
            int options = random.Next(0, 3);

            switch (options)
            {
                case Ladder:
                    Console.WriteLine("Option 1: Ladder");
                    number = UC2_RollingDice.DiceNumber();
                    position = position + number;
                    Console.WriteLine("Current Position:  {0}\n\n", position);
                    break;
                case Snake:
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
                        Console.WriteLine("Moves backward");
                    }
                    Console.WriteLine("Current Position:  {0}\n\n", position);
                    break;
                default:
                    Console.WriteLine("Option 0: No Play");
                    number = 0;
                    position = position + number;
                    Console.WriteLine("Current Position:  {0}\n\n", position);
                    break;


            }

        }

       
      
    }
}
