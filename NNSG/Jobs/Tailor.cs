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
            quantityPerTick = 1;
        }

        public static Tailor GetInstance()
        {
            if (instance == null)
            {
                instance = new Tailor();
                allJobs.Add(instance);
            }
            return instance;
        }

        public override void Ticking()
        {
            Warehouse.clothes.amount += 1;
        }
    }
}
