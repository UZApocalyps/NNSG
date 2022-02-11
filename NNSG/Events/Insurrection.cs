using System;
using System.Collections.Generic;
using System.Text;
using NNSG.Commands;
using NNSG.lang;

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
            if (active)
            {
                if (Person.GetGlobalHappiness() >= 15)
                {
                    active = false;
                }
                else
                {
                    double dead = Person.people.Count * 0.1;
                    Person.RemovePeople((int)dead);
                }
            }
            else
            {
                if (Person.GetGlobalHappiness() <= 0)
                {
                    active = true;
                    CmdSkipDay.trigger = true;
                    foreach (var message in Lang.GetInstance().insurrection)
                    {
                        UI.getInstance().Write(message);
                    }
                }

            }
        }
    }
}
