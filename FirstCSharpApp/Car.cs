using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingConsoleApp
{
    internal abstract class Car
    {
        public int Power { get; }
        public string Model { get; }

        protected Car(int power, string model)
        {
            Power = power;
            Model = model;
        }

        public abstract void Honk();

    }
}
