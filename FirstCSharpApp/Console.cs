

namespace RacingConsoleApp
{
    internal class ConsoleView
    {
        private RaceTrack raceTrack;
        private List<Car> cars;

        public ConsoleView(RaceTrack raceTrack, List<Car> cars)
        {
            this.raceTrack = raceTrack;
            this.cars = cars;
        }

        public void ShowStartMenu()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            ConsoleKey key;
          

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome To The Game!");
                Console.WriteLine("Press Enter To Start The game");
                Console.WriteLine("Press ESC to quit");
                Console.WriteLine("Press i for info about the game");

                key = Console.ReadKey(true).Key;
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
            Console.ReadLine();
        }


        private void ShowDirection()
        {
            (RaceTrack.Turn, int) instr;

            for (int i = 0; i < raceTrack.TrackMap.Count; i++)
            {
                instr = raceTrack.TrackMap[i];

                if (i == 0)
                {
                    Console.WriteLine("First turn {0} and drive {1} meters,".ToUpper(),instr.Item1, instr.Item2);

                } else if (i == raceTrack.TrackMap.Count - 1)
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
            ConsoleKey key;
            while (true)
            {
                key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Escape) { break; }
            }
        }
    }

}
