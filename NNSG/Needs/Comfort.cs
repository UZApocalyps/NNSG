using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Needs
{
    class Comfort : Need
    {
        public Comfort(int value)
        {
            level = value;
        }

        public override void Consume()
        {
            if (Warehouse.furniture.amount > 0 && Randomizer.Probability(100 - level))
            {
                Warehouse.furniture.amount--;
                level = 100;
            }
            else
            {
                level = Math.Clamp(level -= Randomizer.Range(1, 15), 0, 100);
            }
        }
    }
}
