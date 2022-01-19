using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG
{
    public enum GoodType
    {
        Food,
        Clothes,
        Vehicule
    }
    class Good
    {
        public int price;
        public int ammount;
        public string name;
        public GoodType type;
    }
}
