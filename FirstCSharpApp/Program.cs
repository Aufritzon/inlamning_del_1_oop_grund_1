namespace RacingConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            RaceTrack track = new RaceTrack(4);
            ConsoleView view = new ConsoleView();
            Controller controller = new Controller(view, track);
            controller.InitController();
        }
    }


}