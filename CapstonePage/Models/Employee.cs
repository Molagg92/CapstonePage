using System.Globalization;
using System.Collections.Generic;

namespace Capstone.Models
{
  public class Employee
  {
    public string Name { get; set; }
    public int Phone { get; set; }
    public int Id { get; }
    private static List<Employee> _instances = new List<Employee> {};
    public Employee() {}
    public Employee(string name, int phone)
    {
      Name = name;
      Phone = phone;
      _instances.Add(this);
      Id = _instances.Count;
    } 
    public static List<Employee> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Employee Find(int searchId)
    {
      return _instances[searchId-1];
    }

    
  
  }
}
