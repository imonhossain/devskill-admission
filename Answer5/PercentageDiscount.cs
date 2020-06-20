namespace Answer5
{
    public class PercentageDiscount:Discount
    {
        public override double CalculateDiscount(int originalPrice) 
        { 
            double a = originalPrice - (originalPrice*5)/100;
            return a;
        }
    }
}