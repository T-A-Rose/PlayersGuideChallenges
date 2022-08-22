using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinFletchersArrows
{
    class Arrow
    {
        //private ArrowHeadType _arrowHeadType;
        //private ArrowFletchingType _fletchingType;
        //private float Length;

        public Arrow(ArrowHeadType arrowheadType, ArrowFletchingType fletchingType, float length)
        {
            ArrowHeadType = arrowheadType;
            ArrowFletchingType = fletchingType;
            Length = length;
        }

        public Arrow(){
        }

        //private ArrowHeadType GetArrowHeadType() => _arrowHeadType;
        //private ArrowFletchingType GetArrowFletchingType() => _fletchingType;
        //private float GetLength() => _length;

        private ArrowHeadType ArrowHeadType { get; }
        private ArrowFletchingType ArrowFletchingType { get; }
        private float Length { get; }

        internal float GetCost => ((GetArrowHeadCost(ArrowHeadType) + GetArrowFletchingCost(ArrowFletchingType)) + (Length* 0.05f));
        private float GetArrowHeadCost(ArrowHeadType AHT)
        {
            float arrowHTCost = 0;
            switch (AHT)
            {
                case ArrowHeadType.steel:
                    return arrowHTCost = 10;
                case ArrowHeadType.wood:
                    return arrowHTCost = 3;
                case ArrowHeadType.obsidian:
                    return arrowHTCost = 5;
                default:
                    return 0;
            }
        }

        private float GetArrowFletchingCost(ArrowFletchingType AFT)
        {
            float arrowFTCost = 0;
            switch (AFT)
            {
                case ArrowFletchingType.plastic:
                    return arrowFTCost = 10;
                case ArrowFletchingType.turkeyfeathers:
                    return arrowFTCost = 5;
                case ArrowFletchingType.goosefeathers:
                    return arrowFTCost = 3;
                default:
                    return 0;
            }
        }


    }
    public enum ArrowHeadType { steel, wood, obsidian };
    public enum ArrowFletchingType { plastic, turkeyfeathers, goosefeathers };
}
