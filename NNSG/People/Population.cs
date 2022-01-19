using System;
using NNSG;

namespace NNSG
{
    public class Population : ITick
    {
        const string HAPPINESS_COMMAND_NAME = "happiness";

        // Thresholds indicate the global happiness values required to respectively increase or lower population
        public float increaseThreshold = 67;
        public float decreaseThreshold = 33;

        /// <summary>
        /// Will evaluate current global happiness and increase or decrease population
        /// </summary>
        public void Ticking()
        { 
            int happiness = Person.GetGlobalHappiness();

            if (happiness >= increaseThreshold)
            {                
                Person.people.Add(new Person());
            }
            else if (happiness <= decreaseThreshold)
            {
                
            }
        }
    }
}