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

                key = Console.ReadKey().Key;
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
            while (true)
            {
                Console.WriteLine("Game is running");
            }
        }


        private void ShowRules()
        {
            Console.Clear();
            Console.WriteLine("The game is about etc...");
            Console.WriteLine("\r\nPrec ESC to go back.");
            ConsoleKey key;

            while (true)
            {
                key = Console.ReadKey().Key;
                if (key == ConsoleKey.Escape) { break;  }
            }
        }



    }

}
