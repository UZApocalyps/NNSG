using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG
{
    public enum GoodType
    {
        Food,
        Clothes,
        Vehicles,
        Furnitures
    }
    class Good
    {
        public int price;
        public int ammount;
        public GoodType type;
    }
}
