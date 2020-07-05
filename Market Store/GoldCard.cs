using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class GoldCard : DiscountCard
    {
        public override double[] CalculationsPurchase(double turnover, double purchaseValue)
        {
            double[] calculations = new double[4];
            double discountRate = 0;
            double discount = 0;
            double total = 0;

            switch (turnover)
            {
                case double number when (number < 100):
                    discountRate = 2;
                    discount = purchaseValue * discountRate / 100;
                    total = purchaseValue - discount;
                    break;

                case double number when (number >= 100 && number < 200):
                    discountRate = 3;
                    discount = purchaseValue * discountRate / 100;
                    total = purchaseValue - discount;
                    break;

                case double number when (number >= 200 && number < 300):
                    discountRate = 4;
                    discount = purchaseValue * discountRate / 100;
                    total = purchaseValue - discount;
                    break;

                case double number when (number >= 400 && number < 500):
                    discountRate = 5;
                    discount = purchaseValue * discountRate / 100;
                    total = purchaseValue - discount;
                    break;
                case double number when (number >= 600 && number < 700):
                    discountRate = 6;
                    discount = purchaseValue * discountRate / 100;
                    total = purchaseValue - discount;
                    break;

                case double number when (number >= 700 && number < 800):
                    discountRate = 7;
                    discount = purchaseValue * discountRate / 100;
                    total = purchaseValue - discount;
                    break;

                case double number when (number >= 800 && number < 900):
                    discountRate = 8;
                    discount = purchaseValue * discountRate / 100;
                    total = purchaseValue - discount;
                    break;

                case double number when (number >= 900 && number < 1000):
                    discountRate = 9;
                    discount = purchaseValue * discountRate / 100;
                    total = purchaseValue - discount;
                    break;

                case double number when (number >= 1000):
                    discountRate = 10;
                    discount = purchaseValue * discountRate / 100;
                    total = purchaseValue - discount;
                    break;
            }

            calculations[0] = purchaseValue;
            calculations[1] = discountRate;
            calculations[2] = discount;
            calculations[3] = total;

            return calculations;
        }
    }
}
