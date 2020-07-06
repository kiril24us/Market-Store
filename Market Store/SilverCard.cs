using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class SilverCard : DiscountCard
    {
        public SilverCard(double turnover, double purchaseValue) : base(turnover, purchaseValue)
        {

        }

        public override double CalculateDiscountRate()
        {
            if (turnover <= 300)
            {
                discountRate = 2;
            }

            if (turnover > 300)
            {
                discountRate = 3.5;
            }
            return discountRate;
        }
    }
}