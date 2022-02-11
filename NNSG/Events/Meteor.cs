using Newtonsoft.Json;
using NNSG.Commands;
using NNSG.lang;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NNSG.Events
{
    class Meteor : Disaster
    {
        int luck = 10000;

        public Meteor()
        {
            Time.GetInstance().Subscribe(this);
        }

        public override void Ticking()
        {
            if (Randomizer.Range(0,luck) == luck-1)
            {
                foreach (var message in Lang.GetInstance().meteor)
                {
                    UI.getInstance().Write(message);
                }
                double deadPeople = (double)Person.people.Count * 0.7;
                double foodLoss = (double)Warehouse.food.amount * 0.8;
                Person.RemovePeople((int)deadPeople);
                Warehouse.food.amount -= (int)foodLoss;
                UI.getInstance().Write((int)deadPeople + " personnes sont en bouillie");
                UI.getInstance().Write((int)foodLoss + " de nourriture à été détruite");
                CmdSkipDay.trigger = true;
            }
        }

    }
}
