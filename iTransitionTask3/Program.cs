using System;

namespace iTransitionTask3
    {
    class Program
        {
        static void Main(string[] args)
            {
            //if (args.Length % 2 == 0)
            //    {
            //    FindError("Enter an odd number of arguments");
            //    }
            //else if (args.Length < 3)
            //    {
            //    FindError("Argements count should be more or equal 3");
            //    }
            //string[] sortedArgs = args;
            //Array.Sort(sortedArgs);
            //for (int i = 0; i < sortedArgs.Length - 1; i++)
            //    {
            //    if (sortedArgs[i] == sortedArgs[i + 1])
            //        {
            //        FindError("Arguments must be different");
            //        }
            //    }

            string[] arg1 = new string[5];
            arg1[0] = "rock";
            arg1[1] = "paper";
            arg1[2] = "scissors";
            arg1[3] = "lizard";
            arg1[4] = "Spock";


            Game game = new Game();
            game.PlayGame(arg1);
            Environment.Exit(0);
            }

        static void FindError(string errorNotation)
            {
            Console.WriteLine(errorNotation);
            Console.ReadLine();
            Environment.Exit(0);
            }
        }
    }
