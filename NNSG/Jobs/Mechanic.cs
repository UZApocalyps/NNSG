using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Jobs
{
    class Mechanic : Job
    {
        private static Mechanic instance;
        private Mechanic()
        {
            Time.GetInstance().Subscribe(this);
        }

        public static Mechanic GetInstance()
        {
            if (instance == null)
            {
                instance = new Mechanic();
            }
            return instance;
        }

        public override void Ticking()
        {
            Warehouse.vehicles.amount += Randomizer.Range(0, 2) * Person.people.FindAll(p => p.job is Mechanic).Count;
        }
    }
}
