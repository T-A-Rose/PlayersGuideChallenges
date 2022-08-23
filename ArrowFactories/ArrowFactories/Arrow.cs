using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowFactories
{
    class Arrow
    {
        public Arrow(ArrowHeadType arrowheadType, ArrowFletchingType fletchingType, float length)
        {
            ArrowHeadType = arrowheadType;
            ArrowFletchingType = fletchingType;
            Length = length;
        }

        public Arrow(){
        }

        private ArrowHeadType ArrowHeadType { get; }
        private ArrowFletchingType ArrowFletchingType { get; }
        private float Length { get; }
        internal float GetCost => ((GetArrowHeadCost(ArrowHeadType) + GetArrowFletchingCost(ArrowFletchingType)) + (Length* 0.05f));
        
        private float GetArrowHeadCost(ArrowHeadType AHT)
        {
            switch (AHT)
            {
                case ArrowHeadType.steel:
                    return 10;
                case ArrowHeadType.wood:
                    return 3;
                case ArrowHeadType.obsidian:
                    return 5;
                default:
                    return 0;
            }
        }

        private float GetArrowFletchingCost(ArrowFletchingType AFT)
        {
            switch (AFT)
            {
                case ArrowFletchingType.plastic:
                    return 10;
                case ArrowFletchingType.turkeyfeathers:
                    return 5;
                case ArrowFletchingType.goosefeathers:
                    return 3;
                default:
                    return 0;
            }
        }

        public static Arrow CreateEliteArrow() => new Arrow(ArrowHeadType.steel, ArrowFletchingType.plastic, 95);
        public static Arrow CreateBeginnerArrow() => new Arrow(ArrowHeadType.wood, ArrowFletchingType.goosefeathers, 75);
        public static Arrow CreateMarksmenArrow() => new Arrow(ArrowHeadType.steel, ArrowFletchingType.goosefeathers, 65);

    }

    public enum ArrowHeadType { steel, wood, obsidian };
    public enum ArrowFletchingType { plastic, turkeyfeathers, goosefeathers };
}
