using System;
using NNSG;

namespace NNSG
{
    /// <summary>
    /// It represents every Person as a single entity.
    /// It allows to tick it globally and to do it once all Person has been updated.
    /// </summary>
    public class Population : ITick
    {
        const string HAPPINESS_COMMAND_NAME = "happiness";

        // Thresholds indicate the global happiness values required to respectively increase or lower population
        public float increaseThreshold = 67;
        public float decreaseThreshold = 33;

        public Population()
        {
            Time.GetInstance().Subscribe(this);
        }

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
                Person.RemovePeople(1);
            }
        }
    }
}