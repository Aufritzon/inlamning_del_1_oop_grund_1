

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using Microsoft.VisualBasic;

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
            Console.SetWindowSize(45,10);
            Console.SetBufferSize(45,10);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "AMAZING RACING GAME!";
            Console.CursorVisible = false;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome To The Game!");
                Console.WriteLine("Press Enter To Start The game");
                Console.WriteLine("Press ESC to quit");
                Console.WriteLine("Press i for info about the game");

                var key = Console.ReadKey(true).Key;
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



        private void StartGame ()
        {
            Console.Clear();
            ShowDirection();
            ShowCountdown(10);

        }

        private void AskForUserAnswer()
        {
            var trackMap = _raceTrack.TrackMap;
            Console.Clear();
            for (int i = 0; i < trackMap.Count; i++)
            {

            }

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

        private void ShowDirection()
        {
            for (var i = 0; i < _raceTrack.TrackMap.Count; i++)
            {
                var instr = _raceTrack.TrackMap[i];

                if (i == 0)
                {
                    Console.WriteLine("First turn {0} and drive {1} meters,".ToUpper(),instr.Item1, instr.Item2);

                } else if (i == _raceTrack.TrackMap.Count - 1)
                {
                    Console.WriteLine("finally, turn {0} and drive {1} meters.".ToUpper(), instr.Item1, instr.Item2);
                } else
                {
                    Console.WriteLine("then turn {0} and drive {1} meters,".ToUpper(), instr.Item1, instr.Item2);

                }
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
