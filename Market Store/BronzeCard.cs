using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MarketStore
{
    class BronzeCard : DiscountCard
    {
        readonly double turnover;
        readonly double purchaseValue;

        public BronzeCard(double turnover, double purchaseValue)
        {
            this.turnover = turnover;
            this.purchaseValue = purchaseValue;           
        }

        public override double CalculateDiscountRate()
        {
            double discountRate = 0;

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