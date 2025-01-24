using Assign04.Classes;

namespace Assign04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01-Q1
            Calculator C = new Calculator();

            Console.WriteLine($"The Sum of 12 + 32 = {C.AddNumbers(12 , 32)}");       // return the sum of 12 , and 32
            Console.WriteLine($"The Sum of 1 + 43 , 5 = {C.AddNumbers(1, 43, 5)}");   // return the sum of 12 , and 32
            Console.WriteLine($"The Sum of 32.4 + 54.12 = {C.AddNumbers(32.4, 54.12)}");
            #endregion

            Console.WriteLine($"{new string('*', 20)} Part 1 Question 02 {new string('*', 20)}");

            Rectangle R1 = new Rectangle();    // this set the parapmeterless constructor to 0 for height and width
            Rectangle R2 = new Rectangle(12 , 43); 
            Rectangle R3 = new Rectangle(32); // this set both height and width with value of 32 
            Console.WriteLine(R1);
            Console.WriteLine(R2);
            Console.WriteLine(R3);

            Console.WriteLine($"{new string('*', 20)} Part 1 Question 03 {new string('*', 20)}");

            Complex C1 = new Complex();
            Complex C2 = new Complex(){ Real = 32 , Imaginary = 42};
            Console.WriteLine(C1);

            Console.WriteLine($"{new string('*', 20)} Part 1 Question 04 {new string('*', 20)}");
            Employee E = new Employee();
            Manager manager = new Manager();

            E.prints();               // call the prints method form base class Employee
            manager.prints();         // call the prints methd from derived class manager

            #region Question5 part 1
            // BaseClass instance
            BaseClass baseObj = new BaseClass();
            baseObj.DisplayMessage(); // Output: Message from BaseClass

            // DerivedClass1 instance
            DerivedClass1 derived1 = new DerivedClass1();
            derived1.DisplayMessage(); // Output: Message from DerivedClass1

            // DerivedClass2 instance
            DerivedClass2 derived2 = new DerivedClass2();
            derived2.DisplayMessage(); // Output: Message from DerivedClass2

            // Polymorphism: BaseClass reference pointing to DerivedClass1
            BaseClass polyObj1 = new DerivedClass1();
            polyObj1.DisplayMessage(); // Output: Message from DerivedClass1

            // Hiding behavior: BaseClass reference pointing to DerivedClass2
            BaseClass polyObj2 = new DerivedClass2();
            polyObj2.DisplayMessage();
            #endregion

            #region Part 2, Question 1

            #endregion
        }
    }
}
