using NNSG.Needs;
using NNSG.Jobs;
using System;
using System.Linq;
using System.Collections.Generic;

namespace NNSG
{
    class Person : ITick
    {
        public int id;
        public int age;
        public List<Need> needs;
        public Job job;
        public int happiness = 0;
        public static List<Person> people = new List<Person>();

        /// <summary>
        /// Create a new person and configures it for the simulation
        /// </summary>
        public Person()
        {
            // Create its needs
            needs.Add(new Hunger(0));

            // Subscribe the person to update it at each tick
            Time.GetInstance().Subscribe(this);
        }

        public void AddJob(Job job)
        {
            this.job = job;
            job.persons.Add(this);
        }

        /// <summary>
        /// Delete object
        /// </summary>
        public void Dispose()
        {
            this.Equals(null);
        }

        public void Ticking()
        {
            // Updates needs
            foreach (Need need in needs)
            {
                need.Update();
            }

            UpdateHappiness();
        }

        /// <summary>
        /// Updates happiness value based on current value of all needs
        /// </summary>
        private void UpdateHappiness()
        {
            // Round down the average value of all needs to nearest int
            happiness = (int)Math.Floor((needs.Sum(need => need.level) / (float)needs.Count));
        }
    }
}
