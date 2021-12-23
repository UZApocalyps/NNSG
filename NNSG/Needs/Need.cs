using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Needs
{
    abstract class Need
    {
        public int level;

        public void Update()
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
