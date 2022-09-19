
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
            Console.WriteLine(car.Dir + car.Speed + car.EngineType + car.Model);
            Vector2 v = new Vector2(1, 2);

            v.X = 4;

            car.Pos = v;



            Console.WriteLine(v.X);




        }
    }


}