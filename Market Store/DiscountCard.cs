using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    abstract class DiscountCard
    {
        public abstract double CalculateDiscountRate();

        public abstract double CalculateDiscount(double discountRate);

        public abstract double TotalValue(double discount, double total);
    }

}
