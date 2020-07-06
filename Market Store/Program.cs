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

            DiscountCard discountCard;

            double discountRate = 0;
            double discount = 0;
            double total = 0;

            switch (typeOfCard)
            {
                case "bronze":
                    discountCard = new BronzeCard(turnover, purchaseValue);
                    break;
                case "silver":
                    discountCard = new SilverCard(turnover, purchaseValue);
                    break;
                case "gold":
                    discountCard = new GoldCard(turnover, purchaseValue);
                    break;
                default: throw new Exception();
            }

            discountRate = discountCard.CalculateDiscountRate();
            discount = discountCard.CalculateDiscount();
            total = discountCard.TotalValue();

            Console.WriteLine($"Purchase value: ${purchaseValue:f2}");
            Console.WriteLine($"Discount rate: {discountRate:f1}%");
            Console.WriteLine($"Discount: ${discount:f2}");
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
