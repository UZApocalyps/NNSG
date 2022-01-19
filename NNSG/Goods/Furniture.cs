using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Goods
{
    class Furniture : Good
    {
        public Furniture(float amountValue, float priceValue)
        {
            amount = amountValue;
            price = priceValue;
        }
    }
}
