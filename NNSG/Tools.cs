using System;
using System.Linq;

namespace NNSG
{
    class Tools
    {
        static public double linear(double x, double x0 = 0, double x1 = 100, double y0 = 0, double y1 = 100)
        {
            if ((x1 - x0) == 0)
            {
                return (y0 + y1) / 2;
            }
            return y0 + (x - x0) * (y1 - y0) / (x1 - x0);
        }

        /// <summary>
        /// Computes the average value
        /// </summary>
        /// <param name="values"></param>
        /// <returns>If -1 is returned, something went wrong</returns>
        public static int Average(float[] values)
        {
            // Check if array exists and there's at least one value in it
            if (values != null && values.Length > 0)
                return (int)Math.Floor((values.Sum() / (float)values.Length));
            else
                return -1;
        }

        /// <summary>
        /// Computes the average value
        /// </summary>
        /// <param name="values"></param>
        /// <returns>If -1 is returned, something went wrong</returns>
        public static int Average(int[] values)
        {
            // Check if array exists and there's at least one value in it
            if (values != null && values.Length > 0)
            {
                return (int)Math.Floor((values.Sum() / (float)values.Length));
            }
            else
                return -1;
        }
    }
}
