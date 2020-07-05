using MarketStore;
using System;

namespace Market_Store
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Select type of card - bronze, silver or gold");
            string typeOfCard = Console.ReadLine().ToLower();

            while (typeOfCard != "bronze" && typeOfCard != "silver" && typeOfCard != "gold")
            {
                Console.WriteLine("Wrong type of card! Please select bronze, silver or gold!");
                typeOfCard = Console.ReadLine().ToLower();
            }
            Console.WriteLine("Select turnover:");
            double turnover = double.Parse(Console.ReadLine());

            while (turnover < 0)
            {
                Console.WriteLine("Invalid value! Turnover cannot be negative number!");
                turnover = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Select purchase value:");
            double purchaseValue = double.Parse(Console.ReadLine());

            while (purchaseValue < 0)
            {
                Console.WriteLine("Invalid value! Turnover cannot be negative number!");
                purchaseValue = double.Parse(Console.ReadLine());
            }

            DiscountCard discountBronzeCard = new BronzeCard();
            DiscountCard discountSilverCard = new SilverCard();
            DiscountCard discountGoldenCard = new GoldCard();

            double[] result = new double[4];
            switch (typeOfCard)
            {
                case "bronze":
                    result = discountBronzeCard.CalculationsPurchase(turnover, purchaseValue);
                    break;
                case "silver":
                    result = discountSilverCard.CalculationsPurchase(turnover, purchaseValue);
                    break;
                case "gold":
                    result = discountGoldenCard.CalculationsPurchase(turnover, purchaseValue);
                    break;
            }

            Console.WriteLine($"Purchase value: ${result[0]:f2}");
            Console.WriteLine($"Discount rate: {result[1]:f1}%");
            Console.WriteLine($"Discount: ${result[2]:f2}");
            Console.WriteLine($"Discount: ${result[3]:f2}");
        }
    }
}
