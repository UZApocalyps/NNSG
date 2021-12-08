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
            Consume();
        }
        
        private void Consume()
        {
            int chance = Randomizer.Range(0, 100);
            if (Randomizer.Probability(chance))
            {
                level = chance;
                Warehouse.food.ammount--;
            }
            else
            {
                level -= Randomizer.Range(1, 15);
            }
        }
    }
}
