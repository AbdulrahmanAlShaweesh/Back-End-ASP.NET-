using Third_Project.Discounts;

namespace Third_Project.Users
{
    internal class GuestUser : User
    {
        public override string Name => "Guest User";

        public override Discount GetDiscount()
        {
            Console.WriteLine("Sorry, there is no discounts available for guest users");
            return new NullDiscount();
        }
    }
}
