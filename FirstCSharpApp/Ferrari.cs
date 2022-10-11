using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingConsoleApp
{
    internal class Ferrari : Car
    {
        public Ferrari(int power, string model) : base(power, model)
        {
        }

        public override void Honk()
        {
            Console.WriteLine("*in an italian accent* Tut-tut");
        }
    }
}
