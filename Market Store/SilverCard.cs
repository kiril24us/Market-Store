using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class SilverCard : DiscountCard
    {
        readonly double turnover;
        readonly double purchaseValue;

        public SilverCard(double turnover, double purchaseValue)
        {
            this.turnover = turnover;
            this.purchaseValue = purchaseValue;
        }

        public override double CalculateDiscountRate()
        {
            double discountRate = 0;

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

        public override double CalculateDiscount(double discountRate)
        {
            double discount = purchaseValue * discountRate / 100;
            return discount;
        }

        public override double TotalValue(double discount, double total)
        {
            total = purchaseValue - discount;
            return total;
        }
    }
}