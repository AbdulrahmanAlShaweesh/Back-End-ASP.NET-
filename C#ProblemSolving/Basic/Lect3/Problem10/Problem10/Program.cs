namespace Problem10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. 
                Assign the result in a variable then display the result. 
                Note :  
                1. that below 10 degrees is "Just Cold"
                2. above 30 degrees is "Just Hot"
                3. anything else is "Just Good"

             */

            Console.WriteLine("Enter The Temperature? ");
            var temperature = float.TryParse(Console.ReadLine(), out float temperatures);

            if (temperatures < 0) {
                Console.WriteLine("The Temperature Should be more than 0 degree");
            }else
            {
                if(temperatures > 0 && temperatures < 10)
                {
                    Console.WriteLine("The Temperature is \"just cold\"");
                } else if(temperatures > 30)
                {
                    Console.WriteLine("The Temperatures is \"just hot\"");
                }else
                {
                    Console.WriteLine("Just Good");
                }
            }
        }
    }
}
