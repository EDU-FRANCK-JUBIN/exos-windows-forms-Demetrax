using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    static class HexaUtils
    {
        public static float CalculateH(float side)
        {
            return (float)(System.Math.Sin(DegreesToRadians(30)) * side);
        }

        public static float CalculateR(float side)
        {
            return (float)(System.Math.Cos(DegreesToRadians(30)) * side);
        }
        public static double DegreesToRadians(double degrees)
        {
            return degrees * System.Math.PI / 180;
        }
    }
}
