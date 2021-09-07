using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTransitionTask3
    {
    static class Menu
        {

        public static void ShowMenu(List<Move> moves)
            {
            int i = 1;
            Console.WriteLine("Avaible moves:");
            foreach (Move move in moves)
                {
                Console.WriteLine($"{i} - {move.GetName()}");
                i++;
                }
            Console.WriteLine("0 - exit");
            Console.WriteLine("? - help");
            }
        public static int GetAnswer()
            {
            return Convert.ToInt32(Console.ReadLine());
            }

        internal static void ShowGameResult(string gameResult)
            {
            Console.WriteLine($"You are {gameResult}");
            }
        }
    }
