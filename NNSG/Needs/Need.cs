using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Needs
{
    public enum NeedsType
    {
        hunger
    }
    abstract class Need : ITick
    {
        public int level;
        public Person person;
        public string name;

        public Need()
        {
            Time.GetInstance().Subscribe(this);
        }

        public void Ticking()
        {
            if (new Random().Next(0,100) > level)
            {
                level = 100;
                Warehouse.food.ammount--;
            }
        }
    }
}
