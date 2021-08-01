using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadderSimulation
{
    class Snakeladdersimulation
    {
        const int noPlay = 0;
        const int ladder = 1;
        const int snake = 2;
        static int playerPosition = 0;
        public static void selectOption()
        {
            // variables
            int die = 0;
            int option = 0;
            while (playerPosition < 100)
            {
                Random random = new Random();
                option = random.Next(0, 3);
                // invoking the getDie method
                die = getDie();
                if (option == 1)
                {
                    playerPosition = playerPosition + die;
                    Console.WriteLine("Player status is Ladder");
                    Console.WriteLine("Player position is:" + playerPosition);
                }
                else if (option == 2)
                {
                    if (playerPosition > 0 && (playerPosition - die) >= 0)
                    {
                        playerPosition = playerPosition - die;
                        Console.WriteLine("Player status is Snake");
                        Console.WriteLine("Player position is:" + playerPosition);
                    }
                }
                else
                {
                    Console.WriteLine("Player status is No Play");
                    Console.WriteLine("Player position is:" + playerPosition);
                }
            }
        }
        public static int getDie()
        {
            Random random = new Random();
            int die = random.Next(1, 7);
            return die;
        }
    }
}
