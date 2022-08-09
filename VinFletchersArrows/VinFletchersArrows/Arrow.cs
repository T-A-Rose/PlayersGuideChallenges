using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinFletchersArrows
{
    class Arrow
    {
        public ArrowHeadType _arrowHeadType;
        public ArrowFletchingType _fletchingType;
        public float _length;

        public Arrow(ArrowHeadType arrowheadType, ArrowFletchingType fletchingType, float length)
        {
            _arrowHeadType = arrowheadType;
            _fletchingType = fletchingType;
            _length = length;
        }

        //public float GetCost()
        //{
        //    return (float)((arrowHeadCost + arrowFletchingCost) + (0.05 * _arrowShaft));
        //}
    }

    enum ArrowHeadType { steel, wood, obsidian};
    enum ArrowFletchingType { plastic, turkeyfeathers, goosefeathers};
}
