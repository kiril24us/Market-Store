using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class GoldCard : DiscountCard
    {
        readonly double turnover;
        readonly double purchaseValue;

        public GoldCard(double turnover, double purchaseValue)
        {
            this.turnover = turnover;
            this.purchaseValue = purchaseValue;
        }

        public override double CalculateDiscountRate()
        {
            double discountRate = 0;

            switch (turnover)
            {
                case double number when (number >= 0 && number < 100):
                    discountRate = 2;
                    break;

                case double number when (number >= 100 && number < 200):
                    discountRate = 3;
                    break;

                case double number when (number >= 200 && number < 300):
                    discountRate = 4;
                    break;

                case double number when (number >= 300 && number < 400):
                    discountRate = 5;
                    break;
                case double number when (number >= 400 && number < 500):
                    discountRate = 6;
                    break;

                case double number when (number >= 500 && number < 600):
                    discountRate = 7;
                    break;

                case double number when (number >= 600 && number < 700):
                    discountRate = 8;
                    break;

                case double number when (number >= 700 && number < 800):
                    discountRate = 9;
                    break;

                case double number when (number >= 800):
                    discountRate = 10;
                    break;

                default: throw new Exception();
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
