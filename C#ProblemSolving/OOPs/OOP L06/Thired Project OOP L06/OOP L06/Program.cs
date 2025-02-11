using Third_Project.Users;

namespace OOP_L06
{
    internal class Program
    {
           static void Main(string[] args)
            {
                Console.Write("Enter your type (Regular, Premium, Guest): ");
                string userType = Console.ReadLine() ?? string.Empty;
                User user;
                switch (userType.ToLower())
                {
                    case "regular":
                        user = new RegularUser();
                        break;
                    case "premium":
                        user = new PremiumUser();
                        break;
                    case "guest":
                        user = new GuestUser();
                        break;
                    default:
                        Console.WriteLine("Invalid user type");
                        return;  
                }
                Console.WriteLine(user.Name);
                double price = 1000;
                int quantity = 2;
                double discount = user.GetDiscount().CalculateDiscount(price, quantity);
                double priceAfterDiscount = (price * quantity) - discount;
                Console.WriteLine($"Price after discount: {priceAfterDiscount}");
            }
        }
}
