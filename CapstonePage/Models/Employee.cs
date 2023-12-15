using System.Globalization;
using System.Collections.Generic;

namespace Capstone.Models
{
    public class Employee
    {

        public string Name { get; set; }
        public int Phone { get; set; }
        public Employee(string name, int phone)
        {
            Name = name;
            Phone = phone;
        }
        public static List<Employee> GetAll()
        {
            List<Employee> cleaningLadies = new List<Employee>
            {
                new Employee("Alice", 123),
                new Employee("Bob", 456),
                new Employee("Charlie", 789)
            };

            return cleaningLadies;
        }
    }
}