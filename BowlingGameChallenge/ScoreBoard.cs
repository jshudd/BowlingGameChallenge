using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BowlingGameChallenge
{
    public static class ScoreBoard
    {

        public static void PrintScoreBoard(Player p)
        {
            Console.WriteLine("So, how'd you do?\n");

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
            Console.Write($"{p.ScoreArray[3, counter - 1]}         \n\n");

        }

        public static void CalculateScore(Player p)
        {
            //calculate score for frames 1 - 8            
            for (int i = 0; i < 8; i++)
            {
                //3 Strikes in a row!!!
                if (p.ScoreArray[1, i] == 10 && p.ScoreArray[1, i + 1] == 10 && p.ScoreArray[1, i + 2] == 10)
                {
                    p.Score += 30;
                }
                //2 Strikes in a row
                else if (p.ScoreArray[1, i] == 10 && p.ScoreArray[1, i + 1] == 10 && p.ScoreArray[1, i + 2] != 10)
                {
                    p.Score += 20 + p.ScoreArray[1, i + 2];
                }
                //1 Strike
                else if (p.ScoreArray[1, i] == 10 && p.ScoreArray[1, i + 1] != 10)
                {
                    p.Score += 10 + p.ScoreArray[1, i + 1] + p.ScoreArray[2, i + 1];
                }
                //!strike; spare == true
                else if (p.ScoreArray[1, i] != 10 && p.ScoreArray[1, i] + p.ScoreArray[2, i] == 10)
                {
                    p.Score += 10 + p.ScoreArray[1, i + 1];
                }

                //!strike or !spare
                else if (p.ScoreArray[1, i] != 10 && p.ScoreArray[1, i] + p.ScoreArray[2, i] != 10)
                {
                    p.Score += p.ScoreArray[1, i] + p.ScoreArray[2, i];
                }
            }

            //calculate 9th frame
            //3 Strikes in a row!!!
            if (p.ScoreArray[1, 8] == 10 && p.ScoreArray[1, 9] == 10 && p.ScoreArray[2, 9] == 10)
            {
                p.Score += 30;
            }
            //2 Strikes in a row
            else if (p.ScoreArray[1, 8] == 10 && p.ScoreArray[1, 9] == 10 && p.ScoreArray[2, 9] != 10)
            {
                p.Score += 20 + p.ScoreArray[2, 9];
            }
            //1 Strike
            else if (p.ScoreArray[1, 8] == 10 && p.ScoreArray[1, 9] != 10)
            {
                p.Score += 10 + p.ScoreArray[1, 9] + p.ScoreArray[2, 9];
            }
            //!strike; spare == true
            else if (p.ScoreArray[1, 8] != 10 && p.ScoreArray[1, 8] + p.ScoreArray[2, 8] == 10)
            {
                p.Score += 10 + p.ScoreArray[1, 9];
            }

            //!strike or !spare
            else if (p.ScoreArray[1, 8] != 10 && p.ScoreArray[1, 8] + p.ScoreArray[2, 8] != 10)
            {
                p.Score += p.ScoreArray[1, 8] + p.ScoreArray[2, 8];
            }

            //calculate 10th frame for final score
            //3 Strikes in a row!!!
            if (p.ScoreArray[1, 9] == 10 && p.ScoreArray[2, 9] == 10 && p.ScoreArray[3, 9] == 10)
            {
                p.Score += 30;
            }
            //2 Strikes in a row
            if (p.ScoreArray[1, 9] == 10 && p.ScoreArray[2, 9] == 10 && p.ScoreArray[3, 9] != 10)
            {
                p.Score += 20 + p.ScoreArray[3, 9];
            }
            //1 Strike
            if (p.ScoreArray[1, 9] == 10 && p.ScoreArray[2, 9] != 10)
            {
                p.Score += 10 + p.ScoreArray[2, 9] + p.ScoreArray[3, 9];
            }
            //!strike; spare == true
            if (p.ScoreArray[1, 9] != 10 && p.ScoreArray[1, 9] + p.ScoreArray[2, 9] == 10 || p.ScoreArray[2, 9] + p.ScoreArray[3, 9] == 10)
            {
                p.Score += 10 + p.ScoreArray[3, 9];
            }
            //!strike or !spare
            if (p.ScoreArray[1, 9] != 10 && p.ScoreArray[1, 9] + p.ScoreArray[2, 9] != 10)
            {
                p.Score += p.ScoreArray[1, 9] + p.ScoreArray[2, 9];
            }

            Console.WriteLine($"Final Score: {p.Score}");

            if (p.Score == 300)
            {
                Console.WriteLine("Whoa dude! Perfect Score! You should go pro!!\n");
            }
            else if(p.Score >= 200 && p.Score < 300)
            {
                Console.WriteLine("You're not too bad\n");
            }
            else if(p.Score < 200)
            {
                Console.WriteLine("You should come back more often to practice.");
            }
        }
    }
}
