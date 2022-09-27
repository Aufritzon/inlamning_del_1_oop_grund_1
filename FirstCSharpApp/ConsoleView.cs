

using System;
using System.Globalization;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using Microsoft.VisualBasic;
using static RacingConsoleApp.RaceTrack;

namespace RacingConsoleApp
{
    internal class ConsoleView
    {
        private readonly RaceTrack _raceTrack;
        private List<Car> _cars;

        public ConsoleView(RaceTrack raceTrack, List<Car> cars)
        {
            this._raceTrack = raceTrack;
            this._cars = cars;
        }

        public void ShowStartMenu()
        {
            InitConsole();
            ConsoleKey key;

            while (true)
            {
                PrintStartMenu();
                do
                {
                    key = Console.ReadKey(true).Key;
                }
                while (!IsValidStartKey(key));

                switch (key)
                {
                    case ConsoleKey.Enter:
                        {
                            StartGame();
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            return;
                        }
                    case ConsoleKey.I:
                        {
                            ShowRules();
                            break;
                        }
                }
            }
        }

        private void PrintStartMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome To The Game!");
            Console.WriteLine("Press Enter To Start The game");
            Console.WriteLine("Press ESC to quit");
            Console.WriteLine("Press i for info about the game");
        }

        private void InitConsole()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "AMAZING RACING GAME!";
            Console.CursorVisible = false;
        }
        private bool IsValidStartKey(ConsoleKey key)
        {
            return key == ConsoleKey.Enter || key == ConsoleKey.Escape || key == ConsoleKey.I;

        }

        private void StartGame()
        {
            Console.Clear();
            PromptUser();
            ShowCountdown(3);
            ShowDirection();
            ShowCountdown(2);
            AskForUserAnswer();
        }

        private void PromptUser()
        {
            Console.Clear();
            Console.WriteLine("MEMORIZE THE INSTRUCTIONS!");
        }

        private void AskForUserAnswer()
        {
            var trackMap = _raceTrack.TrackMap;
            Console.Clear();
            ClearKeyBuffer();


            for (var i = 0; i < trackMap.Count; i++)
            {
                Console.Clear();
                Console.WriteLine("Press -> to turn RIGHT");
                Console.WriteLine("Press <- to turn LEFT");
                ConsoleKey key;

                do
                {
                    key = Console.ReadKey(true).Key;
                }
                while (!IsLeftOrRightKey(key));

                PrintInputKind(IsWrongTurn(i, key));
                if(IsWrongTurn(i, key)) return;

                Console.CursorVisible = true;

                string input;

                do
                {
                    Console.Clear();
                    Console.WriteLine("Input meters to drive: ");
                    input = Console.ReadLine();
                }
                while (!IsParsable(input));

                Console.CursorVisible = false;

                PrintInputKind(IsWrongDist(i, input));
                if (IsWrongDist(i, input)) return;
            }

        }

        private bool IsParsable(string input) 
        {

            try
            {
                int result = Int32.Parse(input);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void GameOver()
        {
            PrintGameOver();
            while (true)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.Enter) break;
            }
            _raceTrack.NewTrack(3);
        }

        private void PrintGameOver()
        {
            Console.Clear();
            Console.WriteLine("Game Over, You Lose!");
            Console.WriteLine("Press ENTER to go back to the Start Menu.");
        }

        private bool IsWrongTurn(int index, ConsoleKey key) 
        {
            return key != TurnToKey(_raceTrack.TrackMap[index].Item1);
        }

        private bool IsWrongDist(int index, string dist)
        {
            return int.Parse(dist) != _raceTrack.TrackMap[index].Item2;

        }
        

        private void PrintInputKind(bool isWrongTurn)
        {
            if (isWrongTurn)
            {
                Console.WriteLine("INCORRECT!");
                Thread.Sleep(300);
                GameOver();
            } else
            {
                Console.WriteLine("CORRECT!");
                Thread.Sleep(300);
            }

        }

        private static bool IsLeftOrRightKey(ConsoleKey key)
        {
            return key == ConsoleKey.RightArrow | key == ConsoleKey.LeftArrow;
        }
        private static ConsoleKey TurnToKey(RaceTrack.Turn turn) 
        {
            return turn switch
            {
                RaceTrack.Turn.RIGHT => ConsoleKey.RightArrow,
                RaceTrack.Turn.LEFT => ConsoleKey.LeftArrow,
                _ => throw new ArgumentNullException(nameof(turn))
            };
        } 
  
        private void ShowCountdown(int sec)
        {
            Console.WriteLine();
            Console.WriteLine("Seconds left:");
            for (var i = sec; i >= 1; i--)
            {
                Console.Write("\r{0:00}", i);
                Thread.Sleep(1000);
            }
            Console.Write("\rTIME'S UP!");
            Thread.Sleep(1000);
        }

        private static void ClearKeyBuffer()
        {
            while (Console.KeyAvailable)
            {
                Console.ReadKey(true);
            }
        }

        private void ShowDirection()
        {
            Console.Clear();
            foreach (var instr in _raceTrack.TrackMap)
            {
                Console.WriteLine("turn {0} and drive {1} meters".ToUpper(),instr.Item1, instr.Item2);
            }
        }

        private void ShowRules()
        {
            Console.Clear();
            Console.WriteLine("The game is about etc...");
            Console.WriteLine("Prec ESC to go back.");
            while (true)
            {
                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Escape) { break; }
            }
        }
    }

}
