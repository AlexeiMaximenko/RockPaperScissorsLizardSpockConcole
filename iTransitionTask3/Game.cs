using SecurityDriven.Inferno;
using SecurityDriven.Inferno.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using static SecurityDriven.Inferno.Utils;

namespace iTransitionTask3
    {
    class Game
        {
        List<Turn> Turns;
        Turn ComputerTurn;

        public void PlayGame(string[] args)
            {
            List<Turn> turns = new List<Turn>();
            int actionCode = 1;
            foreach (string i in args)
                {
                Turn turn = new Turn(i, actionCode);
                turns.Add(turn);
                if (actionCode < 3)
                    {
                    actionCode++;
                    }
                else
                    {
                    actionCode = 1;
                    }
                }
            Turns = turns;
            ComputerTurn = GetComputerAnswer(Turns);
            HMAC hmac = TurnHMAC.Get(ComputerTurn.GetTurnCode());
            string hash = hmac.ComputeHash(SafeUTF8.GetBytes(ComputerTurn.GetTurnCode())).ToBase16();
            Console.WriteLine(hash);
            ShowMenu(turns);
            Turn playerTurn = turns.ElementAt(GetAnswer() - 1);
            ShowGameResult(GameResult.Calculate(playerTurn, ComputerTurn));
            Console.WriteLine(hmac.Key.ToBase16());
            Console.ReadLine();
            }



        private Turn GetComputerAnswer(List<Turn> turns)
            {
            CryptoRandom random = new CryptoRandom();
            int turnId = random.Next(0, turns.Count());
            Turn computerAnswer = turns.ElementAt(turnId);
            computerAnswer.SetTurnCode(turnId.ToString());
            return computerAnswer;
            }

        private static void ShowMenu(List<Turn> turns)
            {
            int i = 1;
            Console.WriteLine("Avaible moves:");
            foreach (Turn turn in turns)
                {
                Console.WriteLine($"{i} - {turn.GetName()}");
                i++;
                }
            Console.WriteLine("0 - exit");
            Console.WriteLine("? - help");
            }

        private static int GetAnswer()
            {
            return Convert.ToInt32(Console.ReadLine());
            }

        private static void ShowGameResult(string gameResult)
            {
            Console.WriteLine($"You are {gameResult}");
            }
        }
    }
