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
        int Score;
        //konstruktor
        public Player(string name, int Score)
        {
            this.name = name;
            this.Score = Score;
        }
        //metoder
        public void ShowData()
        {
            Console.WriteLine("Name" + name);
            Console.WriteLine("Score" + Score);

        }
    }
}
