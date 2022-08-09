using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinFletchersArrows
{
    internal class ArrowHead
    {

        //ArrowHeadType AHT = ArrowHeadType.steel;

        
        public ArrowHead()
        {
        }

        public int ArrowHeadPrice { get; set; }



    }
}

enum ArrowHeadType { steel, wood, obsidian };