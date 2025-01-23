namespace Problem5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 5 . Write C# program that Assigning one value type variable to another and modifying the value of one variable 
                   and mention what will happen */

            int Value1 = 123;           // integre
            Console.WriteLine(Value1);  // 123

            decimal Value2 = Value1;    // asign int into decimal (will store the value of value1 into value2)
            Console.WriteLine(Value2);  // 123

            Value1 = 100;              // modifying the value of value1, it will also autmaticlly modify value in value2 variable
            Console.WriteLine(Value1); // 100
            Console.WriteLine(Value1); // 100

        }
    }
}
