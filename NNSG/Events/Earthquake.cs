using Newtonsoft.Json;
using NNSG.Commands;
using NNSG.lang;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NNSG.Events
{
    class Earthquake : Disaster
    {
        int luck = 1000;
        Lang lang;

        public Earthquake()
        {
            Time.GetInstance().Subscribe(this);
            lang = JsonConvert.DeserializeObject<Lang>(File.ReadAllText("lang/fr.json"));
        }
        public override void Ticking()
        {
            if (Randomizer.Range(0, luck) == luck - 1)
            {
                foreach (var message in lang.earthquake)
                {
                    UI.getInstance().Write(message);
                }
                double deadPeople = (double)Person.people.Count * 0.25;
                double foodLoss = (double)Warehouse.food.amount * 0.3;

                Person.RemovePeople((int)deadPeople);
                Warehouse.food.amount -= (int)foodLoss;
                UI.getInstance().Write((int)deadPeople + " personnes ont tremblée et en sont mortes");
                UI.getInstance().Write((int)foodLoss + " de nourriture à été détruite");
                CmdSkipDay.trigger = true;
            }
        }
    }
}
