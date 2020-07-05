using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MarketStore
{
    class BronzeCard : DiscountCard
    {
        public override double CalculateDiscountRate(double turnover)
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

        public override double CalculateDiscount(double turnover, double purchaseValue, double discountRate)
        {
            double discount = purchaseValue * discountRate / 100;
            return discount;
        }

        public override double TotalValue(double turnover, double purchaseValue, double discountRate, double discount)
        {
            double total = purchaseValue - discount;
            return total;
        }
    }
}