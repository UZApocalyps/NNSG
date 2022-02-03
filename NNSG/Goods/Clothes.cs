using System;
using System.Collections.Generic;
using System.Text;

namespace NNSG.Goods
{
    class Clothes : Good
    {
        public Clothes(float amountValue, float priceValue)
        {
            amount = amountValue;
            price = priceValue;
        }
    }
}
