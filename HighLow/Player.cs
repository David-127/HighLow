using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow
{
    class Player
    {
        //fält
         string name;
         int points;
        //konstruktor
        public Player(string name, int points)
        {
            this.name = name;
            this.points = points;
        }
        //metoder
        public void ShowData()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Score:" + points);

        }

        public int getPoints()
        {
            return points;
        }
    }
}
