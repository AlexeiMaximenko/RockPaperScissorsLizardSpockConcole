using System.Collections.Generic;

namespace iTransitionTask3
    {
    class GameResult
        {
        public static string Calculate(Turn playerAnswer, Turn computerAnswer, List<Turn> turns)
            {
            int calculate = turns.Count - 1 + turns.IndexOf(playerAnswer) - turns.IndexOf(computerAnswer) % turns.Count;

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

        public static string Calculate(int playerAnswer, int computerAnswer, int turnsCount)
            {
            int calculate = (turnsCount + playerAnswer - computerAnswer) % turnsCount;

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
