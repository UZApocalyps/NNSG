using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Jobs
{
    class Artisan : Job
    {
        private static Artisan instance;
        private Artisan()
        {
            quantityPerTick = 1;
        }

        public static Artisan GetInstance()
        {
            if (instance == null)
            {
                instance = new Artisan();
                allJobs.Add(instance);
            }
            return instance;
        }

        public override void Ticking()
        {
            Warehouse.furniture.amount += 1 * Person.people.FindAll(p => p.job is Artisan).Count;
        }
    }
}
