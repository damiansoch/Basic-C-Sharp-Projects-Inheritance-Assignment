using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Assignment
{
    public class Person
    {
        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //methods
        public void SayName()
        {
            Console.WriteLine("Name:[{0} {1}]", FirstName, LastName);
        }
    }
}
