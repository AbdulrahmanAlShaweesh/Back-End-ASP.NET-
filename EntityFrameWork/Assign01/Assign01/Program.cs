using Assign01.DbContexts;
using Assign01.Models;

namespace Assign01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ItiDbContext dbContext = new ItiDbContext();

            //List<Student> students = dbContext.Students.Where(S => S.FName!.StartsWith("A")).ToList();
        }
    }
}
