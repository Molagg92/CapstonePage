using System.Globalization;
using System.Collections.Generic;

namespace Capstone.Models
{
  public class Employee
  {
    public string Name { get; set; }
    public int Phone { get; set; }

    public Employee()
    {
       
    }
    public Employee(string name, int phone)
    {
      Name = name;
      Phone = phone;
    }
      private static List<Employee> allEmployees = new List<Employee>
    {
      new Employee("Alice", 123),
      new Employee("Bob", 456),
      new Employee("Charlie", 789)
    };
    public static List<Employee> GetAll()
    {
      return allEmployees;
    }
  }
}
