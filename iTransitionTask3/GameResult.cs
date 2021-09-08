namespace iTransitionTask3
    {
    class GameResult
        {
        public static string Calculate(Turn playerAnswer, Turn computerAnswer)
            {
            if (playerAnswer.ActionCode == computerAnswer.ActionCode)
                {
                return "DROW";
                }
            else if (computerAnswer.ActionCode == 1 && playerAnswer.ActionCode == 2 ||
                computerAnswer.ActionCode == 2 && playerAnswer.ActionCode == 3 ||
                computerAnswer.ActionCode == 3 && playerAnswer.ActionCode == 1
                )
                {
                return "WIN";
                }
            return "LOSE";
            }
        }
    }
