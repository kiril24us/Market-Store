using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MarketStore
{
    class BronzeCard : DiscountCard
    {
        public BronzeCard(double turnover, double purchaseValue) : base(turnover, purchaseValue)
        {
            
        }
        public override double CalculateDiscountRate()
        {
            if (turnover < 100)
            {
                discountRate = 0;
            }

            if (turnover >= 100 && turnover <= 300)
            {
                discountRate = 1;
            }

            if (turnover > 300)
            {
                discountRate = 2.5;
            }
            return discountRate;
        }        
    }
}