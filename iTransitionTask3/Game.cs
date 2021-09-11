using SecurityDriven.Inferno;
using SecurityDriven.Inferno.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace iTransitionTask3
    {
    class Game
        {
        Turn ComputerTurn;

        public void PlayGame(string[] args)
            {
            List<Turn> turns = new List<Turn>();
            foreach (string arg in args)
                {
                Turn newTurn = new Turn();
                newTurn.Name = arg;
                turns.Add(newTurn);
                }

            Help.ShowTable(turns);
            ComputerTurn = GetComputerAnswer(turns);
            HMACSHA256 hmac = TurnHMAC.Get(ComputerTurn.Name);
            Console.WriteLine(hmac.Hash.ToBase16());
            ShowMenu(turns);
            Turn playerTurn = turns.ElementAt(GetPlayerAnswer(turns) - 1);
            Console.WriteLine($"Computer turn: {ComputerTurn.Name}");
            Console.WriteLine(GameResult.Calculate(playerTurn, ComputerTurn, turns));
            Console.WriteLine(hmac.Key.ToBase16());
            Console.ReadLine();
            }

        private Turn GetComputerAnswer(List<Turn> turns)
            {
            CryptoRandom random = new CryptoRandom();
            int turnId = random.Next(0, turns.Count() - 1);
            Turn computerAnswer = turns.ElementAt(turnId);
            return computerAnswer;
            }

        private static void ShowMenu(List<Turn> turns)
            {
            int i = 1;
            Console.WriteLine("Avaible moves:");
            foreach (Turn turn in turns)
                {
                Console.WriteLine($"{i} - {turn.Name}");
                i++;
                }
            Console.WriteLine("0 - exit");
            Console.WriteLine("? - help");
            }

        private static int GetPlayerAnswer(List<Turn> turns)
            {
            string input = Console.ReadLine();

            var defense = int.TryParse(input, out int correctAnswer);
            if (defense == true && correctAnswer >= 1 && correctAnswer <= turns.Count)
                {
                return correctAnswer;
                }
            else
                {
                while (defense == false || correctAnswer < 1 || correctAnswer > turns.Count)
                    {
                    if(input == "0")
                        {
                        Environment.Exit(0);
                        }
                    else if (input == "?")
                        {
                        Help.ShowTable(turns);
                        ShowMenu(turns);
                        input = Console.ReadLine();
                        continue;
                        }
                    else
                        {
                        Console.WriteLine("Wrong input");
                        Console.Write("Try again: ");
                        input = Console.ReadLine();
                        defense = int.TryParse(input, out correctAnswer);
                        }
                    }
                }
            return correctAnswer;
            }
        }
    }
