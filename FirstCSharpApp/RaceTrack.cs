namespace RacingConsoleApp
{
    internal class RaceTrack
    {
        private readonly Random _rand = new();
        public int Difficulty { get; set; }
        public List<(Turn, int)> TrackMap { get; } = new();

        public enum Turn
        {
            Right,
            Left
        }

        public RaceTrack(int difficulty)
        {
            Difficulty = difficulty;
            InitTrack(difficulty);
        }

        private Turn RandomDir()
        {
            Turn[] dirs = Enum.GetValues<Turn>();
            return (Turn)dirs.GetValue(_rand.Next(dirs.Length));
        }
        private void InitTrack(int difficulty)
        {
            for (var i = 0; i < difficulty; i++)
            {
                TrackMap.Add((RandomDir(), _rand.Next(1000)));
            }
        }

        public void PrintTrackMap()
        {
            Console.Clear();
            foreach (var instr in TrackMap)
            {
                Console.WriteLine("turn {0} and drive {1} meters".ToUpper(), instr.Item1, instr.Item2);
            }
        }

        public void NewTrack()
        {
            TrackMap.Clear();
            for (var i = 0; i < Difficulty; i++)
            {
                TrackMap.Add((RandomDir(), _rand.Next(500)));
            }
        }
    }
}
