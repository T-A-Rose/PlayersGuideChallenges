using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinFletchersArrows
{
    class Arrow
    {
        int arrowHeadCost = 0;
        int arrowFletchingCost = 0;
        int _arrowShaft;
        ArrowHead _arrowHead;
        Fletching _fletching;
        public Arrow()
        {
            _arrowShaft = 60;
            _arrowHead = ArrowHead.steel;
            _fletching = Fletching.plastic;
        }

        public float GetCost()
        {
            ChooseArrowHead();
            ChooseArrowFletching();
            GetArrowShaft();
            return (float)((arrowHeadCost + arrowFletchingCost) + (0.05 * _arrowShaft));
        }

        ArrowHead ChooseArrowHead()
        {
            Console.WriteLine($"Please select the arrow type you want to use, the options are as follows: {ArrowHead.steel}, {ArrowHead.wood} & {ArrowHead.obsidian}.");
            string arrowHeadChoice = Console.ReadLine().ToLower();
            ArrowHead currentSelection = ArrowHead.steel;

            switch (arrowHeadChoice)
            {
                case "steel":
                    arrowHeadCost = 10;
                    return ArrowHead.steel;
                case "wood":
                    arrowHeadCost = 3;
                    currentSelection = ArrowHead.wood;
                    break;
                case "obsidian":
                    arrowHeadCost = 5;
                    currentSelection = ArrowHead.obsidian;
                    break;
                default:
                    break;
            }
            return currentSelection;
        }

        

        int GetArrowShaft()
        {
            Console.WriteLine($"Now we have your selected arrow type of {_arrowHead} with a {_fletching}, please enter the length of the shaft you want, between 60 - 100 cm's");
            _arrowShaft = Convert.ToInt32(Console.ReadLine());
            return _arrowShaft;
        }
    }



}
