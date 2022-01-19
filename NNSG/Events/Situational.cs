using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Events
{
    internal class Situational : Event
    {
        public static Dictionary<int,Situational> allEvents = new Dictionary<int, Situational>();
        public override void Ticking()
        {
            throw new NotImplementedException();
        }
    }
}
