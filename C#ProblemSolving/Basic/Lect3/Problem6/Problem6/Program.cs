namespace Problem6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write C# program that Assigning one reference type variable to another and modifying the object through one
            // variable and mention what will happen

            Queation6 Q1 = new Queation6();
            Q1.x = 100; 

            Queation6 Q2 = Q1;                   // the Q2 will had the value Problem6.Program+Queation6 Type from Q1

            //  Before Modify Q2
            Console.WriteLine(Q1.x);
            Console.WriteLine(Q2.x);

            Console.WriteLine("Before Modify Q2");

            // After Modifying Q2

            Q2.x = 500;
            Console.WriteLine(Q1.x);
            Console.WriteLine(Q2.x);

            // Both Q1, and Q2 are pointing to the same stack in the memory, so modify one refernce object will affect the other

        }

        class Queation6
        {
            public int x;
            public int y;
        }
    }
}
