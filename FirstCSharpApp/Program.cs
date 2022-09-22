using System.Text;

namespace RacingConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {

            RaceTrack track = new RaceTrack(4);
            Car[] cars = new Car[4];
            ConsoleView view = new ConsoleView(track,cars.ToList());
            view.ShowStartMenu();
        }
    }


}