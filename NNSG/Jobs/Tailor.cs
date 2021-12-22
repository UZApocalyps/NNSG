using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Jobs
{
    class Tailor : Job
    {
        public override int quantityPerTick { get => quantityPerTick; set => quantityPerTick = value; }

        public override void Ticking()
        {
            Warehouse.clothes.ammount += 1;
        }
    }
}
