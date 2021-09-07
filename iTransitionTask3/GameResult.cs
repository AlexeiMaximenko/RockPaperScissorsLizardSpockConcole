namespace iTransitionTask3
    {
    class GameResult
        {
        public static string Calculate(Turn playerAnswer, Turn computerAnswer)
            {
            if (playerAnswer.GetActionCode() == computerAnswer.GetActionCode())
                {
                return "DROW";
                }
            else if (computerAnswer.GetActionCode() == 1 && playerAnswer.GetActionCode() == 2 ||
                computerAnswer.GetActionCode() == 2 && playerAnswer.GetActionCode() == 3 ||
                computerAnswer.GetActionCode() == 3 && playerAnswer.GetActionCode() == 1
                )
                {
                return "WIN";
                }
            return "LOSE";
            }
        }
    }
