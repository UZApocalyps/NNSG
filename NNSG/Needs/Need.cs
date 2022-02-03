using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Needs
{
    abstract class Need
    {
        public int level;

        public void Update()
        {
            Consume();
        }

        public abstract void Consume();
    }
}
