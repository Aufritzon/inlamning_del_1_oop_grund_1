namespace RacingConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            RaceTrack track = new RaceTrack(4);
            ConsoleView view = new ConsoleView();
            Car car = new Ferrari(10,"Ferrari F40");
            Game game = new Game(view, track, car);
            game.InitGame();
        }
    }


}