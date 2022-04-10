using System;

namespace BowlingGameChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Player();

            Startup.Welcome();

            do
            {
                Roll.Bowl(p1);

            } while (!Roll.IsGameOver(p1));

            ScoreBoard.PrintScoreBoard(p1);

            ScoreBoard.CalculateScore(p1);
        }
    }
}
