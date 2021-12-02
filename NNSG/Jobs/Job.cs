using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Jobs
{
    class Job : ITick
    {
        private GoodType goodType;
        public string Name;
        public int quantityPerTick;
        public List<Person> persons;

        public Job(GoodType type)
        {
            goodType = type;
            Time.GetInstance().Subscribe(this);
        }

        public void Ticking()
        {
            Warehouse.food.ammount += quantityPerTick * persons.Count;
        }
    }
}