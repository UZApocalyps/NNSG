using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG
{
    class Tools
    {
        static public double linear(double x, double x0 = 0, double x1=100, double y0=0, double y1=100)
        {
            if ((x1 - x0) == 0)
            {
                return (y0 + y1) / 2;
            }
            return y0 + (x - x0) * (y1 - y0) / (x1 - x0);
        }
    }
}
