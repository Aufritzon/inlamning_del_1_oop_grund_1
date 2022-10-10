namespace RacingConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            RaceTrack track = new RaceTrack(4);
            ConsoleView view = new ConsoleView();
            Game game = new Game(view, track);
            game.InitGame();
        }
    }


}