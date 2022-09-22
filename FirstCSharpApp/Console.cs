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
            Console.WriteLine("Welcome To The Game!");
            Console.WriteLine("Press Enter To Start The game");
            Console.WriteLine("Press ESC to quit");
            Console.WriteLine("Press i for info about the game");

            ConsoleKey key = Console.ReadKey().Key;

            switch (key)
            {
                case ConsoleKey.Enter: 
                    {
                        Console.WriteLine("gfd"); 
                        break;
                    }
                case ConsoleKey.Escape:
                    {

                        break;
                    }
            }




        }

        private void 

        public void ShowRules()
        {
            Console.WriteLine("The game is about etc...");

            Console.WriteLine("\r\nPrec ESC to go back.");

        }



    }

}
