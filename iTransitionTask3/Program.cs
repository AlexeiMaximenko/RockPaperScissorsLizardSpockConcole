using System;

namespace iTransitionTask3
    {
    class Program
        {
        static void Main(string[] args)
            {
            if (args.Length % 2 == 0)
                {
                FindError("Enter an odd number of arguments");
                }
            else if (args.Length < 3)
                {
                FindError("Argements count should be more or equal 3");
                }
            string[] sortedArgs = new string[args.Length];
            Array.Copy(args, sortedArgs, args.Length);
            Array.Sort(sortedArgs);
            for (int i = 0; i < sortedArgs.Length - 1; i++)
                {
                if (sortedArgs[i] == sortedArgs[i + 1])
                    {
                    FindError("Arguments must be different");
                    }
                }

            Game game = new Game();
            game.PlayGame(args);
            Environment.Exit(0);
            }

        static void FindError(string errorNotation)
            {
            Console.WriteLine(errorNotation);
            Environment.Exit(0);
            }
        }
    }
