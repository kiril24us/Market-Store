using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    abstract class DiscountCard
    {    
        public abstract double CalculateDiscountRate(double turnover);

        public abstract double CalculateDiscount(double turnover, double purchaseValue, double discountRate);

        public abstract double TotalValue(double turnover, double purchaseValue, double discountRate, double discount);
    }

}
