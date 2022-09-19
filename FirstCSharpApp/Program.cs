
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace RacingConsoleApp
{

    class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car();


        }
    }

    class Car
    {
        public int Power { get; set; } = 4 == 4 ? 5 : 10;
        public string EngineType { get; set; }

        public Car() : this("fs") 
        {
            Console.WriteLine("Halleluja");
        }


        public Car(string engineType) : this(5, engineType) 
        {
            Console.WriteLine("Okay");
        
        }


        public Car(int power, string engineType)
        {
            Power = power;
            EngineType = engineType;
            Console.WriteLine("normal");
        }   
    }


}