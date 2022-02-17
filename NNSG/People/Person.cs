using NNSG.Needs;
using NNSG.Jobs;
using System;
using System.Linq;
using System.Collections.Generic;

namespace NNSG
{
    class Person : ITick
    {
        private static uint nextAvailableID = 0;

        public uint id;
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
            // Set unique ID 
            id = GetNextID();

            // Randomize age
            age = Randomizer.Range(10, 50);

            // Create its needs
            needs = new List<Need>();
            needs.Add(new Hunger(Randomizer.Range(0, 100)));
            needs.Add(new Clothing(Randomizer.Range(0, 100)));
            needs.Add(new Comfort(Randomizer.Range(0, 100)));
            needs.Add(new Transport(Randomizer.Range(0, 100)));

            // Update happiness to prevent a bug if happiness command is used before calling next a first time
            UpdateHappiness();

            // Subscribe the person to update it at each tick
            Time.GetInstance().Subscribe(this);
        }

        public void AddJob(Job job)
        {
            this.job = job;
        }

        /// <summary>
        /// Delete object
        /// </summary>
        public void Dispose()
        {
            Time.GetInstance().Unsubscribe(this);
            people.Remove(this);
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
            happiness = Tools.Average(needs.Select(need => need.level).ToArray());
        }

        /// <summary>
        /// Compute global happiness value
        /// </summary>
        /// <returns></returns>
        public static int GetGlobalHappiness()
        {
            return Tools.Average(Person.people.Select(person => person.happiness).ToArray());
        }

        private uint GetNextID()
        {
            uint id = nextAvailableID;
            nextAvailableID++;
            return id;
        }

        /// <summary>
        /// Add new people
        /// </summary>
        /// <param name="amount"></param>
        public static void AddPeople(int amount)
        {
            if (amount > 0)
            {
                for (int i = 0; i < amount; i++)
                {
                    Person person = Person.people[i];
                   
                    switch(Randomizer.Range(0, 4))
                    {
                        case 0: person.AddJob(Farmer.GetInstance());
                            break;
                        case 1: person.AddJob(Artisan.GetInstance());
                            break;
                        case 2: person.AddJob(Mechanic.GetInstance());
                            break;
                        case 3: person.AddJob(Tailor.GetInstance());
                            break;
                    }
                    people.Add(person);
                }
            }
        }

        /// <summary>
        /// Remove people randomly 
        /// </summary>
        /// <param name="amount"></param>
        public static void RemovePeople(int amount)
        {
            if (amount > people.Count)
            {
                // GAME OVER
            }
            else
            {
                for (int i = 0; i < amount; i++)
                {
                    if (people.Count > 0)
                    {
                        int index = Randomizer.Range(0, people.Count);
                        people[index].Dispose();
                    }
                    else
                    {
                        // GAME OVER
                    }
                }
            }
        }
    }
}
