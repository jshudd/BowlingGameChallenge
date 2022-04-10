using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BowlingGameChallenge
{
    public static class Startup
    {
        public static void Welcome()
        {
            int leftOffSet = (Console.WindowWidth / 2);
            int topOffSet = (int)(Console.WindowHeight / 2.75);
            Console.SetCursorPosition(leftOffSet, topOffSet);

            string title = @"
  _          _                       _    _   ____                _ _             
 | |        | |                     | |  (_) |  _ \              | (_)            
 | |     ___| |__   _____      _____| | ___  | |_) | _____      _| |_ _ __   __ _ 
 | |    / _ \ '_ \ / _ \ \ /\ / / __| |/ / | |  _ < / _ \ \ /\ / / | | '_ \ / _` |
 | |___|  __/ |_) | (_) \ V  V /\__ \   <| | | |_) | (_) \ V  V /| | | | | | (_| |
 |______\___|_.__/ \___/ \_/\_/ |___/_|\_\_| |____/ \___/ \_/\_/ |_|_|_| |_|\__, |
                                                                             __/ |
                                                                            |___/ 

";
            Console.WriteLine(title);
            Thread.Sleep(5000);

            Console.WriteLine("Welcome to Lebowski Bowling.\nLet's get you some shoes and you can start rolling.\n");
            Thread.Sleep(5000);
            Console.WriteLine("Have fun!\n");
            Thread.Sleep(5000);
            Console.Clear();
        }
    }
}
