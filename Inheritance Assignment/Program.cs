using System;

namespace Inheritance_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee_1 = new Employee();

            employee_1.FirstName = "Sample";
            employee_1.LastName = "Student";

            employee_1.SayName();
        }
    }
}
