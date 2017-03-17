using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoGameEngine
{
    public class Math
    {
        public static float ToRadion(float angle) { return (float)((angle * System.Math.PI) / 180.0); }
    }
}
