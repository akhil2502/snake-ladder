using System;
using System.Collections.Generic;
using System.Text;

namespace snake_ladder.snake_ladder
{
    class SnakeLadderSimulator
    { 
       
        public void getDie()
        {
            Random random = new Random();
            int die = random.Next(1, 7);
            Console.WriteLine(die);
        }
    }
}







