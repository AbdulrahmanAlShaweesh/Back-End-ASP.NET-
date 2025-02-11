namespace Third_Project.Discounts
{
    internal abstract class Discount
    {
        public abstract string Name { get; }

        public abstract double CalculateDiscount(double price, int quantity);
    }
}
