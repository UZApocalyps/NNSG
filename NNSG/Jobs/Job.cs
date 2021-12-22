using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Jobs
{
    abstract class Job : ITick
    {
        public abstract int quantityPerTick { get; set; }
        public abstract void Ticking();
    }
}