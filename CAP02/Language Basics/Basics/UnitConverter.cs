using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class UnitConverter
    {
        int ratio;
        public UnitConverter(int unitRatio)
        {
            ratio = unitRatio;
        }
        public int Convert(int unit) { 
            return unit * ratio;
        }
    }
}
