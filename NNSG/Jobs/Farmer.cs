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
            Time.GetInstance().Subscribe(this);
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
            Warehouse.food.amount += Randomizer.Range(0,2) * Person.people.FindAll(p => p.job is Farmer).Count;
        }
    }
}
