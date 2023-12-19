using System.Security;
using System.Collections.Generic;
using Capstone.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Connections;
using MySqlConnector;

namespace Capstone.Models
{
  public class Employee
  {
    public string Name { get; set; }
    public int Phone { get; set; }
    public int Id { get; set; }
   
    public List<Service> Services { get; set; }
    public Employee() {}
    public Employee(string name, int phone)
    {
      Name = name;
      Phone = phone;
      Services = new List<Service>{};
    } 
    // public static List<Employee> GetAll()
    // {
    //   List<Employee> allEmployees = new List<Employee> { };

    //   MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);
    //   conn.Open();

    //   MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
    //   cmd.CommandText = "SELECT * FROM items;";
      
    //   MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
    //   while (rdr.Read())
    //   {
    //     int employeeId = rdr.GetInt32(0);
    //     string employeeDescription = rdr.GetString(1);
    //     Employee newEmployee = new Employee(employeeDescription, employeeId);
    //     allEmployees.Add(newEmployee);
    //   }
    //   conn.Close();
    //   if (conn != null)
    //   { 
    //       conn.Dispose();
    //   }
    //   return allEmployees;
    // }
  
    // public static void ClearAll()
    // {
    //  MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);
    //  conn.Open();

    //  MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
    //   cmd.CommandText = "DELETE FROM employees;";
    //   cmd.ExecuteNonQuery();

    //   conn.Close();
    //  if (conn != null)
    //  {
    //   conn.Dispose();
    //  }
    // }
    // public static Employee Find(int searchId)
    // {
    //   return
    // }

    // public void Save()
    // {
    //   MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);
    //   conn.Open();

    //   MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
    //   cmd.CommandText = "INSERT INTO employees (name) VALUES (@EmployeeName);";
    //   MySqlParameter param = new MySqlParameter();
    //   param.ParameterName = "@EmployeeName";
    //   param.Value = this.Name;
    //   cmd.Parameters.Add(param);    
    //   cmd.ExecuteNonQuery();
    //   Id = (int) cmd.LastInsertedId;

    //   conn.Close();
    //   if (conn != null)
    //   {
    //     conn.Dispose();
    //   }

  }
    
}
