using Newtonsoft.Json;
using NNSG.Commands;
using NNSG.lang;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NNSG.Events
{
    class Fire : Disaster
    {
        int luck = 1000;

        public Fire()
        {
            Time.GetInstance().Subscribe(this);
        }
        public override void Ticking()
        {
            if (Randomizer.Range(0, luck) == luck - 1)
            {
                foreach (var message in Lang.GetInstance().fire)
                {
                    UI.getInstance().Write(message);
                }
                double deadPeople = (double)Person.people.Count * 0.01;
                double foodLoss = (double)Warehouse.food.amount * 0.6;

                Person.RemovePeople((int)deadPeople);
                Warehouse.food.amount -= (int)foodLoss;
                UI.getInstance().Write((int)deadPeople + " personnes ont brulée");
                UI.getInstance().Write((int)foodLoss + " de nourriture à été détruite");
                CmdSkipDay.trigger = true;
            }
        }
    }
}
