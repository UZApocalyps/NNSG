﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Needs
{
    class Transport : Need
    {
        public Transport(int value)
        {
            level = value;
        }

        public override void Consume()
        {
            if (Warehouse.vehicles.amount > 0 && Randomizer.Probability(100 - level))
            {
                Warehouse.vehicles.amount--;
                level = 100;
            }
            else
            {
                level = Math.Clamp(level -= Randomizer.Range(1, 15), 0, 100);
            }
        }
    }
}
