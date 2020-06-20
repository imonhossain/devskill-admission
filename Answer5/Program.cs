using System;

namespace Answer5
{
    class Program
    {
        static void Main(string[] args)
        {
            PercentageDiscount p1 = new PercentageDiscount();
            double a = p1.CalculateDiscount(5000);
            Console.WriteLine(a);

            FixedDiscount p2 = new FixedDiscount();
            int b = p2.CalculateDiscount(5000);
            Console.WriteLine(b);
        }
    }
}
