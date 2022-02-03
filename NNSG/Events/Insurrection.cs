using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Events
{
    internal class Insurrection : Situational
    {
        private bool active = false;

        public Insurrection()
        {
            Time.GetInstance().Subscribe(this);
        }

        public override void Ticking()
        {
            //todo
        }
    }
}
