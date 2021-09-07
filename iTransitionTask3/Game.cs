using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTransitionTask3
    {
    class Game
        {
        List<Move> Moves;
        Move ComputerAnswer;


        public void PlayGame(string[] args)
            {
            List<Move> moves = new List<Move>();
            int actionCode = 1;
            foreach (string i in args)
                {
                Move move = new Move(i, actionCode);
                moves.Add(move);
                if (actionCode != 3)
                    {
                    actionCode++;
                    }
                else
                    {
                    actionCode = 1;
                    }
                }

            Moves = moves;
            ComputerAnswer = GetComputerAnswer(Moves);
            ComputerAnswer.SetKey(Coder.GetNewKey());
            string key = Coder.ByteDecoder(ComputerAnswer.GetKey());
            string HMAC = Coder.GetHMAC(key);


            //перенести в меню
            Console.WriteLine(key);


            Menu.ShowMenu(Moves);
            Move playerAnswer = moves.ElementAt(Menu.GetAnswer() - 1);
            string gameResult = CalculateGameResult(playerAnswer, ComputerAnswer);
            Menu.ShowGameResult(gameResult);
            Console.ReadLine();
            }

        string CalculateGameResult(Move playerAnswer, Move computerAnswer)
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
        
        Move GetComputerAnswer(List<Move> moves)
            {
            Random random = new Random();
            Move computerAnswer = moves.ElementAt(random.Next(0, moves.Count()));
            return computerAnswer;
            }

        }
    }
