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
    }
}
