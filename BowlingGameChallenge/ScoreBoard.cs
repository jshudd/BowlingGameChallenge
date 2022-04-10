using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameChallenge
{
    public static class ScoreBoard
    {

        public static void PrintScoreBoard(Player p)
        {
            var counter = 1;
            Console.Write("Frame    ");
            Console.Write("Roll 1    ");
            Console.Write("Roll 2    ");
            Console.Write("Roll 3\n");
            do
            {
                Console.Write($"{counter}         ");
                Console.Write($"{p.ScoreArray[1, counter - 1]}         ");
                Console.Write($"{p.ScoreArray[2, counter - 1]}         \n");
                counter++;

            } while (counter < 10);

            Console.Write($"{counter}        ");
            Console.Write($"{p.ScoreArray[1, counter - 1]}         ");
            Console.Write($"{p.ScoreArray[2, counter - 1]}         ");
            Console.Write($"{p.ScoreArray[3, counter - 1]}         \n");

        }

        
    }
}
