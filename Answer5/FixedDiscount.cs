namespace Answer5
{
    public class FixedDiscount:Discount
    {
        
        public override int CalculateDiscount(int originalPrice) 
        { 
            originalPrice=originalPrice -500;
            return originalPrice;
        }
    }
}