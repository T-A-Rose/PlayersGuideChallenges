using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinFletchersArrows
{
    internal class ArrowFletching
    {

        public int arrowFletchingCost { get; set; }

        Fletching ChooseArrowFletching()
        {
            Console.WriteLine($"Please select the arrow fletching you want to use, the options are as follows: {Fletching.plastic}, {Fletching.turkeyFeathers} & {Fletching.gooseFeathers}.");
            string arrowHeadChoice = Console.ReadLine().ToLower();
            Fletching currentSelection = Fletching.plastic;

            switch (arrowHeadChoice)
            {
                case "plastic":
                    arrowFletchingCost = 10;
                    return Fletching.plastic;   
                case "turkey feathers":
                    arrowFletchingCost = 5;
                    return Fletching.turkeyFeathers;
                case "goose feathers":
                    arrowFletchingCost = 3;
                    return Fletching.gooseFeathers;                   
                default:
                    break;
            }
            
        }
    }
}

enum Fletching { plastic, turkeyFeathers, gooseFeathers }