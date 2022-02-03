using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Jobs
{
    class Farmer : Job
    {
        private static Farmer instance;
        private Farmer()
        {
            quantityPerTick = 1;
        }

        public static Farmer GetInstance()
        {
            if (instance == null)
            {
                instance = new Farmer();
            }
            return instance;
        }

        public override void Ticking()
        {
            Warehouse.food.amount += 1 * Person.people.FindAll(p => p.job is Farmer).Count;
        }
    }
}
