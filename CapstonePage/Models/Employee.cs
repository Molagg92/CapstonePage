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

         // Static method to get all cleaning ladies (example)
        public static List<Employee> GetAll()
        {
            // In a real scenario, you would probably fetch data from a database
            // For now, let's create a sample list
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