using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG
{
    /// <summary>
    /// Provides useful methods to generate random numbers
    /// </summary>
    public class Randomizer 
    {
        private static Random randNumber = new Random();

        /// <summary>
        /// Return true if random value generated is smaller than probability
        /// </summary>
        /// <param name="probability">value between 0 and 100</param>
        /// <returns></returns>
        public static bool Probability(float probability)
        {
            int number = randNumber.Next(0, 100);
            return number < probability;
        }

        /// <summary>
        /// Returns a int between given values
        /// </summary>
        /// <param name="from">Minimal value</param>
        /// <param name="to">Maximum value (exclusive)</param>
        /// <returns>Random int</returns>
        public static int Range(int from, int to)
        {
            return randNumber.Next(from, to);
        }
    }
}
