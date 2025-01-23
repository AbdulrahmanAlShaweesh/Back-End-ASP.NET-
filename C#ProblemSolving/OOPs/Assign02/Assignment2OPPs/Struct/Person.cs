using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2OPPs.Struct
{
    internal struct Person
    {
        // Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person"
        // objects and populate it with data. Then, write a C# program to display the details of all
        // the persons in the array.

        // Name , and Age props : usng automatic prop
        private string Name;
        private int Age;

        public string PersonName { 
            get { return Name; }
            set { Name = value; }
        }

        public int PersnAge
        {
            get { return Age; }
            set { Age = value; }

        }
        public Person(string name , int age)
        {
            Name = name;
            Age = age;
        }

       

        public string DisplayDetials()
        {
            return $"Name :: {Name} , Age :: {Age}";
        }


    }
}
