namespace RacingConsoleApp
{
    internal class Car
    {
        public string Model { get; }
        public float HorsePower { get; }
        public string EngineType { get; }
        public int Speed { get; set; } = 0;

        public Position Pos { get; set; } = new Position();

        public Car(string model, int horsePower, string engineType)
        {
            Model = model;
            HorsePower = horsePower;
            EngineType = engineType;

        }

        private float GetWatt() => HorsePower * 745.7f;

        public void Gas()
        {

        }

        public void Move()
        {

        }


    }
}
