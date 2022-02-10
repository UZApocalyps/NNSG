using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NNSG.Events
{
    class Meteor : Disaster
    {
        float luck = 0.0001f;

        private string[] messages;
        Lang lang;
        public Meteor()
        {
            Time.GetInstance().Subscribe(this);
            lang = JsonConvert.DeserializeObject<Lang>(File.ReadAllText("lang/fr.json"));
        }

        public override void Ticking()
        {
            if (Randomizer.Probability(luck))
            {
                foreach (var message in lang.meteor)
                {
                    UI.getInstance().Write(message);
                }
                int deadPeople = Randomizer.Range(Person.people.Count / 5, Person.people.Count / 2);
                float foodLoss = Warehouse.food.amount / 2;
                Person.RemovePeople(deadPeople);
                Warehouse.food.amount -= foodLoss;
                UI.getInstance().Write(deadPeople + " personnes sont en bouillie");
                UI.getInstance().Write(foodLoss + " de nourriture à été détruite");


            }
        }
        private class Lang
        {
            public string[] meteor;
            public string[] fire;
            public string[] earthquake;
            public string[] insurrection;
        }
    }
}
