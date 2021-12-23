using NNSG.Needs;
using NNSG.Jobs;
using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG
{
    class Person : ITick
    {
        public int id;
        public int age;
        public List<Need> needs;
        public Job job;
        public static List<Person> people = new List<Person>();

        public Person()
        {
            needs.Add(new Hunger(100));

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
            foreach(Need need in needs)
            {
                need.Update();
            }
        }
    }
}
