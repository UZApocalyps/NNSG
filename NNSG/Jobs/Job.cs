using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Jobs
{
    abstract class Job : ITick
    {
        public int quantityPerTick;
        public static List<Job> allJobs = new List<Job>();
        public abstract void Ticking();


    }
}