using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameChallenge
{
    public static class Roll
    {
        public static Player Bowl(Player p)
        {
            p.NumberOfPins = 10;
            Random rng = new Random();

            if (p.CurrentFrame < 10)
            {
                p.ScoreArray[1, p.CurrentFrame - 1] = rng.Next(0, 11);
                p.NumberOfPins -= p.ScoreArray[1, p.CurrentFrame - 1];

                //if 1st roll == strike, 2nd score = 0; else rng remaining pins
                if (p.NumberOfPins > 0)
                {
                    p.ScoreArray[2, p.CurrentFrame - 1] = rng.Next(0, p.NumberOfPins + 1);
                    p.NumberOfPins -= p.ScoreArray[2, p.CurrentFrame - 1];                                        
                }
                else
                {
                    p.ScoreArray[2, p.CurrentFrame - 1] = 0;
                }

            }

            //if 10th frame
            if (p.CurrentFrame == 10)
            {
                p.ScoreArray[1, 9] = rng.Next(0, 10);
                p.NumberOfPins -= p.ScoreArray[1, 9];

                //if 1st roll was strike
                if (p.ScoreArray[1, 9] == 10)
                {
                    p.NumberOfPins = 10;
                    p.ScoreArray[2, 9] = rng.Next(0, p.NumberOfPins + 1);
                    p.NumberOfPins -= p.ScoreArray[2, 9];

                    //if 2nd roll strike or spare
                    if (p.ScoreArray[2, 9] == 10 || p.ScoreArray[1, 9] + p.ScoreArray[2, 9] == 10)
                        p.ScoreArray[3, 9] = rng.Next(0, 10);
                }

                p.ScoreArray[2, 9] = rng.Next(0, p.NumberOfPins + 1);
                p.NumberOfPins -= p.ScoreArray[2, 9];

                //if 2nd roll strike or spare
                if (p.ScoreArray[2, 9] == 10 || p.ScoreArray[1, 9] + p.ScoreArray[2, 9] == 10)
                    p.ScoreArray[3, 9] = rng.Next(0, 10);

            }

            p.CurrentFrame++;

            return p;
        }

        public static bool IsGameOver(Player p)
        {
            return p.CurrentFrame > 10;
        }
    }
}
