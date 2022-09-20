
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace RacingConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car("BMWi4",45,"4 cylindrig"){Dir = Direction.UP, Speed = 45};
            Console.WriteLine(car.Pos.X);

            car.Pos.X = 4;



        }
    }


}