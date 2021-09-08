using System;

namespace iTransitionTask3
    {
    class Program
        {
        static void Main(string[] args)
            {
            string[] arg = new string[5];
            arg[0] = "rock";
            arg[1] = "paper";
            arg[2] = "scissors";
            arg[3] = "lizard";
            arg[4] = "Spock";


            Game game = new Game();
            game.PlayGame(arg);
            Environment.Exit(0);
            }

        }
    }
