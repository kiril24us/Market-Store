using System;

namespace Market_Store
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Select turnover:");
            double turnover = double.Parse(Console.ReadLine());
            Console.WriteLine("Select purchase value:");
            double purchaseValue = double.Parse(Console.ReadLine());
        }
    }
}
