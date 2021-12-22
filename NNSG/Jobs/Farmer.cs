using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Jobs
{
    class Farmer : Job
    {

        public Farmer()
        {
            quantityPerTick = 1;
        }
        public override int quantityPerTick { get => quantityPerTick; set => quantityPerTick = value; }

        public override void Ticking()
        {
            Warehouse.food.ammount += 1 * Person.people.FindAll(p => p.job is Farmer).Count;
        }
    }
}
