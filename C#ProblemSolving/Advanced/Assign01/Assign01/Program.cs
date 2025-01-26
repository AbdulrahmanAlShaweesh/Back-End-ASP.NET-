namespace Assign01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var range = new Range<int>(12 , 32);
            Console.WriteLine(range.IsInRange(19));

            //range<boo>.IsInRange()
        }
    }
}
