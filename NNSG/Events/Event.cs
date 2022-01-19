using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Events
{
    abstract class Event
    {
        public string[] messages;

        int luck;
        public abstract void Ticking();
    }
}
