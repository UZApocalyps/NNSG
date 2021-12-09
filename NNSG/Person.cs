using NNSG.Needs;
using NNSG.Jobs;
using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG
{
    class Person
    {
        public int id;
        public int age;
        public Need[] needs;
        public Job job;
        public static List<Person> people = new List<Person>();


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
    }
}
