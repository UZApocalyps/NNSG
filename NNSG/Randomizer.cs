﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG
{
    public class Randomizer 
    {
        private static Random randNumber = new Random();

        public static bool Probability(float probability)
        {
            float number = (float)randNumber.NextDouble() * 100;
            return number <= probability;
        }

        public static int Range(int from, int to) //To is exclusive
        {
            return randNumber.Next(from, to);
        }

    }
}
