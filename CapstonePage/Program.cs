using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;

namespace YourNamespace
 {
    class Program
    {
      static void Main(string[] args)
        {
          //Paramaters (year, month, day, hour, minute, second)
          var date01 = new DateTime(2023, 12, 1, 11, 50, 00);
          var date02 = DateTime.UtcNow;
          var date03 = DateTime.Today;
          var date04 = DateTime.Now;
          var tomorrow = date04.AddDays(1);

          Console.WriteLine(date01);
          Console.WriteLine(date02);
          Console.WriteLine(date03);
          Console.WriteLine(date04);
          Console.WriteLine(tomorrow);

          // Keep the console window open
            Console.ReadLine();
        }
    }
}