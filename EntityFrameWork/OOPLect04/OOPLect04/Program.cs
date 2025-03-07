namespace OOPLect04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex C1 = new Complex() { Real = 32, Image = 12};
            Complex C2 = new Complex() { Image = 10, Real = 4 };

            if(C1 > C2)
            {
                Console.WriteLine("C1 > C2");
            }else
            {
                Console.WriteLine("C1 < C2");
            }
        }
    }
}
