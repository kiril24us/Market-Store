using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class SilverCard : DiscountCard
    {
        public override double[] CalculationsPurchase(double turnover, double purchaseValue)
        {
            double[] calculations = new double[4];
            double discountRate = 0;
            double discount = 0;
            double total = 0;

            if (turnover <= 300)
            {
                discountRate = 2;
                discount = purchaseValue * discountRate / 100;
                total = purchaseValue - discount;
            }

            if (turnover > 300)
            {
                discountRate = 3.5;
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