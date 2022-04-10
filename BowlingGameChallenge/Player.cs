using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameChallenge
{
    public class Player
    {
        public Player()
        {
        }

        public string Name { get; set; }
        public int CurrentFrame { get; set; } = 1;
        public int NumberOfPins { get; set; } = 10;

        //public bool Strike { get; set; } = false;
        //public bool Spare { get; set; } = false;
        public int Score { get; set; } = 0;
        public int[,] ScoreArray { get; set; } = new int[4, 10]
        {
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
        };
    }
}
