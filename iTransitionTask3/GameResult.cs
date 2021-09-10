using System.Collections.Generic;

namespace iTransitionTask3
    {
    class GameResult
        {
        public static string Calculate(Turn playerAnswer, Turn computerAnswer, List<Turn> turns)
            {
            int calculate = ((turns.Count + (turns.IndexOf(playerAnswer) + 1) - (turns.IndexOf(computerAnswer) + 1)) % turns.Count) % 2;

            if (calculate == 0)
                {
                return "DROW";
                }
            else if (calculate % 2 == 1)
                {
                return "WIN";
                }
            return "LOSE";
            }
        }
    }
