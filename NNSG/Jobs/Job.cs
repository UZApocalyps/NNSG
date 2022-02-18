using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Jobs
{
    abstract class Job : ITick
    {        
        /// <summary>
        /// How much resource is produced each tick
        /// </summary>
        public int quantityPerTick;
        public abstract void Ticking();
    }
}