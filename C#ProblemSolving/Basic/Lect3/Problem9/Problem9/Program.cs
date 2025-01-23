namespace Problem9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
                9. Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. 
                Note :The formula for BMI is BMI = (Weight)/(Height*Height)

             */

            DisplayGreetingsPatterin();
            Console.WriteLine("Welcome to My BMI Calculator Enter You weight, height");
            Console.WriteLine($"{new string('*', 50)}");
            Console.WriteLine("\n");

            Console.WriteLine("Enter Your Weight in Kg?");
            var weight = float.TryParse(Console.ReadLine(), out float weights);

            Console.WriteLine("Enter Your height in CM?");
            var height = float.TryParse(Console.ReadLine(), out float heights);

            // calcuate BMI
            var BMI = weights / (heights * heights);

            if (BMI < 0)
            {
                Console.WriteLine("The BMI Can not be neigative");
            }

            else
            {
                if(BMI >= 1 && BMI < 18.5)
                {
                    Console.WriteLine($"You BMI is {BMI} and You are Underweight");
                }else if(BMI >= 18.5 && BMI <= 24.9)
                {
                    Console.WriteLine($"Your BMI is {BMI} and You have a health weight");
                }else if(BMI > 24.9 && BMI <= 29.9)
                {
                    Console.WriteLine("Your BMI is {BMI} and You are overweight");
                }else
                {
                    Console.WriteLine($"You BMI is {BMI} and You are Obese");
                }
            }



        }

        static void DisplayGreetingsPatterin()
        {
            Console.WriteLine(new string('*', 50));
            Console.WriteLine($"*{new string(' ', 48)}*");
            Console.WriteLine($"*{new string(' ', 11)} Welcome To BMI Calculator {new string(' ', 10)}*");
            Console.WriteLine($"*{new string(' ', 48)}*");
            Console.WriteLine($"{new string('*', 50)}");
        }
    }
}
