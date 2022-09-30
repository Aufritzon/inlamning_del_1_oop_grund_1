using System.Text;

namespace RacingConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {

            RaceTrack track = new RaceTrack(4);
            ConsoleView view = new ConsoleView(track);
            view.ShowStartMenu();

        
        }
    }


}