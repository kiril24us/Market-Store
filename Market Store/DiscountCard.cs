using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    abstract class DiscountCard
    {
        protected readonly double purchaseValue;
        protected readonly double turnover;
        protected double discountRate;
        private double discount;

        protected DiscountCard(double turnover, double purchaseValue)
        {
            this.purchaseValue = purchaseValue;
            this.turnover = turnover;
        }

        public abstract double CalculateDiscountRate();

        public double CalculateDiscount()
        {
            discount = purchaseValue * discountRate / 100;
            return discount;
        }

        public double TotalValue()
        {
            double total = purchaseValue - discount;
            return total;
        }
    }
}
