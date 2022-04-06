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

        /// <summary>
        /// Allow to adjust how much population will change
        /// 0.01f = 1%
        /// </summary>
        public float changeFactor = 0.01f;

        public Population()
        {
            Time.GetInstance().Subscribe(this);
        }

        /// <summary>
        /// Will evaluate current global happiness and increase or decrease population or ends the game if there's no one left
        /// </summary>
        public void Ticking()
        {
            if (Person.people.Count > 0)
            {
                int happiness = Person.GetGlobalHappiness();

                if (happiness >= increaseThreshold)
                {
                    Person.AddPeople(PopulationChange());
                }
                else if (happiness <= decreaseThreshold)
                {
                    Person.RemovePeople(PopulationChange());
                }
            }
            else
            {
                GameManager.GetInstance().End();
            }
            
        }

        /// <summary>
        /// Calculates the population changed based on total population and changeFactor
        /// </summary>
        /// <returns></returns>
        private int PopulationChange()
        {
            int change = (int)Math.Ceiling(changeFactor * Person.people.Count);

            return change;
        }
    }
}