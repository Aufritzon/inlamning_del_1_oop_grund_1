namespace RacingConsoleApp
{
    internal class RaceTrack
    {
        private Random Random = new();
        public List<(Turn, int)> TrackMap { get; } = new List<(Turn, int)>();

        public enum Turn
        {
            RIGHT,
            LEFT
        }
        public RaceTrack(int difficulty) => InitTrack(difficulty);
        private Turn RandomDir()
        {
            Turn[]? dirs = Enum.GetValues<Turn>();
            return (Turn)dirs.GetValue(Random.Next(dirs.Length));
        }
        private void InitTrack(int difficulty)
        {
            for (int i = 0; i < difficulty; i++)
            {
                TrackMap.Add((RandomDir(), Random.Next(1000)));
            }
        }
        public void NewTrack(int difficulty)
        {
            TrackMap.Clear();
            for (int i = 0; i < difficulty; i++)
            {
                TrackMap.Add((RandomDir(), Random.Next(500)));
            }

        }
    }
}
