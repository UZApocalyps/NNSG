using NNSG.Needs;
using NNSG.Jobs;
using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG
{
    public enum NeedsType
    {
        hunger
    }
    class Person
    {
        public int id;
        public int age;
        public Need[] needs;
        public Job job;
    }
}
