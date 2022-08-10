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
        private ArrowHeadCostMapper _arrowHeadCostMapper;
        private ArrowFletchingCostMapper _arrowFletchingCostMapper;

        public Arrow(ArrowHeadType arrowheadType, ArrowFletchingType fletchingType, float length, ArrowHeadCostMapper arrowHeadCostMapper, ArrowFletchingCostMapper arrowFletchingCostMapper)
        {
            _arrowHeadType = arrowheadType;
            _fletchingType = fletchingType;
            _length = length;
            _arrowHeadCostMapper = arrowHeadCostMapper;
            _arrowFletchingCostMapper = arrowFletchingCostMapper;
        }

       public float GetCost()
        {
            float arrowHTCost = _arrowHeadCostMapper.GetCost(_arrowHeadType);
            float arrowFTCost = _arrowFletchingCostMapper.GetCost(_fletchingType);
            return ((arrowHTCost + arrowFTCost) + (_length * 0.05f));
        }
    }

    public class ArrowFletchingCostMapper
    {
        public float GetCost(ArrowFletchingType arrowHeadType)
        {
            return arrowHeadType switch
            {
                ArrowFletchingType.plastic => 10,
                _ => 5
            };
        }
        //switch (_fletchingType)
        //{
        //    case ArrowFletchingType.plastic:
        //    arrowFTCost = 10;
        //    break;
        //    case ArrowFletchingType.turkeyfeathers:
        //    arrowFTCost = 5;
        //    break;
        //    case ArrowFletchingType.goosefeathers:
        //    arrowFTCost = 3;
        //    break;
        //    default:
        //    break;
        //}
}

    public class ArrowHeadCostMapper
    {
        public float GetCost(ArrowHeadType arrowHeadType)
        {
            return arrowHeadType switch
            {
                ArrowHeadType.steel => 10,
                _ => 5
            };
        }
        //    switch (arrowHeadType)
        //    {
        //        case ArrowHeadType.steel:
        //            arrowHTCost = 10;
        //            break;
        //        case ArrowHeadType.wood:
        //            arrowHTCost = 3;
        //            break;
        //        case ArrowHeadType.obsidian:
        //            arrowHTCost = 5;
        //            break;
        //        default:
        //            break;
        //    }
        //}
    }

    public enum ArrowHeadType { steel, wood, obsidian };
    public enum ArrowFletchingType { plastic, turkeyfeathers, goosefeathers };
}
