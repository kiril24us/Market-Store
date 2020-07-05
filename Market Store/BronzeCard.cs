using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class BronzeCard : DiscountCard
    {
        public override double[] CalculationsPurchase(double turnover, double purchaseValue)
        {
            double[] calculations = new double[4];
            double discountRate = 0;
            double discount = 0;
            double total = 0;

            if (turnover < 100)
            {
                discountRate = 0;
                discount = 0;
                total = purchaseValue - discount;
            }

            if (turnover >= 100 && turnover <= 300)
            {
                discountRate = 1;
                discount = purchaseValue * discountRate / 100;
                total = purchaseValue - discount;
            }

            if (turnover > 300)
            {
                discountRate = 2.5;
                discount = purchaseValue * discountRate / 100;
                total = purchaseValue - discount;
            }

            calculations[0] = purchaseValue;
            calculations[1] = discountRate;
            calculations[2] = discount;
            calculations[3] = total;

            return calculations;
        }
    }
}