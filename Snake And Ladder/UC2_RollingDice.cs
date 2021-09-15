using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadderGame
{
    class UC2_RollingDice
    {
        public static int DiceNumber()
        {
            Console.WriteLine("Rolling Dice..................");
            Random random = new Random();
            int numberOnDice = random.Next(1, 7);
            Console.WriteLine("You got "+numberOnDice);
            return numberOnDice;
        }
    }
}
