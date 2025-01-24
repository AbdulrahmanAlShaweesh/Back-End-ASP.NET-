namespace Lect5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 3 : Output

            int sum, sub;

            Console.Write("Enter First Number ? ");
            bool isNum1 = int.TryParse(Console.ReadLine() ?? "Enter a valid number ", out int Number1);

            Console.Write("Enter Second Number ? ");
            bool isNum2 = int.TryParse(Console.ReadLine() ?? "Enter a valid number ", out int Number2);

            Console.Write("Enter Third Number ? ");
            bool isNum3 = int.TryParse(Console.ReadLine() ?? "Enter a valid number ", out int Number3);

            Console.Write("Enter Fourth Number ? ");
            bool isNum4 = int.TryParse(Console.ReadLine() ?? "Enter a valid number ", out int Number4);

            Calculate(Number1, Number2, Number3, Number4, out sum, out sub);
            Console.WriteLine($"The Summation of {Number1} and {Number2} is {sum}");
            Console.WriteLine($"The Subtraction of {Number3} and {Number4} is {sub}");
            #endregion

            #region Question 4 : Outout
            Console.Write("Enter a digit and will return the sum of e.g (25 => 7) ? ");
            bool isDigit = int.TryParse(Console.ReadLine(), out int digits);
            int SumOfDigits = SumOfGivenDigits(digits);

            Console.WriteLine($"The sum of the {digits} digit is {SumOfDigits}");
            #endregion

            #region Question 5 : ISPrime Number

            Console.Write("Enter a Prime Number ? ");
            bool isPrimeNumber = int.TryParse(Console.ReadLine() ?? "Enter a valid number", out int PirmeNumber);

            bool isprime = IsPrimeNumber(PirmeNumber);
            if (isprime) {
                Console.WriteLine($"The Number {PirmeNumber} is a Prime Number");
            }else
            {
                Console.WriteLine($"The Number {PirmeNumber} is not a prime number");
            }
            #endregion

            #region Question 6 Min and max number
            int[] numbers = { 25, 10, 55, -5, 30 };
            int min = 0, max = 0;

            MinMaxNumber(numbers, ref min, ref max);
            Console.WriteLine($"Min Number is {min}\nThe Max number is {max}");
            #endregion

            #region Question 7 Calculate Factorial of a geven number
            double factorial = CalculateFactorial(10);
            Console.WriteLine($"The Factorial of 10 is {factorial}");
            #endregion

            #region Question 8 ChangeChar
            string Str = "Abdulrahman Ibraheem";
            char NewChar = 'E';

            ChangeChar(ref Str, 12, NewChar);
            Console.WriteLine($"The New String is {Str}");
            #endregion
        }

        #region Sumation Of Two Numbers : Questio 3
        public static void Calculate(int num1 , int num2 , int num3 , int num4, out int sum , out int sub)
        {
            sum = num1 + num2;
            sub = num3 - num4;
        }
        #endregion

       
        #region Question 4 : Sum of given digits
        public static int SumOfGivenDigits(int digit)
        {
            int sum = 0;

            while (digit > 0)
            {
                int digtNumber = digit % 10;    // remove the last digits
                sum = sum + digtNumber;
                digit = digit / 10;
            }

            return sum;
        }
        #endregion

        #region Question 5 : check if a give number is a prime number or not
        public static bool IsPrimeNumber(int number)
        {
            if(number <= 0)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if(number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        #endregion

        #region Question 6 : Return Min Max Number
        public static void MinMaxNumber(int[] array , ref int min , ref int max) {
            if(array == null || array.Length == 0)
            {
                Console.WriteLine("Array cannot be null or empty.");
            }

            foreach (var item in array)
            {
                if(item < min)
                {
                    min = item;
                }
                if (item > max)
                {
                    max = item;
                }
            }
        }
        #endregion

        #region Question 7 : Calculate Factorial of a number
        public static double CalculateFactorial(int Number)
        {
            if(Number < 0 ) { 
                
                Console.WriteLine("The Number can not be a negative"); 
            }

            double factorial = 1; 

            for (int i = 1; i < Number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        #endregion

        #region Question 8 Chaning Carachter
            public static void ChangeChar(ref string Str, int Index, char NewChar)
            {

                if (Str is not null)
                {
                    char[] CharArray = Str.ToCharArray();
                    CharArray[Index] = NewChar;
                    Str = new string(CharArray);
                }
                else
                {
                    Console.WriteLine("String can not be Null");
                }
            }
        #endregion
        
        }
    }   
