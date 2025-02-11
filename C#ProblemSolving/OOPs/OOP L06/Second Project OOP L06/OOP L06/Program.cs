namespace OOP_L06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------***************-------------------");
            Console.WriteLine(Math.Add(10, 20)); 
            Console.WriteLine(Math.Subtract(100, 50)); 
            Console.WriteLine(Math.Multiply(5000, 5)); 
            Console.WriteLine(Math.Divide(101, 5)); 

            try
            {
                Console.WriteLine(Math.Divide(50, 0));
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Sorry, {ex.Message}");
            }
        }
    }
}
