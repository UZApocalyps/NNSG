using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Jobs
{
    abstract class Job : ITick
    {
        public int quantityPerTick;
        public abstract void Ticking();

    }
}