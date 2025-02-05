using System.Globalization;

namespace Assign05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object obj = new object();
            InterfaceShape();
            Console.WriteLine("***************************************");
            Authentication();
            Console.WriteLine("***************************************");
            SendingNotification();

            long  Number = 10_102_333;
            var cultinfo = new CultureInfo("ar-SA");
            Console.WriteLine(Number.ToString("c" , cultinfo));

        }

        #region Question 01
        public static void InterfaceShape()
        {
            ICircle circle = new Circle(5);
            IRectangle rectangle = new Rectangle(10, 4);

            circle.DisplayShapeInformation();
            Console.WriteLine();
            rectangle.DisplayShapeInformation();
        }
        #endregion
        #region Question 02
        public static void Authentication()
        {
            IAuthenticationService authService = new BasicAuthenticationService();

            string username = "admin";
            string password = "password123";

            bool isAuthenticated = authService.AuthenticateUser(username, password);
            Console.WriteLine($"User Authentication Status: {isAuthenticated}");

            string role = "Admin";
            bool isAuthorized = authService.AuthorizeUser(username, role);
            Console.WriteLine($"User Authorization Status: {isAuthorized}");

            username = "admin";
            password = "wrongpassword";
            isAuthenticated = authService.AuthenticateUser(username, password);
            Console.WriteLine($"User Authentication Status (wrong password): {isAuthenticated}");

            role = "User";
            isAuthorized = authService.AuthorizeUser(username, role);
            Console.WriteLine($"User Authorization Status (wrong role): {isAuthorized}");
        }
        #endregion
        #region Question 03
        public static void SendingNotification()
        {
            INotificationService emailService = new EmailNotificationService();
            INotificationService smsService = new SmsNotificationService();
            INotificationService pushService = new PushNotificationService();

            string recipient = "user@gmail.com";
            string message = "You have a new notification!";

            emailService.SendNotification(recipient, message);
            smsService.SendNotification(recipient, message);
            pushService.SendNotification(recipient, message);
        }
        #endregion
    }
}
