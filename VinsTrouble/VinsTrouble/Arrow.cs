using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinFletchersArrows
{
    class Arrow
    {
        private ArrowHeadType _arrowHeadType;
        private ArrowFletchingType _fletchingType;
        private float _length;

        public Arrow(ArrowHeadType arrowheadType, ArrowFletchingType fletchingType, float length)
        {
            //_arrowHeadType = arrowheadType;
            //_fletchingType = fletchingType;
            //_length = length;
        }

        public Arrow(){
        }

        private ArrowHeadType GetArrowHeadType() => _arrowHeadType;
        private ArrowFletchingType GetArrowFletchingType() => _fletchingType;
        private float GetLength() => _length;

        public float GetCost()
        {
            float arrowHTCost = 0;
            float arrowFTCost = 0;

            switch (_arrowHeadType)
            {
                case ArrowHeadType.steel:
                    arrowHTCost = 10;
                    break;
                case ArrowHeadType.wood:
                    arrowHTCost = 3;
                    break;
                case ArrowHeadType.obsidian:
                    arrowHTCost = 5;
                    break;
                default:
                    break;
            }

            switch (_fletchingType)
            {
                case ArrowFletchingType.plastic:
                    arrowFTCost = 10;
                    break;
                case ArrowFletchingType.turkeyfeathers:
                    arrowFTCost = 5;
                    break;
                case ArrowFletchingType.goosefeathers:
                    arrowFTCost = 3;
                    break;
                default:
                    break;
            }
            return ((arrowHTCost + arrowFTCost) + (_length * 0.05f));
        }
    }
    public enum ArrowHeadType { steel, wood, obsidian };
    public enum ArrowFletchingType { plastic, turkeyfeathers, goosefeathers };
}
