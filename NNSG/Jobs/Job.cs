using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Jobs
{
    class Job : ITick
    {
        private GoodType goodType;
        public float quantityPerTick;
        public List<Person> persons;

        public void Ticking()
        {
            throw new NotImplementedException();
        }
    }
}
