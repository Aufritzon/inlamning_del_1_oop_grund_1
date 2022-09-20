using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingConsoleApp
{
    internal class RaceTrack
    {
        public enum Turn
        {
            RIGHT,
            LEFT
        }
        
        private Queue<(Turn,int)> trackMap = new Queue<(Turn,int)>();
        
        private Random Random = new Random();
        
        public Turn RandomDir()
        {
            Turn[]? dirs = Enum.GetValues<Turn>();
            return (Turn) dirs.GetValue(Random.Next(dirs.Length));
        }

        

        public void InitTrack(int difficulty)
        {
            for (int i = 0; i < 10; i++)
            {
                trackMap.Enqueue((RandomDir(), Random.Next(1000)));
            }

            
        }


      
    }
}
