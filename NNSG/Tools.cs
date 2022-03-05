using System;
using System.Linq;
using System.Collections.Generic;

namespace NNSG
{
    /// <summary>
    /// Provides mathematic methods that aren't included in System.Math
    /// </summary>
    class Tools
    {
        /// <summary>
        /// Returns the interpolated double between range values
        /// </summary>
        /// <param name="x">Input value</param>
        /// <param name="x0">Start of x axis</param>
        /// <param name="x1">End of x axis</param>
        /// <param name="y0">Start of y axis</param>
        /// <param name="y1">End of y axis</param>
        /// <returns>Output</returns>
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
        /// <summary>
        /// Stores most game values in a dictionnary to "snapshot" current state
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, float> CacheValues()
        {
            Dictionary<string, float> values = new Dictionary<string, float>();

            values.Add(Warehouse.food.GetType().ToString(), Warehouse.food.amount);
            values.Add(Warehouse.furniture.GetType().ToString(), Warehouse.food.amount);
            values.Add(Warehouse.vehicles.GetType().ToString(), Warehouse.food.amount);
            values.Add(Warehouse.clothes.GetType().ToString(), Warehouse.food.amount);

            values.Add("People", Person.people.Count);

            return values;
        }
        
        /// <summary>
        /// Convert value to string in a readable manner
        /// e.g. : 10 -> +10 or -10 -> -10
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ShowDiff(float value)
        {
            return (Math.Sign(value) == -1 ? "-" : "+") + Math.Abs(value);
        }
    }
}
