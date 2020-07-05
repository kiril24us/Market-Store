using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    abstract class DiscountCard
    {
        public abstract double[] CalculationsPurchase(double turnover, double purchaseValue);
    }

}
