using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Jobs
{
    class Tailor : Job
    {
        private static Tailor instance;

        private Tailor()
        {
            Time.GetInstance().Subscribe(this);
        }

        public static Tailor GetInstance()
        {
            if (instance == null)
            {
                instance = new Tailor();
            }
            return instance;
        }

        public override void Ticking()
        {
            Warehouse.clothes.amount += Randomizer.Range(0, 2) * Person.people.FindAll(p => p.job is Tailor).Count;
        }
    }
}
