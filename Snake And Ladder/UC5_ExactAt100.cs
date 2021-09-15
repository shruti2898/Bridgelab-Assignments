using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadderGame
{
    class UC5_ExactAt100
    {
        public const int Ladder = 1;
        public const int Snake = 2;
        public const int winningPosition = 100;
        public static void WinningPosition()
        {


            int position = 0;
            int number;
           
            Console.WriteLine("Starting position: " + position);
            while (position < winningPosition && position >= 0)
            {
                Random randomOption = new Random();
                int options = randomOption.Next(0, 3);
               
                switch (options)
                {
                    case Ladder:
                        {
                            Console.WriteLine("Option 1: Ladder");
                            number = UC2_RollingDice.DiceNumber();
                            if (position >= 94 && position < 100)
                            {
                                int numberNeedsToWin = winningPosition - position;

                                if (numberNeedsToWin == number)
                                {
                                    position = position + numberNeedsToWin;
                                    Console.WriteLine("Current position: " + position + "\n\n");
                                    Console.WriteLine("Moves forward by {0}",number);
                                    Console.WriteLine("YOU WON!!!!!\n\n ");
                                }
                                else if (numberNeedsToWin > number)
                                {
                                    Console.WriteLine("Moves forward by {0}\n\n",number);
                                    position = position + number;
                                    Console.WriteLine("Current position: " + position + "\n\n");
                                }
                                else
                                {
                                    Console.WriteLine("Oh No!! Try Again!\n\n");
                                    Console.WriteLine("Current position: " + position + "\n\n");
                                }
                            }
                            else if (position < 94)
                            {
                                Console.WriteLine("Moves forward by {0}\n\n", number);
                                position = position + number;
                                Console.WriteLine("Current position: " + position + "\n\n");
                            }
                        }
                        break;


                    case Snake:
                        {
                            Console.WriteLine("Option 2: Snake");
                            number = UC2_RollingDice.DiceNumber();
                            if (position <= number || position == 0)
                            {
                                position = 0;
                                Console.WriteLine("Start Again\n\n");
                                Console.WriteLine("Current position: " + position + "\n\n");
                            }
                            else
                            {
                                if (position == 100)
                                {
                                    Console.WriteLine("YOU WON!!!!! \n\n");
                                }
                                else
                                {
                                    position = position - number;
                                    Console.WriteLine("Moves backward by {0}\n\n", number);
                                    Console.WriteLine("Current position: " + position + "\n\n");
                                }
                            }
                        }

                        break;

                    default:
                        {
                            Console.WriteLine("Option 0: No Play");
                            position = position + 0;
                            if (position == 100)
                            {
                                Console.WriteLine("YOU WON!!!!! \n\n ");
                            }
                            else
                            {
                                Console.WriteLine("Stays at same position\n\n");
                                Console.WriteLine("Current position: " + position + "\n\n");
                            }
                        }
                        break;
                }
               
            } 
        }       
    }
}
