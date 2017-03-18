using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoGameEngine
{
    class Random
    {
        static System.Random r = new System.Random();
        public static int Get(int min, int max)
        {
            return r.Next(min, max);
        }
        public static double Get(double min, double max)
        {
            double rDouble = r.NextDouble() * (max - min) + min;
            return rDouble;
        }
        public static float Get(float min, float max)
        {
            return (float)Random.Get((double)min, (double)max);
        }
    }
}
