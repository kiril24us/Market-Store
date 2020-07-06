using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class GoldCard : DiscountCard
    {
        public GoldCard(double turnover, double purchaseValue) : base(turnover, purchaseValue)
        {

        }

        public override double CalculateDiscountRate()
        {
            if (turnover >= 800)
            {
                discountRate = 10;
                return discountRate;
            }

            int discountRateAsInt = 2;
            discountRateAsInt += (int)(turnover / 100);
            discountRate = discountRateAsInt;
            
            return discountRate;
        }
    }
}
