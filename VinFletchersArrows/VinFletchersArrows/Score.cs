using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinFletchersArrows;

namespace VinFletchersArrows
{
class Score
    {
        public string _name;
        public int _points;
        public int _level;
        public Score(string name, int points, int level)
        {
            _name = name;
            _points = points;
            _level = level;
        }

        public Score()
        {
            _name = "Unknown";
            _points = 0;
            _level = 1;
        }

        public bool EarnedStar() => (_points / _level) > 1000;
    }
}

//Score a = new Score("R2-D2", 16420, 12);

//a._name = "R2-D2";
//a._points = 1420;
//a._level = 12;

//if (a.EarnedStar()) Console.WriteLine("You earned a star!");

//Score b = new Score("Tom", 69420, 22);

//b._name = "Tom";
//b._points = 69420;
//b._level = 22;

//if (b.EarnedStar()) Console.WriteLine("You earned a star!");

//Console.ReadLine();
