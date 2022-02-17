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
            Time.GetInstance().Subscribe(this);
        }

        public static Artisan GetInstance()
        {
            if (instance == null)
            {
                instance = new Artisan();
            }
            return instance;
        }

        public override void Ticking()
        {
            Warehouse.furniture.amount += 1 * Person.people.FindAll(p => p.job is Artisan).Count;
        }
    }
}
