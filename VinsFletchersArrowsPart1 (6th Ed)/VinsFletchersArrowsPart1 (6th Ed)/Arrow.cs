using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinsFletchersArrowsPart1__6th_Ed_
{
    internal class Arrow
    {
        public int Length;
        public ArrowHead arrowHead;
        public Fletching fletching;

        public Arrow(int length, ArrowHead arrowHead, Fletching fletching)
        {
            Length = length;
            this.arrowHead = arrowHead;
            this.fletching = fletching;
        }

        public float GetCost()
        {
            int arrowHeadCost = 0;
            switch (arrowHead)
            {
                case ArrowHead.Steel:
                        arrowHeadCost = 10;
                    break;
                case ArrowHead.Wood:
                    arrowHeadCost = 3;
                    break;
                case ArrowHead.Obsidian:
                    arrowHeadCost = 5;
                    break;
            }
            return ((float)(arrowHeadCost + (0.05 * Length)));
        }
    }

    enum ArrowHead { Steel, Wood, Obsidian};
    enum Fletching { Plastic, TurkeyFeathers, GooseFeathers};
}
