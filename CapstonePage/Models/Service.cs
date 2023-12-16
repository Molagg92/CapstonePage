using System.Collections.Generic;

namespace Capstone.Models
{
  public class Service
  {
    private static List<Service> _instances = new List<Service> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Employee> Employees { get; set; }

    public Service(string serviceName)
    {
      Name = serviceName;
      _instances.Add(this);
      Id = _instances.Count;
      Employees = new List<Employee>{};
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Service> GetAll()
    {
      return _instances;
    }
    public static Service Find(int searchId)
    {
      return _instances[searchId-1];
    }
    public void AddEmployee(Employee employee)
    {
      Employees.Add(employee);
    }
  }
}