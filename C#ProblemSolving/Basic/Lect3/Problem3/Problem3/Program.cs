namespace Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // * 3. Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

            // taken two number and operator from the user.
            Console.WriteLine("Please Enter the first number? ");
            var Number1 = Console.ReadLine() ?? "Enter a valid number";

            Console.WriteLine("Pease Enter the second number? ");
            var Number2 = Console.ReadLine() ?? "Enter a valid number";

            Console.WriteLine("Please Enter the operation ('+', '-' , '*', '/' , '%', '**')");
            var Operation = Console.ReadLine() ?? "Please Enter an Operation";


            // vaidate the inputs : check if the vairable number1, and number 2 can parse into float or not
            if(!float.TryParse(Number1 , out float number1)) {
                Console.WriteLine($"Invalid Number for Number 1, Please Enter a valid number");
            }

             if(!float.TryParse(Number2 , out float number2))
            {
                Console.WriteLine($"Invalid Number for Number 2, Please Enter a valid number");
            }  
            

            // Using if condition 

            if(Operation == "+")
            {
                Console.WriteLine("************************************************************");
                Console.WriteLine($"{number1} + {number2} = {number1 + number2}"); // adding value on number 1 to number2
                Console.WriteLine("************************************************************");
            }
            else if (Operation == "-")
            {
                Console.WriteLine("************************************************************");
                Console.WriteLine($"{number1} - {number2} = {number1 - number2}"); // sub value on number 1 from number2
                Console.WriteLine("************************************************************");
            }
            else if (Operation == "*")
            {
                Console.WriteLine("************************************************************");
                Console.WriteLine($"{number1} * {number2} = {number1 * number2}"); // multiplying value on number 1 with number2
                Console.WriteLine("************************************************************");
            }

            else if (Operation == "/")
            {
                if(number2 != 0)
                {
                    Console.WriteLine("************************************************************");
                    Console.WriteLine($"{number1} / {number2} = {number1 / number2}"); // divide value on number 1 to number2
                    Console.WriteLine("************************************************************");
                }else
                {
                    Console.WriteLine("Error : Can not divide by zero");
                }
            }

            else if (Operation == "%")
            {
                if (number2 != 0)
                {
                    Console.WriteLine("************************************************************");
                    Console.WriteLine($"{number1} % {number2} = {number1 % number2}"); // modelace of wo numbers
                    Console.WriteLine("************************************************************");
                }
                else
                {
                    Console.WriteLine("Error : Model by zero is not allowed");
                }
            }

        }

    }
}
