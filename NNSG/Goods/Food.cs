using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Goods
{
    class Food : Good
    {
        public Food(float amountValue, float priceValue)
        {
            amount = amountValue;
            price = priceValue;
        }
    }
}
