using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace RacingConsoleApp
{
    internal class Car
    {
        public string Model { get; }
        public int HorsePower { get;}
        public string EngineType { get; }
        public int Speed { get; set; } = 0;
        public Direction Dir { get; set; } = Direction.DOWN;
        public Vector2 Pos { get; set; } = new Vector2(0, 0);

        public Car(string model, int horsePower, String engineType)
        {
            Model = model;
            HorsePower = horsePower;
            EngineType = engineType;

        }


        public void Gas()
        {

        }

        public void Move()
        {
            Pos = new Vector2(Pos.X + Speed, Pos.Y + Speed );

        }

        
    }
}
