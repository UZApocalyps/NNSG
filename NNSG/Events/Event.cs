using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Events
{
    abstract class Event : ITick
    {
        public abstract void Ticking();
    }
}
